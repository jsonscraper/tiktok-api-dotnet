using System.Net;
using System.Text.Json;
using System.Text.RegularExpressions;
namespace JsonScraper.TikTokApi;

public sealed class APIException(int status, string? retryAfter) : Exception($"jsonscraper API returned HTTP {status}") {
    public int Status {get;}=status;
    public string? RetryAfter {get;}=retryAfter;
}
public class Client : IDisposable {
    private readonly string key,baseUrl;
    private readonly HttpClient http;
    private readonly int retries;
    private readonly int? cacheTimeout;
    public Client(string licenseKey,string? baseUrl=null,TimeSpan? timeout=null,int retries=0,int? cacheTimeout=null) {
        if(string.IsNullOrWhiteSpace(licenseKey))throw new ArgumentException("A product and license key are required");
        baseUrl ??="https://tiktok.evelode.com";
        if(!Uri.TryCreate(baseUrl,UriKind.Absolute,out var u) || u.UserInfo!="" || u.Query!="" || u.Fragment!="" || (u.Scheme!="https" && !(u.Scheme=="http" && new[]{"localhost","127.0.0.1","[::1]"}.Contains(u.Host))))throw new ArgumentException("Use an HTTPS base URL");
        var duration=timeout ?? TimeSpan.FromSeconds(30);
        if(duration<=TimeSpan.Zero || retries<0 || retries>5)throw new ArgumentException("Invalid timeout or retries");
        key=licenseKey;this.baseUrl=baseUrl.TrimEnd('/');this.retries=retries;this.cacheTimeout=cacheTimeout;
        http=new HttpClient(new HttpClientHandler{AllowAutoRedirect=false}){Timeout=duration};
    }
    public async Task<byte[]> RequestAsync(string path, IReadOnlyDictionary<string,object?>? parameters=null,CancellationToken cancellationToken=default) {
        if(!Regex.IsMatch(path,@"^/[A-Za-z0-9_/-]+$") || path.Contains("//") || path.Contains(".."))throw new ArgumentException("Use an API path, not a URL");
        var q=parameters?.Where(p=>p.Value!=null).ToDictionary(p=>p.Key,p=>p.Value) ?? new Dictionary<string,object?>();
        if(cacheTimeout!=null)q.TryAdd("cache_timeout",cacheTimeout);q["license_key"]=key;
        static string Value(object? v)=>v is bool b ? (b?"true":"false") : Convert.ToString(v,System.Globalization.CultureInfo.InvariantCulture) ?? "";
        var url=baseUrl+path+"?"+string.Join("&",q.Select(p=>Uri.EscapeDataString(p.Key)+"="+Uri.EscapeDataString(Value(p.Value))));
        for(int attempt=0;attempt<=retries;attempt++){
            try{
                using var req=new HttpRequestMessage(HttpMethod.Get,url);
                req.Headers.Accept.ParseAdd("application/json");req.Headers.UserAgent.ParseAdd("jsonscraper-dotnet/0.1.0");
                using var res=await http.SendAsync(req,cancellationToken);
                if(res.IsSuccessStatusCode)return await res.Content.ReadAsByteArrayAsync(cancellationToken);
                int status=(int)res.StatusCode;string? retry=res.Headers.RetryAfter?.ToString();
                if(attempt==retries || !new[]{429,502,503,504}.Contains(status))throw new APIException(status,retry);
                var delay=int.TryParse(retry,out int n) && n>=0?Math.Min(n,60):1<<attempt;
                await Task.Delay(TimeSpan.FromSeconds(delay),cancellationToken);
            }catch(HttpRequestException){throw new IOException("Unable to reach jsonscraper API");}
             catch(TaskCanceledException) when(!cancellationToken.IsCancellationRequested){throw new TimeoutException("jsonscraper API request timed out");}
        }
        throw new IOException("Request failed");
    }
    public async Task<JsonDocument> JsonAsync(string path,IReadOnlyDictionary<string,object?>? parameters=null,CancellationToken cancellationToken=default)=>JsonDocument.Parse(await RequestAsync(path,parameters,cancellationToken));
    public void Dispose(){http.Dispose();GC.SuppressFinalize(this);}
}

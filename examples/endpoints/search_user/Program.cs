using JsonScraper.TikTokApi;
using System.Text.Json;

// Search for user by keyword. GET /searchUser
// dotnet run --project examples/endpoints/search_user -- --help
var query=new Dictionary<string,object?>{["keyword"]="apple", ["cursor"]=null, ["count"]=null, ["region"]=null, ["follower_count"]=null, ["profile_type"]=null, ["other_pref"]=null, ["cache_timeout"]="60"};
double timeout=30;int retries=0;string? output=null;
try {
 foreach(string arg in args) {
  if(arg=="--help"){Console.WriteLine("Search for user by keyword\nGET /searchUser\n\nEnvironment: JSONSCRAPER_TIKTOK_LICENSE_KEY\nCommon options: --timeout=30, --help\nQuery options:\n  --keyword=VALUE  Any text or keyword\n  --cursor=VALUE  Used for scrolling (pagination) in user items, you can get cursor value from the previous response.\n  --count=VALUE  Number of results you want to get. For example: 10.\n  --region=VALUE  Region (country) code. Default: US\n  --follower_count=VALUE  Filter by followers count, can be empty or one of: ZERO_TO_ONE_K (0 to 1k), ONE_K_TO_TEN_K (1k to 10k), TEN_K_TO_ONE_H_K(10k to 100k), ONE_H_K_PLUS(100k+)\n  --profile_type=VALUE  Filter by user profile type, can be empty or one of: VERIFIED\n  --other_pref=VALUE  Filter by other preference, can be empty or one of: USERNAME (keyword usage in username).\n  --cache_timeout=VALUE  Cache timeout in seconds. By default we use caching system with 3600 seconds window to speed up next requests to API. If you want to disable caching, you can set 0 here. \n\nValues omitted from the command use the public Postman sample defaults. Replace IDs/URLs with your own inputs. Each run makes one request; live requests may consume quota.");return;}
  if(!arg.StartsWith("--")||!arg.Contains('='))throw new ArgumentException("Use --parameter=value or --help");
  var pair=arg[2..].Split('=',2);
  switch(pair[0]){
   case "timeout":timeout=double.Parse(pair[1],System.Globalization.CultureInfo.InvariantCulture);break;
   case "retries":retries=int.Parse(pair[1]);break;
   case "output":output=pair[1];break;
   default:if(!query.ContainsKey(pair[0]))throw new ArgumentException("Unknown parameter: "+pair[0]);query[pair[0]]=pair[1];break;
  }
 }
 var key=Environment.GetEnvironmentVariable("JSONSCRAPER_TIKTOK_LICENSE_KEY");
 if(string.IsNullOrWhiteSpace(key))throw new ArgumentException("Set JSONSCRAPER_TIKTOK_LICENSE_KEY before making a licensed request");
 if(!double.IsFinite(timeout)||timeout<=0||retries<0||retries>5)throw new ArgumentException("Use a positive timeout and 0 to 5 retries");
 using var cancellation=new CancellationTokenSource();
 Console.CancelKeyPress+=(_,e)=>{e.Cancel=true;cancellation.Cancel();};
 using var client=new TikTok(key,timeout:TimeSpan.FromSeconds(timeout),retries:retries);
 var bytes=await client.RequestAsync("/searchUser",query,cancellation.Token);
 if(output!=null){await File.WriteAllBytesAsync(output,bytes,cancellation.Token);return;}
 using var response=JsonDocument.Parse(bytes);
 if(!response.RootElement.TryGetProperty("status",out var status)||status.GetString()!="ok")throw new InvalidOperationException("The API returned an application error; inspect the response envelope");
 if(response.RootElement.TryGetProperty("rate_limit_reached",out var limited)&&limited.ValueKind==JsonValueKind.True)throw new InvalidOperationException("License rate limit reached");
 Console.WriteLine(JsonSerializer.Serialize(response.RootElement,new JsonSerializerOptions{WriteIndented=true}));
}catch(APIException e){Console.Error.WriteLine($"HTTP {e.Status}. Check parameters, access and quota. Retry-After: {e.RetryAfter}");Environment.ExitCode=1;}
catch(OperationCanceledException){Console.Error.WriteLine("Request cancelled");Environment.ExitCode=1;}
catch(Exception e){Console.Error.WriteLine(e.Message);Environment.ExitCode=1;}

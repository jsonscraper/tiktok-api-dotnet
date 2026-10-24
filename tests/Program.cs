using JsonScraper.TikTokApi;
using System.Text.Json;
try{
 using var c=new Client("contract-secret",Environment.GetEnvironmentVariable("BASE_URL"),TimeSpan.FromSeconds(double.Parse(Environment.GetEnvironmentVariable("TIMEOUT")??"3",System.Globalization.CultureInfo.InvariantCulture)),int.Parse(Environment.GetEnvironmentVariable("RETRIES")??"0"));
 var bytes=await c.RequestAsync(Environment.GetEnvironmentVariable("API_PATH")!,new Dictionary<string,object?>{["video_id"]="a&b?x=1+/Ю",["license_key"]="override",["count"]=0,["flag"]=false});
 await Console.OpenStandardOutput().WriteAsync(bytes);
}catch(APIException e){Console.Write(JsonSerializer.Serialize(new{error=e.Status}));}catch(Exception){Console.Write("{\"error\":\"transport\"}");}

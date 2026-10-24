using JsonScraper.TikTokApi;

using var client = new TikTok(Environment.GetEnvironmentVariable("JSONSCRAPER_TIKTOK_LICENSE_KEY")!);
using var response = await client.JsonAsync("/getUserInfo", new Dictionary<string, object?> { ["query"]="therock", ["cache_timeout"]=60 });
if (response.RootElement.GetProperty("status").GetString() != "ok") throw new Exception("API application error");
Console.WriteLine(response.RootElement.GetProperty("tiktok"));

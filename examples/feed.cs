// Copy into a separate console application's Program.cs.
using JsonScraper.TikTokApi;
using var client=new TikTok(Environment.GetEnvironmentVariable("JSONSCRAPER_TIKTOK_LICENSE_KEY")!);
using var response=await client.JsonAsync("/getUserFeed",new Dictionary<string,object?>{["query"]="therock", ["count"]=10, ["max_cursor"]="", ["cache_timeout"]=60});
Console.WriteLine(response.RootElement);

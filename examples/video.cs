// Copy into a separate console application's Program.cs.
using JsonScraper.TikTokApi;
using var client=new TikTok(Environment.GetEnvironmentVariable("JSONSCRAPER_TIKTOK_LICENSE_KEY")!);
using var response=await client.JsonAsync("/getVideoByID",new Dictionary<string,object?>{["video_id"]="7106855913906081070", ["cache_timeout"]=60});
Console.WriteLine(response.RootElement);

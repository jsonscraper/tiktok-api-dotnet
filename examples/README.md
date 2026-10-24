# TikTok dotnet request examples

Every file below is a complete single-request CLI program with environment-based authentication, all documented query options, timeout configuration, error handling and full response output. Sample defaults come from Postman; replace account names, IDs and URLs for your use case. `--help` requires no API key and makes no network request.

Set `JSONSCRAPER_TIKTOK_LICENSE_KEY` and install the SDK as described in the main README. Each execution makes one live request and may consume quota. None of these programs loops through a feed automatically.

## Get non watermarked video url

[Open the complete example](endpoints/get_no_watermark_url/Program.cs) · `GET /getNoWatermarkUrl`

```sh
dotnet run --project examples/endpoints/get_no_watermark_url -- --help
```

## Get non watermarked video url by video ID

[Open the complete example](endpoints/get_no_watermark_url_by_id/Program.cs) · `GET /getNoWatermarkUrlByID`

```sh
dotnet run --project examples/endpoints/get_no_watermark_url_by_id -- --help
```

## Get video info by ID

[Open the complete example](endpoints/get_video_by_id/Program.cs) · `GET /getVideoByID`

```sh
dotnet run --project examples/endpoints/get_video_by_id -- --help
```

## Get video info by URL

[Open the complete example](endpoints/get_video_by_url/Program.cs) · `GET /getVideoByUrl`

```sh
dotnet run --project examples/endpoints/get_video_by_url -- --help
```

## Convert short TikTok video URL to full TikTok video URL

[Open the complete example](endpoints/get_unshortened_url/Program.cs) · `GET /getUnshortenedUrl`

```sh
dotnet run --project examples/endpoints/get_unshortened_url -- --help
```

## Get comments list by video URL

[Open the complete example](endpoints/get_comments_by_url/Program.cs) · `GET /getCommentsByUrl`

```sh
dotnet run --project examples/endpoints/get_comments_by_url -- --help
```

## Get comments list by video ID

[Open the complete example](endpoints/get_comments_by_id/Program.cs) · `GET /getCommentsByID`

```sh
dotnet run --project examples/endpoints/get_comments_by_id -- --help
```

## Get comments replies

[Open the complete example](endpoints/get_comments_replies/Program.cs) · `GET /getCommentsReplies`

```sh
dotnet run --project examples/endpoints/get_comments_replies -- --help
```

## Search for user by keyword

[Open the complete example](endpoints/search_user/Program.cs) · `GET /searchUser`

```sh
dotnet run --project examples/endpoints/search_user -- --help
```

## Search for video by keyword

[Open the complete example](endpoints/search_video/Program.cs) · `GET /searchVideo`

```sh
dotnet run --project examples/endpoints/search_video -- --help
```

## Search for music by keyword

[Open the complete example](endpoints/search_music/Program.cs) · `GET /searchMusic`

```sh
dotnet run --project examples/endpoints/search_music -- --help
```

## Search for live by keyword

[Open the complete example](endpoints/search_live/Program.cs) · `GET /searchLive`

```sh
dotnet run --project examples/endpoints/search_live -- --help
```

## Search for hashtag by keyword

[Open the complete example](endpoints/search_hashtag/Program.cs) · `GET /searchHashtag`

```sh
dotnet run --project examples/endpoints/search_hashtag -- --help
```

## Search for location by keyword

[Open the complete example](endpoints/search_location/Program.cs) · `GET /searchLocation`

```sh
dotnet run --project examples/endpoints/search_location -- --help
```

## Top search by text query

[Open the complete example](endpoints/search_top/Program.cs) · `GET /searchTop`

```sh
dotnet run --project examples/endpoints/search_top -- --help
```

## Search insights by text query

[Open the complete example](endpoints/search_insights/Program.cs) · `GET /searchInsights`

```sh
dotnet run --project examples/endpoints/search_insights -- --help
```

## Search comment suggested users

[Open the complete example](endpoints/search_comment_suggested_users/Program.cs) · `GET /searchCommentSuggestedUsers`

```sh
dotnet run --project examples/endpoints/search_comment_suggested_users -- --help
```

## Get user info by profile URL or nickname

[Open the complete example](endpoints/get_user_info/Program.cs) · `GET /getUserInfo`

```sh
dotnet run --project examples/endpoints/get_user_info -- --help
```

## Get user info by profile ID

[Open the complete example](endpoints/get_user_info_by_id/Program.cs) · `GET /getUserInfoByID`

```sh
dotnet run --project examples/endpoints/get_user_info_by_id -- --help
```

## Get user info by username

[Open the complete example](endpoints/get_basic_user_info/Program.cs) · `GET /getBasicUserInfo`

```sh
dotnet run --project examples/endpoints/get_basic_user_info -- --help
```

## Get user feed by profile URL or nickname

[Open the complete example](endpoints/get_user_feed/Program.cs) · `GET /getUserFeed`

```sh
dotnet run --project examples/endpoints/get_user_feed -- --help
```

## Get user feed by profile ID

[Open the complete example](endpoints/get_user_feed_by_id/Program.cs) · `GET /getUserFeedByID`

```sh
dotnet run --project examples/endpoints/get_user_feed_by_id -- --help
```

## Get user ID by profile URL or nickname

[Open the complete example](endpoints/get_user_id/Program.cs) · `GET /getUserID`

```sh
dotnet run --project examples/endpoints/get_user_id -- --help
```

## Get username by TikTok user ID

[Open the complete example](endpoints/get_username_by_id/Program.cs) · `GET /getUsernameByID`

```sh
dotnet run --project examples/endpoints/get_username_by_id -- --help
```

## Get Twitter username by profile URL, nickname or TikTok user ID

[Open the complete example](endpoints/get_twitter_username/Program.cs) · `GET /getTwitterUsername`

```sh
dotnet run --project examples/endpoints/get_twitter_username -- --help
```

## Get Instagram username by profile URL, nickname or TikTok user ID

[Open the complete example](endpoints/get_instagram_username/Program.cs) · `GET /getInstagramUsername`

```sh
dotnet run --project examples/endpoints/get_instagram_username -- --help
```

## Get YouTube channel info by profile URL, nickname or TikTok user ID

[Open the complete example](endpoints/get_youtube_channel/Program.cs) · `GET /getYoutubeChannel`

```sh
dotnet run --project examples/endpoints/get_youtube_channel -- --help
```

## Get user followers by profile URL or nickname

[Open the complete example](endpoints/get_followers/Program.cs) · `GET /getFollowers`

```sh
dotnet run --project examples/endpoints/get_followers -- --help
```

## Get user followers by profile ID

[Open the complete example](endpoints/get_followers_by_id/Program.cs) · `GET /getFollowersByID`

```sh
dotnet run --project examples/endpoints/get_followers_by_id -- --help
```

## Get user following by profile URL or nickname

[Open the complete example](endpoints/get_following/Program.cs) · `GET /getFollowing`

```sh
dotnet run --project examples/endpoints/get_following -- --help
```

## Get user following by profile ID

[Open the complete example](endpoints/get_following_by_id/Program.cs) · `GET /getFollowingByID`

```sh
dotnet run --project examples/endpoints/get_following_by_id -- --help
```

## Get live event info by ID

[Open the complete example](endpoints/get_live_event_info_by_id/Program.cs) · `GET /getLiveEventInfoByID`

```sh
dotnet run --project examples/endpoints/get_live_event_info_by_id -- --help
```

## Get hashtag info by URL or tag name

[Open the complete example](endpoints/get_hashtag_info/Program.cs) · `GET /getHashtagInfo`

```sh
dotnet run --project examples/endpoints/get_hashtag_info -- --help
```

## Get hashtag feed by URL or tag name

[Open the complete example](endpoints/get_hashtag_feed/Program.cs) · `GET /getHashtagFeed`

```sh
dotnet run --project examples/endpoints/get_hashtag_feed -- --help
```

## Get hashtag feed by ID

[Open the complete example](endpoints/get_hashtag_feed_by_id/Program.cs) · `GET /getHashtagFeedByID`

```sh
dotnet run --project examples/endpoints/get_hashtag_feed_by_id -- --help
```

## Get location info by ID

[Open the complete example](endpoints/get_location_info_by_id/Program.cs) · `GET /getLocationInfoByID`

```sh
dotnet run --project examples/endpoints/get_location_info_by_id -- --help
```

## Get videos by location ID

[Open the complete example](endpoints/get_location_feed_by_id/Program.cs) · `GET /getLocationFeedByID`

```sh
dotnet run --project examples/endpoints/get_location_feed_by_id -- --help
```

## Get music info by URL or ID

[Open the complete example](endpoints/get_music_info/Program.cs) · `GET /getMusicInfo`

```sh
dotnet run --project examples/endpoints/get_music_info -- --help
```

## Get music feed by URL or ID

[Open the complete example](endpoints/get_music_feed/Program.cs) · `GET /getMusicFeed`

```sh
dotnet run --project examples/endpoints/get_music_feed -- --help
```

## Get music charts

[Open the complete example](endpoints/get_music_charts/Program.cs) · `GET /getMusicCharts`

```sh
dotnet run --project examples/endpoints/get_music_charts -- --help
```

## Get trending categories list

[Open the complete example](endpoints/get_trending_categories_list/Program.cs) · `GET /getTrendingCategoriesList`

```sh
dotnet run --project examples/endpoints/get_trending_categories_list -- --help
```

## Get trending feed

[Open the complete example](endpoints/get_trending_feed/Program.cs) · `GET /getTrendingFeed`

```sh
dotnet run --project examples/endpoints/get_trending_feed -- --help
```

## Get effect information by IDs

[Open the complete example](endpoints/get_stickers_by_id/Program.cs) · `GET /getStickersByID`

```sh
dotnet run --project examples/endpoints/get_stickers_by_id -- --help
```

## Get effect information by ID

[Open the complete example](endpoints/get_sticker_by_id/Program.cs) · `GET /getStickerByID`

```sh
dotnet run --project examples/endpoints/get_sticker_by_id -- --help
```

## Get videos by effect ID

[Open the complete example](endpoints/get_sticker_feed_by_id/Program.cs) · `GET /getStickerFeedByID`

```sh
dotnet run --project examples/endpoints/get_sticker_feed_by_id -- --help
```

## Get user stories

[Open the complete example](endpoints/get_user_stories/Program.cs) · `GET /getUserStories`

```sh
dotnet run --project examples/endpoints/get_user_stories -- --help
```

## Get story info by ID

[Open the complete example](endpoints/get_story_info_by_id/Program.cs) · `GET /getStoryInfoByID`

```sh
dotnet run --project examples/endpoints/get_story_info_by_id -- --help
```

## Get user playlists

[Open the complete example](endpoints/get_user_playlists/Program.cs) · `GET /getUserPlaylists`

```sh
dotnet run --project examples/endpoints/get_user_playlists -- --help
```

## Get user playlist by ID

[Open the complete example](endpoints/get_user_playlist_by_id/Program.cs) · `GET /getUserPlaylistByID`

```sh
dotnet run --project examples/endpoints/get_user_playlist_by_id -- --help
```

## Get video by playlist ID

[Open the complete example](endpoints/get_video_by_playlist_id/Program.cs) · `GET /getVideoByPlaylistID`

```sh
dotnet run --project examples/endpoints/get_video_by_playlist_id -- --help
```

## Get available ranking list

[Open the complete example](endpoints/get_available_ranking_list/Program.cs) · `GET /getAvailableRankingList`

```sh
dotnet run --project examples/endpoints/get_available_ranking_list -- --help
```

## Get ranking info

[Open the complete example](endpoints/get_ranking_info/Program.cs) · `GET /getRankingInfo`

```sh
dotnet run --project examples/endpoints/get_ranking_info -- --help
```

## Get live info

[Open the complete example](endpoints/get_live_info/Program.cs) · `GET /getLiveInfo`

```sh
dotnet run --project examples/endpoints/get_live_info -- --help
```

## Get live feed

[Open the complete example](endpoints/get_live_feed/Program.cs) · `GET /getLiveFeed`

```sh
dotnet run --project examples/endpoints/get_live_feed -- --help
```


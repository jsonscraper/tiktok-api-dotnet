# TikTok API endpoint reference

54 unique GET routes from the published Postman collection. Configure `license_key` on the client. Query parameters below use the same names as the API; check Postman for required/optional rules.

| SDK method | GET path | Query parameters | Purpose |
| --- | --- | --- | --- |
| `GetNoWatermarkUrlAsync` | `/getNoWatermarkUrl` | `video_url`, `region`, `cache_timeout` | Get non watermarked video url |
| `GetNoWatermarkUrlByIdAsync` | `/getNoWatermarkUrlByID` | `video_id`, `region`, `cache_timeout` | Get non watermarked video url by video ID |
| `GetVideoByIdAsync` | `/getVideoByID` | `video_id`, `region`, `cache_timeout` | Get video info by ID |
| `GetVideoByUrlAsync` | `/getVideoByUrl` | `video_url`, `region`, `cache_timeout` | Get video info by URL |
| `GetUnshortenedUrlAsync` | `/getUnshortenedUrl` | `video_url`, `cache_timeout` | Convert short TikTok video URL to full TikTok video URL |
| `GetCommentsByUrlAsync` | `/getCommentsByUrl` | `video_url`, `region`, `cursor`, `count`, `cache_timeout` | Get comments list by video URL |
| `GetCommentsByIdAsync` | `/getCommentsByID` | `video_id`, `region`, `cursor`, `count`, `cache_timeout` | Get comments list by video ID |
| `GetCommentsRepliesAsync` | `/getCommentsReplies` | `video_id`, `comment_id`, `cursor`, `count`, `cache_timeout` | Get comments replies |
| `SearchUserAsync` | `/searchUser` | `keyword`, `cursor`, `count`, `region`, `follower_count`, `profile_type`, `other_pref`, `cache_timeout` | Search for user by keyword |
| `SearchVideoAsync` | `/searchVideo` | `keyword`, `cursor`, `count`, `cache_timeout`, `date_posted`, `sort_by`, `region` | Search for video by keyword |
| `SearchMusicAsync` | `/searchMusic` | `keyword`, `cursor`, `count`, `cache_timeout`, `filter_by`, `sort_type`, `region` | Search for music by keyword |
| `SearchLiveAsync` | `/searchLive` | `keyword`, `offset`, `count`, `cache_timeout`, `region` | Search for live by keyword |
| `SearchHashtagAsync` | `/searchHashtag` | `keyword`, `cursor`, `count`, `region`, `cache_timeout` | Search for hashtag by keyword |
| `SearchLocationAsync` | `/searchLocation` | `keyword`, `cursor`, `count`, `region`, `cache_timeout` | Search for location by keyword |
| `SearchTopAsync` | `/searchTop` | `keyword`, `cursor`, `count`, `region`, `sort_type`, `publish_time`, `cache_timeout` | Top search by text query |
| `SearchInsightsAsync` | `/searchInsights` | `keyword`, `cursor`, `count`, `region`, `cache_timeout` | Search insights by text query |
| `SearchCommentSuggestedUsersAsync` | `/searchCommentSuggestedUsers` | `keyword`, `count`, `region`, `cache_timeout` | Search comment suggested users |
| `GetUserInfoAsync` | `/getUserInfo` | `query`, `region`, `cache_timeout` | Get user info by profile URL or nickname |
| `GetUserInfoByIdAsync` | `/getUserInfoByID` | `user_id`, `region`, `cache_timeout` | Get user info by profile ID |
| `GetBasicUserInfoAsync` | `/getBasicUserInfo` | `query`, `region`, `cache_timeout` | Get user info by username |
| `GetUserFeedAsync` | `/getUserFeed` | `query`, `max_cursor`, `count`, `region`, `with_pinned_posts`, `sort_type`, `cache_timeout` | Get user feed by profile URL or nickname |
| `GetUserFeedByIdAsync` | `/getUserFeedByID` | `user_id`, `max_cursor`, `count`, `region`, `with_pinned_posts`, `sort_type`, `cache_timeout` | Get user feed by profile ID |
| `GetUserIdAsync` | `/getUserID` | `query`, `region`, `cache_timeout` | Get user ID by profile URL or nickname |
| `GetUsernameByIdAsync` | `/getUsernameByID` | `user_id`, `region`, `cache_timeout` | Get username by TikTok user ID |
| `GetTwitterUsernameAsync` | `/getTwitterUsername` | `query`, `region`, `cache_timeout` | Get Twitter username by profile URL, nickname or TikTok user ID |
| `GetInstagramUsernameAsync` | `/getInstagramUsername` | `query`, `region`, `cache_timeout` | Get Instagram username by profile URL, nickname or TikTok user ID |
| `GetYoutubeChannelAsync` | `/getYoutubeChannel` | `query`, `region`, `cache_timeout` | Get YouTube channel info by profile URL, nickname or TikTok user ID |
| `GetFollowersAsync` | `/getFollowers` | `query`, `count`, `min_time`, `cache_timeout` | Get user followers by profile URL or nickname |
| `GetFollowersByIdAsync` | `/getFollowersByID` | `user_id`, `count`, `min_time`, `cache_timeout` | Get user followers by profile ID |
| `GetFollowingAsync` | `/getFollowing` | `query`, `count`, `min_time`, `cache_timeout` | Get user following by profile URL or nickname |
| `GetFollowingByIdAsync` | `/getFollowingByID` | `user_id`, `count`, `min_time`, `cache_timeout` | Get user following by profile ID |
| `GetLiveEventInfoByIdAsync` | `/getLiveEventInfoByID` | `event_id`, `cache_timeout` | Get live event info by ID |
| `GetHashtagInfoAsync` | `/getHashtagInfo` | `query`, `region`, `cache_timeout` | Get hashtag info by URL or tag name |
| `GetHashtagFeedAsync` | `/getHashtagFeed` | `query`, `cursor`, `count`, `region`, `cache_timeout` | Get hashtag feed by URL or tag name |
| `GetHashtagFeedByIdAsync` | `/getHashtagFeedByID` | `id`, `cursor`, `count`, `region`, `cache_timeout` | Get hashtag feed by ID |
| `GetLocationInfoByIdAsync` | `/getLocationInfoByID` | `location_id`, `cache_timeout` | Get location info by ID |
| `GetLocationFeedByIdAsync` | `/getLocationFeedByID` | `location_id`, `count`, `cursor`, `region`, `cache_timeout` | Get videos by location ID |
| `GetMusicInfoAsync` | `/getMusicInfo` | `query`, `region`, `cache_timeout` | Get music info by URL or ID |
| `GetMusicFeedAsync` | `/getMusicFeed` | `query`, `cursor`, `count`, `cache_timeout`, `region` | Get music feed by URL or ID |
| `GetMusicChartsAsync` | `/getMusicCharts` | `chart_type`, `cache_timeout`, `region` | Get music charts |
| `GetTrendingCategoriesListAsync` | `/getTrendingCategoriesList` | `region`, `offset`, `count`, `cache_timeout` | Get trending categories list |
| `GetTrendingFeedAsync` | `/getTrendingFeed` | `region`, `pull_type`, `cache_timeout` | Get trending feed |
| `GetStickersByIdAsync` | `/getStickersByID` | `sticker_ids`, `cache_timeout` | Get effect information by IDs |
| `GetStickerByIdAsync` | `/getStickerByID` | `sticker_id`, `cache_timeout` | Get effect information by ID |
| `GetStickerFeedByIdAsync` | `/getStickerFeedByID` | `sticker_id`, `count`, `cursor`, `region`, `cache_timeout` | Get videos by effect ID |
| `GetUserStoriesAsync` | `/getUserStories` | `user_id`, `count`, `min_cursor`, `region`, `cache_timeout` | Get user stories |
| `GetStoryInfoByIdAsync` | `/getStoryInfoByID` | `story_id`, `region`, `cache_timeout` | Get story info by ID |
| `GetUserPlaylistsAsync` | `/getUserPlaylists` | `user_id`, `cursor`, `cache_timeout` | Get user playlists |
| `GetUserPlaylistByIdAsync` | `/getUserPlaylistByID` | `user_id`, `playlist_id`, `cache_timeout` | Get user playlist by ID |
| `GetVideoByPlaylistIdAsync` | `/getVideoByPlaylistID` | `user_id`, `playlist_id`, `max_cursor`, `cache_timeout` | Get video by playlist ID |
| `GetAvailableRankingListAsync` | `/getAvailableRankingList` | `room_id`, `user_id`, `cache_timeout` | Get available ranking list |
| `GetRankingInfoAsync` | `/getRankingInfo` | `rank_type`, `room_id`, `user_id`, `cache_timeout` | Get ranking info |
| `GetLiveInfoAsync` | `/getLiveInfo` | `room_id`, `user_id`, `cache_timeout` | Get live info |
| `GetLiveFeedAsync` | `/getLiveFeed` | `draw_room_id`, `max_time`, `region`, `cache_timeout` | Get live feed |

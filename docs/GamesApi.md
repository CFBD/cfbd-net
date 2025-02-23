# CollegeFootballData.Api.GamesApi

All URIs are relative to *https://apinext.collegefootballdata.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAdvancedBoxScore**](GamesApi.md#getadvancedboxscore) | **GET** /game/box/advanced |  |
| [**GetCalendar**](GamesApi.md#getcalendar) | **GET** /calendar |  |
| [**GetGamePlayerStats**](GamesApi.md#getgameplayerstats) | **GET** /games/players |  |
| [**GetGameTeamStats**](GamesApi.md#getgameteamstats) | **GET** /games/teams |  |
| [**GetGames**](GamesApi.md#getgames) | **GET** /games |  |
| [**GetMedia**](GamesApi.md#getmedia) | **GET** /games/media |  |
| [**GetRecords**](GamesApi.md#getrecords) | **GET** /records |  |
| [**GetScoreboard**](GamesApi.md#getscoreboard) | **GET** /scoreboard |  |
| [**GetWeather**](GamesApi.md#getweather) | **GET** /games/weather |  |

<a id="getadvancedboxscore"></a>
# **GetAdvancedBoxScore**
> AdvancedBoxScore GetAdvancedBoxScore (int id)



Retrieves an advanced box score for a game

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetAdvancedBoxScoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GamesApi(config);
            var id = 56;  // int | Required game id filter

            try
            {
                AdvancedBoxScore result = apiInstance.GetAdvancedBoxScore(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GamesApi.GetAdvancedBoxScore: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAdvancedBoxScoreWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AdvancedBoxScore> response = apiInstance.GetAdvancedBoxScoreWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GamesApi.GetAdvancedBoxScoreWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Required game id filter |  |

### Return type

[**AdvancedBoxScore**](AdvancedBoxScore.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcalendar"></a>
# **GetCalendar**
> List&lt;CalendarWeek&gt; GetCalendar (int year)



Retrieves calendar information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetCalendarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GamesApi(config);
            var year = 56;  // int | Required year filter

            try
            {
                List<CalendarWeek> result = apiInstance.GetCalendar(year);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GamesApi.GetCalendar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCalendarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<CalendarWeek>> response = apiInstance.GetCalendarWithHttpInfo(year);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GamesApi.GetCalendarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Required year filter |  |

### Return type

[**List&lt;CalendarWeek&gt;**](CalendarWeek.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getgameplayerstats"></a>
# **GetGamePlayerStats**
> List&lt;GamePlayerStats&gt; GetGamePlayerStats (int? year = null, int? week = null, string? team = null, string? conference = null, DivisionClassification? classification = null, SeasonType? seasonType = null, string? category = null, int? id = null)



Retrieves player box score statistics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetGamePlayerStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GamesApi(config);
            var year = 56;  // int? | Required year filter (along with one of week, team, or conference), unless id is specified (optional) 
            var week = 56;  // int? | Optional week filter, required if team and conference not specified (optional) 
            var team = "team_example";  // string? | Optional team filter, required if week and conference not specified (optional) 
            var conference = "conference_example";  // string? | Optional conference filter, required if week and team not specified (optional) 
            var classification = new DivisionClassification?(); // DivisionClassification? | Optional division classification filter (optional) 
            var seasonType = new SeasonType?(); // SeasonType? | Optional season type filter (optional) 
            var category = "category_example";  // string? | Optional player statistical category filter (optional) 
            var id = 56;  // int? | Optional id filter to retrieve a single game (optional) 

            try
            {
                List<GamePlayerStats> result = apiInstance.GetGamePlayerStats(year, week, team, conference, classification, seasonType, category, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GamesApi.GetGamePlayerStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGamePlayerStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<GamePlayerStats>> response = apiInstance.GetGamePlayerStatsWithHttpInfo(year, week, team, conference, classification, seasonType, category, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GamesApi.GetGamePlayerStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int?** | Required year filter (along with one of week, team, or conference), unless id is specified | [optional]  |
| **week** | **int?** | Optional week filter, required if team and conference not specified | [optional]  |
| **team** | **string?** | Optional team filter, required if week and conference not specified | [optional]  |
| **conference** | **string?** | Optional conference filter, required if week and team not specified | [optional]  |
| **classification** | [**DivisionClassification?**](DivisionClassification?.md) | Optional division classification filter | [optional]  |
| **seasonType** | [**SeasonType?**](SeasonType?.md) | Optional season type filter | [optional]  |
| **category** | **string?** | Optional player statistical category filter | [optional]  |
| **id** | **int?** | Optional id filter to retrieve a single game | [optional]  |

### Return type

[**List&lt;GamePlayerStats&gt;**](GamePlayerStats.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getgameteamstats"></a>
# **GetGameTeamStats**
> List&lt;GameTeamStats&gt; GetGameTeamStats (int? year = null, int? week = null, string? team = null, string? conference = null, DivisionClassification? classification = null, SeasonType? seasonType = null, int? id = null)



Retrieves team box score statistics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetGameTeamStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GamesApi(config);
            var year = 56;  // int? | Required year filter (along with one of week, team, or conference), unless id is specified (optional) 
            var week = 56;  // int? | Optional week filter, required if team and conference not specified (optional) 
            var team = "team_example";  // string? | Optional team filter, required if week and conference not specified (optional) 
            var conference = "conference_example";  // string? | Optional conference filter, required if week and team not specified (optional) 
            var classification = new DivisionClassification?(); // DivisionClassification? | Optional division classification filter (optional) 
            var seasonType = new SeasonType?(); // SeasonType? | Optional season type filter (optional) 
            var id = 56;  // int? | Optional id filter to retrieve a single game (optional) 

            try
            {
                List<GameTeamStats> result = apiInstance.GetGameTeamStats(year, week, team, conference, classification, seasonType, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GamesApi.GetGameTeamStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGameTeamStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<GameTeamStats>> response = apiInstance.GetGameTeamStatsWithHttpInfo(year, week, team, conference, classification, seasonType, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GamesApi.GetGameTeamStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int?** | Required year filter (along with one of week, team, or conference), unless id is specified | [optional]  |
| **week** | **int?** | Optional week filter, required if team and conference not specified | [optional]  |
| **team** | **string?** | Optional team filter, required if week and conference not specified | [optional]  |
| **conference** | **string?** | Optional conference filter, required if week and team not specified | [optional]  |
| **classification** | [**DivisionClassification?**](DivisionClassification?.md) | Optional division classification filter | [optional]  |
| **seasonType** | [**SeasonType?**](SeasonType?.md) | Optional season type filter | [optional]  |
| **id** | **int?** | Optional id filter to retrieve a single game | [optional]  |

### Return type

[**List&lt;GameTeamStats&gt;**](GameTeamStats.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getgames"></a>
# **GetGames**
> List&lt;Game&gt; GetGames (int? year = null, int? week = null, SeasonType? seasonType = null, DivisionClassification? classification = null, string? team = null, string? home = null, string? away = null, string? conference = null, int? id = null)



Retrieves historical game data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetGamesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GamesApi(config);
            var year = 56;  // int? | Required year filter (except when id is specified) (optional) 
            var week = 56;  // int? | Optional week filter (optional) 
            var seasonType = new SeasonType?(); // SeasonType? | Optional season type filter (optional) 
            var classification = new DivisionClassification?(); // DivisionClassification? | Optional division classification filter (optional) 
            var team = "team_example";  // string? | Optional team filter (optional) 
            var home = "home_example";  // string? | Optional home team filter (optional) 
            var away = "away_example";  // string? | Optional away team filter (optional) 
            var conference = "conference_example";  // string? | Optional conference filter (optional) 
            var id = 56;  // int? | Game id filter to retrieve a single game (optional) 

            try
            {
                List<Game> result = apiInstance.GetGames(year, week, seasonType, classification, team, home, away, conference, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GamesApi.GetGames: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGamesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Game>> response = apiInstance.GetGamesWithHttpInfo(year, week, seasonType, classification, team, home, away, conference, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GamesApi.GetGamesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int?** | Required year filter (except when id is specified) | [optional]  |
| **week** | **int?** | Optional week filter | [optional]  |
| **seasonType** | [**SeasonType?**](SeasonType?.md) | Optional season type filter | [optional]  |
| **classification** | [**DivisionClassification?**](DivisionClassification?.md) | Optional division classification filter | [optional]  |
| **team** | **string?** | Optional team filter | [optional]  |
| **home** | **string?** | Optional home team filter | [optional]  |
| **away** | **string?** | Optional away team filter | [optional]  |
| **conference** | **string?** | Optional conference filter | [optional]  |
| **id** | **int?** | Game id filter to retrieve a single game | [optional]  |

### Return type

[**List&lt;Game&gt;**](Game.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmedia"></a>
# **GetMedia**
> List&lt;GameMedia&gt; GetMedia (int year, SeasonType? seasonType = null, int? week = null, string? team = null, string? conference = null, MediaType? mediaType = null, DivisionClassification? classification = null)



Retrieves media information for games

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetMediaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GamesApi(config);
            var year = 56;  // int | Required year filter
            var seasonType = new SeasonType?(); // SeasonType? | Optional season type filter (optional) 
            var week = 56;  // int? | Optional week filter (optional) 
            var team = "team_example";  // string? | Optional team filter (optional) 
            var conference = "conference_example";  // string? | Optional conference filter (optional) 
            var mediaType = new MediaType?(); // MediaType? | Optional media type filter (optional) 
            var classification = new DivisionClassification?(); // DivisionClassification? | Optional division classification filter (optional) 

            try
            {
                List<GameMedia> result = apiInstance.GetMedia(year, seasonType, week, team, conference, mediaType, classification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GamesApi.GetMedia: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMediaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<GameMedia>> response = apiInstance.GetMediaWithHttpInfo(year, seasonType, week, team, conference, mediaType, classification);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GamesApi.GetMediaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Required year filter |  |
| **seasonType** | [**SeasonType?**](SeasonType?.md) | Optional season type filter | [optional]  |
| **week** | **int?** | Optional week filter | [optional]  |
| **team** | **string?** | Optional team filter | [optional]  |
| **conference** | **string?** | Optional conference filter | [optional]  |
| **mediaType** | [**MediaType?**](MediaType?.md) | Optional media type filter | [optional]  |
| **classification** | [**DivisionClassification?**](DivisionClassification?.md) | Optional division classification filter | [optional]  |

### Return type

[**List&lt;GameMedia&gt;**](GameMedia.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrecords"></a>
# **GetRecords**
> List&lt;TeamRecords&gt; GetRecords (int? year = null, string? team = null, string? conference = null)



Retrieves historical team records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GamesApi(config);
            var year = 56;  // int? | Year filter, required if team not specified (optional) 
            var team = "team_example";  // string? | Team filter, required if year not specified (optional) 
            var conference = "conference_example";  // string? | Optional conference filter (optional) 

            try
            {
                List<TeamRecords> result = apiInstance.GetRecords(year, team, conference);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GamesApi.GetRecords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<TeamRecords>> response = apiInstance.GetRecordsWithHttpInfo(year, team, conference);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GamesApi.GetRecordsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int?** | Year filter, required if team not specified | [optional]  |
| **team** | **string?** | Team filter, required if year not specified | [optional]  |
| **conference** | **string?** | Optional conference filter | [optional]  |

### Return type

[**List&lt;TeamRecords&gt;**](TeamRecords.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getscoreboard"></a>
# **GetScoreboard**
> List&lt;ScoreboardGame&gt; GetScoreboard (DivisionClassification? classification = null, string? conference = null)



Retrieves live scoreboard data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetScoreboardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GamesApi(config);
            var classification = new DivisionClassification?(); // DivisionClassification? | Optional division classification filter, defaults to fbs (optional) 
            var conference = "conference_example";  // string? | Optional conference filter (optional) 

            try
            {
                List<ScoreboardGame> result = apiInstance.GetScoreboard(classification, conference);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GamesApi.GetScoreboard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetScoreboardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ScoreboardGame>> response = apiInstance.GetScoreboardWithHttpInfo(classification, conference);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GamesApi.GetScoreboardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **classification** | [**DivisionClassification?**](DivisionClassification?.md) | Optional division classification filter, defaults to fbs | [optional]  |
| **conference** | **string?** | Optional conference filter | [optional]  |

### Return type

[**List&lt;ScoreboardGame&gt;**](ScoreboardGame.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getweather"></a>
# **GetWeather**
> List&lt;GameWeather&gt; GetWeather (int? year = null, SeasonType? seasonType = null, int? week = null, string? team = null, string? conference = null, DivisionClassification? classification = null, int? gameId = null)



Retrieve historical and future weather data (Patreon only)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetWeatherExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GamesApi(config);
            var year = 56;  // int? | Year filter, required if game id not specified (optional) 
            var seasonType = new SeasonType?(); // SeasonType? | Optional season type filter (optional) 
            var week = 56;  // int? | Optional week filter (optional) 
            var team = "team_example";  // string? | Optional team filter (optional) 
            var conference = "conference_example";  // string? | Optional conference filter (optional) 
            var classification = new DivisionClassification?(); // DivisionClassification? | Optional division classification filter (optional) 
            var gameId = 56;  // int? | Filter for retrieving a single game (optional) 

            try
            {
                List<GameWeather> result = apiInstance.GetWeather(year, seasonType, week, team, conference, classification, gameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GamesApi.GetWeather: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWeatherWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<GameWeather>> response = apiInstance.GetWeatherWithHttpInfo(year, seasonType, week, team, conference, classification, gameId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GamesApi.GetWeatherWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int?** | Year filter, required if game id not specified | [optional]  |
| **seasonType** | [**SeasonType?**](SeasonType?.md) | Optional season type filter | [optional]  |
| **week** | **int?** | Optional week filter | [optional]  |
| **team** | **string?** | Optional team filter | [optional]  |
| **conference** | **string?** | Optional conference filter | [optional]  |
| **classification** | [**DivisionClassification?**](DivisionClassification?.md) | Optional division classification filter | [optional]  |
| **gameId** | **int?** | Filter for retrieving a single game | [optional]  |

### Return type

[**List&lt;GameWeather&gt;**](GameWeather.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# CollegeFootballData.Api.StatsApi

All URIs are relative to *https://apinext.collegefootballdata.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAdvancedGameStats**](StatsApi.md#getadvancedgamestats) | **GET** /stats/game/advanced |  |
| [**GetAdvancedSeasonStats**](StatsApi.md#getadvancedseasonstats) | **GET** /stats/season/advanced |  |
| [**GetCategories**](StatsApi.md#getcategories) | **GET** /stats/categories |  |
| [**GetPlayerSeasonStats**](StatsApi.md#getplayerseasonstats) | **GET** /stats/player/season |  |
| [**GetTeamStats**](StatsApi.md#getteamstats) | **GET** /stats/season |  |

<a id="getadvancedgamestats"></a>
# **GetAdvancedGameStats**
> List&lt;AdvancedGameStat&gt; GetAdvancedGameStats (int? year = null, string? team = null, double? week = null, string? opponent = null, bool? excludeGarbageTime = null, SeasonType? seasonType = null)



Retrieves advanced statistics aggregated by game

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetAdvancedGameStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StatsApi(config);
            var year = 56;  // int? | Year filter, required if team not specified (optional) 
            var team = "team_example";  // string? | Team filter, required if year not specified (optional) 
            var week = 1.2D;  // double? | Optional week filter (optional) 
            var opponent = "opponent_example";  // string? | Optional opponent filter (optional) 
            var excludeGarbageTime = true;  // bool? | Garbage time exclusion filter, defaults to false (optional) 
            var seasonType = new SeasonType?(); // SeasonType? | Optional season type filter (optional) 

            try
            {
                List<AdvancedGameStat> result = apiInstance.GetAdvancedGameStats(year, team, week, opponent, excludeGarbageTime, seasonType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatsApi.GetAdvancedGameStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAdvancedGameStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<AdvancedGameStat>> response = apiInstance.GetAdvancedGameStatsWithHttpInfo(year, team, week, opponent, excludeGarbageTime, seasonType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatsApi.GetAdvancedGameStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int?** | Year filter, required if team not specified | [optional]  |
| **team** | **string?** | Team filter, required if year not specified | [optional]  |
| **week** | **double?** | Optional week filter | [optional]  |
| **opponent** | **string?** | Optional opponent filter | [optional]  |
| **excludeGarbageTime** | **bool?** | Garbage time exclusion filter, defaults to false | [optional]  |
| **seasonType** | [**SeasonType?**](SeasonType?.md) | Optional season type filter | [optional]  |

### Return type

[**List&lt;AdvancedGameStat&gt;**](AdvancedGameStat.md)

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

<a id="getadvancedseasonstats"></a>
# **GetAdvancedSeasonStats**
> List&lt;AdvancedSeasonStat&gt; GetAdvancedSeasonStats (int? year = null, string? team = null, bool? excludeGarbageTime = null, int? startWeek = null, int? endWeek = null)



Retrieves advanced season statistics for teams

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetAdvancedSeasonStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StatsApi(config);
            var year = 56;  // int? | Year filter, required if team not specified (optional) 
            var team = "team_example";  // string? | Team filter, required if year not specified (optional) 
            var excludeGarbageTime = true;  // bool? | Garbage time exclusion filter, defaults to false (optional) 
            var startWeek = 56;  // int? | Optional start week range filter (optional) 
            var endWeek = 56;  // int? | Optional end week range filter (optional) 

            try
            {
                List<AdvancedSeasonStat> result = apiInstance.GetAdvancedSeasonStats(year, team, excludeGarbageTime, startWeek, endWeek);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatsApi.GetAdvancedSeasonStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAdvancedSeasonStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<AdvancedSeasonStat>> response = apiInstance.GetAdvancedSeasonStatsWithHttpInfo(year, team, excludeGarbageTime, startWeek, endWeek);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatsApi.GetAdvancedSeasonStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int?** | Year filter, required if team not specified | [optional]  |
| **team** | **string?** | Team filter, required if year not specified | [optional]  |
| **excludeGarbageTime** | **bool?** | Garbage time exclusion filter, defaults to false | [optional]  |
| **startWeek** | **int?** | Optional start week range filter | [optional]  |
| **endWeek** | **int?** | Optional end week range filter | [optional]  |

### Return type

[**List&lt;AdvancedSeasonStat&gt;**](AdvancedSeasonStat.md)

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

<a id="getcategories"></a>
# **GetCategories**
> List&lt;string&gt; GetCategories ()



Gets team statistical categories

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StatsApi(config);

            try
            {
                List<string> result = apiInstance.GetCategories();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatsApi.GetCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<string>> response = apiInstance.GetCategoriesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatsApi.GetCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

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

<a id="getplayerseasonstats"></a>
# **GetPlayerSeasonStats**
> List&lt;PlayerStat&gt; GetPlayerSeasonStats (int year, string? conference = null, string? team = null, int? startWeek = null, int? endWeek = null, SeasonType? seasonType = null, string? category = null)



Retrieves aggregated player statistics for a given season

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetPlayerSeasonStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StatsApi(config);
            var year = 56;  // int | Required year filter
            var conference = "conference_example";  // string? | Optional conference filter (optional) 
            var team = "team_example";  // string? | Optional team filter (optional) 
            var startWeek = 56;  // int? | Optional starting week range (optional) 
            var endWeek = 56;  // int? | Optional ending week range (optional) 
            var seasonType = new SeasonType?(); // SeasonType? | Optional season type filter (optional) 
            var category = "category_example";  // string? | Optional category filter (optional) 

            try
            {
                List<PlayerStat> result = apiInstance.GetPlayerSeasonStats(year, conference, team, startWeek, endWeek, seasonType, category);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatsApi.GetPlayerSeasonStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPlayerSeasonStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PlayerStat>> response = apiInstance.GetPlayerSeasonStatsWithHttpInfo(year, conference, team, startWeek, endWeek, seasonType, category);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatsApi.GetPlayerSeasonStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Required year filter |  |
| **conference** | **string?** | Optional conference filter | [optional]  |
| **team** | **string?** | Optional team filter | [optional]  |
| **startWeek** | **int?** | Optional starting week range | [optional]  |
| **endWeek** | **int?** | Optional ending week range | [optional]  |
| **seasonType** | [**SeasonType?**](SeasonType?.md) | Optional season type filter | [optional]  |
| **category** | **string?** | Optional category filter | [optional]  |

### Return type

[**List&lt;PlayerStat&gt;**](PlayerStat.md)

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

<a id="getteamstats"></a>
# **GetTeamStats**
> List&lt;TeamStat&gt; GetTeamStats (int? year = null, string? team = null, string? conference = null, int? startWeek = null, int? endWeek = null)



Retrieves aggregated team season statistics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetTeamStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StatsApi(config);
            var year = 56;  // int? | Year filter, required if team not specified (optional) 
            var team = "team_example";  // string? | Team filter, required if year not specified (optional) 
            var conference = "conference_example";  // string? | Optional conference filter (optional) 
            var startWeek = 56;  // int? | Optional week start range filter (optional) 
            var endWeek = 56;  // int? | Optional week end range filter (optional) 

            try
            {
                List<TeamStat> result = apiInstance.GetTeamStats(year, team, conference, startWeek, endWeek);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatsApi.GetTeamStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTeamStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<TeamStat>> response = apiInstance.GetTeamStatsWithHttpInfo(year, team, conference, startWeek, endWeek);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatsApi.GetTeamStatsWithHttpInfo: " + e.Message);
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
| **startWeek** | **int?** | Optional week start range filter | [optional]  |
| **endWeek** | **int?** | Optional week end range filter | [optional]  |

### Return type

[**List&lt;TeamStat&gt;**](TeamStat.md)

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


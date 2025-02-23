# CollegeFootballData.Api.BettingApi

All URIs are relative to *https://apinext.collegefootballdata.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetLines**](BettingApi.md#getlines) | **GET** /lines |  |

<a id="getlines"></a>
# **GetLines**
> List&lt;BettingGame&gt; GetLines (int? gameId = null, int? year = null, SeasonType? seasonType = null, int? week = null, string? team = null, string? home = null, string? away = null, string? conference = null, string? provider = null)



Retrieves historical betting data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetLinesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BettingApi(config);
            var gameId = 56;  // int? | Optional gameId filter (optional) 
            var year = 56;  // int? | Year filter, required if game id not specified (optional) 
            var seasonType = new SeasonType?(); // SeasonType? | Optional season type filter (optional) 
            var week = 56;  // int? | Optional week filter (optional) 
            var team = "team_example";  // string? | Optional team filter (optional) 
            var home = "home_example";  // string? | Optional home team filter (optional) 
            var away = "away_example";  // string? | Optional away team filter (optional) 
            var conference = "conference_example";  // string? | Optional conference filter (optional) 
            var provider = "provider_example";  // string? | Optional provider name filter (optional) 

            try
            {
                List<BettingGame> result = apiInstance.GetLines(gameId, year, seasonType, week, team, home, away, conference, provider);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BettingApi.GetLines: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLinesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<BettingGame>> response = apiInstance.GetLinesWithHttpInfo(gameId, year, seasonType, week, team, home, away, conference, provider);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BettingApi.GetLinesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gameId** | **int?** | Optional gameId filter | [optional]  |
| **year** | **int?** | Year filter, required if game id not specified | [optional]  |
| **seasonType** | [**SeasonType?**](SeasonType?.md) | Optional season type filter | [optional]  |
| **week** | **int?** | Optional week filter | [optional]  |
| **team** | **string?** | Optional team filter | [optional]  |
| **home** | **string?** | Optional home team filter | [optional]  |
| **away** | **string?** | Optional away team filter | [optional]  |
| **conference** | **string?** | Optional conference filter | [optional]  |
| **provider** | **string?** | Optional provider name filter | [optional]  |

### Return type

[**List&lt;BettingGame&gt;**](BettingGame.md)

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


# CollegeFootballData.Api.RankingsApi

All URIs are relative to *https://apinext.collegefootballdata.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetRankings**](RankingsApi.md#getrankings) | **GET** /rankings |  |

<a id="getrankings"></a>
# **GetRankings**
> List&lt;PollWeek&gt; GetRankings (int year, SeasonType? seasonType = null, double? week = null)



Retrieves historical poll data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetRankingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RankingsApi(config);
            var year = 56;  // int | Required year filter
            var seasonType = new SeasonType?(); // SeasonType? | Optional season type filter (optional) 
            var week = 1.2D;  // double? | Optional week filter (optional) 

            try
            {
                List<PollWeek> result = apiInstance.GetRankings(year, seasonType, week);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RankingsApi.GetRankings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRankingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PollWeek>> response = apiInstance.GetRankingsWithHttpInfo(year, seasonType, week);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RankingsApi.GetRankingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Required year filter |  |
| **seasonType** | [**SeasonType?**](SeasonType?.md) | Optional season type filter | [optional]  |
| **week** | **double?** | Optional week filter | [optional]  |

### Return type

[**List&lt;PollWeek&gt;**](PollWeek.md)

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


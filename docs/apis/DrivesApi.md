# CollegeFootballData.Api.DrivesApi

All URIs are relative to *https://apinext.collegefootballdata.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDrives**](DrivesApi.md#getdrives) | **GET** /drives |  |

<a id="getdrives"></a>
# **GetDrives**
> List&lt;Drive&gt; GetDrives (int year, SeasonType seasonType = null, int week = null, string team = null, string offense = null, string defense = null, string conference = null, string offenseConference = null, string defenseConference = null, DivisionClassification classification = null)



Retrieves historical drive data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetDrivesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DrivesApi(config);
            var year = 56;  // int | Required year filter
            var seasonType = (SeasonType) "regular";  // SeasonType | Optional season type filter (optional) 
            var week = 56;  // int | Optional week filter (optional) 
            var team = "team_example";  // string | Optional team filter (optional) 
            var offense = "offense_example";  // string | Optional offensive team filter (optional) 
            var defense = "defense_example";  // string | Optional defensive team filter (optional) 
            var conference = "conference_example";  // string | Optional conference filter (optional) 
            var offenseConference = "offenseConference_example";  // string | Optional offensive team conference filter (optional) 
            var defenseConference = "defenseConference_example";  // string | Optional defensive team conference filter (optional) 
            var classification = (DivisionClassification) "fbs";  // DivisionClassification | Optional division classification filter (optional) 

            try
            {
                List<Drive> result = apiInstance.GetDrives(year, seasonType, week, team, offense, defense, conference, offenseConference, defenseConference, classification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DrivesApi.GetDrives: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDrivesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Drive>> response = apiInstance.GetDrivesWithHttpInfo(year, seasonType, week, team, offense, defense, conference, offenseConference, defenseConference, classification);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DrivesApi.GetDrivesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Required year filter |  |
| **seasonType** | **SeasonType** | Optional season type filter | [optional]  |
| **week** | **int** | Optional week filter | [optional]  |
| **team** | **string** | Optional team filter | [optional]  |
| **offense** | **string** | Optional offensive team filter | [optional]  |
| **defense** | **string** | Optional defensive team filter | [optional]  |
| **conference** | **string** | Optional conference filter | [optional]  |
| **offenseConference** | **string** | Optional offensive team conference filter | [optional]  |
| **defenseConference** | **string** | Optional defensive team conference filter | [optional]  |
| **classification** | **DivisionClassification** | Optional division classification filter | [optional]  |

### Return type

[**List&lt;Drive&gt;**](Drive.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


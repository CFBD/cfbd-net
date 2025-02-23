# CollegeFootballData.Api.RecruitingApi

All URIs are relative to *https://apinext.collegefootballdata.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAggregatedTeamRecruitingRatings**](RecruitingApi.md#getaggregatedteamrecruitingratings) | **GET** /recruiting/groups |  |
| [**GetRecruits**](RecruitingApi.md#getrecruits) | **GET** /recruiting/players |  |
| [**GetTeamRecruitingRankings**](RecruitingApi.md#getteamrecruitingrankings) | **GET** /recruiting/teams |  |

<a id="getaggregatedteamrecruitingratings"></a>
# **GetAggregatedTeamRecruitingRatings**
> List&lt;AggregatedTeamRecruiting&gt; GetAggregatedTeamRecruitingRatings (string? team = null, string? conference = null, RecruitClassification? recruitType = null, int? startYear = null, int? endYear = null)



Retrieves aggregated recruiting statistics by team and position grouping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetAggregatedTeamRecruitingRatingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RecruitingApi(config);
            var team = "team_example";  // string? | Optional team filter (optional) 
            var conference = "conference_example";  // string? | Optional conference filter (optional) 
            var recruitType = new RecruitClassification?(); // RecruitClassification? | Optional recruit type filter, defaults to HighSchool (optional) 
            var startYear = 56;  // int? | Optional start year range, defaults to 2000 (optional) 
            var endYear = 56;  // int? | Optional end year range, defaults to current year (optional) 

            try
            {
                List<AggregatedTeamRecruiting> result = apiInstance.GetAggregatedTeamRecruitingRatings(team, conference, recruitType, startYear, endYear);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecruitingApi.GetAggregatedTeamRecruitingRatings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAggregatedTeamRecruitingRatingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<AggregatedTeamRecruiting>> response = apiInstance.GetAggregatedTeamRecruitingRatingsWithHttpInfo(team, conference, recruitType, startYear, endYear);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecruitingApi.GetAggregatedTeamRecruitingRatingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **team** | **string?** | Optional team filter | [optional]  |
| **conference** | **string?** | Optional conference filter | [optional]  |
| **recruitType** | [**RecruitClassification?**](RecruitClassification?.md) | Optional recruit type filter, defaults to HighSchool | [optional]  |
| **startYear** | **int?** | Optional start year range, defaults to 2000 | [optional]  |
| **endYear** | **int?** | Optional end year range, defaults to current year | [optional]  |

### Return type

[**List&lt;AggregatedTeamRecruiting&gt;**](AggregatedTeamRecruiting.md)

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

<a id="getrecruits"></a>
# **GetRecruits**
> List&lt;Recruit&gt; GetRecruits (int? year = null, string? team = null, string? position = null, string? state = null, RecruitClassification? classification = null)



Retrieves player recruiting rankings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetRecruitsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RecruitingApi(config);
            var year = 56;  // int? | Year filter, required when no team specified (optional) 
            var team = "team_example";  // string? | Team filter, required when no team specified (optional) 
            var position = "position_example";  // string? | Optional position categorization filter (optional) 
            var state = "state_example";  // string? | Optional state/province filter (optional) 
            var classification = new RecruitClassification?(); // RecruitClassification? | Optional recruit type classification filter, defaults to HighSchool (optional) 

            try
            {
                List<Recruit> result = apiInstance.GetRecruits(year, team, position, state, classification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecruitingApi.GetRecruits: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecruitsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Recruit>> response = apiInstance.GetRecruitsWithHttpInfo(year, team, position, state, classification);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecruitingApi.GetRecruitsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int?** | Year filter, required when no team specified | [optional]  |
| **team** | **string?** | Team filter, required when no team specified | [optional]  |
| **position** | **string?** | Optional position categorization filter | [optional]  |
| **state** | **string?** | Optional state/province filter | [optional]  |
| **classification** | [**RecruitClassification?**](RecruitClassification?.md) | Optional recruit type classification filter, defaults to HighSchool | [optional]  |

### Return type

[**List&lt;Recruit&gt;**](Recruit.md)

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

<a id="getteamrecruitingrankings"></a>
# **GetTeamRecruitingRankings**
> List&lt;TeamRecruitingRanking&gt; GetTeamRecruitingRankings (int? year = null, string? team = null)



Retrieves team recruiting rankings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetTeamRecruitingRankingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RecruitingApi(config);
            var year = 56;  // int? | Optional year filter (optional) 
            var team = "team_example";  // string? | Optional team filter (optional) 

            try
            {
                List<TeamRecruitingRanking> result = apiInstance.GetTeamRecruitingRankings(year, team);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecruitingApi.GetTeamRecruitingRankings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTeamRecruitingRankingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<TeamRecruitingRanking>> response = apiInstance.GetTeamRecruitingRankingsWithHttpInfo(year, team);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecruitingApi.GetTeamRecruitingRankingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int?** | Optional year filter | [optional]  |
| **team** | **string?** | Optional team filter | [optional]  |

### Return type

[**List&lt;TeamRecruitingRanking&gt;**](TeamRecruitingRanking.md)

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


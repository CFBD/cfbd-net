# CollegeFootballData.Api.AdjustedMetricsApi

All URIs are relative to *https://api.collegefootballdata.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAdjustedPlayerPassingStats**](AdjustedMetricsApi.md#getadjustedplayerpassingstats) | **GET** /wepa/players/passing |  |
| [**GetAdjustedPlayerRushingStats**](AdjustedMetricsApi.md#getadjustedplayerrushingstats) | **GET** /wepa/players/rushing |  |
| [**GetAdjustedTeamSeasonStats**](AdjustedMetricsApi.md#getadjustedteamseasonstats) | **GET** /wepa/team/season |  |
| [**GetKickerPaar**](AdjustedMetricsApi.md#getkickerpaar) | **GET** /wepa/players/kicking |  |

<a id="getadjustedplayerpassingstats"></a>
# **GetAdjustedPlayerPassingStats**
> List&lt;PlayerWeightedEPA&gt; GetAdjustedPlayerPassingStats (int year = null, string team = null, string conference = null, string position = null)



Retrieve opponent-adjusted player passing statistics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetAdjustedPlayerPassingStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdjustedMetricsApi(config);
            var year = 56;  // int | Optional year filter (optional) 
            var team = "team_example";  // string | Optional team filter (optional) 
            var conference = "conference_example";  // string | Optional conference abbreviation filter (optional) 
            var position = "position_example";  // string | Optional position abbreviation filter (optional) 

            try
            {
                List<PlayerWeightedEPA> result = apiInstance.GetAdjustedPlayerPassingStats(year, team, conference, position);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdjustedMetricsApi.GetAdjustedPlayerPassingStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAdjustedPlayerPassingStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PlayerWeightedEPA>> response = apiInstance.GetAdjustedPlayerPassingStatsWithHttpInfo(year, team, conference, position);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdjustedMetricsApi.GetAdjustedPlayerPassingStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Optional year filter | [optional]  |
| **team** | **string** | Optional team filter | [optional]  |
| **conference** | **string** | Optional conference abbreviation filter | [optional]  |
| **position** | **string** | Optional position abbreviation filter | [optional]  |

### Return type

[**List&lt;PlayerWeightedEPA&gt;**](PlayerWeightedEPA.md)

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

<a id="getadjustedplayerrushingstats"></a>
# **GetAdjustedPlayerRushingStats**
> List&lt;PlayerWeightedEPA&gt; GetAdjustedPlayerRushingStats (int year = null, string team = null, string conference = null, string position = null)



Retrieve opponent-adjusted player rushing statistics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetAdjustedPlayerRushingStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdjustedMetricsApi(config);
            var year = 56;  // int | Optional year filter (optional) 
            var team = "team_example";  // string | Optional team filter (optional) 
            var conference = "conference_example";  // string | Optional conference abbreviation filter (optional) 
            var position = "position_example";  // string | Optional position abbreviation filter (optional) 

            try
            {
                List<PlayerWeightedEPA> result = apiInstance.GetAdjustedPlayerRushingStats(year, team, conference, position);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdjustedMetricsApi.GetAdjustedPlayerRushingStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAdjustedPlayerRushingStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PlayerWeightedEPA>> response = apiInstance.GetAdjustedPlayerRushingStatsWithHttpInfo(year, team, conference, position);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdjustedMetricsApi.GetAdjustedPlayerRushingStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Optional year filter | [optional]  |
| **team** | **string** | Optional team filter | [optional]  |
| **conference** | **string** | Optional conference abbreviation filter | [optional]  |
| **position** | **string** | Optional position abbreviation filter | [optional]  |

### Return type

[**List&lt;PlayerWeightedEPA&gt;**](PlayerWeightedEPA.md)

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

<a id="getadjustedteamseasonstats"></a>
# **GetAdjustedTeamSeasonStats**
> List&lt;AdjustedTeamMetrics&gt; GetAdjustedTeamSeasonStats (int year = null, string team = null, string conference = null)



Retrieve opponent-adjusted team season statistics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetAdjustedTeamSeasonStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdjustedMetricsApi(config);
            var year = 56;  // int | Optional year filter (optional) 
            var team = "team_example";  // string | Optional team filter (optional) 
            var conference = "conference_example";  // string | Optional conference filter (optional) 

            try
            {
                List<AdjustedTeamMetrics> result = apiInstance.GetAdjustedTeamSeasonStats(year, team, conference);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdjustedMetricsApi.GetAdjustedTeamSeasonStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAdjustedTeamSeasonStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<AdjustedTeamMetrics>> response = apiInstance.GetAdjustedTeamSeasonStatsWithHttpInfo(year, team, conference);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdjustedMetricsApi.GetAdjustedTeamSeasonStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Optional year filter | [optional]  |
| **team** | **string** | Optional team filter | [optional]  |
| **conference** | **string** | Optional conference filter | [optional]  |

### Return type

[**List&lt;AdjustedTeamMetrics&gt;**](AdjustedTeamMetrics.md)

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

<a id="getkickerpaar"></a>
# **GetKickerPaar**
> List&lt;KickerPAAR&gt; GetKickerPaar (int year = null, string team = null, string conference = null)



Retrieve Points Added Above Replacement (PAAR) ratings for kickers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetKickerPaarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdjustedMetricsApi(config);
            var year = 56;  // int | Optional year filter (optional) 
            var team = "team_example";  // string | Optional team filter (optional) 
            var conference = "conference_example";  // string | Optional conference abbreviation filter (optional) 

            try
            {
                List<KickerPAAR> result = apiInstance.GetKickerPaar(year, team, conference);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdjustedMetricsApi.GetKickerPaar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetKickerPaarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<KickerPAAR>> response = apiInstance.GetKickerPaarWithHttpInfo(year, team, conference);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdjustedMetricsApi.GetKickerPaarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Optional year filter | [optional]  |
| **team** | **string** | Optional team filter | [optional]  |
| **conference** | **string** | Optional conference abbreviation filter | [optional]  |

### Return type

[**List&lt;KickerPAAR&gt;**](KickerPAAR.md)

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


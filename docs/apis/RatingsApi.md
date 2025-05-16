# CollegeFootballData.Api.RatingsApi

All URIs are relative to *https://api.collegefootballdata.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetConferenceSP**](RatingsApi.md#getconferencesp) | **GET** /ratings/sp/conferences |  |
| [**GetElo**](RatingsApi.md#getelo) | **GET** /ratings/elo |  |
| [**GetFPI**](RatingsApi.md#getfpi) | **GET** /ratings/fpi |  |
| [**GetSP**](RatingsApi.md#getsp) | **GET** /ratings/sp |  |
| [**GetSRS**](RatingsApi.md#getsrs) | **GET** /ratings/srs |  |

<a id="getconferencesp"></a>
# **GetConferenceSP**
> List&lt;ConferenceSP&gt; GetConferenceSP (int year = null, string conference = null)



Retrieves aggregated historical conference SP+ data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetConferenceSPExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RatingsApi(config);
            var year = 56;  // int | Optional year filter (optional) 
            var conference = "conference_example";  // string | Optional conference filter (optional) 

            try
            {
                List<ConferenceSP> result = apiInstance.GetConferenceSP(year, conference);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RatingsApi.GetConferenceSP: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConferenceSPWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ConferenceSP>> response = apiInstance.GetConferenceSPWithHttpInfo(year, conference);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RatingsApi.GetConferenceSPWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Optional year filter | [optional]  |
| **conference** | **string** | Optional conference filter | [optional]  |

### Return type

[**List&lt;ConferenceSP&gt;**](ConferenceSP.md)

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

<a id="getelo"></a>
# **GetElo**
> List&lt;TeamElo&gt; GetElo (int year = null, int week = null, SeasonType seasonType = null, string team = null, string conference = null)



Retrieves historical Elo ratings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetEloExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RatingsApi(config);
            var year = 56;  // int | Optional year filter (optional) 
            var week = 56;  // int | Optional week filter, defaults to last available week in the season (optional) 
            var seasonType = (SeasonType) "regular";  // SeasonType | Optional season type filter (optional) 
            var team = "team_example";  // string | Optional team filter (optional) 
            var conference = "conference_example";  // string | Optional conference filter (optional) 

            try
            {
                List<TeamElo> result = apiInstance.GetElo(year, week, seasonType, team, conference);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RatingsApi.GetElo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEloWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<TeamElo>> response = apiInstance.GetEloWithHttpInfo(year, week, seasonType, team, conference);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RatingsApi.GetEloWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Optional year filter | [optional]  |
| **week** | **int** | Optional week filter, defaults to last available week in the season | [optional]  |
| **seasonType** | **SeasonType** | Optional season type filter | [optional]  |
| **team** | **string** | Optional team filter | [optional]  |
| **conference** | **string** | Optional conference filter | [optional]  |

### Return type

[**List&lt;TeamElo&gt;**](TeamElo.md)

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

<a id="getfpi"></a>
# **GetFPI**
> List&lt;TeamFPI&gt; GetFPI (int year = null, string team = null, string conference = null)



Retrieves historical Football Power Index (FPI) ratings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetFPIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RatingsApi(config);
            var year = 56;  // int | year filter, required if team not specified (optional) 
            var team = "team_example";  // string | team filter, required if year not specified (optional) 
            var conference = "conference_example";  // string | Optional conference filter (optional) 

            try
            {
                List<TeamFPI> result = apiInstance.GetFPI(year, team, conference);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RatingsApi.GetFPI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFPIWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<TeamFPI>> response = apiInstance.GetFPIWithHttpInfo(year, team, conference);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RatingsApi.GetFPIWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | year filter, required if team not specified | [optional]  |
| **team** | **string** | team filter, required if year not specified | [optional]  |
| **conference** | **string** | Optional conference filter | [optional]  |

### Return type

[**List&lt;TeamFPI&gt;**](TeamFPI.md)

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

<a id="getsp"></a>
# **GetSP**
> List&lt;TeamSP&gt; GetSP (int year = null, string team = null)



Retrieves SP+ ratings for a given year or school

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetSPExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RatingsApi(config);
            var year = 56;  // int | Year filter, required if team not specified (optional) 
            var team = "team_example";  // string | Team filter, required if year not specified (optional) 

            try
            {
                List<TeamSP> result = apiInstance.GetSP(year, team);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RatingsApi.GetSP: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSPWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<TeamSP>> response = apiInstance.GetSPWithHttpInfo(year, team);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RatingsApi.GetSPWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Year filter, required if team not specified | [optional]  |
| **team** | **string** | Team filter, required if year not specified | [optional]  |

### Return type

[**List&lt;TeamSP&gt;**](TeamSP.md)

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

<a id="getsrs"></a>
# **GetSRS**
> List&lt;TeamSRS&gt; GetSRS (int year = null, string team = null, string conference = null)



Retrieves historical SRS for a year or team

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetSRSExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RatingsApi(config);
            var year = 56;  // int | Year filter, required if team not specified (optional) 
            var team = "team_example";  // string | Team filter, required if year not specified (optional) 
            var conference = "conference_example";  // string | Optional conference filter (optional) 

            try
            {
                List<TeamSRS> result = apiInstance.GetSRS(year, team, conference);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RatingsApi.GetSRS: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSRSWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<TeamSRS>> response = apiInstance.GetSRSWithHttpInfo(year, team, conference);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RatingsApi.GetSRSWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Year filter, required if team not specified | [optional]  |
| **team** | **string** | Team filter, required if year not specified | [optional]  |
| **conference** | **string** | Optional conference filter | [optional]  |

### Return type

[**List&lt;TeamSRS&gt;**](TeamSRS.md)

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


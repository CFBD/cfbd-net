# CollegeFootballData.Api.PlaysApi

All URIs are relative to *https://apinext.collegefootballdata.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetLivePlays**](PlaysApi.md#getliveplays) | **GET** /live/plays |  |
| [**GetPlayStatTypes**](PlaysApi.md#getplaystattypes) | **GET** /plays/stats/types |  |
| [**GetPlayStats**](PlaysApi.md#getplaystats) | **GET** /plays/stats |  |
| [**GetPlayTypes**](PlaysApi.md#getplaytypes) | **GET** /plays/types |  |
| [**GetPlays**](PlaysApi.md#getplays) | **GET** /plays |  |

<a id="getliveplays"></a>
# **GetLivePlays**
> LiveGame GetLivePlays (int gameId)



Queries live play-by-play data and advanced stats

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetLivePlaysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PlaysApi(config);
            var gameId = 56;  // int | Game Id filter

            try
            {
                LiveGame result = apiInstance.GetLivePlays(gameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaysApi.GetLivePlays: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLivePlaysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LiveGame> response = apiInstance.GetLivePlaysWithHttpInfo(gameId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlaysApi.GetLivePlaysWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gameId** | **int** | Game Id filter |  |

### Return type

[**LiveGame**](LiveGame.md)

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

<a id="getplaystattypes"></a>
# **GetPlayStatTypes**
> List&lt;PlayStatType&gt; GetPlayStatTypes ()



Retrieves available play stat types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetPlayStatTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PlaysApi(config);

            try
            {
                List<PlayStatType> result = apiInstance.GetPlayStatTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaysApi.GetPlayStatTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPlayStatTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PlayStatType>> response = apiInstance.GetPlayStatTypesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlaysApi.GetPlayStatTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;PlayStatType&gt;**](PlayStatType.md)

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

<a id="getplaystats"></a>
# **GetPlayStats**
> List&lt;PlayStat&gt; GetPlayStats (int year = null, int week = null, string team = null, int gameId = null, int athleteId = null, int statTypeId = null, SeasonType seasonType = null, string conference = null)



Retrieve player-play associations (limit 2000)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetPlayStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PlaysApi(config);
            var year = 56;  // int | Optional year filter (optional) 
            var week = 56;  // int | Optional week filter (optional) 
            var team = "team_example";  // string | Optional team filter (optional) 
            var gameId = 56;  // int | Optional gameId filter (optional) 
            var athleteId = 56;  // int | Optional athleteId filter (optional) 
            var statTypeId = 56;  // int | Optional statTypeId filter (optional) 
            var seasonType = (SeasonType) "regular";  // SeasonType | Optional season type filter (optional) 
            var conference = "conference_example";  // string | Optional conference filter (optional) 

            try
            {
                List<PlayStat> result = apiInstance.GetPlayStats(year, week, team, gameId, athleteId, statTypeId, seasonType, conference);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaysApi.GetPlayStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPlayStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PlayStat>> response = apiInstance.GetPlayStatsWithHttpInfo(year, week, team, gameId, athleteId, statTypeId, seasonType, conference);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlaysApi.GetPlayStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Optional year filter | [optional]  |
| **week** | **int** | Optional week filter | [optional]  |
| **team** | **string** | Optional team filter | [optional]  |
| **gameId** | **int** | Optional gameId filter | [optional]  |
| **athleteId** | **int** | Optional athleteId filter | [optional]  |
| **statTypeId** | **int** | Optional statTypeId filter | [optional]  |
| **seasonType** | **SeasonType** | Optional season type filter | [optional]  |
| **conference** | **string** | Optional conference filter | [optional]  |

### Return type

[**List&lt;PlayStat&gt;**](PlayStat.md)

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

<a id="getplaytypes"></a>
# **GetPlayTypes**
> List&lt;PlayType&gt; GetPlayTypes ()



Retrieves available play types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetPlayTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PlaysApi(config);

            try
            {
                List<PlayType> result = apiInstance.GetPlayTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaysApi.GetPlayTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPlayTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PlayType>> response = apiInstance.GetPlayTypesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlaysApi.GetPlayTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;PlayType&gt;**](PlayType.md)

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

<a id="getplays"></a>
# **GetPlays**
> List&lt;Play&gt; GetPlays (int year, int week, string team = null, string offense = null, string defense = null, string offenseConference = null, string defenseConference = null, string conference = null, string playType = null, SeasonType seasonType = null, DivisionClassification classification = null)



Retrieves historical play data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetPlaysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PlaysApi(config);
            var year = 56;  // int | Required year filter
            var week = 56;  // int | Required week filter
            var team = "team_example";  // string | Optional team filter (optional) 
            var offense = "offense_example";  // string | Optional offensive team filter (optional) 
            var defense = "defense_example";  // string | Optional defensive team filter (optional) 
            var offenseConference = "offenseConference_example";  // string | Optional offensive conference filter (optional) 
            var defenseConference = "defenseConference_example";  // string | Optional defensive conference filter (optional) 
            var conference = "conference_example";  // string | Optional conference filter (optional) 
            var playType = "playType_example";  // string | Optoinal play type abbreviation filter (optional) 
            var seasonType = (SeasonType) "regular";  // SeasonType | Optional season type filter (optional) 
            var classification = (DivisionClassification) "fbs";  // DivisionClassification | Optional division classification filter (optional) 

            try
            {
                List<Play> result = apiInstance.GetPlays(year, week, team, offense, defense, offenseConference, defenseConference, conference, playType, seasonType, classification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaysApi.GetPlays: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPlaysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Play>> response = apiInstance.GetPlaysWithHttpInfo(year, week, team, offense, defense, offenseConference, defenseConference, conference, playType, seasonType, classification);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlaysApi.GetPlaysWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Required year filter |  |
| **week** | **int** | Required week filter |  |
| **team** | **string** | Optional team filter | [optional]  |
| **offense** | **string** | Optional offensive team filter | [optional]  |
| **defense** | **string** | Optional defensive team filter | [optional]  |
| **offenseConference** | **string** | Optional offensive conference filter | [optional]  |
| **defenseConference** | **string** | Optional defensive conference filter | [optional]  |
| **conference** | **string** | Optional conference filter | [optional]  |
| **playType** | **string** | Optoinal play type abbreviation filter | [optional]  |
| **seasonType** | **SeasonType** | Optional season type filter | [optional]  |
| **classification** | **DivisionClassification** | Optional division classification filter | [optional]  |

### Return type

[**List&lt;Play&gt;**](Play.md)

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


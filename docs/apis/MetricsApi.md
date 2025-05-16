# CollegeFootballData.Api.MetricsApi

All URIs are relative to *https://api.collegefootballdata.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetFieldGoalExpectedPoints**](MetricsApi.md#getfieldgoalexpectedpoints) | **GET** /metrics/fg/ep |  |
| [**GetPredictedPoints**](MetricsApi.md#getpredictedpoints) | **GET** /ppa/predicted |  |
| [**GetPredictedPointsAddedByGame**](MetricsApi.md#getpredictedpointsaddedbygame) | **GET** /ppa/games |  |
| [**GetPredictedPointsAddedByPlayerGame**](MetricsApi.md#getpredictedpointsaddedbyplayergame) | **GET** /ppa/players/games |  |
| [**GetPredictedPointsAddedByPlayerSeason**](MetricsApi.md#getpredictedpointsaddedbyplayerseason) | **GET** /ppa/players/season |  |
| [**GetPredictedPointsAddedByTeam**](MetricsApi.md#getpredictedpointsaddedbyteam) | **GET** /ppa/teams |  |
| [**GetPregameWinProbabilities**](MetricsApi.md#getpregamewinprobabilities) | **GET** /metrics/wp/pregame |  |
| [**GetWinProbability**](MetricsApi.md#getwinprobability) | **GET** /metrics/wp |  |

<a id="getfieldgoalexpectedpoints"></a>
# **GetFieldGoalExpectedPoints**
> List&lt;FieldGoalEP&gt; GetFieldGoalExpectedPoints ()



Queries field goal expected points values

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetFieldGoalExpectedPointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MetricsApi(config);

            try
            {
                List<FieldGoalEP> result = apiInstance.GetFieldGoalExpectedPoints();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GetFieldGoalExpectedPoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFieldGoalExpectedPointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<FieldGoalEP>> response = apiInstance.GetFieldGoalExpectedPointsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GetFieldGoalExpectedPointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;FieldGoalEP&gt;**](FieldGoalEP.md)

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

<a id="getpredictedpoints"></a>
# **GetPredictedPoints**
> List&lt;PredictedPointsValue&gt; GetPredictedPoints (int down, int distance)



Query Predicted Points values by down and distance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetPredictedPointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MetricsApi(config);
            var down = 56;  // int | Down value
            var distance = 56;  // int | Distance value

            try
            {
                List<PredictedPointsValue> result = apiInstance.GetPredictedPoints(down, distance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GetPredictedPoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPredictedPointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PredictedPointsValue>> response = apiInstance.GetPredictedPointsWithHttpInfo(down, distance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GetPredictedPointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **down** | **int** | Down value |  |
| **distance** | **int** | Distance value |  |

### Return type

[**List&lt;PredictedPointsValue&gt;**](PredictedPointsValue.md)

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

<a id="getpredictedpointsaddedbygame"></a>
# **GetPredictedPointsAddedByGame**
> List&lt;TeamGamePredictedPointsAdded&gt; GetPredictedPointsAddedByGame (int year, int week = null, SeasonType seasonType = null, string team = null, string conference = null, bool excludeGarbageTime = null)



Retrieves historical team PPA metrics by game

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetPredictedPointsAddedByGameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MetricsApi(config);
            var year = 56;  // int | Required year filter
            var week = 56;  // int | Optional week filter (optional) 
            var seasonType = (SeasonType) "regular";  // SeasonType | Optional season type filter (optional) 
            var team = "team_example";  // string | Optional team filter (optional) 
            var conference = "conference_example";  // string | Optional conference abbreviation filter (optional) 
            var excludeGarbageTime = true;  // bool | Optional flag to exclude garbage time plays (optional) 

            try
            {
                List<TeamGamePredictedPointsAdded> result = apiInstance.GetPredictedPointsAddedByGame(year, week, seasonType, team, conference, excludeGarbageTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GetPredictedPointsAddedByGame: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPredictedPointsAddedByGameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<TeamGamePredictedPointsAdded>> response = apiInstance.GetPredictedPointsAddedByGameWithHttpInfo(year, week, seasonType, team, conference, excludeGarbageTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GetPredictedPointsAddedByGameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Required year filter |  |
| **week** | **int** | Optional week filter | [optional]  |
| **seasonType** | **SeasonType** | Optional season type filter | [optional]  |
| **team** | **string** | Optional team filter | [optional]  |
| **conference** | **string** | Optional conference abbreviation filter | [optional]  |
| **excludeGarbageTime** | **bool** | Optional flag to exclude garbage time plays | [optional]  |

### Return type

[**List&lt;TeamGamePredictedPointsAdded&gt;**](TeamGamePredictedPointsAdded.md)

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

<a id="getpredictedpointsaddedbyplayergame"></a>
# **GetPredictedPointsAddedByPlayerGame**
> List&lt;PlayerGamePredictedPointsAdded&gt; GetPredictedPointsAddedByPlayerGame (int year, int week = null, SeasonType seasonType = null, string team = null, string position = null, string playerId = null, double threshold = null, bool excludeGarbageTime = null)



Queries player PPA statistics by game

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetPredictedPointsAddedByPlayerGameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MetricsApi(config);
            var year = 56;  // int | Required year filter
            var week = 56;  // int | Week filter, required if team not specified (optional) 
            var seasonType = (SeasonType) "regular";  // SeasonType | Optional season type filter (optional) 
            var team = "team_example";  // string | Team filter, required if week not specified (optional) 
            var position = "position_example";  // string | Optional player position abbreviation filter (optional) 
            var playerId = "playerId_example";  // string | Optional player ID filter (optional) 
            var threshold = 1.2D;  // double | Threshold value for minimum number of plays (optional) 
            var excludeGarbageTime = true;  // bool | Optional flag to exclude garbage time plays (optional) 

            try
            {
                List<PlayerGamePredictedPointsAdded> result = apiInstance.GetPredictedPointsAddedByPlayerGame(year, week, seasonType, team, position, playerId, threshold, excludeGarbageTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GetPredictedPointsAddedByPlayerGame: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPredictedPointsAddedByPlayerGameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PlayerGamePredictedPointsAdded>> response = apiInstance.GetPredictedPointsAddedByPlayerGameWithHttpInfo(year, week, seasonType, team, position, playerId, threshold, excludeGarbageTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GetPredictedPointsAddedByPlayerGameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Required year filter |  |
| **week** | **int** | Week filter, required if team not specified | [optional]  |
| **seasonType** | **SeasonType** | Optional season type filter | [optional]  |
| **team** | **string** | Team filter, required if week not specified | [optional]  |
| **position** | **string** | Optional player position abbreviation filter | [optional]  |
| **playerId** | **string** | Optional player ID filter | [optional]  |
| **threshold** | **double** | Threshold value for minimum number of plays | [optional]  |
| **excludeGarbageTime** | **bool** | Optional flag to exclude garbage time plays | [optional]  |

### Return type

[**List&lt;PlayerGamePredictedPointsAdded&gt;**](PlayerGamePredictedPointsAdded.md)

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

<a id="getpredictedpointsaddedbyplayerseason"></a>
# **GetPredictedPointsAddedByPlayerSeason**
> List&lt;PlayerSeasonPredictedPointsAdded&gt; GetPredictedPointsAddedByPlayerSeason (int year = null, string conference = null, string team = null, string position = null, string playerId = null, double threshold = null, bool excludeGarbageTime = null)



Queries player PPA statistics by season

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetPredictedPointsAddedByPlayerSeasonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MetricsApi(config);
            var year = 56;  // int | Year filter, required if playerId not specified (optional) 
            var conference = "conference_example";  // string | Optional conference abbreviation filter (optional) 
            var team = "team_example";  // string | Optional team filter (optional) 
            var position = "position_example";  // string | Optional position abbreviation filter (optional) 
            var playerId = "playerId_example";  // string | Player ID filter, required if year not specified (optional) 
            var threshold = 1.2D;  // double | Threshold value for minimum number of plays (optional) 
            var excludeGarbageTime = true;  // bool | Optional flag to exclude garbage time plays (optional) 

            try
            {
                List<PlayerSeasonPredictedPointsAdded> result = apiInstance.GetPredictedPointsAddedByPlayerSeason(year, conference, team, position, playerId, threshold, excludeGarbageTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GetPredictedPointsAddedByPlayerSeason: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPredictedPointsAddedByPlayerSeasonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PlayerSeasonPredictedPointsAdded>> response = apiInstance.GetPredictedPointsAddedByPlayerSeasonWithHttpInfo(year, conference, team, position, playerId, threshold, excludeGarbageTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GetPredictedPointsAddedByPlayerSeasonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Year filter, required if playerId not specified | [optional]  |
| **conference** | **string** | Optional conference abbreviation filter | [optional]  |
| **team** | **string** | Optional team filter | [optional]  |
| **position** | **string** | Optional position abbreviation filter | [optional]  |
| **playerId** | **string** | Player ID filter, required if year not specified | [optional]  |
| **threshold** | **double** | Threshold value for minimum number of plays | [optional]  |
| **excludeGarbageTime** | **bool** | Optional flag to exclude garbage time plays | [optional]  |

### Return type

[**List&lt;PlayerSeasonPredictedPointsAdded&gt;**](PlayerSeasonPredictedPointsAdded.md)

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

<a id="getpredictedpointsaddedbyteam"></a>
# **GetPredictedPointsAddedByTeam**
> List&lt;TeamSeasonPredictedPointsAdded&gt; GetPredictedPointsAddedByTeam (int year = null, string team = null, string conference = null, bool excludeGarbageTime = null)



Retrieves historical team PPA metrics by season

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetPredictedPointsAddedByTeamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MetricsApi(config);
            var year = 56;  // int | Year filter, required if team not specified (optional) 
            var team = "team_example";  // string | Team filter, required if year not specified (optional) 
            var conference = "conference_example";  // string | Conference abbreviation filter (optional) 
            var excludeGarbageTime = true;  // bool | Exclude garbage time plays (optional) 

            try
            {
                List<TeamSeasonPredictedPointsAdded> result = apiInstance.GetPredictedPointsAddedByTeam(year, team, conference, excludeGarbageTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GetPredictedPointsAddedByTeam: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPredictedPointsAddedByTeamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<TeamSeasonPredictedPointsAdded>> response = apiInstance.GetPredictedPointsAddedByTeamWithHttpInfo(year, team, conference, excludeGarbageTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GetPredictedPointsAddedByTeamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Year filter, required if team not specified | [optional]  |
| **team** | **string** | Team filter, required if year not specified | [optional]  |
| **conference** | **string** | Conference abbreviation filter | [optional]  |
| **excludeGarbageTime** | **bool** | Exclude garbage time plays | [optional]  |

### Return type

[**List&lt;TeamSeasonPredictedPointsAdded&gt;**](TeamSeasonPredictedPointsAdded.md)

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

<a id="getpregamewinprobabilities"></a>
# **GetPregameWinProbabilities**
> List&lt;PregameWinProbability&gt; GetPregameWinProbabilities (int year = null, int week = null, SeasonType seasonType = null, string team = null)



Queries pregame win probabilities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetPregameWinProbabilitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MetricsApi(config);
            var year = 56;  // int | Optional year filter (optional) 
            var week = 56;  // int | Optional week filter (optional) 
            var seasonType = (SeasonType) "regular";  // SeasonType | Optional season type filter (optional) 
            var team = "team_example";  // string | Optional team filter (optional) 

            try
            {
                List<PregameWinProbability> result = apiInstance.GetPregameWinProbabilities(year, week, seasonType, team);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GetPregameWinProbabilities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPregameWinProbabilitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PregameWinProbability>> response = apiInstance.GetPregameWinProbabilitiesWithHttpInfo(year, week, seasonType, team);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GetPregameWinProbabilitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Optional year filter | [optional]  |
| **week** | **int** | Optional week filter | [optional]  |
| **seasonType** | **SeasonType** | Optional season type filter | [optional]  |
| **team** | **string** | Optional team filter | [optional]  |

### Return type

[**List&lt;PregameWinProbability&gt;**](PregameWinProbability.md)

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

<a id="getwinprobability"></a>
# **GetWinProbability**
> List&lt;PlayWinProbability&gt; GetWinProbability (int gameId)



Query play win probabilities by game

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetWinProbabilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MetricsApi(config);
            var gameId = 56;  // int | Required game ID filter

            try
            {
                List<PlayWinProbability> result = apiInstance.GetWinProbability(gameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GetWinProbability: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWinProbabilityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PlayWinProbability>> response = apiInstance.GetWinProbabilityWithHttpInfo(gameId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GetWinProbabilityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gameId** | **int** | Required game ID filter |  |

### Return type

[**List&lt;PlayWinProbability&gt;**](PlayWinProbability.md)

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


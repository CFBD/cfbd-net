# CollegeFootballData.Api.PlayersApi

All URIs are relative to *https://api.collegefootballdata.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetPlayerUsage**](PlayersApi.md#getplayerusage) | **GET** /player/usage |  |
| [**GetReturningProduction**](PlayersApi.md#getreturningproduction) | **GET** /player/returning |  |
| [**GetTransferPortal**](PlayersApi.md#gettransferportal) | **GET** /player/portal |  |
| [**SearchPlayers**](PlayersApi.md#searchplayers) | **GET** /player/search |  |

<a id="getplayerusage"></a>
# **GetPlayerUsage**
> List&lt;PlayerUsage&gt; GetPlayerUsage (int year, string conference = null, string position = null, string team = null, int playerId = null, bool excludeGarbageTime = null)



Retrieves player usage data for a given season

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetPlayerUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PlayersApi(config);
            var year = 56;  // int | Required year filter
            var conference = "conference_example";  // string | Optional conference abbreviation filter (optional) 
            var position = "position_example";  // string | Optional position abbreivation filter (optional) 
            var team = "team_example";  // string | Optional team filter (optional) 
            var playerId = 56;  // int | Optional player id filter (optional) 
            var excludeGarbageTime = true;  // bool | Optional exclude garbage time flag, defaults to false (optional) 

            try
            {
                List<PlayerUsage> result = apiInstance.GetPlayerUsage(year, conference, position, team, playerId, excludeGarbageTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayersApi.GetPlayerUsage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPlayerUsageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PlayerUsage>> response = apiInstance.GetPlayerUsageWithHttpInfo(year, conference, position, team, playerId, excludeGarbageTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayersApi.GetPlayerUsageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Required year filter |  |
| **conference** | **string** | Optional conference abbreviation filter | [optional]  |
| **position** | **string** | Optional position abbreivation filter | [optional]  |
| **team** | **string** | Optional team filter | [optional]  |
| **playerId** | **int** | Optional player id filter | [optional]  |
| **excludeGarbageTime** | **bool** | Optional exclude garbage time flag, defaults to false | [optional]  |

### Return type

[**List&lt;PlayerUsage&gt;**](PlayerUsage.md)

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

<a id="getreturningproduction"></a>
# **GetReturningProduction**
> List&lt;ReturningProduction&gt; GetReturningProduction (int year = null, string team = null, string conference = null)



Retrieves returning production data. Either a year or team filter must be specified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetReturningProductionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PlayersApi(config);
            var year = 56;  // int | Year filter, required if team not specified (optional) 
            var team = "team_example";  // string | Team filter, required if year not specified (optional) 
            var conference = "conference_example";  // string | Optional conference filter (optional) 

            try
            {
                List<ReturningProduction> result = apiInstance.GetReturningProduction(year, team, conference);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayersApi.GetReturningProduction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReturningProductionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ReturningProduction>> response = apiInstance.GetReturningProductionWithHttpInfo(year, team, conference);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayersApi.GetReturningProductionWithHttpInfo: " + e.Message);
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

[**List&lt;ReturningProduction&gt;**](ReturningProduction.md)

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

<a id="gettransferportal"></a>
# **GetTransferPortal**
> List&lt;PlayerTransfer&gt; GetTransferPortal (int year)



Retrieves transfer portal data for a given year

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetTransferPortalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PlayersApi(config);
            var year = 56;  // int | Required year filter

            try
            {
                List<PlayerTransfer> result = apiInstance.GetTransferPortal(year);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayersApi.GetTransferPortal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransferPortalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PlayerTransfer>> response = apiInstance.GetTransferPortalWithHttpInfo(year);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayersApi.GetTransferPortalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** | Required year filter |  |

### Return type

[**List&lt;PlayerTransfer&gt;**](PlayerTransfer.md)

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

<a id="searchplayers"></a>
# **SearchPlayers**
> List&lt;PlayerSearchResult&gt; SearchPlayers (string searchTerm, int year = null, string team = null, string position = null)



Search for players (lists top 100 results)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class SearchPlayersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PlayersApi(config);
            var searchTerm = "searchTerm_example";  // string | Search term for matching player name
            var year = 56;  // int | Optional year filter (optional) 
            var team = "team_example";  // string | Optional team filter (optional) 
            var position = "position_example";  // string | Optional position abbreviation filter (optional) 

            try
            {
                List<PlayerSearchResult> result = apiInstance.SearchPlayers(searchTerm, year, team, position);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayersApi.SearchPlayers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchPlayersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PlayerSearchResult>> response = apiInstance.SearchPlayersWithHttpInfo(searchTerm, year, team, position);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayersApi.SearchPlayersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchTerm** | **string** | Search term for matching player name |  |
| **year** | **int** | Optional year filter | [optional]  |
| **team** | **string** | Optional team filter | [optional]  |
| **position** | **string** | Optional position abbreviation filter | [optional]  |

### Return type

[**List&lt;PlayerSearchResult&gt;**](PlayerSearchResult.md)

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


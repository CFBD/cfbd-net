# CollegeFootballData.Api.CoachesApi

All URIs are relative to *https://apinext.collegefootballdata.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCoaches**](CoachesApi.md#getcoaches) | **GET** /coaches |  |

<a id="getcoaches"></a>
# **GetCoaches**
> List&lt;Coach&gt; GetCoaches (string firstName = null, string lastName = null, string team = null, int year = null, int minYear = null, int maxYear = null)



Retrieves historical head coach information and records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetCoachesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CoachesApi(config);
            var firstName = "firstName_example";  // string | Optional first name filter (optional) 
            var lastName = "lastName_example";  // string | Optional last name filter (optional) 
            var team = "team_example";  // string | Optional team filter (optional) 
            var year = 56;  // int | Optional year filter (optional) 
            var minYear = 56;  // int | Optional start year range filter (optional) 
            var maxYear = 56;  // int | Optional end year range filter (optional) 

            try
            {
                List<Coach> result = apiInstance.GetCoaches(firstName, lastName, team, year, minYear, maxYear);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoachesApi.GetCoaches: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCoachesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Coach>> response = apiInstance.GetCoachesWithHttpInfo(firstName, lastName, team, year, minYear, maxYear);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoachesApi.GetCoachesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firstName** | **string** | Optional first name filter | [optional]  |
| **lastName** | **string** | Optional last name filter | [optional]  |
| **team** | **string** | Optional team filter | [optional]  |
| **year** | **int** | Optional year filter | [optional]  |
| **minYear** | **int** | Optional start year range filter | [optional]  |
| **maxYear** | **int** | Optional end year range filter | [optional]  |

### Return type

[**List&lt;Coach&gt;**](Coach.md)

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


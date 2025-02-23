# CollegeFootballData.Api.VenuesApi

All URIs are relative to *https://apinext.collegefootballdata.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetVenues**](VenuesApi.md#getvenues) | **GET** /venues |  |

<a id="getvenues"></a>
# **GetVenues**
> List&lt;Venue&gt; GetVenues ()



Retrieve list of venues

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace Example
{
    public class GetVenuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apinext.collegefootballdata.com";
            // Configure Bearer token for authorization: apiKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VenuesApi(config);

            try
            {
                List<Venue> result = apiInstance.GetVenues();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VenuesApi.GetVenues: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVenuesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Venue>> response = apiInstance.GetVenuesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VenuesApi.GetVenuesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Venue&gt;**](Venue.md)

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


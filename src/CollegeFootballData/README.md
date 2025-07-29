# Created with Openapi Generator

<a id="cli"></a>
## Run the following powershell command to generate the library

```ps1
$properties = @(
    'apiName=Api',
    'targetFramework=net8.0',
    'validatable=true',
    'nullableReferenceTypes=true',
    'hideGenerationTimestamp=true',
    'packageVersion=5.7.2',
    'packageAuthors=OpenAPI',
    'packageCompany=OpenAPI',
    'packageCopyright=No Copyright',
    'packageDescription=A library generated from a OpenAPI doc',
    'packageName=CollegeFootballData',
    'packageTags=CFBD;CFB;NCAAF;NCAA;football',
    'packageTitle=OpenAPI Library'
) -join ","

$global = @(
    'apiDocs=true',
    'modelDocs=true',
    'apiTests=true',
    'modelTests=true'
) -join ","

java -jar "<path>/openapi-generator/modules/openapi-generator-cli/target/openapi-generator-cli.jar" generate `
    -g csharp-netcore `
    -i <your-swagger-file>.yaml `
    -o <your-output-folder> `
    --library generichost `
    --additional-properties $properties `
    --global-property $global `
    --git-host "" `
    --git-repo-id "" `
    --git-user-id "" `
    --release-note ""
    # -t templates
```

<a id="usage"></a>
## Using the library in your project

```cs
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace YourProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var api = host.Services.GetRequiredService<IAdjustedMetricsApi>();
            GetAdjustedPlayerPassingStatsApiResponse apiResponse = await api.GetAdjustedPlayerPassingStatsAsync("todo");
            List<PlayerWeightedEPA> model = apiResponse.Ok();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
          .ConfigureApi((context, options) =>
          {
              // the type of token here depends on the api security specifications
              ApiKeyToken token = new("<your token>", ClientUtils.ApiKeyHeader.Authorization);
              options.AddTokens(token);

              // optionally choose the method the tokens will be provided with, default is RateLimitProvider
              options.UseProvider<RateLimitProvider<ApiKeyToken>, ApiKeyToken>();

              options.ConfigureJsonOptions((jsonOptions) =>
              {
                  // your custom converters if any
              });

              options.AddApiHttpClients(builder: builder => builder
                .AddRetryPolicy(2)
                .AddTimeoutPolicy(TimeSpan.FromSeconds(5))
                .AddCircuitBreakerPolicy(10, TimeSpan.FromSeconds(30))
                // add whatever middleware you prefer
              );
          });
    }
}
```
<a id="questions"></a>
## Questions

- What about HttpRequest failures and retries?
  If supportsRetry is enabled, you can configure Polly in the ConfigureClients method.
- How are tokens used?
  Tokens are provided by a TokenProvider class. The default is RateLimitProvider which will perform client side rate limiting.
  Other providers can be used with the UseProvider method.
- Does an HttpRequest throw an error when the server response is not Ok?
  It depends how you made the request. If the return type is ApiResponse<T> no error will be thrown, though the Content property will be null. 
  StatusCode and ReasonPhrase will contain information about the error.
  If the return type is T, then it will throw. If the return type is TOrDefault, it will return null.
- How do I validate requests and process responses?
  Use the provided On and After methods in the Api class from the namespace CollegeFootballData.Rest.DefaultApi.
  Or provide your own class by using the generic ConfigureApi method.

<a id="dependencies"></a>
## Dependencies

- [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting/) - 5.0.0 or later
- [Microsoft.Extensions.Http](https://www.nuget.org/packages/Microsoft.Extensions.Http/) - 5.0.0 or later
- [Microsoft.Extensions.Http.Polly](https://www.nuget.org/packages/Microsoft.Extensions.Http.Polly/) - 5.0.1 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.7.0 or later

<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="apiKey"></a>
### apiKey

- **Type**: Bearer Authentication


## Build
- SDK version: 5.7.2
- Generator version: 7.12.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

## Api Information
- appName: College Football Data API
- appVersion: 5.7.2
- appDescription: This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.

## [OpenApi Global properties](https://openapi-generator.tech/docs/globals)
- generateAliasAsModel: 
- supportingFiles: 
- models: omitted for brevity
- apis: omitted for brevity
- apiDocs: true
- modelDocs: true
- apiTests: true
- modelTests: true

## [OpenApi Generator Parameters](https://openapi-generator.tech/docs/generators/csharp-netcore)
- allowUnicodeIdentifiers: 
- apiName: Api
- caseInsensitiveResponseHeaders: 
- conditionalSerialization: false
- disallowAdditionalPropertiesIfNotPresent: 
- gitHost: 
- gitRepoId: 
- gitUserId: 
- hideGenerationTimestamp: true
- interfacePrefix: I
- library: generichost
- licenseId: 
- modelPropertyNaming: 
- netCoreProjectFile: false
- nonPublicApi: false
- nullableReferenceTypes: true
- optionalAssemblyInfo: 
- optionalEmitDefaultValues: false
- optionalMethodArgument: true
- optionalProjectFile: 
- packageAuthors: OpenAPI
- packageCompany: OpenAPI
- packageCopyright: No Copyright
- packageDescription: A library generated from a OpenAPI doc
- packageGuid: {5DF532F3-9490-4D76-95BE-C494C8C324DE}
- packageName: CollegeFootballData
- packageTags: CFBD;CFB;NCAAF;NCAA;football
- packageTitle: OpenAPI Library
- packageVersion: 5.7.2
- releaseNote: 
- returnICollection: false
- sortParamsByRequiredFlag: 
- sourceFolder: src
- targetFramework: net8.0
- useCollection: false
- useDateTimeOffset: false
- useOneOfDiscriminatorLookup: false
- validatable: true

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project.

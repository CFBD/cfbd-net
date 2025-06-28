# CollegeFootballData

## Installation

Install via the dotnet CLI:
```
dotnet add package CollegeFootballData
```

## Sample Script
```csharp
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using CollegeFootballData.Api;
using CollegeFootballData.Client;
using CollegeFootballData.Model;
using CollegeFootballData.Extensions;

static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
          .ConfigureApi((context, services, options) =>
          {
              var token = new BearerToken("<your API key here>");
              options.AddTokens(token);

              options.AddApiHttpClients(builder: builder => builder
                .AddRetryPolicy(2)
                .AddTimeoutPolicy(TimeSpan.FromSeconds(5))
                .AddCircuitBreakerPolicy(10, TimeSpan.FromSeconds(30))
                // add whatever middleware you prefer
              );
          });

try
{
  var host = CreateHostBuilder([]).Build();
  var api = host.Services.GetRequiredService<IPlaysApi>();
  var apiResponse = await api.GetPlaysAsync(year: 2023, week: 1, seasonType: SeasonType.Postseason, team: "Michigan");
  List<Play> plays = apiResponse.Ok();

  Console.WriteLine($"Plays in 2023: {plays.Count}");
} catch (Exception ex)
{
  Console.WriteLine($"Error: {ex.Message}");
  return;
}
```

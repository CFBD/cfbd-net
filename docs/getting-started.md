# Getting Started Guide

This guide will help you get started with the CollegeFootballData.NET client library.

## Prerequisites

- .NET 8.0 SDK or later
- Visual Studio, VS Code, or your preferred .NET IDE
- Basic knowledge of C# and async/await patterns

## Installation

### Using .NET CLI

```bash
dotnet new console -n MyCollegeFootballApp
cd MyCollegeFootballApp
dotnet add package CollegeFootballData
```

### Using Package Manager Console

```powershell
Install-Package CollegeFootballData
```

### Using PackageReference

Add this to your `.csproj` file:

```xml
<PackageReference Include="CollegeFootballData" Version="5.8.0" />
```

## Basic Setup

### 1. Import Required Namespaces

```csharp
using CollegeFootballData;
using CollegeFootballData.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
```

### 2. Create the API Client with Authentication

**Important**: Authentication is required for all API calls.

```csharp
// Get API key from environment variable
string apiKey = Environment.GetEnvironmentVariable("COLLEGE_FOOTBALL_API_KEY") 
    ?? throw new InvalidOperationException("API key is required for all API calls");

// Create authentication provider with Bearer token
var authProvider = new BaseBearerTokenAuthenticationProvider(new StaticAccessTokenProvider(apiKey));

// Create HTTP client and request adapter with authentication
var httpClient = new HttpClient();
var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);

// Create the API client
var client = new ApiClient(requestAdapter);
```

### 3. Implement Access Token Provider

```csharp
public class StaticAccessTokenProvider : IAccessTokenProvider
{
    private readonly string _token;

    public StaticAccessTokenProvider(string token)
    {
        _token = token ?? throw new ArgumentNullException(nameof(token));
    }

    public Task<string> GetAuthorizationTokenAsync(Uri uri, Dictionary<string, object>? additionalAuthenticationContext = null, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(_token);
    }

    public AllowedHostsValidator AllowedHostsValidator { get; } = new AllowedHostsValidator();
}
```

### 4. Make Your First API Call

```csharp
try
{
    // Get games for the 2023 season
    var games = await client.Games.GetAsync(requestConfiguration =>
    {
        requestConfiguration.QueryParameters.Year = 2023;
    });

    Console.WriteLine($"Found {games.Count} games for 2023");
    
    // Display first 5 games
    foreach (var game in games.Take(5))
    {
        Console.WriteLine($"{game.AwayTeam} @ {game.HomeTeam}");
        Console.WriteLine($"Date: {game.StartDate:yyyy-MM-dd}");
        Console.WriteLine($"Score: {game.AwayPoints} - {game.HomePoints}");
        Console.WriteLine();
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
```

## Complete Example Program

```csharp
using CollegeFootballData;
using CollegeFootballData.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace MyCollegeFootballApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Get API key from environment variable
            string apiKey = Environment.GetEnvironmentVariable("COLLEGE_FOOTBALL_API_KEY");
            if (string.IsNullOrEmpty(apiKey))
            {
                Console.WriteLine("Please set COLLEGE_FOOTBALL_API_KEY environment variable");
                return;
            }

            // Setup authentication and client
            var authProvider = new BaseBearerTokenAuthenticationProvider(new StaticAccessTokenProvider(apiKey));
            var httpClient = new HttpClient();
            var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
            var client = new ApiClient(requestAdapter);

            try
            {
                // Example 1: Get recent games
                Console.WriteLine("=== Recent Games ===");
                await GetRecentGames(client);

                // Example 2: Get team information
                Console.WriteLine("\n=== SEC Teams ===");
                await GetConferenceTeams(client);

                // Example 3: Get player stats
                Console.WriteLine("\n=== Top Rushers ===");
                await GetTopRushers(client);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static async Task GetRecentGames(ApiClient client)
        {
            var games = await client.Games.GetAsync(requestConfiguration =>
            {
                requestConfiguration.QueryParameters.Year = 2023;
                requestConfiguration.QueryParameters.Week = 1;
            });

            foreach (var game in games.Take(5))
            {
                Console.WriteLine($"{game.AwayTeam} @ {game.HomeTeam} - {game.StartDate:MMM dd}");
            }
        }

        static async Task GetConferenceTeams(ApiClient client)
        {
            var teams = await client.Teams.GetAsync(requestConfiguration =>
            {
                requestConfiguration.QueryParameters.Conference = "SEC";
            });

            foreach (var team in teams.OrderBy(t => t.School))
            {
                Console.WriteLine($"{team.School} ({team.Mascot})");
            }
        }

        static async Task GetTopRushers(ApiClient client)
        {
            var rushers = await client.Stats.Player.Season.GetAsync(requestConfiguration =>
            {
                requestConfiguration.QueryParameters.Year = 2023;
                requestConfiguration.QueryParameters.Category = "rushing";
            });

            foreach (var player in rushers.Take(10))
            {
                Console.WriteLine($"{player.Player} - {player.Team}");
            }
        }
    }

    // Access token provider implementation
    public class StaticAccessTokenProvider : IAccessTokenProvider
    {
        private readonly string _token;

        public StaticAccessTokenProvider(string token)
        {
            _token = token ?? throw new ArgumentNullException(nameof(token));
        }

        public Task<string> GetAuthorizationTokenAsync(Uri uri, Dictionary<string, object>? additionalAuthenticationContext = null, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(_token);
        }

        public AllowedHostsValidator AllowedHostsValidator { get; } = new AllowedHostsValidator();
    }
}
```

## Configuration Options

### Setting Up API Key Environment Variable

**Windows (Command Prompt):**
```cmd
set COLLEGE_FOOTBALL_API_KEY=your_api_key_here
```

**Windows (PowerShell):**
```powershell
$env:COLLEGE_FOOTBALL_API_KEY="your_api_key_here"
```

**macOS/Linux (Bash):**
```bash
export COLLEGE_FOOTBALL_API_KEY="your_api_key_here"
```

### Adding API Key Authentication (Required)

All API calls require authentication:

```csharp
// Get your API key from environment variable
string apiKey = Environment.GetEnvironmentVariable("COLLEGE_FOOTBALL_API_KEY") 
    ?? throw new InvalidOperationException("API key is required");

// Create authentication provider
var authProvider = new BaseBearerTokenAuthenticationProvider(new StaticAccessTokenProvider(apiKey));

// Create HTTP client and request adapter with authentication
var httpClient = new HttpClient();
var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);

// Create the API client
var client = new ApiClient(requestAdapter);
```

### Setting Request Timeouts

```csharp
var httpClient = new HttpClient();
httpClient.Timeout = TimeSpan.FromSeconds(30);

var authProvider = new BaseBearerTokenAuthenticationProvider(new StaticAccessTokenProvider(apiKey));
var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
var client = new ApiClient(requestAdapter);
```

### Using with Dependency Injection

For ASP.NET Core applications:

```csharp
// In Program.cs or Startup.cs
services.AddSingleton<IAccessTokenProvider>(provider =>
{
    var configuration = provider.GetRequiredService<IConfiguration>();
    var apiKey = configuration["CollegeFootballData:ApiKey"];
    return new StaticAccessTokenProvider(apiKey);
});

services.AddSingleton<IAuthenticationProvider>(provider =>
{
    var tokenProvider = provider.GetRequiredService<IAccessTokenProvider>();
    return new BaseBearerTokenAuthenticationProvider(tokenProvider);
});

services.AddHttpClient<ApiClient>();

services.AddScoped<IRequestAdapter>(provider =>
{
    var httpClientFactory = provider.GetRequiredService<IHttpClientFactory>();
    var httpClient = httpClientFactory.CreateClient(nameof(ApiClient));
    var authProvider = provider.GetRequiredService<IAuthenticationProvider>();
    return new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
});

services.AddScoped<ApiClient>();
```

## Best Practices

### 1. Use Async/Await Properly

```csharp
// Good
var games = await client.Games.GetAsync(config => 
{
    config.QueryParameters.Year = 2023;
});

// Avoid blocking calls
// var games = client.Games.GetAsync(...).Result; // Don't do this
```

### 2. Handle Exceptions

```csharp
try
{
    var games = await client.Games.GetAsync(config => 
    {
        config.QueryParameters.Year = 2023;
    });
}
catch (HttpRequestException ex)
{
    Console.WriteLine($"HTTP Error: {ex.Message}");
}
catch (TaskCanceledException ex)
{
    Console.WriteLine($"Request timed out: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}
```

### 3. Dispose Resources Properly

```csharp
using var httpClient = new HttpClient();
var requestAdapter = new HttpClientRequestAdapter(httpClient);
var client = new ApiClient(requestAdapter);

// Client will be disposed automatically
```

### 4. Use Filtering Efficiently

```csharp
// Get specific data rather than filtering client-side
var alabamaGames = await client.Games.GetAsync(config =>
{
    config.QueryParameters.Year = 2023;
    config.QueryParameters.Team = "Alabama"; // Filter server-side
});

// Rather than:
// var allGames = await client.Games.GetAsync(...);
// var alabamaGames = allGames.Where(g => g.HomeTeam == "Alabama" || g.AwayTeam == "Alabama");
```

## Next Steps

- Explore the [API Reference](../README.md#documentation) for detailed endpoint documentation
- Check out the [Examples](examples.md) for common use cases
- Learn about [Authentication](authentication.md) for premium features
- Review [Error Handling](error-handling.md) best practices

## Common Issues

### Missing Authentication

All API calls require authentication:
- Make sure you have a valid API key from CollegeFootballData.com
- Use the proper `BaseBearerTokenAuthenticationProvider` setup
- Set your API key in the `COLLEGE_FOOTBALL_API_KEY` environment variable

### Monthly Call Limits

The API uses monthly call limits rather than rate limiting:
- **Free tier**: 1,000 calls per month
- **Premium tiers**: Higher limits based on subscription
- Monitor your usage to avoid hitting limits
- Consider upgrading if you need more calls

### Missing Data

Some data may not be available for all years or teams:
- Check the API response for null values
- Use appropriate year ranges for your queries
- Verify team names match the API's format

### Large Responses

Some endpoints return large amounts of data:
- Use filtering parameters to limit results
- Consider pagination for large datasets
- Process data in chunks if needed
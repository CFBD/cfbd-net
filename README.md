# CollegeFootballData.NET

Official .NET client library for the [CollegeFootballData.com](https://collegefootballdata.com) API. This library provides strongly-typed access to college football data including games, teams, players, statistics, rankings, and more.

## Installation

Install the package from NuGet:

```bash
dotnet add package CollegeFootballData
```

Or via Package Manager Console:

```powershell
Install-Package CollegeFootballData
```

Or via PackageReference in your `.csproj` file:

```xml
<PackageReference Include="CollegeFootballData" Version="5.10.0" />
```

## Quick Start

Here's a simple example to get games for a specific year:

```csharp
using CollegeFootballData;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

// Get API key from environment variable
string apiKey = Environment.GetEnvironmentVariable("COLLEGE_FOOTBALL_API_KEY") 
    ?? throw new InvalidOperationException("API key is required");

// Create authentication provider with Bearer token
var authProvider = new BaseBearerTokenAuthenticationProvider(new StaticAccessTokenProvider(apiKey));

// Create HTTP client and request adapter with authentication
var httpClient = new HttpClient();
var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);

// Create the API client
var client = new ApiClient(requestAdapter);

// Get games for the 2023 season
var games = await client.Games.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
});

// Display the first few games
foreach (var game in games.Take(5))
{
    Console.WriteLine($"{game.AwayTeam} @ {game.HomeTeam} - {game.StartDate:yyyy-MM-dd}");
    Console.WriteLine($"Score: {game.AwayPoints} - {game.HomePoints}");
    Console.WriteLine($"Venue: {game.Venue}");
    Console.WriteLine();
}

// Simple access token provider implementation
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

## Authentication

**Important**: API authentication is required for all tiers of the CollegeFootballData.com API.

The API offers different subscription tiers based on monthly call limits:

- **Free tier**: 1,000 calls per month (requires API key)
- **Premium tiers**: Higher monthly call limits based on Patreon support level

All API calls must include a valid API key as a Bearer token in the Authorization header.

## Basic Usage Examples

### Get games with filters

```csharp
// Setup authentication (required for all API calls)
string apiKey = Environment.GetEnvironmentVariable("COLLEGE_FOOTBALL_API_KEY");
var authProvider = new BaseBearerTokenAuthenticationProvider(new StaticAccessTokenProvider(apiKey));
var httpClient = new HttpClient();
var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
var client = new ApiClient(requestAdapter);

// Get all games for a specific team in 2023
var teamGames = await client.Games.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Team = "Alabama";
});

// Get games for a specific week
var weekGames = await client.Games.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Week = 1;
});

// Get games between specific teams
var matchup = await client.Games.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Home = "Alabama";
    requestConfiguration.QueryParameters.Away = "Georgia";
});
```

### Get team information

```csharp
// Get all FBS teams
var teams = await client.Teams.Fbs.GetAsync();

// Get teams from a specific conference
var secTeams = await client.Teams.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Conference = "SEC";
});
```

### Get player statistics

```csharp
// Get player stats for a season
var playerStats = await client.Stats.Player.Season.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Category = "passing";
});
```

## Error Handling

The library uses standard .NET exception handling. Wrap your API calls in try-catch blocks:

```csharp
try
{
    var games = await client.Games.GetAsync(requestConfiguration =>
    {
        requestConfiguration.QueryParameters.Year = 2023;
    });
}
catch (HttpRequestException ex)
{
    Console.WriteLine($"HTTP error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
```

## Requirements

- .NET 8.0 or later
- Microsoft.Kiota packages (automatically included)

## Contributing

This library is auto-generated from the CollegeFootballData.com OpenAPI specification. For issues or feature requests, please visit the [GitHub repository](https://github.com/cfbd/cfb-net).

## License

This project is licensed under the terms specified in the repository.

## Documentation

For detailed documentation on all available endpoints and their parameters, see the following guides:

### API Endpoints

- [Games](docs/games.md) - Historical and live game data
- [Teams](docs/teams.md) - Team information and statistics
- [Players](docs/players.md) - Player data and statistics
- [Stats](docs/stats.md) - Team and player statistics
- [Rankings](docs/rankings.md) - Polls and ranking data
- [Ratings](docs/ratings.md) - Team rating systems (ELO, FPI, SP+, SRS)
- [Recruiting](docs/recruiting.md) - Recruiting rankings and player data
- [Coaches](docs/coaches.md) - Coaching staff information
- [Conferences](docs/conferences.md) - Conference information and statistics
- [Venues](docs/venues.md) - Stadium and venue information
- [Calendar](docs/calendar.md) - Season calendar and week information
- [Records](docs/records.md) - Team records and historical data
- [Lines](docs/lines.md) - Betting lines and odds
- [Drives](docs/drives.md) - Game drive information
- [Plays](docs/plays.md) - Play-by-play data
- [Live](docs/live.md) - Live game data
- [Metrics](docs/metrics.md) - Advanced team metrics
- [PPA](docs/ppa.md) - Predicted Points Added statistics
- [Draft](docs/draft.md) - NFL Draft information
- [Scoreboard](docs/scoreboard.md) - Live scoreboard data
- [Talent](docs/talent.md) - Team talent ratings
- [WEPA](docs/wepa.md) - Win Expected Points Added

### Guides

- [Getting Started](docs/getting-started.md) - Detailed setup and usage guide
- [Authentication](docs/authentication.md) - API key setup and usage
- [Examples](docs/examples.md) - Common use cases and code examples
- [Error Handling](docs/error-handling.md) - Best practices for error handling

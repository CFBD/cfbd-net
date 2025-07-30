# Examples and Common Use Cases

This guide provides practical examples for common scenarios using the CollegeFootballData.NET library.

## Setup

All examples assume you have set up the client with proper authentication as follows:

```csharp
using CollegeFootballData;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

// Get API key (required for all API calls)
string apiKey = Environment.GetEnvironmentVariable("COLLEGE_FOOTBALL_API_KEY") 
    ?? throw new InvalidOperationException("API key is required for all API calls");

// Setup authentication
var authProvider = new BaseBearerTokenAuthenticationProvider(new StaticAccessTokenProvider(apiKey));
var httpClient = new HttpClient();
var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
var client = new ApiClient(requestAdapter);

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
```

## 1. Season Analysis Dashboard

Create a comprehensive season overview:

```csharp
public class SeasonAnalyzer
{
    private readonly ApiClient _client;

    public SeasonAnalyzer(ApiClient client)
    {
        _client = client;
    }

    public async Task<SeasonSummary> AnalyzeSeason(string team, int year)
    {
        // Get all games for the team
        var gamesTask = _client.Games.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
            config.QueryParameters.Team = team;
        });

        // Get team stats
        var statsTask = _client.Stats.Season.Team.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
            config.QueryParameters.Team = team;
        });

        // Get rankings throughout season
        var rankingsTask = _client.Rankings.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
        });

        await Task.WhenAll(gamesTask, statsTask, rankingsTask);

        var games = gamesTask.Result;
        var stats = statsTask.Result.FirstOrDefault();
        var rankings = rankingsTask.Result.Where(r => r.School == team).ToList();

        return new SeasonSummary
        {
            Team = team,
            Year = year,
            Record = CalculateRecord(games, team),
            ConferenceRecord = CalculateConferenceRecord(games, team),
            StrengthOfSchedule = CalculateStrengthOfSchedule(games, team),
            RankingHistory = rankings.OrderBy(r => r.Week).ToList(),
            KeyStats = stats
        };
    }

    private (int wins, int losses) CalculateRecord(List<Game> games, string team)
    {
        int wins = 0, losses = 0;
        
        foreach (var game in games.Where(g => g.Completed == true))
        {
            bool isHome = game.HomeTeam == team;
            int teamScore = isHome ? game.HomePoints ?? 0 : game.AwayPoints ?? 0;
            int opponentScore = isHome ? game.AwayPoints ?? 0 : game.HomePoints ?? 0;
            
            if (teamScore > opponentScore) wins++;
            else losses++;
        }
        
        return (wins, losses);
    }
}

public class SeasonSummary
{
    public string Team { get; set; }
    public int Year { get; set; }
    public (int wins, int losses) Record { get; set; }
    public (int wins, int losses) ConferenceRecord { get; set; }
    public double StrengthOfSchedule { get; set; }
    public List<Ranking> RankingHistory { get; set; }
    public object KeyStats { get; set; }
}
```

## 2. Player Performance Tracker

Track player statistics across multiple categories:

```csharp
public class PlayerTracker
{
    private readonly ApiClient _client;

    public PlayerTracker(ApiClient client)
    {
        _client = client;
    }

    public async Task<PlayerProfile> GetPlayerProfile(string playerName, int year)
    {
        // Search for the player
        var searchResults = await _client.Player.Search.GetAsync(config =>
        {
            config.QueryParameters.SearchTerm = playerName;
            config.QueryParameters.Year = year;
        });

        var player = searchResults.FirstOrDefault();
        if (player == null) return null;

        // Get player statistics for multiple categories
        var passingTask = _client.Stats.Player.Season.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
            config.QueryParameters.Team = player.Team;
            config.QueryParameters.Category = "passing";
        });

        var rushingTask = _client.Stats.Player.Season.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
            config.QueryParameters.Team = player.Team;
            config.QueryParameters.Category = "rushing";
        });

        var receivingTask = _client.Stats.Player.Season.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
            config.QueryParameters.Team = player.Team;
            config.QueryParameters.Category = "receiving";
        });

        // Get PPA data
        var ppaTask = _client.Ppa.Players.Season.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
            config.QueryParameters.Team = player.Team;
        });

        await Task.WhenAll(passingTask, rushingTask, receivingTask, ppaTask);

        return new PlayerProfile
        {
            BasicInfo = player,
            PassingStats = passingTask.Result.FirstOrDefault(p => p.Player == playerName),
            RushingStats = rushingTask.Result.FirstOrDefault(p => p.Player == playerName),
            ReceivingStats = receivingTask.Result.FirstOrDefault(p => p.Player == playerName),
            PPAStats = ppaTask.Result.FirstOrDefault(p => p.Name == playerName)
        };
    }
}
```

## 3. Conference Power Rankings

Compare teams within a conference:

```csharp
public class ConferenceAnalyzer
{
    private readonly ApiClient _client;

    public async Task<List<TeamRating>> GetConferencePowerRankings(string conference, int year)
    {
        // Get all teams in conference
        var teamsTask = _client.Teams.GetAsync(config =>
        {
            config.QueryParameters.Conference = conference;
        });

        // Get various rating systems
        var eloTask = _client.Ratings.Elo.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
            config.QueryParameters.Conference = conference;
        });

        var fpiTask = _client.Ratings.Fpi.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
            config.QueryParameters.Conference = conference;
        });

        var spTask = _client.Ratings.Sp.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
            config.QueryParameters.Conference = conference;
        });

        await Task.WhenAll(teamsTask, eloTask, fpiTask, spTask);

        var teams = teamsTask.Result;
        var eloRatings = eloTask.Result;
        var fpiRatings = fpiTask.Result;
        var spRatings = spTask.Result;

        var powerRankings = teams.Select(team => new TeamRating
        {
            Team = team.School,
            EloRating = eloRatings.FirstOrDefault(e => e.Team == team.School)?.Elo,
            FpiRating = fpiRatings.FirstOrDefault(f => f.Team == team.School)?.Fpi,
            SpRating = spRatings.FirstOrDefault(s => s.Team == team.School)?.Rating,
            CompositeScore = CalculateCompositeScore(team.School, eloRatings, fpiRatings, spRatings)
        })
        .OrderByDescending(t => t.CompositeScore)
        .ToList();

        return powerRankings;
    }

    private double CalculateCompositeScore(string team, 
        List<EloRating> elo, List<FpiRating> fpi, List<SpRating> sp)
    {
        // Normalize and combine ratings (implementation depends on rating scales)
        var eloScore = elo.FirstOrDefault(e => e.Team == team)?.Elo ?? 0;
        var fpiScore = fpi.FirstOrDefault(f => f.Team == team)?.Fpi ?? 0;
        var spScore = sp.FirstOrDefault(s => s.Team == team)?.Rating ?? 0;
        
        // Simple average (you might want to weight these differently)
        return (eloScore + fpiScore + spScore) / 3.0;
    }
}
```

## 4. Game Prediction Model

Use historical data to predict game outcomes:

```csharp
public class GamePredictor
{
    private readonly ApiClient _client;

    public async Task<GamePrediction> PredictGame(string homeTeam, string awayTeam, int year)
    {
        // Get team ratings
        var homeRatingsTask = GetTeamRatings(homeTeam, year);
        var awayRatingsTask = GetTeamRatings(awayTeam, year);

        // Get head-to-head history
        var h2hTask = _client.Games.GetAsync(config =>
        {
            config.QueryParameters.Team = homeTeam;
            config.QueryParameters.MinYear = year - 10;
            config.QueryParameters.MaxYear = year;
        });

        await Task.WhenAll(homeRatingsTask, awayRatingsTask, h2hTask);

        var homeRatings = homeRatingsTask.Result;
        var awayRatings = awayRatingsTask.Result;
        var h2hGames = h2hTask.Result.Where(g => 
            (g.HomeTeam == homeTeam && g.AwayTeam == awayTeam) ||
            (g.HomeTeam == awayTeam && g.AwayTeam == homeTeam))
            .ToList();

        return new GamePrediction
        {
            HomeTeam = homeTeam,
            AwayTeam = awayTeam,
            HomeWinProbability = CalculateWinProbability(homeRatings, awayRatings, true),
            PredictedScore = PredictScore(homeRatings, awayRatings),
            HeadToHeadRecord = CalculateH2HRecord(h2hGames, homeTeam, awayTeam),
            Confidence = CalculateConfidence(homeRatings, awayRatings)
        };
    }

    private async Task<TeamRatings> GetTeamRatings(string team, int year)
    {
        var eloTask = _client.Ratings.Elo.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
            config.QueryParameters.Team = team;
        });

        var spTask = _client.Ratings.Sp.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
            config.QueryParameters.Team = team;
        });

        await Task.WhenAll(eloTask, spTask);

        return new TeamRatings
        {
            Team = team,
            Elo = eloTask.Result.FirstOrDefault()?.Elo ?? 1500,
            SpRating = spTask.Result.FirstOrDefault()?.Rating ?? 0
        };
    }
}
```

## 5. Recruiting Class Analyzer

Analyze and compare recruiting classes:

```csharp
public class RecruitingAnalyzer
{
    private readonly ApiClient _client;

    public async Task<List<RecruitingClassSummary>> CompareRecruitingClasses(
        List<string> teams, int year)
    {
        var results = new List<RecruitingClassSummary>();

        foreach (var team in teams)
        {
            var recruits = await _client.Recruiting.Players.GetAsync(config =>
            {
                config.QueryParameters.Year = year;
                config.QueryParameters.Team = team;
            });

            var summary = new RecruitingClassSummary
            {
                Team = team,
                Year = year,
                TotalRecruits = recruits.Count,
                FiveStars = recruits.Count(r => r.Rating >= 0.95),
                FourStars = recruits.Count(r => r.Rating >= 0.89 && r.Rating < 0.95),
                ThreeStars = recruits.Count(r => r.Rating >= 0.80 && r.Rating < 0.89),
                AverageRating = recruits.Average(r => r.Rating ?? 0),
                TopRecruit = recruits.OrderByDescending(r => r.Rating).FirstOrDefault(),
                PositionalBreakdown = recruits.GroupBy(r => r.Position)
                    .ToDictionary(g => g.Key, g => g.Count())
            };

            results.Add(summary);
        }

        return results.OrderByDescending(r => r.AverageRating).ToList();
    }
}
```

## 6. Weekly Scoreboard

Create a comprehensive weekly scoreboard:

```csharp
public class WeeklyScoreboard
{
    private readonly ApiClient _client;

    public async Task<ScoreboardData> GetWeeklyScoreboard(int year, int week)
    {
        // Get all games for the week
        var gamesTask = _client.Games.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
            config.QueryParameters.Week = week;
        });

        // Get rankings for context
        var rankingsTask = _client.Rankings.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
            config.QueryParameters.Week = week;
        });

        await Task.WhenAll(gamesTask, rankingsTask);

        var games = gamesTask.Result;
        var rankings = rankingsTask.Result;

        // Group games by conference and add ranking context
        var gamesByConference = games
            .GroupBy(g => g.HomeConference ?? "Independent")
            .ToDictionary(g => g.Key, g => g.ToList());

        return new ScoreboardData
        {
            Year = year,
            Week = week,
            GamesByConference = gamesByConference,
            Rankings = rankings.ToDictionary(r => r.School, r => r.Rank),
            TopGames = IdentifyTopGames(games, rankings),
            Upsets = IdentifyUpsets(games, rankings)
        };
    }

    private List<Game> IdentifyTopGames(List<Game> games, List<Ranking> rankings)
    {
        var rankedTeams = rankings.Where(r => r.Rank <= 25)
            .ToDictionary(r => r.School, r => r.Rank);

        return games.Where(g => 
            rankedTeams.ContainsKey(g.HomeTeam) || 
            rankedTeams.ContainsKey(g.AwayTeam))
            .OrderBy(g => 
            {
                var homeRank = rankedTeams.GetValueOrDefault(g.HomeTeam, 26);
                var awayRank = rankedTeams.GetValueOrDefault(g.AwayTeam, 26);
                return Math.Min(homeRank, awayRank);
            })
            .ToList();
    }
}
```

## Error Handling Patterns

### Robust API Calls

```csharp
public async Task<T> SafeApiCall<T>(Func<Task<T>> apiCall, string operationName)
{
    const int maxRetries = 3;
    const int baseDelay = 1000; // 1 second

    for (int attempt = 1; attempt <= maxRetries; attempt++)
    {
        try
        {
            return await apiCall();
        }
        catch (HttpRequestException ex) when (ex.Message.Contains("429"))
        {
            if (attempt == maxRetries) throw;
            
            // Exponential backoff for rate limiting
            var delay = baseDelay * Math.Pow(2, attempt - 1);
            await Task.Delay(TimeSpan.FromMilliseconds(delay));
        }
        catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
        {
            if (attempt == maxRetries) throw;
            
            await Task.Delay(TimeSpan.FromMilliseconds(baseDelay * attempt));
        }
    }

    throw new InvalidOperationException($"Failed to complete {operationName} after {maxRetries} attempts");
}
```

## Performance Optimization

### Parallel API Calls

```csharp
public async Task<ComprehensiveTeamData> GetComprehensiveTeamData(string team, int year)
{
    // Execute multiple API calls in parallel
    var tasks = new List<Task>
    {
        _client.Games.GetAsync(config => 
        {
            config.QueryParameters.Year = year;
            config.QueryParameters.Team = team;
        }),
        _client.Stats.Season.Team.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
            config.QueryParameters.Team = team;
        }),
        _client.Ratings.Sp.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
            config.QueryParameters.Team = team;
        }),
        _client.Recruiting.Players.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
            config.QueryParameters.Team = team;
        })
    };

    await Task.WhenAll(tasks);

    // Extract results from completed tasks
    var games = ((Task<List<Game>>)tasks[0]).Result;
    var stats = ((Task<List<TeamSeasonStat>>)tasks[1]).Result;
    var ratings = ((Task<List<SpRating>>)tasks[2]).Result;
    var recruits = ((Task<List<Recruit>>)tasks[3]).Result;

    return new ComprehensiveTeamData
    {
        Team = team,
        Year = year,
        Games = games,
        Stats = stats.FirstOrDefault(),
        Rating = ratings.FirstOrDefault(),
        Recruits = recruits
    };
}
```

These examples demonstrate practical implementations for common college football data analysis scenarios. Each example can be adapted and extended based on your specific needs.
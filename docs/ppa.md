# PPA (Predicted Points Added) API

The PPA API provides advanced analytics using Predicted Points Added, a metric that measures the value of plays and players.

## Endpoints

- `/ppa/games` - Game-level PPA data
- `/ppa/players/games` - Player PPA for specific games
- `/ppa/players/season` - Player season PPA averages
- `/ppa/teams` - Team PPA data
- `/ppa/predicted` - Predicted PPA values

## Usage

### Team PPA

```csharp
var teamPPA = await client.Ppa.Teams.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Team = "Alabama";
});
```

### Player Season PPA

```csharp
var playerPPA = await client.Ppa.Players.Season.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Team = "Alabama";
});
```

## Query Parameters

### Team PPA

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | No | Season year |
| `team` | string | No | Team filter |
| `conference` | string | No | Conference filter |
| `excludeGarbageTime` | bool | No | Exclude garbage time plays |

### Player PPA

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | No | Season year |
| `week` | int | No | Week filter |
| `team` | string | No | Team filter |
| `position` | string | No | Position filter |
| `playerId` | int | No | Specific player ID |
| `threshold` | string | No | Minimum play threshold |
| `excludeGarbageTime` | bool | No | Exclude garbage time |

## Examples

### Get quarterback PPA leaders

```csharp
var qbPPA = await client.Ppa.Players.Season.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Position = "QB";
    requestConfiguration.QueryParameters.ExcludeGarbageTime = true;
});

var topQBs = qbPPA
    .OrderByDescending(p => p.AveragePPA?.Overall)
    .Take(10)
    .ToList();
```

### Compare team offensive efficiency

```csharp
var secTeamPPA = await client.Ppa.Teams.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Conference = "SEC";
    requestConfiguration.QueryParameters.ExcludeGarbageTime = true;
});

var offensiveRankings = secTeamPPA
    .OrderByDescending(t => t.Offense?.Overall)
    .Select(t => new { t.Team, OffensePPA = t.Offense?.Overall })
    .ToList();
```

## Response Properties

### Team PPA

| Property | Type | Description |
|----------|------|-------------|
| `Season` | int? | Season year |
| `Team` | string? | Team name |
| `Conference` | string? | Conference name |
| `Offense` | object? | Offensive PPA metrics |
| `Defense` | object? | Defensive PPA metrics |

### Player PPA

| Property | Type | Description |
|----------|------|-------------|
| `Season` | int? | Season year |
| `Name` | string? | Player name |
| `Position` | string? | Player position |
| `Team` | string? | Team name |
| `AveragePPA` | object? | Average PPA by down/distance |
| `TotalPPA` | object? | Total PPA statistics |

## PPA Metrics Explained

**Predicted Points Added (PPA)** measures the value of each play by calculating how much it increases or decreases a team's expected points on that drive.

### Key Concepts

- **Positive PPA**: Play increased scoring probability
- **Negative PPA**: Play decreased scoring probability
- **Situational Context**: Down, distance, and field position matter
- **Cumulative Value**: Season totals show overall impact

### PPA Categories

- **Overall**: All plays combined
- **Passing**: Passing plays only
- **Rushing**: Rushing plays only
- **1st Down**: First down situations
- **2nd Down**: Second down situations
- **3rd Down**: Third down situations

## Use Cases

1. **Player Evaluation**: Identify most valuable players beyond basic stats
2. **Team Efficiency**: Measure offensive and defensive effectiveness
3. **Situational Analysis**: Evaluate performance in specific game situations
4. **Advanced Analytics**: Deep dive into team and player performance
5. **Draft Analysis**: Evaluate college players for professional potential
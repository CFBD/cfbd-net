# Stats API

The Stats API provides comprehensive statistical data for teams and players across various categories and time periods.

## Endpoints

- `/stats/game/advanced` - Advanced game statistics
- `/stats/player/season` - Player season statistics
- `/stats/season/advanced` - Advanced season statistics
- `/stats/season/team` - Team season statistics
- `/stats/categories` - Available statistical categories

## Usage

### Player Season Stats

```csharp
var playerStats = await client.Stats.Player.Season.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Category = "passing";
});
```

### Team Season Stats

```csharp
var teamStats = await client.Stats.Season.Team.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
});
```

### Advanced Season Stats

```csharp
var advancedStats = await client.Stats.Season.Advanced.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
});
```

### Game Advanced Stats

```csharp
var gameStats = await client.Stats.Game.Advanced.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Week = 1;
});
```

## Query Parameters

### Player Season Stats

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | Yes | Season year |
| `team` | string | No | Team name filter |
| `conference` | string | No | Conference filter |
| `startWeek` | int | No | Starting week |
| `endWeek` | int | No | Ending week |
| `seasonType` | SeasonType | No | Season type filter |
| `category` | string | No | Statistical category |

### Team Season Stats

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | No | Season year |
| `team` | string | No | Team name filter |
| `conference` | string | No | Conference filter |
| `startWeek` | int | No | Starting week |
| `endWeek` | int | No | Ending week |
| `seasonType` | SeasonType | No | Season type filter |

### Advanced Season Stats

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | No | Season year |
| `team` | string | No | Team name filter |
| `excludeGarbageTime` | bool | No | Exclude garbage time stats |
| `startWeek` | int | No | Starting week |
| `endWeek` | int | No | Ending week |
| `seasonType` | SeasonType | No | Season type filter |

### Game Advanced Stats

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | No | Season year |
| `week` | int | No | Week number |
| `team` | string | No | Team name filter |
| `opponent` | string | No | Opponent team filter |
| `excludeGarbageTime` | bool | No | Exclude garbage time stats |
| `seasonType` | SeasonType | No | Season type filter |
| `gameId` | int | No | Specific game ID |

## Statistical Categories

Common statistical categories include:

### Offensive Categories
- `passing` - Passing statistics
- `rushing` - Rushing statistics  
- `receiving` - Receiving statistics
- `scoring` - Scoring statistics

### Defensive Categories
- `defensive` - General defensive stats
- `interceptions` - Interception statistics
- `fumbles` - Fumble recovery stats

### Special Teams
- `kicking` - Field goal and extra point stats
- `punting` - Punting statistics
- `kickReturns` - Kick return stats
- `puntReturns` - Punt return stats

## Examples

### Get passing statistics for a team

```csharp
var passingStats = await client.Stats.Player.Season.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Team = "Alabama";
    requestConfiguration.QueryParameters.Category = "passing";
});
```

### Get rushing leaders for a conference

```csharp
var rushingLeaders = await client.Stats.Player.Season.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Conference = "SEC";
    requestConfiguration.QueryParameters.Category = "rushing";
});
```

### Get team offensive statistics

```csharp
var teamOffense = await client.Stats.Season.Team.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Team = "Georgia";
});
```

### Get advanced stats excluding garbage time

```csharp
var cleanStats = await client.Stats.Season.Advanced.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.ExcludeGarbageTime = true;
});
```

### Get available statistical categories

```csharp
var categories = await client.Stats.Categories.GetAsync();
```

## Response Types

### Player Season Statistics

Contains player performance data including:
- Player identification (name, team, position)
- Statistical categories and values
- Season totals and averages

### Team Season Statistics

Contains team-level performance data including:
- Team identification
- Offensive and defensive statistics
- Season totals and per-game averages

### Advanced Statistics

Contains advanced metrics such as:
- Success rates
- Explosiveness metrics
- Down and distance performance
- Field position data

## Related Endpoints

- [Players](players.md) - Player information and search
- [Teams](teams.md) - Team information
- [Games](games.md) - Game data for context
- [PPA](ppa.md) - Predicted Points Added statistics
- [Metrics](metrics.md) - Advanced team metrics

## Use Cases

1. **Player Analysis**: Evaluate individual player performance
2. **Team Comparison**: Compare teams across various statistical categories
3. **Season Tracking**: Monitor statistical trends throughout a season
4. **Fantasy Football**: Access player statistics for fantasy leagues
5. **Recruiting Analysis**: Evaluate player performance for recruiting
6. **Advanced Analytics**: Perform deep statistical analysis with advanced metrics
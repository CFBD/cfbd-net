# Players API

The Players API provides access to player information, search functionality, usage statistics, transfer data, and returning player information.

## Endpoints

- `/player/search` - Search for players
- `/player/usage` - Player usage statistics
- `/player/returning` - Returning player information
- `/player/portal` - Transfer portal data

## Usage

### Player Search

```csharp
var players = await client.Player.Search.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.SearchTerm = "Tua";
});
```

### Player Usage Stats

```csharp
var usage = await client.Player.Usage.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Team = "Alabama";
});
```

### Returning Players

```csharp
var returningPlayers = await client.Player.Returning.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2024;
    requestConfiguration.QueryParameters.Team = "Georgia";
});
```

### Transfer Portal

```csharp
var transfers = await client.Player.Portal.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
});
```

## Query Parameters

### Player Search

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `searchTerm` | string | Yes | Player name to search for |
| `position` | string | No | Position filter |
| `team` | string | No | Team filter |
| `year` | int | No | Year filter |

### Player Usage

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | Yes | Season year |
| `team` | string | No | Team filter |
| `conference` | string | No | Conference filter |
| `position` | string | No | Position filter |
| `playerId` | int | No | Specific player ID |
| `excludeGarbageTime` | bool | No | Exclude garbage time snaps |

### Returning Players

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | No | Season year |
| `team` | string | No | Team filter |
| `conference` | string | No | Conference filter |

### Transfer Portal

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | Yes | Transfer year |

## Examples

### Search for a player by name

```csharp
var searchResults = await client.Player.Search.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.SearchTerm = "Bryce Young";
});

var player = searchResults.FirstOrDefault();
if (player != null)
{
    Console.WriteLine($"Found: {player.Name} - {player.Team} ({player.Position})");
}
```

### Get quarterback usage for a team

```csharp
var qbUsage = await client.Player.Usage.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Team = "Alabama";
    requestConfiguration.QueryParameters.Position = "QB";
});
```

### Find returning offensive players

```csharp
var returningOffense = await client.Player.Returning.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2024;
    requestConfiguration.QueryParameters.Team = "Georgia";
});

var offensivePlayers = returningOffense
    .Where(p => new[] { "QB", "RB", "WR", "TE", "OL" }.Contains(p.Position))
    .ToList();
```

### Get all transfers for a year

```csharp
var transfers2023 = await client.Player.Portal.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
});

// Group by destination team
var transfersByTeam = transfers2023
    .Where(t => !string.IsNullOrEmpty(t.Destination))
    .GroupBy(t => t.Destination)
    .OrderByDescending(g => g.Count())
    .ToList();
```

### Search for players by position and team

```csharp
var alabamaQBs = await client.Player.Search.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.SearchTerm = "";
    requestConfiguration.QueryParameters.Team = "Alabama";
    requestConfiguration.QueryParameters.Position = "QB";
    requestConfiguration.QueryParameters.Year = 2023;
});
```

## Response Types

### Player Search Result

Contains player identification and basic information:
- Player name and ID
- Team and position
- Years of eligibility
- Height and weight

### Player Usage

Contains snap count and usage data:
- Player identification
- Total snaps and usage percentage
- Positional usage breakdowns
- Game-by-game usage

### Returning Players

Contains information about returning players:
- Player identification
- Previous season statistics
- Projected role

### Transfer Portal

Contains transfer information:
- Player identification
- Origin and destination teams
- Transfer date and season
- Eligibility information

## Related Endpoints

- [Stats/Player](stats.md) - Player statistics
- [Recruiting/Players](recruiting.md) - Player recruiting information
- [PPA/Players](ppa.md) - Player PPA statistics
- [Games/Players](games.md) - Player game statistics

## Use Cases

1. **Player Research**: Find and analyze specific players
2. **Roster Management**: Track returning players and transfers
3. **Usage Analysis**: Analyze player snap counts and roles
4. **Transfer Tracking**: Monitor player movement between schools
5. **Fantasy Sports**: Research player usage for fantasy leagues
6. **Recruiting Analysis**: Evaluate player performance and fit
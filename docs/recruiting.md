# Recruiting API

The Recruiting API provides access to recruiting rankings, player commitments, and team recruiting class data.

## Endpoints

- `/recruiting/players` - Individual player recruiting data
- `/recruiting/teams` - Team recruiting class rankings
- `/recruiting/groups` - Positional group recruiting rankings

## Usage

### Player Recruiting Data

```csharp
var recruits = await client.Recruiting.Players.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2024;
    requestConfiguration.QueryParameters.Team = "Alabama";
});
```

### Team Recruiting Rankings

```csharp
var teamRankings = await client.Recruiting.Teams.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2024;
});
```

## Query Parameters

### Player Recruiting

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | Yes | Recruiting class year |
| `classification` | DivisionClassification | No | Division filter |
| `position` | string | No | Position filter |
| `state` | string | No | State filter |
| `team` | string | No | Team filter |

### Team Recruiting

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | No | Recruiting class year |
| `team` | string | No | Team filter |

## Examples

### Get top recruits by position

```csharp
var topQBs = await client.Recruiting.Players.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2024;
    requestConfiguration.QueryParameters.Position = "QB";
});

var fiveStarQBs = topQBs.Where(r => r.Rating >= 0.95).ToList();
```

### Analyze team recruiting class

```csharp
var alabamaClass = await client.Recruiting.Players.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2024;
    requestConfiguration.QueryParameters.Team = "Alabama";
});

var averageRating = alabamaClass.Average(r => r.Rating ?? 0);
var fiveStars = alabamaClass.Count(r => r.Rating >= 0.95);
var fourStars = alabamaClass.Count(r => r.Rating >= 0.89 && r.Rating < 0.95);
```

## Use Cases

1. **Recruiting Analysis**: Evaluate team recruiting success
2. **Player Tracking**: Follow top recruit commitments
3. **Positional Needs**: Analyze recruiting by position
4. **Geographic Recruiting**: Track recruiting by state/region
# Ratings API

The Ratings API provides access to various team rating systems including ELO, FPI, SP+, and SRS ratings.

## Endpoints

- `/ratings/elo` - ELO ratings
- `/ratings/fpi` - ESPN's Football Power Index
- `/ratings/sp` - SP+ ratings  
- `/ratings/srs` - Simple Rating System

## Usage

### ELO Ratings

```csharp
var eloRatings = await client.Ratings.Elo.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
});
```

### FPI Ratings

```csharp
var fpiRatings = await client.Ratings.Fpi.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
});
```

### SP+ Ratings

```csharp
var spRatings = await client.Ratings.Sp.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
});
```

## Query Parameters

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | No | Season year |
| `week` | int | No | Week number |
| `team` | string | No | Team filter |
| `conference` | string | No | Conference filter |

## Examples

### Compare rating systems

```csharp
var year = 2023;
var team = "Alabama";

var eloTask = client.Ratings.Elo.GetAsync(config => 
{
    config.QueryParameters.Year = year;
    config.QueryParameters.Team = team;
});

var fpiTask = client.Ratings.Fpi.GetAsync(config => 
{
    config.QueryParameters.Year = year;
    config.QueryParameters.Team = team;
});

var spTask = client.Ratings.Sp.GetAsync(config => 
{
    config.QueryParameters.Year = year;
    config.QueryParameters.Team = team;
});

await Task.WhenAll(eloTask, fpiTask, spTask);

var eloRating = eloTask.Result.FirstOrDefault();
var fpiRating = fpiTask.Result.FirstOrDefault();
var spRating = spTask.Result.FirstOrDefault();
```

## Use Cases

1. **Team Evaluation**: Compare teams using multiple rating systems
2. **Strength of Schedule**: Analyze opponent ratings
3. **Predictive Analysis**: Use ratings for game predictions
4. **Historical Comparison**: Track rating changes over time
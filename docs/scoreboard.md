# Scoreboard API

Live scoreboard data and game information.

## Endpoint

`/scoreboard`

## Usage

```csharp
var scoreboard = await client.Scoreboard.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Week = 1;
    requestConfiguration.QueryParameters.Year = 2023;
});
```

## Query Parameters

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | No | Season year |
| `week` | int | No | Week number |
| `seasonType` | SeasonType | No | Season type |
| `classification` | DivisionClassification | No | Division filter |
| `conference` | string | No | Conference filter |

## Use Cases

1. **Live Scores**: Get current game scores and status
2. **Weekly Overview**: See all games for a specific week
3. **Conference Tracking**: Monitor specific conference games
4. **Real-time Updates**: Track games as they happen
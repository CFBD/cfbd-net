# Lines API

Betting lines and odds data for college football games.

## Endpoint

`/lines`

## Usage

```csharp
var lines = await client.Lines.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Week = 1;
});
```

## Query Parameters

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `gameId` | int | No | Specific game ID |
| `year` | int | No | Season year |
| `week` | int | No | Week number |
| `seasonType` | SeasonType | No | Season type |
| `team` | string | No | Team filter |
| `home` | string | No | Home team filter |
| `away` | string | No | Away team filter |
| `conference` | string | No | Conference filter |

## Response Properties

| Property | Type | Description |
|----------|------|-------------|
| `Id` | int? | Game identifier |
| `Season` | int? | Season year |
| `Week` | int? | Week number |
| `SeasonType` | string? | Season type |
| `StartDate` | DateTimeOffset? | Game start date |
| `HomeTeam` | string? | Home team |
| `AwayTeam` | string? | Away team |
| `Lines` | List? | Betting lines from various sources |

## Use Cases

1. **Betting Analysis**: Analyze betting lines and market movements
2. **Game Predictions**: Use lines as baseline for predictions
3. **Historical Odds**: Track how betting markets performed
4. **Line Shopping**: Compare odds across different sportsbooks
# Rankings API

The Rankings API provides access to college football polls and ranking data from various sources.

## Endpoint

`/rankings`

## Usage

```csharp
var rankings = await client.Rankings.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Week = 10;
});
```

## Query Parameters

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | Yes | Season year |
| `week` | int | No | Week number (1-15 for regular season) |
| `seasonType` | SeasonType | No | Season type (regular, postseason) |

## Examples

### Get current rankings

```csharp
var currentRankings = await client.Rankings.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Week = 12;
});
```

### Get final season rankings

```csharp
var finalRankings = await client.Rankings.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.SeasonTypeAsSeasonType = SeasonType.Postseason;
});
```

## Response Properties

| Property | Type | Description |
|----------|------|-------------|
| `Season` | int? | Season year |
| `SeasonType` | SeasonType? | Season type |
| `Week` | int? | Week number |
| `Poll` | string? | Poll name (AP, Coaches, CFP, etc.) |
| `Rank` | int? | Team rank |
| `School` | string? | School name |
| `Conference` | string? | Conference name |
| `FirstPlaceVotes` | int? | Number of first place votes |
| `Points` | int? | Total poll points |

## Use Cases

1. **Weekly Rankings**: Track team rankings throughout the season
2. **Historical Analysis**: Compare rankings across different polls
3. **Poll Comparison**: Analyze differences between AP and Coaches polls
4. **Ranking Trends**: Monitor team movement in rankings
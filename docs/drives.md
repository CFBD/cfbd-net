# Drives API

Game drive information and statistics.

## Endpoint

`/drives`

## Usage

```csharp
var drives = await client.Drives.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Week = 1;
});
```

## Query Parameters

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | Yes | Season year |
| `seasonType` | SeasonType | No | Season type |
| `week` | int | No | Week number |
| `team` | string | No | Team filter |
| `offense` | string | No | Offensive team filter |
| `defense` | string | No | Defensive team filter |
| `conference` | string | No | Conference filter |
| `offenseConference` | string | No | Offensive team conference |
| `defenseConference` | string | No | Defensive team conference |
| `gameId` | int | No | Specific game ID |

## Use Cases

1. **Drive Efficiency**: Analyze offensive drive success rates
2. **Red Zone Performance**: Study drives that reach the red zone
3. **Defensive Analysis**: Evaluate defensive stops and performance
4. **Game Flow**: Understand how games develop drive by drive
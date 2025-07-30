# Teams Sub-endpoints

Additional team-related endpoints for specific data types.

## Endpoints

- `/teams/matchup` - Historical matchup data between teams
- `/teams/fbs` - FBS-specific team information

## Usage

### Team Matchup History

```csharp
var matchupHistory = await client.Teams.Matchup.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Team1 = "Alabama";
    requestConfiguration.QueryParameters.Team2 = "Auburn";
    requestConfiguration.QueryParameters.MinYear = 2000;
    requestConfiguration.QueryParameters.MaxYear = 2023;
});
```

### FBS Teams

```csharp
var fbsTeams = await client.Teams.Fbs.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
});
```

## Query Parameters

### Matchup History

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `team1` | string | Yes | First team name |
| `team2` | string | Yes | Second team name |
| `minYear` | int | No | Minimum year |
| `maxYear` | int | No | Maximum year |

## Use Cases

1. **Rivalry Analysis**: Study historical matchups between teams
2. **Head-to-Head Records**: Get win-loss records between specific teams
3. **Trend Analysis**: Identify patterns in team matchups over time
4. **FBS Directory**: Access current FBS team information
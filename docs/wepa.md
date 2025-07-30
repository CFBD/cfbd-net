# WEPA (Win Expected Points Added) API

Win Expected Points Added statistics and advanced analytics.

## Endpoints

- `/wepa/players` - Player WEPA statistics
- `/wepa/team` - Team WEPA data

## Usage

### Player WEPA

```csharp
var playerWepa = await client.Wepa.Players.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Team = "Alabama";
});
```

### Team WEPA

```csharp
var teamWepa = await client.Wepa.Team.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
});
```

## Query Parameters

### Player WEPA

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | No | Season year |
| `week` | int | No | Week number |
| `team` | string | No | Team filter |
| `position` | string | No | Position filter |
| `excludeGarbageTime` | bool | No | Exclude garbage time |

### Team WEPA

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | No | Season year |
| `team` | string | No | Team filter |
| `excludeGarbageTime` | bool | No | Exclude garbage time |

## WEPA Explained

Win Expected Points Added (WEPA) measures how much each play or player contributes to their team's win probability. It combines:

- **Expected Points Added (EPA)**: Point value of plays
- **Win Probability**: Game situation context
- **Leverage**: Importance of the game moment

## Use Cases

1. **Player Evaluation**: Identify most valuable players in win-impacting situations
2. **Clutch Performance**: Measure performance in high-leverage moments
3. **Team Efficiency**: Evaluate teams in game-deciding situations
4. **Advanced Analytics**: Deep dive into situational performance
# Draft API

NFL Draft information for college football players.

## Endpoints

- `/draft/picks` - Draft pick information
- `/draft/positions` - Draft positions data
- `/draft/teams` - NFL team draft information

## Usage

### Draft Picks

```csharp
var draftPicks = await client.Draft.Picks.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
});
```

### Draft Positions

```csharp
var positions = await client.Draft.Positions.GetAsync();
```

### Draft Teams

```csharp
var draftTeams = await client.Draft.Teams.GetAsync();
```

## Query Parameters

### Draft Picks

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | No | Draft year |
| `nflTeam` | string | No | NFL team filter |
| `college` | string | No | College filter |
| `conference` | string | No | Conference filter |
| `position` | string | No | Position filter |

## Use Cases

1. **Draft Analysis**: Track which colleges produce NFL talent
2. **Position Trends**: Analyze draft trends by position
3. **Team Success**: Correlate college success with NFL draft results
4. **Player Evaluation**: Study draft outcomes for player assessment
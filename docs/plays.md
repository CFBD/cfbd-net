# Plays API

Play-by-play data and play type information.

## Endpoints

- `/plays` - Play-by-play data
- `/plays/types` - Available play types
- `/plays/stats` - Play statistics

## Usage

### Play-by-Play Data

```csharp
var plays = await client.Plays.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Week = 1;
    requestConfiguration.QueryParameters.Team = "Alabama";
});
```

### Play Types

```csharp
var playTypes = await client.Plays.Types.GetAsync();
```

### Play Statistics

```csharp
var playStats = await client.Plays.Stats.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Team = "Alabama";
});
```

## Use Cases

1. **Play Analysis**: Study individual play effectiveness
2. **Situational Football**: Analyze performance by down and distance
3. **Advanced Analytics**: Calculate success rates and efficiency metrics
4. **Game Preparation**: Scout opponent tendencies and play calling
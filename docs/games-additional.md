# Games Sub-endpoints

Additional game-related endpoints for specific data types.

## Endpoints

- `/games/media` - TV and media information
- `/games/weather` - Weather conditions
- `/games/players` - Player statistics for games
- `/games/teams` - Team statistics for games

## Usage

### Game Media Information

```csharp
var gameMedia = await client.Games.Media.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Week = 1;
});
```

### Game Weather

```csharp
var gameWeather = await client.Games.Weather.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Week = 1;
});
```

### Game Player Stats

```csharp
var playerStats = await client.Games.Players.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Week = 1;
    requestConfiguration.QueryParameters.Team = "Alabama";
});
```

### Game Team Stats

```csharp
var teamStats = await client.Games.Teams.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Week = 1;
});
```

## Use Cases

1. **Media Planning**: Find TV schedules and broadcast information
2. **Weather Analysis**: Consider weather impact on game performance
3. **Player Performance**: Track individual player statistics by game
4. **Team Analysis**: Compare team statistics across games
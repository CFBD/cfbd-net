# Game API

Individual game details, box scores, and advanced game statistics.

## Endpoints

- `/game/{id}` - Individual game details
- `/game/{id}/box` - Game box score
- `/game/{id}/advanced` - Advanced game statistics

## Usage

### Game Details

```csharp
var gameDetails = await client.Game[gameId].GetAsync();
```

### Box Score

```csharp
var boxScore = await client.Game[gameId].Box.GetAsync();
```

## Response Properties

### Game Details

Contains comprehensive game information including:
- Basic game information (teams, score, date)
- Game statistics and performance metrics
- Player statistics and contributions
- Advanced analytics and efficiency metrics

### Box Score

Contains traditional box score data:
- Team statistics (yards, first downs, turnovers)
- Player statistics by category
- Quarter-by-quarter scoring
- Key performance indicators

## Use Cases

1. **Game Analysis**: Deep dive into individual game performance
2. **Player Evaluation**: Analyze player performance in specific games
3. **Team Comparison**: Compare team statistics head-to-head
4. **Historical Research**: Study specific games for analysis
# Metrics API

Advanced team metrics and analytics.

## Endpoints

- `/metrics/wp` - Win Probability metrics
- `/metrics/fg` - Field Goal metrics

## Usage

### Win Probability

```csharp
var wpMetrics = await client.Metrics.Wp.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Team = "Alabama";
});
```

### Field Goal Metrics

```csharp
var fgMetrics = await client.Metrics.Fg.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
});
```

## Use Cases

1. **Game Analysis**: Understand win probability throughout games
2. **Clutch Performance**: Identify teams that perform well in close games
3. **Special Teams**: Analyze field goal efficiency and performance
4. **Advanced Analytics**: Use metrics for deeper team evaluation
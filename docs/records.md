# Records API

Team records and historical performance data.

## Endpoint

`/records`

## Usage

```csharp
var records = await client.Records.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Team = "Alabama";
});
```

## Query Parameters

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | No | Season year |
| `team` | string | No | Team filter |
| `conference` | string | No | Conference filter |

## Use Cases

1. **Historical Records**: Track team performance over time
2. **Conference Standings**: Compare teams within conferences
3. **Win-Loss Analysis**: Analyze team records and trends
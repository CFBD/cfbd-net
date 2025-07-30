# Calendar API

Season calendar information including weeks and important dates.

## Endpoint

`/calendar`

## Usage

```csharp
var calendar = await client.Calendar.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
});
```

## Query Parameters

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | Yes | Season year |

## Response Properties

| Property | Type | Description |
|----------|------|-------------|
| `Season` | int? | Season year |
| `Week` | int? | Week number |
| `SeasonType` | string? | Season type |
| `FirstGameStart` | DateTimeOffset? | First game of week |
| `LastGameStart` | DateTimeOffset? | Last game of week |

## Use Cases

1. **Season Planning**: Get important dates for a season
2. **Week Navigation**: Understand week boundaries
3. **Schedule Integration**: Align with official CFB calendar
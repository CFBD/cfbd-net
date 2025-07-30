# Live API

Access real-time game data and scores.

## Endpoints

- `/live/plays` - Live play-by-play data

## Usage

```csharp
var livePlays = await client.Live.Plays.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Id = 401520393;
});
```

## Query Parameters

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `id` | int | Yes | Game ID |

## Use Cases

- Real-time game tracking
- Live play-by-play updates
- In-game statistics
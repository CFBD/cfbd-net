# Venues API

Information about stadiums and venues where games are played.

## Endpoint

`/venues`

## Usage

```csharp
var venues = await client.Venues.GetAsync();
```

## Response Properties

| Property | Type | Description |
|----------|------|-------------|
| `Id` | int? | Venue identifier |
| `Name` | string? | Venue name |
| `Capacity` | int? | Seating capacity |
| `Grass` | bool? | Natural grass surface |
| `City` | string? | City location |
| `State` | string? | State location |
| `Zip` | string? | ZIP code |
| `CountryCode` | string? | Country code |
| `Location` | object? | Geographic coordinates |
| `Elevation` | double? | Elevation above sea level |
| `YearConstructed` | int? | Construction year |
| `Dome` | bool? | Indoor/domed venue |
| `Timezone` | string? | Time zone |

## Examples

### Find venues by capacity

```csharp
var venues = await client.Venues.GetAsync();
var largestVenues = venues
    .Where(v => v.Capacity.HasValue)
    .OrderByDescending(v => v.Capacity.Value)
    .Take(10)
    .ToList();
```

### Find venues by state

```csharp
var venues = await client.Venues.GetAsync();
var texasVenues = venues
    .Where(v => v.State == "TX")
    .OrderBy(v => v.Name)
    .ToList();
```

## Use Cases

1. **Venue Information**: Get details about stadiums
2. **Capacity Analysis**: Compare venue sizes
3. **Geographic Analysis**: Map venue locations
4. **Environmental Factors**: Consider elevation, dome status for analysis
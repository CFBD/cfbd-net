# Conferences API

Information about college football conferences and conference statistics.

## Endpoint

`/conferences`

## Usage

```csharp
var conferences = await client.Conferences.GetAsync();
```

## Response Properties

| Property | Type | Description |
|----------|------|-------------|
| `Id` | int? | Conference identifier |
| `Name` | string? | Conference name |
| `ShortName` | string? | Conference abbreviation |
| `Classification` | string? | Division classification |

## Examples

### Get all conferences

```csharp
var allConferences = await client.Conferences.GetAsync();
var fbsConferences = allConferences
    .Where(c => c.Classification == "fbs")
    .OrderBy(c => c.Name)
    .ToList();
```

## Use Cases

1. **Conference Directory**: List all active conferences
2. **Classification Analysis**: Group conferences by division
3. **Data Integration**: Use conference IDs for filtering other endpoints
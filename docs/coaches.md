# Coaches API

The Coaches API provides information about coaching staff, including historical coaching records and current staff.

## Endpoint

`/coaches`

## Usage

```csharp
var coaches = await client.Coaches.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Team = "Alabama";
});
```

## Query Parameters

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `firstName` | string | No | Coach first name filter |
| `lastName` | string | No | Coach last name filter |
| `team` | string | No | Team filter |
| `year` | int | No | Season year filter |
| `minYear` | int | No | Minimum year filter |
| `maxYear` | int | No | Maximum year filter |

## Examples

### Get current coaching staff

```csharp
var currentStaff = await client.Coaches.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Team = "Alabama";
});
```

### Search for specific coach

```csharp
var nickSaban = await client.Coaches.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.FirstName = "Nick";
    requestConfiguration.QueryParameters.LastName = "Saban";
});
```

### Get coaching history

```csharp
var coachHistory = await client.Coaches.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.LastName = "Saban";
    requestConfiguration.QueryParameters.MinYear = 2000;
    requestConfiguration.QueryParameters.MaxYear = 2023;
});
```

## Response Properties

| Property | Type | Description |
|----------|------|-------------|
| `FirstName` | string? | Coach first name |
| `LastName` | string? | Coach last name |
| `School` | string? | School name |
| `Year` | int? | Season year |
| `Games` | int? | Games coached |
| `Wins` | int? | Wins |
| `Losses` | int? | Losses |
| `Ties` | int? | Ties |
| `Preseason_rank` | int? | Preseason ranking |
| `Postseason_rank` | int? | Final ranking |

## Use Cases

1. **Staff Directory**: Get current coaching staff information
2. **Historical Analysis**: Track coaching records and tenure
3. **Coaching Changes**: Monitor staff movement between schools
4. **Performance Analysis**: Evaluate coaching success metrics
# Teams API

The Teams API provides access to team information, including basic team data and FBS-specific information.

## Endpoints

- `/teams` - General team information
- `/teams/fbs` - FBS-specific team data

## Usage

### General Teams

```csharp
var teams = await client.Teams.GetAsync(requestConfiguration =>
{
    // Configure query parameters here
});
```

### FBS Teams

```csharp
var fbsTeams = await client.Teams.Fbs.GetAsync(requestConfiguration =>
{
    // Configure query parameters here
});
```

## Query Parameters

### General Teams

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `conference` | string | No | Conference abbreviation filter |
| `year` | int | No | Season year filter |

### FBS Teams

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | No | Season year filter |

## Response

### Team Properties

| Property | Type | Description |
|----------|------|-------------|
| `Id` | int? | Unique team identifier |
| `School` | string? | School name |
| `Mascot` | string? | Team mascot |
| `Abbreviation` | string? | Team abbreviation |
| `AltName1` | string? | Alternative team name |
| `AltName2` | string? | Secondary alternative name |
| `AltName3` | string? | Third alternative name |
| `Conference` | string? | Current conference |
| `Classification` | string? | Division classification |
| `Color` | string? | Primary team color (hex) |
| `AltColor` | string? | Secondary team color (hex) |
| `Logos` | List<string>? | Team logo URLs |

## Examples

### Get all teams

```csharp
var allTeams = await client.Teams.GetAsync();
```

### Get teams from a specific conference

```csharp
var secTeams = await client.Teams.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Conference = "SEC";
});
```

### Get FBS teams for a specific year

```csharp
var fbsTeams2023 = await client.Teams.Fbs.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
});
```

### Find a specific team

```csharp
var alabamaTeam = (await client.Teams.GetAsync())
    .FirstOrDefault(t => t.School == "Alabama");
```

## Related Endpoints

- [Teams/Matchup](teams-matchup.md) - Historical matchup data between teams
- [Stats](stats.md) - Team statistics
- [Rankings](rankings.md) - Team rankings and polls
- [Ratings](ratings.md) - Team rating systems
- [Recruiting/Teams](recruiting.md) - Team recruiting information
- [Records](records.md) - Team records and historical data

## Use Cases

1. **Team Directory**: Build a comprehensive list of college football teams
2. **Conference Analysis**: Analyze teams within specific conferences
3. **Branding**: Access team colors and logos for UI/display purposes
4. **Data Integration**: Use team IDs to link with other API endpoints
5. **Historical Tracking**: Monitor team conference changes over time
6. **Search Functionality**: Implement team search using various name formats
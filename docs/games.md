# Games API

The Games API provides access to historical and live game data for college football games.

## Endpoint

`/games`

## Usage

```csharp
var games = await client.Games.GetAsync(requestConfiguration =>
{
    // Configure query parameters here
});
```

## Query Parameters

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | Yes* | Season year (required except when id is specified) |
| `week` | int | No | Week number filter |
| `seasonType` | SeasonType | No | Season type filter (regular, postseason, both) |
| `team` | string | No | Team name filter |
| `home` | string | No | Home team filter |
| `away` | string | No | Away team filter |
| `conference` | string | No | Conference abbreviation filter |
| `classification` | DivisionClassification | No | Division classification (fbs, fcs, ii, iii) |
| `id` | int | No | Specific game ID to retrieve |

## Response

Returns a `List<Game>` with the following properties:

### Game Properties

| Property | Type | Description |
|----------|------|-------------|
| `Id` | int? | Unique game identifier |
| `Season` | int? | Season year |
| `Week` | int? | Week number |
| `SeasonType` | SeasonType? | Type of season (regular, postseason) |
| `StartDate` | DateTimeOffset? | Game start date and time |
| `Completed` | bool? | Whether the game is completed |
| `NeutralSite` | bool? | Whether played at neutral site |
| `ConferenceGame` | bool? | Whether it's a conference game |
| `Attendance` | int? | Game attendance |
| `Venue` | string? | Stadium/venue name |
| `VenueId` | int? | Venue identifier |
| `HomeTeam` | string? | Home team name |
| `HomeId` | int? | Home team identifier |
| `HomeConference` | string? | Home team conference |
| `HomeClassification` | DivisionClassification? | Home team division |
| `HomePoints` | int? | Home team final score |
| `HomeLineScores` | List<double?>? | Home team quarter scores |
| `HomePregameElo` | int? | Home team pre-game ELO rating |
| `HomePostgameElo` | int? | Home team post-game ELO rating |
| `HomePostgameWinProbability` | double? | Home team post-game win probability |
| `AwayTeam` | string? | Away team name |
| `AwayId` | int? | Away team identifier |
| `AwayConference` | string? | Away team conference |
| `AwayClassification` | DivisionClassification? | Away team division |
| `AwayPoints` | int? | Away team final score |
| `AwayLineScores` | List<double?>? | Away team quarter scores |
| `AwayPregameElo` | int? | Away team pre-game ELO rating |
| `AwayPostgameElo` | int? | Away team post-game ELO rating |
| `AwayPostgameWinProbability` | double? | Away team post-game win probability |
| `ExcitementIndex` | double? | Game excitement rating |
| `Highlights` | string? | Link to game highlights |
| `Notes` | string? | Additional game notes |

## Examples

### Get all games for a season

```csharp
var games2023 = await client.Games.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
});
```

### Get games for a specific week

```csharp
var week1Games = await client.Games.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Week = 1;
});
```

### Get games for a specific team

```csharp
var alabamaGames = await client.Games.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Team = "Alabama";
});
```

### Get conference games only

```csharp
var secGames = await client.Games.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Conference = "SEC";
});
```

### Get postseason games

```csharp
var bowlGames = await client.Games.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.SeasonTypeAsSeasonType = SeasonType.Postseason;
});
```

### Get a specific game

```csharp
var specificGame = await client.Games.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Id = 401520393;
});
```

### Get head-to-head matchup

```csharp
var matchup = await client.Games.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
    requestConfiguration.QueryParameters.Home = "Alabama";
    requestConfiguration.QueryParameters.Away = "Georgia";
});
```

## Related Endpoints

- [Game](game.md) - Individual game details and box scores
- [Games/Media](games-media.md) - TV and media information for games
- [Games/Weather](games-weather.md) - Weather conditions for games
- [Games/Players](games-players.md) - Player statistics for games
- [Games/Teams](games-teams.md) - Team statistics for games
- [Live](live.md) - Live game data and scores
- [Scoreboard](scoreboard.md) - Live scoreboard information

## Use Cases

1. **Season Analysis**: Get all games for a season to analyze trends
2. **Team Performance**: Track a specific team's games and results
3. **Weekly Schedules**: Display upcoming or completed games for a week
4. **Conference Analysis**: Analyze games within specific conferences
5. **Postseason Tracking**: Monitor bowl games and playoff results
6. **Historical Research**: Access historical game data for analysis
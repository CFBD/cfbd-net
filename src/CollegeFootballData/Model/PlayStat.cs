// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.10
 * Contact: admin@collegefootballdata.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using CollegeFootballData.Client;

namespace CollegeFootballData.Model
{
    /// <summary>
    /// PlayStat
    /// </summary>
    public partial class PlayStat : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayStat" /> class.
        /// </summary>
        /// <param name="gameId">gameId</param>
        /// <param name="season">season</param>
        /// <param name="week">week</param>
        /// <param name="team">team</param>
        /// <param name="conference">conference</param>
        /// <param name="opponent">opponent</param>
        /// <param name="teamScore">teamScore</param>
        /// <param name="opponentScore">opponentScore</param>
        /// <param name="driveId">driveId</param>
        /// <param name="playId">playId</param>
        /// <param name="period">period</param>
        /// <param name="clock">clock</param>
        /// <param name="yardsToGoal">yardsToGoal</param>
        /// <param name="down">down</param>
        /// <param name="distance">distance</param>
        /// <param name="athleteId">athleteId</param>
        /// <param name="athleteName">athleteName</param>
        /// <param name="statType">statType</param>
        /// <param name="stat">stat</param>
        [JsonConstructor]
        public PlayStat(double gameId, double season, double week, string team, string conference, string opponent, double teamScore, double opponentScore, string driveId, string playId, double period, PlayStatClock clock, double yardsToGoal, double down, double distance, string athleteId, string athleteName, string statType, double stat)
        {
            GameId = gameId;
            Season = season;
            Week = week;
            Team = team;
            Conference = conference;
            Opponent = opponent;
            TeamScore = teamScore;
            OpponentScore = opponentScore;
            DriveId = driveId;
            PlayId = playId;
            Period = period;
            Clock = clock;
            YardsToGoal = yardsToGoal;
            Down = down;
            Distance = distance;
            AthleteId = athleteId;
            AthleteName = athleteName;
            StatType = statType;
            Stat = stat;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [JsonPropertyName("gameId")]
        public double GameId { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [JsonPropertyName("season")]
        public double Season { get; set; }

        /// <summary>
        /// Gets or Sets Week
        /// </summary>
        [JsonPropertyName("week")]
        public double Week { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [JsonPropertyName("team")]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [JsonPropertyName("conference")]
        public string Conference { get; set; }

        /// <summary>
        /// Gets or Sets Opponent
        /// </summary>
        [JsonPropertyName("opponent")]
        public string Opponent { get; set; }

        /// <summary>
        /// Gets or Sets TeamScore
        /// </summary>
        [JsonPropertyName("teamScore")]
        public double TeamScore { get; set; }

        /// <summary>
        /// Gets or Sets OpponentScore
        /// </summary>
        [JsonPropertyName("opponentScore")]
        public double OpponentScore { get; set; }

        /// <summary>
        /// Gets or Sets DriveId
        /// </summary>
        [JsonPropertyName("driveId")]
        public string DriveId { get; set; }

        /// <summary>
        /// Gets or Sets PlayId
        /// </summary>
        [JsonPropertyName("playId")]
        public string PlayId { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [JsonPropertyName("period")]
        public double Period { get; set; }

        /// <summary>
        /// Gets or Sets Clock
        /// </summary>
        [JsonPropertyName("clock")]
        public PlayStatClock Clock { get; set; }

        /// <summary>
        /// Gets or Sets YardsToGoal
        /// </summary>
        [JsonPropertyName("yardsToGoal")]
        public double YardsToGoal { get; set; }

        /// <summary>
        /// Gets or Sets Down
        /// </summary>
        [JsonPropertyName("down")]
        public double Down { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [JsonPropertyName("distance")]
        public double Distance { get; set; }

        /// <summary>
        /// Gets or Sets AthleteId
        /// </summary>
        [JsonPropertyName("athleteId")]
        public string AthleteId { get; set; }

        /// <summary>
        /// Gets or Sets AthleteName
        /// </summary>
        [JsonPropertyName("athleteName")]
        public string AthleteName { get; set; }

        /// <summary>
        /// Gets or Sets StatType
        /// </summary>
        [JsonPropertyName("statType")]
        public string StatType { get; set; }

        /// <summary>
        /// Gets or Sets Stat
        /// </summary>
        [JsonPropertyName("stat")]
        public double Stat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayStat {\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Opponent: ").Append(Opponent).Append("\n");
            sb.Append("  TeamScore: ").Append(TeamScore).Append("\n");
            sb.Append("  OpponentScore: ").Append(OpponentScore).Append("\n");
            sb.Append("  DriveId: ").Append(DriveId).Append("\n");
            sb.Append("  PlayId: ").Append(PlayId).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Clock: ").Append(Clock).Append("\n");
            sb.Append("  YardsToGoal: ").Append(YardsToGoal).Append("\n");
            sb.Append("  Down: ").Append(Down).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  AthleteId: ").Append(AthleteId).Append("\n");
            sb.Append("  AthleteName: ").Append(AthleteName).Append("\n");
            sb.Append("  StatType: ").Append(StatType).Append("\n");
            sb.Append("  Stat: ").Append(Stat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="PlayStat" />
    /// </summary>
    public class PlayStatJsonConverter : JsonConverter<PlayStat>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayStat" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayStat Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double?> gameId = default;
            Option<double?> season = default;
            Option<double?> week = default;
            Option<string?> team = default;
            Option<string?> conference = default;
            Option<string?> opponent = default;
            Option<double?> teamScore = default;
            Option<double?> opponentScore = default;
            Option<string?> driveId = default;
            Option<string?> playId = default;
            Option<double?> period = default;
            Option<PlayStatClock?> clock = default;
            Option<double?> yardsToGoal = default;
            Option<double?> down = default;
            Option<double?> distance = default;
            Option<string?> athleteId = default;
            Option<string?> athleteName = default;
            Option<string?> statType = default;
            Option<double?> stat = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "gameId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                gameId = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "season":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                season = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "week":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                week = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "team":
                            team = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "conference":
                            conference = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "opponent":
                            opponent = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "teamScore":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                teamScore = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "opponentScore":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                opponentScore = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "driveId":
                            driveId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "playId":
                            playId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "period":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                period = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "clock":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                clock = new Option<PlayStatClock?>(JsonSerializer.Deserialize<PlayStatClock>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "yardsToGoal":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                yardsToGoal = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "down":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                down = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "distance":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                distance = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "athleteId":
                            athleteId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "athleteName":
                            athleteName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "statType":
                            statType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "stat":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                stat = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!gameId.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(gameId));

            if (!season.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(season));

            if (!week.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(week));

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(team));

            if (!conference.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(conference));

            if (!opponent.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(opponent));

            if (!teamScore.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(teamScore));

            if (!opponentScore.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(opponentScore));

            if (!driveId.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(driveId));

            if (!playId.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(playId));

            if (!period.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(period));

            if (!clock.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(clock));

            if (!yardsToGoal.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(yardsToGoal));

            if (!down.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(down));

            if (!distance.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(distance));

            if (!athleteId.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(athleteId));

            if (!athleteName.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(athleteName));

            if (!statType.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(statType));

            if (!stat.IsSet)
                throw new ArgumentException("Property is required for class PlayStat.", nameof(stat));

            if (gameId.IsSet && gameId.Value == null)
                throw new ArgumentNullException(nameof(gameId), "Property is not nullable for class PlayStat.");

            if (season.IsSet && season.Value == null)
                throw new ArgumentNullException(nameof(season), "Property is not nullable for class PlayStat.");

            if (week.IsSet && week.Value == null)
                throw new ArgumentNullException(nameof(week), "Property is not nullable for class PlayStat.");

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class PlayStat.");

            if (conference.IsSet && conference.Value == null)
                throw new ArgumentNullException(nameof(conference), "Property is not nullable for class PlayStat.");

            if (opponent.IsSet && opponent.Value == null)
                throw new ArgumentNullException(nameof(opponent), "Property is not nullable for class PlayStat.");

            if (teamScore.IsSet && teamScore.Value == null)
                throw new ArgumentNullException(nameof(teamScore), "Property is not nullable for class PlayStat.");

            if (opponentScore.IsSet && opponentScore.Value == null)
                throw new ArgumentNullException(nameof(opponentScore), "Property is not nullable for class PlayStat.");

            if (driveId.IsSet && driveId.Value == null)
                throw new ArgumentNullException(nameof(driveId), "Property is not nullable for class PlayStat.");

            if (playId.IsSet && playId.Value == null)
                throw new ArgumentNullException(nameof(playId), "Property is not nullable for class PlayStat.");

            if (period.IsSet && period.Value == null)
                throw new ArgumentNullException(nameof(period), "Property is not nullable for class PlayStat.");

            if (clock.IsSet && clock.Value == null)
                throw new ArgumentNullException(nameof(clock), "Property is not nullable for class PlayStat.");

            if (yardsToGoal.IsSet && yardsToGoal.Value == null)
                throw new ArgumentNullException(nameof(yardsToGoal), "Property is not nullable for class PlayStat.");

            if (down.IsSet && down.Value == null)
                throw new ArgumentNullException(nameof(down), "Property is not nullable for class PlayStat.");

            if (distance.IsSet && distance.Value == null)
                throw new ArgumentNullException(nameof(distance), "Property is not nullable for class PlayStat.");

            if (athleteId.IsSet && athleteId.Value == null)
                throw new ArgumentNullException(nameof(athleteId), "Property is not nullable for class PlayStat.");

            if (athleteName.IsSet && athleteName.Value == null)
                throw new ArgumentNullException(nameof(athleteName), "Property is not nullable for class PlayStat.");

            if (statType.IsSet && statType.Value == null)
                throw new ArgumentNullException(nameof(statType), "Property is not nullable for class PlayStat.");

            if (stat.IsSet && stat.Value == null)
                throw new ArgumentNullException(nameof(stat), "Property is not nullable for class PlayStat.");

            return new PlayStat(gameId.Value!.Value!, season.Value!.Value!, week.Value!.Value!, team.Value!, conference.Value!, opponent.Value!, teamScore.Value!.Value!, opponentScore.Value!.Value!, driveId.Value!, playId.Value!, period.Value!.Value!, clock.Value!, yardsToGoal.Value!.Value!, down.Value!.Value!, distance.Value!.Value!, athleteId.Value!, athleteName.Value!, statType.Value!, stat.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="PlayStat" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playStat"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayStat playStat, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playStat, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayStat" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playStat"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayStat playStat, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playStat.Team == null)
                throw new ArgumentNullException(nameof(playStat.Team), "Property is required for class PlayStat.");

            if (playStat.Conference == null)
                throw new ArgumentNullException(nameof(playStat.Conference), "Property is required for class PlayStat.");

            if (playStat.Opponent == null)
                throw new ArgumentNullException(nameof(playStat.Opponent), "Property is required for class PlayStat.");

            if (playStat.DriveId == null)
                throw new ArgumentNullException(nameof(playStat.DriveId), "Property is required for class PlayStat.");

            if (playStat.PlayId == null)
                throw new ArgumentNullException(nameof(playStat.PlayId), "Property is required for class PlayStat.");

            if (playStat.Clock == null)
                throw new ArgumentNullException(nameof(playStat.Clock), "Property is required for class PlayStat.");

            if (playStat.AthleteId == null)
                throw new ArgumentNullException(nameof(playStat.AthleteId), "Property is required for class PlayStat.");

            if (playStat.AthleteName == null)
                throw new ArgumentNullException(nameof(playStat.AthleteName), "Property is required for class PlayStat.");

            if (playStat.StatType == null)
                throw new ArgumentNullException(nameof(playStat.StatType), "Property is required for class PlayStat.");

            writer.WriteNumber("gameId", playStat.GameId);

            writer.WriteNumber("season", playStat.Season);

            writer.WriteNumber("week", playStat.Week);

            writer.WriteString("team", playStat.Team);

            writer.WriteString("conference", playStat.Conference);

            writer.WriteString("opponent", playStat.Opponent);

            writer.WriteNumber("teamScore", playStat.TeamScore);

            writer.WriteNumber("opponentScore", playStat.OpponentScore);

            writer.WriteString("driveId", playStat.DriveId);

            writer.WriteString("playId", playStat.PlayId);

            writer.WriteNumber("period", playStat.Period);

            writer.WritePropertyName("clock");
            JsonSerializer.Serialize(writer, playStat.Clock, jsonSerializerOptions);
            writer.WriteNumber("yardsToGoal", playStat.YardsToGoal);

            writer.WriteNumber("down", playStat.Down);

            writer.WriteNumber("distance", playStat.Distance);

            writer.WriteString("athleteId", playStat.AthleteId);

            writer.WriteString("athleteName", playStat.AthleteName);

            writer.WriteString("statType", playStat.StatType);

            writer.WriteNumber("stat", playStat.Stat);
        }
    }
}

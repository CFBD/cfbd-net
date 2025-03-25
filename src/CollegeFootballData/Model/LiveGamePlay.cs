// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.9
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
    /// LiveGamePlay
    /// </summary>
    public partial class LiveGamePlay : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LiveGamePlay" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="homeScore">homeScore</param>
        /// <param name="awayScore">awayScore</param>
        /// <param name="period">period</param>
        /// <param name="clock">clock</param>
        /// <param name="wallClock">wallClock</param>
        /// <param name="teamId">teamId</param>
        /// <param name="team">team</param>
        /// <param name="down">down</param>
        /// <param name="distance">distance</param>
        /// <param name="yardsToGoal">yardsToGoal</param>
        /// <param name="yardsGained">yardsGained</param>
        /// <param name="playTypeId">playTypeId</param>
        /// <param name="playType">playType</param>
        /// <param name="garbageTime">garbageTime</param>
        /// <param name="success">success</param>
        /// <param name="rushPash">rushPash</param>
        /// <param name="downType">downType</param>
        /// <param name="playText">playText</param>
        /// <param name="epa">epa</param>
        [JsonConstructor]
        public LiveGamePlay(string id, int homeScore, int awayScore, int period, string clock, DateTime wallClock, int teamId, string team, int down, int distance, int yardsToGoal, int yardsGained, int playTypeId, string playType, bool garbageTime, bool success, RushPashEnum rushPash, DownTypeEnum downType, string playText, double? epa = default)
        {
            Id = id;
            HomeScore = homeScore;
            AwayScore = awayScore;
            Period = period;
            Clock = clock;
            WallClock = wallClock;
            TeamId = teamId;
            Team = team;
            Down = down;
            Distance = distance;
            YardsToGoal = yardsToGoal;
            YardsGained = yardsGained;
            PlayTypeId = playTypeId;
            PlayType = playType;
            GarbageTime = garbageTime;
            Success = success;
            RushPash = rushPash;
            DownType = downType;
            PlayText = playText;
            Epa = epa;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines RushPash
        /// </summary>
        public enum RushPashEnum
        {
            /// <summary>
            /// Enum Rush for value: rush
            /// </summary>
            Rush = 1,

            /// <summary>
            /// Enum Pass for value: pass
            /// </summary>
            Pass = 2,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            Other = 3
        }

        /// <summary>
        /// Returns a <see cref="RushPashEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static RushPashEnum RushPashEnumFromString(string value)
        {
            if (value.Equals("rush"))
                return RushPashEnum.Rush;

            if (value.Equals("pass"))
                return RushPashEnum.Pass;

            if (value.Equals("other"))
                return RushPashEnum.Other;

            throw new NotImplementedException($"Could not convert value to type RushPashEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="RushPashEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RushPashEnum? RushPashEnumFromStringOrDefault(string value)
        {
            if (value.Equals("rush"))
                return RushPashEnum.Rush;

            if (value.Equals("pass"))
                return RushPashEnum.Pass;

            if (value.Equals("other"))
                return RushPashEnum.Other;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="RushPashEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string RushPashEnumToJsonValue(RushPashEnum value)
        {
            if (value == RushPashEnum.Rush)
                return "rush";

            if (value == RushPashEnum.Pass)
                return "pass";

            if (value == RushPashEnum.Other)
                return "other";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets RushPash
        /// </summary>
        [JsonPropertyName("rushPash")]
        public RushPashEnum RushPash { get; set; }

        /// <summary>
        /// Defines DownType
        /// </summary>
        public enum DownTypeEnum
        {
            /// <summary>
            /// Enum Passing for value: passing
            /// </summary>
            Passing = 1,

            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            Standard = 2
        }

        /// <summary>
        /// Returns a <see cref="DownTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static DownTypeEnum DownTypeEnumFromString(string value)
        {
            if (value.Equals("passing"))
                return DownTypeEnum.Passing;

            if (value.Equals("standard"))
                return DownTypeEnum.Standard;

            throw new NotImplementedException($"Could not convert value to type DownTypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="DownTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DownTypeEnum? DownTypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("passing"))
                return DownTypeEnum.Passing;

            if (value.Equals("standard"))
                return DownTypeEnum.Standard;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="DownTypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string DownTypeEnumToJsonValue(DownTypeEnum value)
        {
            if (value == DownTypeEnum.Passing)
                return "passing";

            if (value == DownTypeEnum.Standard)
                return "standard";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets DownType
        /// </summary>
        [JsonPropertyName("downType")]
        public DownTypeEnum DownType { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets HomeScore
        /// </summary>
        [JsonPropertyName("homeScore")]
        public int HomeScore { get; set; }

        /// <summary>
        /// Gets or Sets AwayScore
        /// </summary>
        [JsonPropertyName("awayScore")]
        public int AwayScore { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [JsonPropertyName("period")]
        public int Period { get; set; }

        /// <summary>
        /// Gets or Sets Clock
        /// </summary>
        [JsonPropertyName("clock")]
        public string Clock { get; set; }

        /// <summary>
        /// Gets or Sets WallClock
        /// </summary>
        [JsonPropertyName("wallClock")]
        public DateTime WallClock { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [JsonPropertyName("teamId")]
        public int TeamId { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [JsonPropertyName("team")]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Down
        /// </summary>
        [JsonPropertyName("down")]
        public int Down { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [JsonPropertyName("distance")]
        public int Distance { get; set; }

        /// <summary>
        /// Gets or Sets YardsToGoal
        /// </summary>
        [JsonPropertyName("yardsToGoal")]
        public int YardsToGoal { get; set; }

        /// <summary>
        /// Gets or Sets YardsGained
        /// </summary>
        [JsonPropertyName("yardsGained")]
        public int YardsGained { get; set; }

        /// <summary>
        /// Gets or Sets PlayTypeId
        /// </summary>
        [JsonPropertyName("playTypeId")]
        public int PlayTypeId { get; set; }

        /// <summary>
        /// Gets or Sets PlayType
        /// </summary>
        [JsonPropertyName("playType")]
        public string PlayType { get; set; }

        /// <summary>
        /// Gets or Sets GarbageTime
        /// </summary>
        [JsonPropertyName("garbageTime")]
        public bool GarbageTime { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets PlayText
        /// </summary>
        [JsonPropertyName("playText")]
        public string PlayText { get; set; }

        /// <summary>
        /// Gets or Sets Epa
        /// </summary>
        [JsonPropertyName("epa")]
        public double? Epa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LiveGamePlay {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  HomeScore: ").Append(HomeScore).Append("\n");
            sb.Append("  AwayScore: ").Append(AwayScore).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Clock: ").Append(Clock).Append("\n");
            sb.Append("  WallClock: ").Append(WallClock).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Down: ").Append(Down).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  YardsToGoal: ").Append(YardsToGoal).Append("\n");
            sb.Append("  YardsGained: ").Append(YardsGained).Append("\n");
            sb.Append("  PlayTypeId: ").Append(PlayTypeId).Append("\n");
            sb.Append("  PlayType: ").Append(PlayType).Append("\n");
            sb.Append("  GarbageTime: ").Append(GarbageTime).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  RushPash: ").Append(RushPash).Append("\n");
            sb.Append("  DownType: ").Append(DownType).Append("\n");
            sb.Append("  PlayText: ").Append(PlayText).Append("\n");
            sb.Append("  Epa: ").Append(Epa).Append("\n");
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
    /// A Json converter for type <see cref="LiveGamePlay" />
    /// </summary>
    public class LiveGamePlayJsonConverter : JsonConverter<LiveGamePlay>
    {
        /// <summary>
        /// The format to use to serialize WallClock
        /// </summary>
        public static string WallClockFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="LiveGamePlay" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override LiveGamePlay Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<int?> homeScore = default;
            Option<int?> awayScore = default;
            Option<int?> period = default;
            Option<string?> clock = default;
            Option<DateTime?> wallClock = default;
            Option<int?> teamId = default;
            Option<string?> team = default;
            Option<int?> down = default;
            Option<int?> distance = default;
            Option<int?> yardsToGoal = default;
            Option<int?> yardsGained = default;
            Option<int?> playTypeId = default;
            Option<string?> playType = default;
            Option<bool?> garbageTime = default;
            Option<bool?> success = default;
            Option<LiveGamePlay.RushPashEnum?> rushPash = default;
            Option<LiveGamePlay.DownTypeEnum?> downType = default;
            Option<string?> playText = default;
            Option<double?> epa = default;

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
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "homeScore":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                homeScore = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "awayScore":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                awayScore = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "period":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                period = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "clock":
                            clock = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "wallClock":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                wallClock = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "teamId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                teamId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "team":
                            team = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "down":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                down = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "distance":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                distance = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "yardsToGoal":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                yardsToGoal = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "yardsGained":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                yardsGained = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "playTypeId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                playTypeId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "playType":
                            playType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "garbageTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                garbageTime = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "success":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                success = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "rushPash":
                            string? rushPashRawValue = utf8JsonReader.GetString();
                            if (rushPashRawValue != null)
                                rushPash = new Option<LiveGamePlay.RushPashEnum?>(LiveGamePlay.RushPashEnumFromStringOrDefault(rushPashRawValue));
                            break;
                        case "downType":
                            string? downTypeRawValue = utf8JsonReader.GetString();
                            if (downTypeRawValue != null)
                                downType = new Option<LiveGamePlay.DownTypeEnum?>(LiveGamePlay.DownTypeEnumFromStringOrDefault(downTypeRawValue));
                            break;
                        case "playText":
                            playText = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "epa":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                epa = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(id));

            if (!homeScore.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(homeScore));

            if (!awayScore.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(awayScore));

            if (!period.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(period));

            if (!clock.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(clock));

            if (!wallClock.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(wallClock));

            if (!teamId.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(teamId));

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(team));

            if (!down.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(down));

            if (!distance.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(distance));

            if (!yardsToGoal.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(yardsToGoal));

            if (!yardsGained.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(yardsGained));

            if (!playTypeId.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(playTypeId));

            if (!playType.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(playType));

            if (!garbageTime.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(garbageTime));

            if (!success.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(success));

            if (!rushPash.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(rushPash));

            if (!downType.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(downType));

            if (!playText.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(playText));

            if (!epa.IsSet)
                throw new ArgumentException("Property is required for class LiveGamePlay.", nameof(epa));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class LiveGamePlay.");

            if (homeScore.IsSet && homeScore.Value == null)
                throw new ArgumentNullException(nameof(homeScore), "Property is not nullable for class LiveGamePlay.");

            if (awayScore.IsSet && awayScore.Value == null)
                throw new ArgumentNullException(nameof(awayScore), "Property is not nullable for class LiveGamePlay.");

            if (period.IsSet && period.Value == null)
                throw new ArgumentNullException(nameof(period), "Property is not nullable for class LiveGamePlay.");

            if (clock.IsSet && clock.Value == null)
                throw new ArgumentNullException(nameof(clock), "Property is not nullable for class LiveGamePlay.");

            if (wallClock.IsSet && wallClock.Value == null)
                throw new ArgumentNullException(nameof(wallClock), "Property is not nullable for class LiveGamePlay.");

            if (teamId.IsSet && teamId.Value == null)
                throw new ArgumentNullException(nameof(teamId), "Property is not nullable for class LiveGamePlay.");

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class LiveGamePlay.");

            if (down.IsSet && down.Value == null)
                throw new ArgumentNullException(nameof(down), "Property is not nullable for class LiveGamePlay.");

            if (distance.IsSet && distance.Value == null)
                throw new ArgumentNullException(nameof(distance), "Property is not nullable for class LiveGamePlay.");

            if (yardsToGoal.IsSet && yardsToGoal.Value == null)
                throw new ArgumentNullException(nameof(yardsToGoal), "Property is not nullable for class LiveGamePlay.");

            if (yardsGained.IsSet && yardsGained.Value == null)
                throw new ArgumentNullException(nameof(yardsGained), "Property is not nullable for class LiveGamePlay.");

            if (playTypeId.IsSet && playTypeId.Value == null)
                throw new ArgumentNullException(nameof(playTypeId), "Property is not nullable for class LiveGamePlay.");

            if (playType.IsSet && playType.Value == null)
                throw new ArgumentNullException(nameof(playType), "Property is not nullable for class LiveGamePlay.");

            if (garbageTime.IsSet && garbageTime.Value == null)
                throw new ArgumentNullException(nameof(garbageTime), "Property is not nullable for class LiveGamePlay.");

            if (success.IsSet && success.Value == null)
                throw new ArgumentNullException(nameof(success), "Property is not nullable for class LiveGamePlay.");

            if (rushPash.IsSet && rushPash.Value == null)
                throw new ArgumentNullException(nameof(rushPash), "Property is not nullable for class LiveGamePlay.");

            if (downType.IsSet && downType.Value == null)
                throw new ArgumentNullException(nameof(downType), "Property is not nullable for class LiveGamePlay.");

            if (playText.IsSet && playText.Value == null)
                throw new ArgumentNullException(nameof(playText), "Property is not nullable for class LiveGamePlay.");

            return new LiveGamePlay(id.Value!, homeScore.Value!.Value!, awayScore.Value!.Value!, period.Value!.Value!, clock.Value!, wallClock.Value!.Value!, teamId.Value!.Value!, team.Value!, down.Value!.Value!, distance.Value!.Value!, yardsToGoal.Value!.Value!, yardsGained.Value!.Value!, playTypeId.Value!.Value!, playType.Value!, garbageTime.Value!.Value!, success.Value!.Value!, rushPash.Value!.Value!, downType.Value!.Value!, playText.Value!, epa.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="LiveGamePlay" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="liveGamePlay"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, LiveGamePlay liveGamePlay, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, liveGamePlay, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="LiveGamePlay" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="liveGamePlay"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, LiveGamePlay liveGamePlay, JsonSerializerOptions jsonSerializerOptions)
        {
            if (liveGamePlay.Id == null)
                throw new ArgumentNullException(nameof(liveGamePlay.Id), "Property is required for class LiveGamePlay.");

            if (liveGamePlay.Clock == null)
                throw new ArgumentNullException(nameof(liveGamePlay.Clock), "Property is required for class LiveGamePlay.");

            if (liveGamePlay.Team == null)
                throw new ArgumentNullException(nameof(liveGamePlay.Team), "Property is required for class LiveGamePlay.");

            if (liveGamePlay.PlayType == null)
                throw new ArgumentNullException(nameof(liveGamePlay.PlayType), "Property is required for class LiveGamePlay.");

            if (liveGamePlay.PlayText == null)
                throw new ArgumentNullException(nameof(liveGamePlay.PlayText), "Property is required for class LiveGamePlay.");

            writer.WriteString("id", liveGamePlay.Id);

            writer.WriteNumber("homeScore", liveGamePlay.HomeScore);

            writer.WriteNumber("awayScore", liveGamePlay.AwayScore);

            writer.WriteNumber("period", liveGamePlay.Period);

            writer.WriteString("clock", liveGamePlay.Clock);

            writer.WriteString("wallClock", liveGamePlay.WallClock.ToString(WallClockFormat));

            writer.WriteNumber("teamId", liveGamePlay.TeamId);

            writer.WriteString("team", liveGamePlay.Team);

            writer.WriteNumber("down", liveGamePlay.Down);

            writer.WriteNumber("distance", liveGamePlay.Distance);

            writer.WriteNumber("yardsToGoal", liveGamePlay.YardsToGoal);

            writer.WriteNumber("yardsGained", liveGamePlay.YardsGained);

            writer.WriteNumber("playTypeId", liveGamePlay.PlayTypeId);

            writer.WriteString("playType", liveGamePlay.PlayType);

            writer.WriteBoolean("garbageTime", liveGamePlay.GarbageTime);

            writer.WriteBoolean("success", liveGamePlay.Success);

            var rushPashRawValue = LiveGamePlay.RushPashEnumToJsonValue(liveGamePlay.RushPash);
            writer.WriteString("rushPash", rushPashRawValue);
            var downTypeRawValue = LiveGamePlay.DownTypeEnumToJsonValue(liveGamePlay.DownType);
            writer.WriteString("downType", downTypeRawValue);
            writer.WriteString("playText", liveGamePlay.PlayText);

            if (liveGamePlay.Epa != null)
                writer.WriteNumber("epa", liveGamePlay.Epa.Value);
            else
                writer.WriteNull("epa");
        }
    }
}

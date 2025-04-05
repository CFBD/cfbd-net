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
    /// Drive
    /// </summary>
    public partial class Drive : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Drive" /> class.
        /// </summary>
        /// <param name="offense">offense</param>
        /// <param name="defense">defense</param>
        /// <param name="gameId">gameId</param>
        /// <param name="id">id</param>
        /// <param name="scoring">scoring</param>
        /// <param name="startPeriod">startPeriod</param>
        /// <param name="startYardline">startYardline</param>
        /// <param name="startYardsToGoal">startYardsToGoal</param>
        /// <param name="startTime">startTime</param>
        /// <param name="endPeriod">endPeriod</param>
        /// <param name="endYardline">endYardline</param>
        /// <param name="endYardsToGoal">endYardsToGoal</param>
        /// <param name="endTime">endTime</param>
        /// <param name="plays">plays</param>
        /// <param name="yards">yards</param>
        /// <param name="driveResult">driveResult</param>
        /// <param name="isHomeOffense">isHomeOffense</param>
        /// <param name="startOffenseScore">startOffenseScore</param>
        /// <param name="startDefenseScore">startDefenseScore</param>
        /// <param name="endOffenseScore">endOffenseScore</param>
        /// <param name="endDefenseScore">endDefenseScore</param>
        /// <param name="offenseConference">offenseConference</param>
        /// <param name="defenseConference">defenseConference</param>
        /// <param name="driveNumber">driveNumber</param>
        [JsonConstructor]
        public Drive(string offense, string defense, int gameId, string id, bool scoring, int startPeriod, int startYardline, int startYardsToGoal, PlayClock startTime, int endPeriod, int endYardline, int endYardsToGoal, PlayClock endTime, int plays, int yards, string driveResult, bool isHomeOffense, int startOffenseScore, int startDefenseScore, int endOffenseScore, int endDefenseScore, string? offenseConference = default, string? defenseConference = default, int? driveNumber = default)
        {
            Offense = offense;
            Defense = defense;
            GameId = gameId;
            Id = id;
            Scoring = scoring;
            StartPeriod = startPeriod;
            StartYardline = startYardline;
            StartYardsToGoal = startYardsToGoal;
            StartTime = startTime;
            EndPeriod = endPeriod;
            EndYardline = endYardline;
            EndYardsToGoal = endYardsToGoal;
            EndTime = endTime;
            Plays = plays;
            Yards = yards;
            DriveResult = driveResult;
            IsHomeOffense = isHomeOffense;
            StartOffenseScore = startOffenseScore;
            StartDefenseScore = startDefenseScore;
            EndOffenseScore = endOffenseScore;
            EndDefenseScore = endDefenseScore;
            OffenseConference = offenseConference;
            DefenseConference = defenseConference;
            DriveNumber = driveNumber;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Offense
        /// </summary>
        [JsonPropertyName("offense")]
        public string Offense { get; set; }

        /// <summary>
        /// Gets or Sets Defense
        /// </summary>
        [JsonPropertyName("defense")]
        public string Defense { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [JsonPropertyName("gameId")]
        public int GameId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Scoring
        /// </summary>
        [JsonPropertyName("scoring")]
        public bool Scoring { get; set; }

        /// <summary>
        /// Gets or Sets StartPeriod
        /// </summary>
        [JsonPropertyName("startPeriod")]
        public int StartPeriod { get; set; }

        /// <summary>
        /// Gets or Sets StartYardline
        /// </summary>
        [JsonPropertyName("startYardline")]
        public int StartYardline { get; set; }

        /// <summary>
        /// Gets or Sets StartYardsToGoal
        /// </summary>
        [JsonPropertyName("startYardsToGoal")]
        public int StartYardsToGoal { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [JsonPropertyName("startTime")]
        public PlayClock StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndPeriod
        /// </summary>
        [JsonPropertyName("endPeriod")]
        public int EndPeriod { get; set; }

        /// <summary>
        /// Gets or Sets EndYardline
        /// </summary>
        [JsonPropertyName("endYardline")]
        public int EndYardline { get; set; }

        /// <summary>
        /// Gets or Sets EndYardsToGoal
        /// </summary>
        [JsonPropertyName("endYardsToGoal")]
        public int EndYardsToGoal { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [JsonPropertyName("endTime")]
        public PlayClock EndTime { get; set; }

        /// <summary>
        /// Gets or Sets Plays
        /// </summary>
        [JsonPropertyName("plays")]
        public int Plays { get; set; }

        /// <summary>
        /// Gets or Sets Yards
        /// </summary>
        [JsonPropertyName("yards")]
        public int Yards { get; set; }

        /// <summary>
        /// Gets or Sets DriveResult
        /// </summary>
        [JsonPropertyName("driveResult")]
        public string DriveResult { get; set; }

        /// <summary>
        /// Gets or Sets IsHomeOffense
        /// </summary>
        [JsonPropertyName("isHomeOffense")]
        public bool IsHomeOffense { get; set; }

        /// <summary>
        /// Gets or Sets StartOffenseScore
        /// </summary>
        [JsonPropertyName("startOffenseScore")]
        public int StartOffenseScore { get; set; }

        /// <summary>
        /// Gets or Sets StartDefenseScore
        /// </summary>
        [JsonPropertyName("startDefenseScore")]
        public int StartDefenseScore { get; set; }

        /// <summary>
        /// Gets or Sets EndOffenseScore
        /// </summary>
        [JsonPropertyName("endOffenseScore")]
        public int EndOffenseScore { get; set; }

        /// <summary>
        /// Gets or Sets EndDefenseScore
        /// </summary>
        [JsonPropertyName("endDefenseScore")]
        public int EndDefenseScore { get; set; }

        /// <summary>
        /// Gets or Sets OffenseConference
        /// </summary>
        [JsonPropertyName("offenseConference")]
        public string? OffenseConference { get; set; }

        /// <summary>
        /// Gets or Sets DefenseConference
        /// </summary>
        [JsonPropertyName("defenseConference")]
        public string? DefenseConference { get; set; }

        /// <summary>
        /// Gets or Sets DriveNumber
        /// </summary>
        [JsonPropertyName("driveNumber")]
        public int? DriveNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Drive {\n");
            sb.Append("  Offense: ").Append(Offense).Append("\n");
            sb.Append("  Defense: ").Append(Defense).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Scoring: ").Append(Scoring).Append("\n");
            sb.Append("  StartPeriod: ").Append(StartPeriod).Append("\n");
            sb.Append("  StartYardline: ").Append(StartYardline).Append("\n");
            sb.Append("  StartYardsToGoal: ").Append(StartYardsToGoal).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndPeriod: ").Append(EndPeriod).Append("\n");
            sb.Append("  EndYardline: ").Append(EndYardline).Append("\n");
            sb.Append("  EndYardsToGoal: ").Append(EndYardsToGoal).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Plays: ").Append(Plays).Append("\n");
            sb.Append("  Yards: ").Append(Yards).Append("\n");
            sb.Append("  DriveResult: ").Append(DriveResult).Append("\n");
            sb.Append("  IsHomeOffense: ").Append(IsHomeOffense).Append("\n");
            sb.Append("  StartOffenseScore: ").Append(StartOffenseScore).Append("\n");
            sb.Append("  StartDefenseScore: ").Append(StartDefenseScore).Append("\n");
            sb.Append("  EndOffenseScore: ").Append(EndOffenseScore).Append("\n");
            sb.Append("  EndDefenseScore: ").Append(EndDefenseScore).Append("\n");
            sb.Append("  OffenseConference: ").Append(OffenseConference).Append("\n");
            sb.Append("  DefenseConference: ").Append(DefenseConference).Append("\n");
            sb.Append("  DriveNumber: ").Append(DriveNumber).Append("\n");
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
    /// A Json converter for type <see cref="Drive" />
    /// </summary>
    public class DriveJsonConverter : JsonConverter<Drive>
    {
        /// <summary>
        /// Deserializes json to <see cref="Drive" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Drive Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> offense = default;
            Option<string?> defense = default;
            Option<int?> gameId = default;
            Option<string?> id = default;
            Option<bool?> scoring = default;
            Option<int?> startPeriod = default;
            Option<int?> startYardline = default;
            Option<int?> startYardsToGoal = default;
            Option<PlayClock?> startTime = default;
            Option<int?> endPeriod = default;
            Option<int?> endYardline = default;
            Option<int?> endYardsToGoal = default;
            Option<PlayClock?> endTime = default;
            Option<int?> plays = default;
            Option<int?> yards = default;
            Option<string?> driveResult = default;
            Option<bool?> isHomeOffense = default;
            Option<int?> startOffenseScore = default;
            Option<int?> startDefenseScore = default;
            Option<int?> endOffenseScore = default;
            Option<int?> endDefenseScore = default;
            Option<string?> offenseConference = default;
            Option<string?> defenseConference = default;
            Option<int?> driveNumber = default;

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
                        case "offense":
                            offense = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "defense":
                            defense = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "gameId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                gameId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "scoring":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                scoring = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "startPeriod":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                startPeriod = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "startYardline":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                startYardline = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "startYardsToGoal":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                startYardsToGoal = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "startTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                startTime = new Option<PlayClock?>(JsonSerializer.Deserialize<PlayClock>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "endPeriod":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                endPeriod = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "endYardline":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                endYardline = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "endYardsToGoal":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                endYardsToGoal = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "endTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                endTime = new Option<PlayClock?>(JsonSerializer.Deserialize<PlayClock>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "plays":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                plays = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "yards":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                yards = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "driveResult":
                            driveResult = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "isHomeOffense":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isHomeOffense = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "startOffenseScore":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                startOffenseScore = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "startDefenseScore":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                startDefenseScore = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "endOffenseScore":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                endOffenseScore = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "endDefenseScore":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                endDefenseScore = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "offenseConference":
                            offenseConference = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "defenseConference":
                            defenseConference = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "driveNumber":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                driveNumber = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!offense.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(offense));

            if (!defense.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(defense));

            if (!gameId.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(gameId));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(id));

            if (!scoring.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(scoring));

            if (!startPeriod.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(startPeriod));

            if (!startYardline.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(startYardline));

            if (!startYardsToGoal.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(startYardsToGoal));

            if (!startTime.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(startTime));

            if (!endPeriod.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(endPeriod));

            if (!endYardline.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(endYardline));

            if (!endYardsToGoal.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(endYardsToGoal));

            if (!endTime.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(endTime));

            if (!plays.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(plays));

            if (!yards.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(yards));

            if (!driveResult.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(driveResult));

            if (!isHomeOffense.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(isHomeOffense));

            if (!startOffenseScore.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(startOffenseScore));

            if (!startDefenseScore.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(startDefenseScore));

            if (!endOffenseScore.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(endOffenseScore));

            if (!endDefenseScore.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(endDefenseScore));

            if (!offenseConference.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(offenseConference));

            if (!defenseConference.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(defenseConference));

            if (!driveNumber.IsSet)
                throw new ArgumentException("Property is required for class Drive.", nameof(driveNumber));

            if (offense.IsSet && offense.Value == null)
                throw new ArgumentNullException(nameof(offense), "Property is not nullable for class Drive.");

            if (defense.IsSet && defense.Value == null)
                throw new ArgumentNullException(nameof(defense), "Property is not nullable for class Drive.");

            if (gameId.IsSet && gameId.Value == null)
                throw new ArgumentNullException(nameof(gameId), "Property is not nullable for class Drive.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class Drive.");

            if (scoring.IsSet && scoring.Value == null)
                throw new ArgumentNullException(nameof(scoring), "Property is not nullable for class Drive.");

            if (startPeriod.IsSet && startPeriod.Value == null)
                throw new ArgumentNullException(nameof(startPeriod), "Property is not nullable for class Drive.");

            if (startYardline.IsSet && startYardline.Value == null)
                throw new ArgumentNullException(nameof(startYardline), "Property is not nullable for class Drive.");

            if (startYardsToGoal.IsSet && startYardsToGoal.Value == null)
                throw new ArgumentNullException(nameof(startYardsToGoal), "Property is not nullable for class Drive.");

            if (startTime.IsSet && startTime.Value == null)
                throw new ArgumentNullException(nameof(startTime), "Property is not nullable for class Drive.");

            if (endPeriod.IsSet && endPeriod.Value == null)
                throw new ArgumentNullException(nameof(endPeriod), "Property is not nullable for class Drive.");

            if (endYardline.IsSet && endYardline.Value == null)
                throw new ArgumentNullException(nameof(endYardline), "Property is not nullable for class Drive.");

            if (endYardsToGoal.IsSet && endYardsToGoal.Value == null)
                throw new ArgumentNullException(nameof(endYardsToGoal), "Property is not nullable for class Drive.");

            if (endTime.IsSet && endTime.Value == null)
                throw new ArgumentNullException(nameof(endTime), "Property is not nullable for class Drive.");

            if (plays.IsSet && plays.Value == null)
                throw new ArgumentNullException(nameof(plays), "Property is not nullable for class Drive.");

            if (yards.IsSet && yards.Value == null)
                throw new ArgumentNullException(nameof(yards), "Property is not nullable for class Drive.");

            if (driveResult.IsSet && driveResult.Value == null)
                throw new ArgumentNullException(nameof(driveResult), "Property is not nullable for class Drive.");

            if (isHomeOffense.IsSet && isHomeOffense.Value == null)
                throw new ArgumentNullException(nameof(isHomeOffense), "Property is not nullable for class Drive.");

            if (startOffenseScore.IsSet && startOffenseScore.Value == null)
                throw new ArgumentNullException(nameof(startOffenseScore), "Property is not nullable for class Drive.");

            if (startDefenseScore.IsSet && startDefenseScore.Value == null)
                throw new ArgumentNullException(nameof(startDefenseScore), "Property is not nullable for class Drive.");

            if (endOffenseScore.IsSet && endOffenseScore.Value == null)
                throw new ArgumentNullException(nameof(endOffenseScore), "Property is not nullable for class Drive.");

            if (endDefenseScore.IsSet && endDefenseScore.Value == null)
                throw new ArgumentNullException(nameof(endDefenseScore), "Property is not nullable for class Drive.");

            return new Drive(offense.Value!, defense.Value!, gameId.Value!.Value!, id.Value!, scoring.Value!.Value!, startPeriod.Value!.Value!, startYardline.Value!.Value!, startYardsToGoal.Value!.Value!, startTime.Value!, endPeriod.Value!.Value!, endYardline.Value!.Value!, endYardsToGoal.Value!.Value!, endTime.Value!, plays.Value!.Value!, yards.Value!.Value!, driveResult.Value!, isHomeOffense.Value!.Value!, startOffenseScore.Value!.Value!, startDefenseScore.Value!.Value!, endOffenseScore.Value!.Value!, endDefenseScore.Value!.Value!, offenseConference.Value!, defenseConference.Value!, driveNumber.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="Drive" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="drive"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Drive drive, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, drive, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Drive" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="drive"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Drive drive, JsonSerializerOptions jsonSerializerOptions)
        {
            if (drive.Offense == null)
                throw new ArgumentNullException(nameof(drive.Offense), "Property is required for class Drive.");

            if (drive.Defense == null)
                throw new ArgumentNullException(nameof(drive.Defense), "Property is required for class Drive.");

            if (drive.Id == null)
                throw new ArgumentNullException(nameof(drive.Id), "Property is required for class Drive.");

            if (drive.StartTime == null)
                throw new ArgumentNullException(nameof(drive.StartTime), "Property is required for class Drive.");

            if (drive.EndTime == null)
                throw new ArgumentNullException(nameof(drive.EndTime), "Property is required for class Drive.");

            if (drive.DriveResult == null)
                throw new ArgumentNullException(nameof(drive.DriveResult), "Property is required for class Drive.");

            writer.WriteString("offense", drive.Offense);

            writer.WriteString("defense", drive.Defense);

            writer.WriteNumber("gameId", drive.GameId);

            writer.WriteString("id", drive.Id);

            writer.WriteBoolean("scoring", drive.Scoring);

            writer.WriteNumber("startPeriod", drive.StartPeriod);

            writer.WriteNumber("startYardline", drive.StartYardline);

            writer.WriteNumber("startYardsToGoal", drive.StartYardsToGoal);

            writer.WritePropertyName("startTime");
            JsonSerializer.Serialize(writer, drive.StartTime, jsonSerializerOptions);
            writer.WriteNumber("endPeriod", drive.EndPeriod);

            writer.WriteNumber("endYardline", drive.EndYardline);

            writer.WriteNumber("endYardsToGoal", drive.EndYardsToGoal);

            writer.WritePropertyName("endTime");
            JsonSerializer.Serialize(writer, drive.EndTime, jsonSerializerOptions);
            writer.WriteNumber("plays", drive.Plays);

            writer.WriteNumber("yards", drive.Yards);

            writer.WriteString("driveResult", drive.DriveResult);

            writer.WriteBoolean("isHomeOffense", drive.IsHomeOffense);

            writer.WriteNumber("startOffenseScore", drive.StartOffenseScore);

            writer.WriteNumber("startDefenseScore", drive.StartDefenseScore);

            writer.WriteNumber("endOffenseScore", drive.EndOffenseScore);

            writer.WriteNumber("endDefenseScore", drive.EndDefenseScore);

            if (drive.OffenseConference != null)
                writer.WriteString("offenseConference", drive.OffenseConference);
            else
                writer.WriteNull("offenseConference");

            if (drive.DefenseConference != null)
                writer.WriteString("defenseConference", drive.DefenseConference);
            else
                writer.WriteNull("defenseConference");

            if (drive.DriveNumber != null)
                writer.WriteNumber("driveNumber", drive.DriveNumber.Value);
            else
                writer.WriteNull("driveNumber");
        }
    }
}

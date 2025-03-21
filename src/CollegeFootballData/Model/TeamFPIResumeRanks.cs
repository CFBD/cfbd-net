// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.8
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
    /// TeamFPIResumeRanks
    /// </summary>
    public partial class TeamFPIResumeRanks : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamFPIResumeRanks" /> class.
        /// </summary>
        /// <param name="gameControl">gameControl</param>
        /// <param name="remainingStrengthOfSchedule">remainingStrengthOfSchedule</param>
        /// <param name="strengthOfSchedule">strengthOfSchedule</param>
        /// <param name="averageWinProbability">averageWinProbability</param>
        /// <param name="fpi">fpi</param>
        /// <param name="strengthOfRecord">strengthOfRecord</param>
        [JsonConstructor]
        public TeamFPIResumeRanks(int? gameControl = default, int? remainingStrengthOfSchedule = default, int? strengthOfSchedule = default, int? averageWinProbability = default, int? fpi = default, int? strengthOfRecord = default)
        {
            GameControl = gameControl;
            RemainingStrengthOfSchedule = remainingStrengthOfSchedule;
            StrengthOfSchedule = strengthOfSchedule;
            AverageWinProbability = averageWinProbability;
            Fpi = fpi;
            StrengthOfRecord = strengthOfRecord;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets GameControl
        /// </summary>
        [JsonPropertyName("gameControl")]
        public int? GameControl { get; set; }

        /// <summary>
        /// Gets or Sets RemainingStrengthOfSchedule
        /// </summary>
        [JsonPropertyName("remainingStrengthOfSchedule")]
        public int? RemainingStrengthOfSchedule { get; set; }

        /// <summary>
        /// Gets or Sets StrengthOfSchedule
        /// </summary>
        [JsonPropertyName("strengthOfSchedule")]
        public int? StrengthOfSchedule { get; set; }

        /// <summary>
        /// Gets or Sets AverageWinProbability
        /// </summary>
        [JsonPropertyName("averageWinProbability")]
        public int? AverageWinProbability { get; set; }

        /// <summary>
        /// Gets or Sets Fpi
        /// </summary>
        [JsonPropertyName("fpi")]
        public int? Fpi { get; set; }

        /// <summary>
        /// Gets or Sets StrengthOfRecord
        /// </summary>
        [JsonPropertyName("strengthOfRecord")]
        public int? StrengthOfRecord { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamFPIResumeRanks {\n");
            sb.Append("  GameControl: ").Append(GameControl).Append("\n");
            sb.Append("  RemainingStrengthOfSchedule: ").Append(RemainingStrengthOfSchedule).Append("\n");
            sb.Append("  StrengthOfSchedule: ").Append(StrengthOfSchedule).Append("\n");
            sb.Append("  AverageWinProbability: ").Append(AverageWinProbability).Append("\n");
            sb.Append("  Fpi: ").Append(Fpi).Append("\n");
            sb.Append("  StrengthOfRecord: ").Append(StrengthOfRecord).Append("\n");
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
    /// A Json converter for type <see cref="TeamFPIResumeRanks" />
    /// </summary>
    public class TeamFPIResumeRanksJsonConverter : JsonConverter<TeamFPIResumeRanks>
    {
        /// <summary>
        /// Deserializes json to <see cref="TeamFPIResumeRanks" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TeamFPIResumeRanks Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> gameControl = default;
            Option<int?> remainingStrengthOfSchedule = default;
            Option<int?> strengthOfSchedule = default;
            Option<int?> averageWinProbability = default;
            Option<int?> fpi = default;
            Option<int?> strengthOfRecord = default;

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
                        case "gameControl":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                gameControl = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "remainingStrengthOfSchedule":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                remainingStrengthOfSchedule = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "strengthOfSchedule":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                strengthOfSchedule = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "averageWinProbability":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                averageWinProbability = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "fpi":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                fpi = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "strengthOfRecord":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                strengthOfRecord = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!gameControl.IsSet)
                throw new ArgumentException("Property is required for class TeamFPIResumeRanks.", nameof(gameControl));

            if (!remainingStrengthOfSchedule.IsSet)
                throw new ArgumentException("Property is required for class TeamFPIResumeRanks.", nameof(remainingStrengthOfSchedule));

            if (!strengthOfSchedule.IsSet)
                throw new ArgumentException("Property is required for class TeamFPIResumeRanks.", nameof(strengthOfSchedule));

            if (!averageWinProbability.IsSet)
                throw new ArgumentException("Property is required for class TeamFPIResumeRanks.", nameof(averageWinProbability));

            if (!fpi.IsSet)
                throw new ArgumentException("Property is required for class TeamFPIResumeRanks.", nameof(fpi));

            if (!strengthOfRecord.IsSet)
                throw new ArgumentException("Property is required for class TeamFPIResumeRanks.", nameof(strengthOfRecord));

            return new TeamFPIResumeRanks(gameControl.Value!, remainingStrengthOfSchedule.Value!, strengthOfSchedule.Value!, averageWinProbability.Value!, fpi.Value!, strengthOfRecord.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="TeamFPIResumeRanks" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamFPIResumeRanks"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TeamFPIResumeRanks teamFPIResumeRanks, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, teamFPIResumeRanks, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TeamFPIResumeRanks" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamFPIResumeRanks"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TeamFPIResumeRanks teamFPIResumeRanks, JsonSerializerOptions jsonSerializerOptions)
        {
            if (teamFPIResumeRanks.GameControl != null)
                writer.WriteNumber("gameControl", teamFPIResumeRanks.GameControl.Value);
            else
                writer.WriteNull("gameControl");

            if (teamFPIResumeRanks.RemainingStrengthOfSchedule != null)
                writer.WriteNumber("remainingStrengthOfSchedule", teamFPIResumeRanks.RemainingStrengthOfSchedule.Value);
            else
                writer.WriteNull("remainingStrengthOfSchedule");

            if (teamFPIResumeRanks.StrengthOfSchedule != null)
                writer.WriteNumber("strengthOfSchedule", teamFPIResumeRanks.StrengthOfSchedule.Value);
            else
                writer.WriteNull("strengthOfSchedule");

            if (teamFPIResumeRanks.AverageWinProbability != null)
                writer.WriteNumber("averageWinProbability", teamFPIResumeRanks.AverageWinProbability.Value);
            else
                writer.WriteNull("averageWinProbability");

            if (teamFPIResumeRanks.Fpi != null)
                writer.WriteNumber("fpi", teamFPIResumeRanks.Fpi.Value);
            else
                writer.WriteNull("fpi");

            if (teamFPIResumeRanks.StrengthOfRecord != null)
                writer.WriteNumber("strengthOfRecord", teamFPIResumeRanks.StrengthOfRecord.Value);
            else
                writer.WriteNull("strengthOfRecord");
        }
    }
}

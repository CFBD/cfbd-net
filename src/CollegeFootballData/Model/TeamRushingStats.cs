// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.11
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
    /// TeamRushingStats
    /// </summary>
    public partial class TeamRushingStats : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRushingStats" /> class.
        /// </summary>
        /// <param name="team">team</param>
        /// <param name="powerSuccess">powerSuccess</param>
        /// <param name="stuffRate">stuffRate</param>
        /// <param name="lineYards">lineYards</param>
        /// <param name="lineYardsAverage">lineYardsAverage</param>
        /// <param name="secondLevelYards">secondLevelYards</param>
        /// <param name="secondLevelYardsAverage">secondLevelYardsAverage</param>
        /// <param name="openFieldYards">openFieldYards</param>
        /// <param name="openFieldYardsAverage">openFieldYardsAverage</param>
        [JsonConstructor]
        public TeamRushingStats(string team, double powerSuccess, double stuffRate, double lineYards, double lineYardsAverage, double secondLevelYards, double secondLevelYardsAverage, double openFieldYards, double openFieldYardsAverage)
        {
            Team = team;
            PowerSuccess = powerSuccess;
            StuffRate = stuffRate;
            LineYards = lineYards;
            LineYardsAverage = lineYardsAverage;
            SecondLevelYards = secondLevelYards;
            SecondLevelYardsAverage = secondLevelYardsAverage;
            OpenFieldYards = openFieldYards;
            OpenFieldYardsAverage = openFieldYardsAverage;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [JsonPropertyName("team")]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets PowerSuccess
        /// </summary>
        [JsonPropertyName("powerSuccess")]
        public double PowerSuccess { get; set; }

        /// <summary>
        /// Gets or Sets StuffRate
        /// </summary>
        [JsonPropertyName("stuffRate")]
        public double StuffRate { get; set; }

        /// <summary>
        /// Gets or Sets LineYards
        /// </summary>
        [JsonPropertyName("lineYards")]
        public double LineYards { get; set; }

        /// <summary>
        /// Gets or Sets LineYardsAverage
        /// </summary>
        [JsonPropertyName("lineYardsAverage")]
        public double LineYardsAverage { get; set; }

        /// <summary>
        /// Gets or Sets SecondLevelYards
        /// </summary>
        [JsonPropertyName("secondLevelYards")]
        public double SecondLevelYards { get; set; }

        /// <summary>
        /// Gets or Sets SecondLevelYardsAverage
        /// </summary>
        [JsonPropertyName("secondLevelYardsAverage")]
        public double SecondLevelYardsAverage { get; set; }

        /// <summary>
        /// Gets or Sets OpenFieldYards
        /// </summary>
        [JsonPropertyName("openFieldYards")]
        public double OpenFieldYards { get; set; }

        /// <summary>
        /// Gets or Sets OpenFieldYardsAverage
        /// </summary>
        [JsonPropertyName("openFieldYardsAverage")]
        public double OpenFieldYardsAverage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamRushingStats {\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  PowerSuccess: ").Append(PowerSuccess).Append("\n");
            sb.Append("  StuffRate: ").Append(StuffRate).Append("\n");
            sb.Append("  LineYards: ").Append(LineYards).Append("\n");
            sb.Append("  LineYardsAverage: ").Append(LineYardsAverage).Append("\n");
            sb.Append("  SecondLevelYards: ").Append(SecondLevelYards).Append("\n");
            sb.Append("  SecondLevelYardsAverage: ").Append(SecondLevelYardsAverage).Append("\n");
            sb.Append("  OpenFieldYards: ").Append(OpenFieldYards).Append("\n");
            sb.Append("  OpenFieldYardsAverage: ").Append(OpenFieldYardsAverage).Append("\n");
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
    /// A Json converter for type <see cref="TeamRushingStats" />
    /// </summary>
    public class TeamRushingStatsJsonConverter : JsonConverter<TeamRushingStats>
    {
        /// <summary>
        /// Deserializes json to <see cref="TeamRushingStats" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TeamRushingStats Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> team = default;
            Option<double?> powerSuccess = default;
            Option<double?> stuffRate = default;
            Option<double?> lineYards = default;
            Option<double?> lineYardsAverage = default;
            Option<double?> secondLevelYards = default;
            Option<double?> secondLevelYardsAverage = default;
            Option<double?> openFieldYards = default;
            Option<double?> openFieldYardsAverage = default;

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
                        case "team":
                            team = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "powerSuccess":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                powerSuccess = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "stuffRate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                stuffRate = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "lineYards":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lineYards = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "lineYardsAverage":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lineYardsAverage = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "secondLevelYards":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                secondLevelYards = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "secondLevelYardsAverage":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                secondLevelYardsAverage = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "openFieldYards":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                openFieldYards = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "openFieldYardsAverage":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                openFieldYardsAverage = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class TeamRushingStats.", nameof(team));

            if (!powerSuccess.IsSet)
                throw new ArgumentException("Property is required for class TeamRushingStats.", nameof(powerSuccess));

            if (!stuffRate.IsSet)
                throw new ArgumentException("Property is required for class TeamRushingStats.", nameof(stuffRate));

            if (!lineYards.IsSet)
                throw new ArgumentException("Property is required for class TeamRushingStats.", nameof(lineYards));

            if (!lineYardsAverage.IsSet)
                throw new ArgumentException("Property is required for class TeamRushingStats.", nameof(lineYardsAverage));

            if (!secondLevelYards.IsSet)
                throw new ArgumentException("Property is required for class TeamRushingStats.", nameof(secondLevelYards));

            if (!secondLevelYardsAverage.IsSet)
                throw new ArgumentException("Property is required for class TeamRushingStats.", nameof(secondLevelYardsAverage));

            if (!openFieldYards.IsSet)
                throw new ArgumentException("Property is required for class TeamRushingStats.", nameof(openFieldYards));

            if (!openFieldYardsAverage.IsSet)
                throw new ArgumentException("Property is required for class TeamRushingStats.", nameof(openFieldYardsAverage));

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class TeamRushingStats.");

            if (powerSuccess.IsSet && powerSuccess.Value == null)
                throw new ArgumentNullException(nameof(powerSuccess), "Property is not nullable for class TeamRushingStats.");

            if (stuffRate.IsSet && stuffRate.Value == null)
                throw new ArgumentNullException(nameof(stuffRate), "Property is not nullable for class TeamRushingStats.");

            if (lineYards.IsSet && lineYards.Value == null)
                throw new ArgumentNullException(nameof(lineYards), "Property is not nullable for class TeamRushingStats.");

            if (lineYardsAverage.IsSet && lineYardsAverage.Value == null)
                throw new ArgumentNullException(nameof(lineYardsAverage), "Property is not nullable for class TeamRushingStats.");

            if (secondLevelYards.IsSet && secondLevelYards.Value == null)
                throw new ArgumentNullException(nameof(secondLevelYards), "Property is not nullable for class TeamRushingStats.");

            if (secondLevelYardsAverage.IsSet && secondLevelYardsAverage.Value == null)
                throw new ArgumentNullException(nameof(secondLevelYardsAverage), "Property is not nullable for class TeamRushingStats.");

            if (openFieldYards.IsSet && openFieldYards.Value == null)
                throw new ArgumentNullException(nameof(openFieldYards), "Property is not nullable for class TeamRushingStats.");

            if (openFieldYardsAverage.IsSet && openFieldYardsAverage.Value == null)
                throw new ArgumentNullException(nameof(openFieldYardsAverage), "Property is not nullable for class TeamRushingStats.");

            return new TeamRushingStats(team.Value!, powerSuccess.Value!.Value!, stuffRate.Value!.Value!, lineYards.Value!.Value!, lineYardsAverage.Value!.Value!, secondLevelYards.Value!.Value!, secondLevelYardsAverage.Value!.Value!, openFieldYards.Value!.Value!, openFieldYardsAverage.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="TeamRushingStats" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamRushingStats"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TeamRushingStats teamRushingStats, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, teamRushingStats, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TeamRushingStats" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamRushingStats"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TeamRushingStats teamRushingStats, JsonSerializerOptions jsonSerializerOptions)
        {
            if (teamRushingStats.Team == null)
                throw new ArgumentNullException(nameof(teamRushingStats.Team), "Property is required for class TeamRushingStats.");

            writer.WriteString("team", teamRushingStats.Team);

            writer.WriteNumber("powerSuccess", teamRushingStats.PowerSuccess);

            writer.WriteNumber("stuffRate", teamRushingStats.StuffRate);

            writer.WriteNumber("lineYards", teamRushingStats.LineYards);

            writer.WriteNumber("lineYardsAverage", teamRushingStats.LineYardsAverage);

            writer.WriteNumber("secondLevelYards", teamRushingStats.SecondLevelYards);

            writer.WriteNumber("secondLevelYardsAverage", teamRushingStats.SecondLevelYardsAverage);

            writer.WriteNumber("openFieldYards", teamRushingStats.OpenFieldYards);

            writer.WriteNumber("openFieldYardsAverage", teamRushingStats.OpenFieldYardsAverage);
        }
    }
}

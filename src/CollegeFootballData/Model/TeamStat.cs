// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.7
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
    /// TeamStat
    /// </summary>
    public partial class TeamStat : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamStat" /> class.
        /// </summary>
        /// <param name="season">season</param>
        /// <param name="team">team</param>
        /// <param name="conference">conference</param>
        /// <param name="statName">statName</param>
        /// <param name="statValue">statValue</param>
        [JsonConstructor]
        public TeamStat(int season, string team, string conference, string statName, TeamStatStatValue statValue)
        {
            Season = season;
            Team = team;
            Conference = conference;
            StatName = statName;
            StatValue = statValue;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [JsonPropertyName("season")]
        public int Season { get; set; }

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
        /// Gets or Sets StatName
        /// </summary>
        [JsonPropertyName("statName")]
        public string StatName { get; set; }

        /// <summary>
        /// Gets or Sets StatValue
        /// </summary>
        [JsonPropertyName("statValue")]
        public TeamStatStatValue StatValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamStat {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  StatName: ").Append(StatName).Append("\n");
            sb.Append("  StatValue: ").Append(StatValue).Append("\n");
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
    /// A Json converter for type <see cref="TeamStat" />
    /// </summary>
    public class TeamStatJsonConverter : JsonConverter<TeamStat>
    {
        /// <summary>
        /// Deserializes json to <see cref="TeamStat" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TeamStat Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> season = default;
            Option<string?> team = default;
            Option<string?> conference = default;
            Option<string?> statName = default;
            Option<TeamStatStatValue?> statValue = default;

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
                        case "season":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                season = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "team":
                            team = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "conference":
                            conference = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "statName":
                            statName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "statValue":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                statValue = new Option<TeamStatStatValue?>(JsonSerializer.Deserialize<TeamStatStatValue>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!season.IsSet)
                throw new ArgumentException("Property is required for class TeamStat.", nameof(season));

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class TeamStat.", nameof(team));

            if (!conference.IsSet)
                throw new ArgumentException("Property is required for class TeamStat.", nameof(conference));

            if (!statName.IsSet)
                throw new ArgumentException("Property is required for class TeamStat.", nameof(statName));

            if (!statValue.IsSet)
                throw new ArgumentException("Property is required for class TeamStat.", nameof(statValue));

            if (season.IsSet && season.Value == null)
                throw new ArgumentNullException(nameof(season), "Property is not nullable for class TeamStat.");

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class TeamStat.");

            if (conference.IsSet && conference.Value == null)
                throw new ArgumentNullException(nameof(conference), "Property is not nullable for class TeamStat.");

            if (statName.IsSet && statName.Value == null)
                throw new ArgumentNullException(nameof(statName), "Property is not nullable for class TeamStat.");

            if (statValue.IsSet && statValue.Value == null)
                throw new ArgumentNullException(nameof(statValue), "Property is not nullable for class TeamStat.");

            return new TeamStat(season.Value!.Value!, team.Value!, conference.Value!, statName.Value!, statValue.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="TeamStat" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamStat"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TeamStat teamStat, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, teamStat, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TeamStat" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamStat"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TeamStat teamStat, JsonSerializerOptions jsonSerializerOptions)
        {
            if (teamStat.Team == null)
                throw new ArgumentNullException(nameof(teamStat.Team), "Property is required for class TeamStat.");

            if (teamStat.Conference == null)
                throw new ArgumentNullException(nameof(teamStat.Conference), "Property is required for class TeamStat.");

            if (teamStat.StatName == null)
                throw new ArgumentNullException(nameof(teamStat.StatName), "Property is required for class TeamStat.");

            if (teamStat.StatValue == null)
                throw new ArgumentNullException(nameof(teamStat.StatValue), "Property is required for class TeamStat.");

            writer.WriteNumber("season", teamStat.Season);

            writer.WriteString("team", teamStat.Team);

            writer.WriteString("conference", teamStat.Conference);

            writer.WriteString("statName", teamStat.StatName);

            writer.WritePropertyName("statValue");
            JsonSerializer.Serialize(writer, teamStat.StatValue, jsonSerializerOptions);
        }
    }
}

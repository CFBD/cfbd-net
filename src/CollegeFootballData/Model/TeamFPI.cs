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
    /// TeamFPI
    /// </summary>
    public partial class TeamFPI : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamFPI" /> class.
        /// </summary>
        /// <param name="year">year</param>
        /// <param name="team">team</param>
        /// <param name="resumeRanks">resumeRanks</param>
        /// <param name="efficiencies">efficiencies</param>
        /// <param name="conference">conference</param>
        /// <param name="fpi">fpi</param>
        [JsonConstructor]
        public TeamFPI(int year, string team, TeamFPIResumeRanks resumeRanks, TeamFPIEfficiencies efficiencies, string? conference = default, double? fpi = default)
        {
            Year = year;
            Team = team;
            ResumeRanks = resumeRanks;
            Efficiencies = efficiencies;
            Conference = conference;
            Fpi = fpi;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [JsonPropertyName("year")]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [JsonPropertyName("team")]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets ResumeRanks
        /// </summary>
        [JsonPropertyName("resumeRanks")]
        public TeamFPIResumeRanks ResumeRanks { get; set; }

        /// <summary>
        /// Gets or Sets Efficiencies
        /// </summary>
        [JsonPropertyName("efficiencies")]
        public TeamFPIEfficiencies Efficiencies { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [JsonPropertyName("conference")]
        public string? Conference { get; set; }

        /// <summary>
        /// Gets or Sets Fpi
        /// </summary>
        [JsonPropertyName("fpi")]
        public double? Fpi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamFPI {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  ResumeRanks: ").Append(ResumeRanks).Append("\n");
            sb.Append("  Efficiencies: ").Append(Efficiencies).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Fpi: ").Append(Fpi).Append("\n");
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
    /// A Json converter for type <see cref="TeamFPI" />
    /// </summary>
    public class TeamFPIJsonConverter : JsonConverter<TeamFPI>
    {
        /// <summary>
        /// Deserializes json to <see cref="TeamFPI" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TeamFPI Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> year = default;
            Option<string?> team = default;
            Option<TeamFPIResumeRanks?> resumeRanks = default;
            Option<TeamFPIEfficiencies?> efficiencies = default;
            Option<string?> conference = default;
            Option<double?> fpi = default;

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
                        case "year":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                year = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "team":
                            team = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "resumeRanks":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                resumeRanks = new Option<TeamFPIResumeRanks?>(JsonSerializer.Deserialize<TeamFPIResumeRanks>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "efficiencies":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                efficiencies = new Option<TeamFPIEfficiencies?>(JsonSerializer.Deserialize<TeamFPIEfficiencies>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "conference":
                            conference = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "fpi":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                fpi = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!year.IsSet)
                throw new ArgumentException("Property is required for class TeamFPI.", nameof(year));

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class TeamFPI.", nameof(team));

            if (!resumeRanks.IsSet)
                throw new ArgumentException("Property is required for class TeamFPI.", nameof(resumeRanks));

            if (!efficiencies.IsSet)
                throw new ArgumentException("Property is required for class TeamFPI.", nameof(efficiencies));

            if (!conference.IsSet)
                throw new ArgumentException("Property is required for class TeamFPI.", nameof(conference));

            if (!fpi.IsSet)
                throw new ArgumentException("Property is required for class TeamFPI.", nameof(fpi));

            if (year.IsSet && year.Value == null)
                throw new ArgumentNullException(nameof(year), "Property is not nullable for class TeamFPI.");

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class TeamFPI.");

            if (resumeRanks.IsSet && resumeRanks.Value == null)
                throw new ArgumentNullException(nameof(resumeRanks), "Property is not nullable for class TeamFPI.");

            if (efficiencies.IsSet && efficiencies.Value == null)
                throw new ArgumentNullException(nameof(efficiencies), "Property is not nullable for class TeamFPI.");

            return new TeamFPI(year.Value!.Value!, team.Value!, resumeRanks.Value!, efficiencies.Value!, conference.Value!, fpi.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="TeamFPI" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamFPI"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TeamFPI teamFPI, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, teamFPI, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TeamFPI" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamFPI"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TeamFPI teamFPI, JsonSerializerOptions jsonSerializerOptions)
        {
            if (teamFPI.Team == null)
                throw new ArgumentNullException(nameof(teamFPI.Team), "Property is required for class TeamFPI.");

            if (teamFPI.ResumeRanks == null)
                throw new ArgumentNullException(nameof(teamFPI.ResumeRanks), "Property is required for class TeamFPI.");

            if (teamFPI.Efficiencies == null)
                throw new ArgumentNullException(nameof(teamFPI.Efficiencies), "Property is required for class TeamFPI.");

            writer.WriteNumber("year", teamFPI.Year);

            writer.WriteString("team", teamFPI.Team);

            writer.WritePropertyName("resumeRanks");
            JsonSerializer.Serialize(writer, teamFPI.ResumeRanks, jsonSerializerOptions);
            writer.WritePropertyName("efficiencies");
            JsonSerializer.Serialize(writer, teamFPI.Efficiencies, jsonSerializerOptions);
            if (teamFPI.Conference != null)
                writer.WriteString("conference", teamFPI.Conference);
            else
                writer.WriteNull("conference");

            if (teamFPI.Fpi != null)
                writer.WriteNumber("fpi", teamFPI.Fpi.Value);
            else
                writer.WriteNull("fpi");
        }
    }
}

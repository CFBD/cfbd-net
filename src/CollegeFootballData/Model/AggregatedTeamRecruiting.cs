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
    /// AggregatedTeamRecruiting
    /// </summary>
    public partial class AggregatedTeamRecruiting : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedTeamRecruiting" /> class.
        /// </summary>
        /// <param name="team">team</param>
        /// <param name="conference">conference</param>
        /// <param name="averageRating">averageRating</param>
        /// <param name="totalRating">totalRating</param>
        /// <param name="commits">commits</param>
        /// <param name="averageStars">averageStars</param>
        /// <param name="positionGroup">positionGroup</param>
        [JsonConstructor]
        public AggregatedTeamRecruiting(string team, string conference, double averageRating, double totalRating, int commits, double averageStars, string? positionGroup = default)
        {
            Team = team;
            Conference = conference;
            AverageRating = averageRating;
            TotalRating = totalRating;
            Commits = commits;
            AverageStars = averageStars;
            PositionGroup = positionGroup;
            OnCreated();
        }

        partial void OnCreated();

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
        /// Gets or Sets AverageRating
        /// </summary>
        [JsonPropertyName("averageRating")]
        public double AverageRating { get; set; }

        /// <summary>
        /// Gets or Sets TotalRating
        /// </summary>
        [JsonPropertyName("totalRating")]
        public double TotalRating { get; set; }

        /// <summary>
        /// Gets or Sets Commits
        /// </summary>
        [JsonPropertyName("commits")]
        public int Commits { get; set; }

        /// <summary>
        /// Gets or Sets AverageStars
        /// </summary>
        [JsonPropertyName("averageStars")]
        public double AverageStars { get; set; }

        /// <summary>
        /// Gets or Sets PositionGroup
        /// </summary>
        [JsonPropertyName("positionGroup")]
        public string? PositionGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AggregatedTeamRecruiting {\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  AverageRating: ").Append(AverageRating).Append("\n");
            sb.Append("  TotalRating: ").Append(TotalRating).Append("\n");
            sb.Append("  Commits: ").Append(Commits).Append("\n");
            sb.Append("  AverageStars: ").Append(AverageStars).Append("\n");
            sb.Append("  PositionGroup: ").Append(PositionGroup).Append("\n");
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
    /// A Json converter for type <see cref="AggregatedTeamRecruiting" />
    /// </summary>
    public class AggregatedTeamRecruitingJsonConverter : JsonConverter<AggregatedTeamRecruiting>
    {
        /// <summary>
        /// Deserializes json to <see cref="AggregatedTeamRecruiting" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AggregatedTeamRecruiting Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> team = default;
            Option<string?> conference = default;
            Option<double?> averageRating = default;
            Option<double?> totalRating = default;
            Option<int?> commits = default;
            Option<double?> averageStars = default;
            Option<string?> positionGroup = default;

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
                        case "conference":
                            conference = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "averageRating":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                averageRating = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "totalRating":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                totalRating = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "commits":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                commits = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "averageStars":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                averageStars = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "positionGroup":
                            positionGroup = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class AggregatedTeamRecruiting.", nameof(team));

            if (!conference.IsSet)
                throw new ArgumentException("Property is required for class AggregatedTeamRecruiting.", nameof(conference));

            if (!averageRating.IsSet)
                throw new ArgumentException("Property is required for class AggregatedTeamRecruiting.", nameof(averageRating));

            if (!totalRating.IsSet)
                throw new ArgumentException("Property is required for class AggregatedTeamRecruiting.", nameof(totalRating));

            if (!commits.IsSet)
                throw new ArgumentException("Property is required for class AggregatedTeamRecruiting.", nameof(commits));

            if (!averageStars.IsSet)
                throw new ArgumentException("Property is required for class AggregatedTeamRecruiting.", nameof(averageStars));

            if (!positionGroup.IsSet)
                throw new ArgumentException("Property is required for class AggregatedTeamRecruiting.", nameof(positionGroup));

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class AggregatedTeamRecruiting.");

            if (conference.IsSet && conference.Value == null)
                throw new ArgumentNullException(nameof(conference), "Property is not nullable for class AggregatedTeamRecruiting.");

            if (averageRating.IsSet && averageRating.Value == null)
                throw new ArgumentNullException(nameof(averageRating), "Property is not nullable for class AggregatedTeamRecruiting.");

            if (totalRating.IsSet && totalRating.Value == null)
                throw new ArgumentNullException(nameof(totalRating), "Property is not nullable for class AggregatedTeamRecruiting.");

            if (commits.IsSet && commits.Value == null)
                throw new ArgumentNullException(nameof(commits), "Property is not nullable for class AggregatedTeamRecruiting.");

            if (averageStars.IsSet && averageStars.Value == null)
                throw new ArgumentNullException(nameof(averageStars), "Property is not nullable for class AggregatedTeamRecruiting.");

            return new AggregatedTeamRecruiting(team.Value!, conference.Value!, averageRating.Value!.Value!, totalRating.Value!.Value!, commits.Value!.Value!, averageStars.Value!.Value!, positionGroup.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AggregatedTeamRecruiting" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="aggregatedTeamRecruiting"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AggregatedTeamRecruiting aggregatedTeamRecruiting, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, aggregatedTeamRecruiting, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AggregatedTeamRecruiting" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="aggregatedTeamRecruiting"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AggregatedTeamRecruiting aggregatedTeamRecruiting, JsonSerializerOptions jsonSerializerOptions)
        {
            if (aggregatedTeamRecruiting.Team == null)
                throw new ArgumentNullException(nameof(aggregatedTeamRecruiting.Team), "Property is required for class AggregatedTeamRecruiting.");

            if (aggregatedTeamRecruiting.Conference == null)
                throw new ArgumentNullException(nameof(aggregatedTeamRecruiting.Conference), "Property is required for class AggregatedTeamRecruiting.");

            writer.WriteString("team", aggregatedTeamRecruiting.Team);

            writer.WriteString("conference", aggregatedTeamRecruiting.Conference);

            writer.WriteNumber("averageRating", aggregatedTeamRecruiting.AverageRating);

            writer.WriteNumber("totalRating", aggregatedTeamRecruiting.TotalRating);

            writer.WriteNumber("commits", aggregatedTeamRecruiting.Commits);

            writer.WriteNumber("averageStars", aggregatedTeamRecruiting.AverageStars);

            if (aggregatedTeamRecruiting.PositionGroup != null)
                writer.WriteString("positionGroup", aggregatedTeamRecruiting.PositionGroup);
            else
                writer.WriteNull("positionGroup");
        }
    }
}

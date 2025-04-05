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
    /// TeamScoringOpportunities
    /// </summary>
    public partial class TeamScoringOpportunities : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamScoringOpportunities" /> class.
        /// </summary>
        /// <param name="team">team</param>
        /// <param name="opportunities">opportunities</param>
        /// <param name="points">points</param>
        /// <param name="pointsPerOpportunity">pointsPerOpportunity</param>
        [JsonConstructor]
        public TeamScoringOpportunities(string team, int opportunities, int points, double pointsPerOpportunity)
        {
            Team = team;
            Opportunities = opportunities;
            Points = points;
            PointsPerOpportunity = pointsPerOpportunity;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [JsonPropertyName("team")]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Opportunities
        /// </summary>
        [JsonPropertyName("opportunities")]
        public int Opportunities { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [JsonPropertyName("points")]
        public int Points { get; set; }

        /// <summary>
        /// Gets or Sets PointsPerOpportunity
        /// </summary>
        [JsonPropertyName("pointsPerOpportunity")]
        public double PointsPerOpportunity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamScoringOpportunities {\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Opportunities: ").Append(Opportunities).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  PointsPerOpportunity: ").Append(PointsPerOpportunity).Append("\n");
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
    /// A Json converter for type <see cref="TeamScoringOpportunities" />
    /// </summary>
    public class TeamScoringOpportunitiesJsonConverter : JsonConverter<TeamScoringOpportunities>
    {
        /// <summary>
        /// Deserializes json to <see cref="TeamScoringOpportunities" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TeamScoringOpportunities Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> team = default;
            Option<int?> opportunities = default;
            Option<int?> points = default;
            Option<double?> pointsPerOpportunity = default;

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
                        case "opportunities":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                opportunities = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "points":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                points = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "pointsPerOpportunity":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                pointsPerOpportunity = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class TeamScoringOpportunities.", nameof(team));

            if (!opportunities.IsSet)
                throw new ArgumentException("Property is required for class TeamScoringOpportunities.", nameof(opportunities));

            if (!points.IsSet)
                throw new ArgumentException("Property is required for class TeamScoringOpportunities.", nameof(points));

            if (!pointsPerOpportunity.IsSet)
                throw new ArgumentException("Property is required for class TeamScoringOpportunities.", nameof(pointsPerOpportunity));

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class TeamScoringOpportunities.");

            if (opportunities.IsSet && opportunities.Value == null)
                throw new ArgumentNullException(nameof(opportunities), "Property is not nullable for class TeamScoringOpportunities.");

            if (points.IsSet && points.Value == null)
                throw new ArgumentNullException(nameof(points), "Property is not nullable for class TeamScoringOpportunities.");

            if (pointsPerOpportunity.IsSet && pointsPerOpportunity.Value == null)
                throw new ArgumentNullException(nameof(pointsPerOpportunity), "Property is not nullable for class TeamScoringOpportunities.");

            return new TeamScoringOpportunities(team.Value!, opportunities.Value!.Value!, points.Value!.Value!, pointsPerOpportunity.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="TeamScoringOpportunities" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamScoringOpportunities"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TeamScoringOpportunities teamScoringOpportunities, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, teamScoringOpportunities, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TeamScoringOpportunities" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamScoringOpportunities"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TeamScoringOpportunities teamScoringOpportunities, JsonSerializerOptions jsonSerializerOptions)
        {
            if (teamScoringOpportunities.Team == null)
                throw new ArgumentNullException(nameof(teamScoringOpportunities.Team), "Property is required for class TeamScoringOpportunities.");

            writer.WriteString("team", teamScoringOpportunities.Team);

            writer.WriteNumber("opportunities", teamScoringOpportunities.Opportunities);

            writer.WriteNumber("points", teamScoringOpportunities.Points);

            writer.WriteNumber("pointsPerOpportunity", teamScoringOpportunities.PointsPerOpportunity);
        }
    }
}

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
    /// TeamRecruitingRanking
    /// </summary>
    public partial class TeamRecruitingRanking : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRecruitingRanking" /> class.
        /// </summary>
        /// <param name="year">year</param>
        /// <param name="rank">rank</param>
        /// <param name="team">team</param>
        /// <param name="points">points</param>
        [JsonConstructor]
        public TeamRecruitingRanking(int year, int rank, string team, double points)
        {
            Year = year;
            Rank = rank;
            Team = team;
            Points = points;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [JsonPropertyName("year")]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [JsonPropertyName("team")]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [JsonPropertyName("points")]
        public double Points { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamRecruitingRanking {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
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
    /// A Json converter for type <see cref="TeamRecruitingRanking" />
    /// </summary>
    public class TeamRecruitingRankingJsonConverter : JsonConverter<TeamRecruitingRanking>
    {
        /// <summary>
        /// Deserializes json to <see cref="TeamRecruitingRanking" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TeamRecruitingRanking Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> year = default;
            Option<int?> rank = default;
            Option<string?> team = default;
            Option<double?> points = default;

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
                        case "rank":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rank = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "team":
                            team = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "points":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                points = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!year.IsSet)
                throw new ArgumentException("Property is required for class TeamRecruitingRanking.", nameof(year));

            if (!rank.IsSet)
                throw new ArgumentException("Property is required for class TeamRecruitingRanking.", nameof(rank));

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class TeamRecruitingRanking.", nameof(team));

            if (!points.IsSet)
                throw new ArgumentException("Property is required for class TeamRecruitingRanking.", nameof(points));

            if (year.IsSet && year.Value == null)
                throw new ArgumentNullException(nameof(year), "Property is not nullable for class TeamRecruitingRanking.");

            if (rank.IsSet && rank.Value == null)
                throw new ArgumentNullException(nameof(rank), "Property is not nullable for class TeamRecruitingRanking.");

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class TeamRecruitingRanking.");

            if (points.IsSet && points.Value == null)
                throw new ArgumentNullException(nameof(points), "Property is not nullable for class TeamRecruitingRanking.");

            return new TeamRecruitingRanking(year.Value!.Value!, rank.Value!.Value!, team.Value!, points.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="TeamRecruitingRanking" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamRecruitingRanking"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TeamRecruitingRanking teamRecruitingRanking, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, teamRecruitingRanking, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TeamRecruitingRanking" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamRecruitingRanking"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TeamRecruitingRanking teamRecruitingRanking, JsonSerializerOptions jsonSerializerOptions)
        {
            if (teamRecruitingRanking.Team == null)
                throw new ArgumentNullException(nameof(teamRecruitingRanking.Team), "Property is required for class TeamRecruitingRanking.");

            writer.WriteNumber("year", teamRecruitingRanking.Year);

            writer.WriteNumber("rank", teamRecruitingRanking.Rank);

            writer.WriteString("team", teamRecruitingRanking.Team);

            writer.WriteNumber("points", teamRecruitingRanking.Points);
        }
    }
}

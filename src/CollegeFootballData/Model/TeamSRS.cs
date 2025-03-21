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
    /// TeamSRS
    /// </summary>
    public partial class TeamSRS : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSRS" /> class.
        /// </summary>
        /// <param name="year">year</param>
        /// <param name="team">team</param>
        /// <param name="rating">rating</param>
        /// <param name="ranking">ranking</param>
        /// <param name="conference">conference</param>
        /// <param name="division">division</param>
        [JsonConstructor]
        public TeamSRS(int year, string team, double rating, int ranking, string? conference = default, string? division = default)
        {
            Year = year;
            Team = team;
            Rating = rating;
            Ranking = ranking;
            Conference = conference;
            Division = division;
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
        /// Gets or Sets Rating
        /// </summary>
        [JsonPropertyName("rating")]
        public double Rating { get; set; }

        /// <summary>
        /// Gets or Sets Ranking
        /// </summary>
        [JsonPropertyName("ranking")]
        public int Ranking { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [JsonPropertyName("conference")]
        public string? Conference { get; set; }

        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [JsonPropertyName("division")]
        public string? Division { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamSRS {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Ranking: ").Append(Ranking).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
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
    /// A Json converter for type <see cref="TeamSRS" />
    /// </summary>
    public class TeamSRSJsonConverter : JsonConverter<TeamSRS>
    {
        /// <summary>
        /// Deserializes json to <see cref="TeamSRS" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TeamSRS Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> year = default;
            Option<string?> team = default;
            Option<double?> rating = default;
            Option<int?> ranking = default;
            Option<string?> conference = default;
            Option<string?> division = default;

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
                        case "rating":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rating = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "ranking":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                ranking = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "conference":
                            conference = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "division":
                            division = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!year.IsSet)
                throw new ArgumentException("Property is required for class TeamSRS.", nameof(year));

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class TeamSRS.", nameof(team));

            if (!rating.IsSet)
                throw new ArgumentException("Property is required for class TeamSRS.", nameof(rating));

            if (!ranking.IsSet)
                throw new ArgumentException("Property is required for class TeamSRS.", nameof(ranking));

            if (!conference.IsSet)
                throw new ArgumentException("Property is required for class TeamSRS.", nameof(conference));

            if (!division.IsSet)
                throw new ArgumentException("Property is required for class TeamSRS.", nameof(division));

            if (year.IsSet && year.Value == null)
                throw new ArgumentNullException(nameof(year), "Property is not nullable for class TeamSRS.");

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class TeamSRS.");

            if (rating.IsSet && rating.Value == null)
                throw new ArgumentNullException(nameof(rating), "Property is not nullable for class TeamSRS.");

            if (ranking.IsSet && ranking.Value == null)
                throw new ArgumentNullException(nameof(ranking), "Property is not nullable for class TeamSRS.");

            return new TeamSRS(year.Value!.Value!, team.Value!, rating.Value!.Value!, ranking.Value!.Value!, conference.Value!, division.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="TeamSRS" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamSRS"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TeamSRS teamSRS, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, teamSRS, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TeamSRS" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamSRS"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TeamSRS teamSRS, JsonSerializerOptions jsonSerializerOptions)
        {
            if (teamSRS.Team == null)
                throw new ArgumentNullException(nameof(teamSRS.Team), "Property is required for class TeamSRS.");

            writer.WriteNumber("year", teamSRS.Year);

            writer.WriteString("team", teamSRS.Team);

            writer.WriteNumber("rating", teamSRS.Rating);

            writer.WriteNumber("ranking", teamSRS.Ranking);

            if (teamSRS.Conference != null)
                writer.WriteString("conference", teamSRS.Conference);
            else
                writer.WriteNull("conference");

            if (teamSRS.Division != null)
                writer.WriteString("division", teamSRS.Division);
            else
                writer.WriteNull("division");
        }
    }
}

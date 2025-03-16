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
    /// PollRank
    /// </summary>
    public partial class PollRank : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PollRank" /> class.
        /// </summary>
        /// <param name="school">school</param>
        /// <param name="rank">rank</param>
        /// <param name="conference">conference</param>
        /// <param name="firstPlaceVotes">firstPlaceVotes</param>
        /// <param name="points">points</param>
        [JsonConstructor]
        public PollRank(string school, int? rank = default, string? conference = default, int? firstPlaceVotes = default, int? points = default)
        {
            School = school;
            Rank = rank;
            Conference = conference;
            FirstPlaceVotes = firstPlaceVotes;
            Points = points;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets School
        /// </summary>
        [JsonPropertyName("school")]
        public string School { get; set; }

        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [JsonPropertyName("rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [JsonPropertyName("conference")]
        public string? Conference { get; set; }

        /// <summary>
        /// Gets or Sets FirstPlaceVotes
        /// </summary>
        [JsonPropertyName("firstPlaceVotes")]
        public int? FirstPlaceVotes { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [JsonPropertyName("points")]
        public int? Points { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PollRank {\n");
            sb.Append("  School: ").Append(School).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  FirstPlaceVotes: ").Append(FirstPlaceVotes).Append("\n");
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
    /// A Json converter for type <see cref="PollRank" />
    /// </summary>
    public class PollRankJsonConverter : JsonConverter<PollRank>
    {
        /// <summary>
        /// Deserializes json to <see cref="PollRank" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PollRank Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> school = default;
            Option<int?> rank = default;
            Option<string?> conference = default;
            Option<int?> firstPlaceVotes = default;
            Option<int?> points = default;

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
                        case "school":
                            school = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "rank":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rank = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "conference":
                            conference = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "firstPlaceVotes":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                firstPlaceVotes = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "points":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                points = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!school.IsSet)
                throw new ArgumentException("Property is required for class PollRank.", nameof(school));

            if (!rank.IsSet)
                throw new ArgumentException("Property is required for class PollRank.", nameof(rank));

            if (!conference.IsSet)
                throw new ArgumentException("Property is required for class PollRank.", nameof(conference));

            if (!firstPlaceVotes.IsSet)
                throw new ArgumentException("Property is required for class PollRank.", nameof(firstPlaceVotes));

            if (!points.IsSet)
                throw new ArgumentException("Property is required for class PollRank.", nameof(points));

            if (school.IsSet && school.Value == null)
                throw new ArgumentNullException(nameof(school), "Property is not nullable for class PollRank.");

            return new PollRank(school.Value!, rank.Value!, conference.Value!, firstPlaceVotes.Value!, points.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="PollRank" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="pollRank"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PollRank pollRank, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, pollRank, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PollRank" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="pollRank"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PollRank pollRank, JsonSerializerOptions jsonSerializerOptions)
        {
            if (pollRank.School == null)
                throw new ArgumentNullException(nameof(pollRank.School), "Property is required for class PollRank.");

            writer.WriteString("school", pollRank.School);

            if (pollRank.Rank != null)
                writer.WriteNumber("rank", pollRank.Rank.Value);
            else
                writer.WriteNull("rank");

            if (pollRank.Conference != null)
                writer.WriteString("conference", pollRank.Conference);
            else
                writer.WriteNull("conference");

            if (pollRank.FirstPlaceVotes != null)
                writer.WriteNumber("firstPlaceVotes", pollRank.FirstPlaceVotes.Value);
            else
                writer.WriteNull("firstPlaceVotes");

            if (pollRank.Points != null)
                writer.WriteNumber("points", pollRank.Points.Value);
            else
                writer.WriteNull("points");
        }
    }
}

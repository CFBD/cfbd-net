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
    /// PollWeek
    /// </summary>
    public partial class PollWeek : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PollWeek" /> class.
        /// </summary>
        /// <param name="season">season</param>
        /// <param name="seasonType">seasonType</param>
        /// <param name="week">week</param>
        /// <param name="polls">polls</param>
        [JsonConstructor]
        public PollWeek(int season, SeasonType seasonType, int week, List<Poll> polls)
        {
            Season = season;
            SeasonType = seasonType;
            Week = week;
            Polls = polls;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets SeasonType
        /// </summary>
        [JsonPropertyName("seasonType")]
        public SeasonType SeasonType { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [JsonPropertyName("season")]
        public int Season { get; set; }

        /// <summary>
        /// Gets or Sets Week
        /// </summary>
        [JsonPropertyName("week")]
        public int Week { get; set; }

        /// <summary>
        /// Gets or Sets Polls
        /// </summary>
        [JsonPropertyName("polls")]
        public List<Poll> Polls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PollWeek {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  SeasonType: ").Append(SeasonType).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  Polls: ").Append(Polls).Append("\n");
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
    /// A Json converter for type <see cref="PollWeek" />
    /// </summary>
    public class PollWeekJsonConverter : JsonConverter<PollWeek>
    {
        /// <summary>
        /// Deserializes json to <see cref="PollWeek" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PollWeek Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> season = default;
            Option<SeasonType?> seasonType = default;
            Option<int?> week = default;
            Option<List<Poll>?> polls = default;

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
                        case "seasonType":
                            string? seasonTypeRawValue = utf8JsonReader.GetString();
                            if (seasonTypeRawValue != null)
                                seasonType = new Option<SeasonType?>(SeasonTypeValueConverter.FromStringOrDefault(seasonTypeRawValue));
                            break;
                        case "week":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                week = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "polls":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                polls = new Option<List<Poll>?>(JsonSerializer.Deserialize<List<Poll>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!season.IsSet)
                throw new ArgumentException("Property is required for class PollWeek.", nameof(season));

            if (!seasonType.IsSet)
                throw new ArgumentException("Property is required for class PollWeek.", nameof(seasonType));

            if (!week.IsSet)
                throw new ArgumentException("Property is required for class PollWeek.", nameof(week));

            if (!polls.IsSet)
                throw new ArgumentException("Property is required for class PollWeek.", nameof(polls));

            if (season.IsSet && season.Value == null)
                throw new ArgumentNullException(nameof(season), "Property is not nullable for class PollWeek.");

            if (seasonType.IsSet && seasonType.Value == null)
                throw new ArgumentNullException(nameof(seasonType), "Property is not nullable for class PollWeek.");

            if (week.IsSet && week.Value == null)
                throw new ArgumentNullException(nameof(week), "Property is not nullable for class PollWeek.");

            if (polls.IsSet && polls.Value == null)
                throw new ArgumentNullException(nameof(polls), "Property is not nullable for class PollWeek.");

            return new PollWeek(season.Value!.Value!, seasonType.Value!.Value!, week.Value!.Value!, polls.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="PollWeek" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="pollWeek"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PollWeek pollWeek, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, pollWeek, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PollWeek" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="pollWeek"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PollWeek pollWeek, JsonSerializerOptions jsonSerializerOptions)
        {
            if (pollWeek.Polls == null)
                throw new ArgumentNullException(nameof(pollWeek.Polls), "Property is required for class PollWeek.");

            writer.WriteNumber("season", pollWeek.Season);

            var seasonTypeRawValue = SeasonTypeValueConverter.ToJsonValue(pollWeek.SeasonType);
            writer.WriteString("seasonType", seasonTypeRawValue);

            writer.WriteNumber("week", pollWeek.Week);

            writer.WritePropertyName("polls");
            JsonSerializer.Serialize(writer, pollWeek.Polls, jsonSerializerOptions);
        }
    }
}

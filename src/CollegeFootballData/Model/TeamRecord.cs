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
    /// TeamRecord
    /// </summary>
    public partial class TeamRecord : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRecord" /> class.
        /// </summary>
        /// <param name="games">games</param>
        /// <param name="wins">wins</param>
        /// <param name="losses">losses</param>
        /// <param name="ties">ties</param>
        [JsonConstructor]
        public TeamRecord(int games, int wins, int losses, int ties)
        {
            Games = games;
            Wins = wins;
            Losses = losses;
            Ties = ties;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Games
        /// </summary>
        [JsonPropertyName("games")]
        public int Games { get; set; }

        /// <summary>
        /// Gets or Sets Wins
        /// </summary>
        [JsonPropertyName("wins")]
        public int Wins { get; set; }

        /// <summary>
        /// Gets or Sets Losses
        /// </summary>
        [JsonPropertyName("losses")]
        public int Losses { get; set; }

        /// <summary>
        /// Gets or Sets Ties
        /// </summary>
        [JsonPropertyName("ties")]
        public int Ties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamRecord {\n");
            sb.Append("  Games: ").Append(Games).Append("\n");
            sb.Append("  Wins: ").Append(Wins).Append("\n");
            sb.Append("  Losses: ").Append(Losses).Append("\n");
            sb.Append("  Ties: ").Append(Ties).Append("\n");
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
    /// A Json converter for type <see cref="TeamRecord" />
    /// </summary>
    public class TeamRecordJsonConverter : JsonConverter<TeamRecord>
    {
        /// <summary>
        /// Deserializes json to <see cref="TeamRecord" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TeamRecord Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> games = default;
            Option<int?> wins = default;
            Option<int?> losses = default;
            Option<int?> ties = default;

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
                        case "games":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                games = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "wins":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                wins = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "losses":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                losses = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "ties":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                ties = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!games.IsSet)
                throw new ArgumentException("Property is required for class TeamRecord.", nameof(games));

            if (!wins.IsSet)
                throw new ArgumentException("Property is required for class TeamRecord.", nameof(wins));

            if (!losses.IsSet)
                throw new ArgumentException("Property is required for class TeamRecord.", nameof(losses));

            if (!ties.IsSet)
                throw new ArgumentException("Property is required for class TeamRecord.", nameof(ties));

            if (games.IsSet && games.Value == null)
                throw new ArgumentNullException(nameof(games), "Property is not nullable for class TeamRecord.");

            if (wins.IsSet && wins.Value == null)
                throw new ArgumentNullException(nameof(wins), "Property is not nullable for class TeamRecord.");

            if (losses.IsSet && losses.Value == null)
                throw new ArgumentNullException(nameof(losses), "Property is not nullable for class TeamRecord.");

            if (ties.IsSet && ties.Value == null)
                throw new ArgumentNullException(nameof(ties), "Property is not nullable for class TeamRecord.");

            return new TeamRecord(games.Value!.Value!, wins.Value!.Value!, losses.Value!.Value!, ties.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="TeamRecord" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamRecord"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TeamRecord teamRecord, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, teamRecord, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TeamRecord" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamRecord"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TeamRecord teamRecord, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("games", teamRecord.Games);

            writer.WriteNumber("wins", teamRecord.Wins);

            writer.WriteNumber("losses", teamRecord.Losses);

            writer.WriteNumber("ties", teamRecord.Ties);
        }
    }
}

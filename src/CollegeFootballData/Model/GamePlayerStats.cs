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
    /// GamePlayerStats
    /// </summary>
    public partial class GamePlayerStats : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GamePlayerStats" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="teams">teams</param>
        [JsonConstructor]
        public GamePlayerStats(int id, List<GamePlayerStatsTeam> teams)
        {
            Id = id;
            Teams = teams;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [JsonPropertyName("teams")]
        public List<GamePlayerStatsTeam> Teams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GamePlayerStats {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
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
    /// A Json converter for type <see cref="GamePlayerStats" />
    /// </summary>
    public class GamePlayerStatsJsonConverter : JsonConverter<GamePlayerStats>
    {
        /// <summary>
        /// Deserializes json to <see cref="GamePlayerStats" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GamePlayerStats Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> id = default;
            Option<List<GamePlayerStatsTeam>?> teams = default;

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
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "teams":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                teams = new Option<List<GamePlayerStatsTeam>?>(JsonSerializer.Deserialize<List<GamePlayerStatsTeam>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class GamePlayerStats.", nameof(id));

            if (!teams.IsSet)
                throw new ArgumentException("Property is required for class GamePlayerStats.", nameof(teams));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class GamePlayerStats.");

            if (teams.IsSet && teams.Value == null)
                throw new ArgumentNullException(nameof(teams), "Property is not nullable for class GamePlayerStats.");

            return new GamePlayerStats(id.Value!.Value!, teams.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GamePlayerStats" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gamePlayerStats"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GamePlayerStats gamePlayerStats, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, gamePlayerStats, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GamePlayerStats" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gamePlayerStats"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GamePlayerStats gamePlayerStats, JsonSerializerOptions jsonSerializerOptions)
        {
            if (gamePlayerStats.Teams == null)
                throw new ArgumentNullException(nameof(gamePlayerStats.Teams), "Property is required for class GamePlayerStats.");

            writer.WriteNumber("id", gamePlayerStats.Id);

            writer.WritePropertyName("teams");
            JsonSerializer.Serialize(writer, gamePlayerStats.Teams, jsonSerializerOptions);
        }
    }
}

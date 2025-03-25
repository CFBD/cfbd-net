// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.9
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
    /// GameTeamStatsTeamStat
    /// </summary>
    public partial class GameTeamStatsTeamStat : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameTeamStatsTeamStat" /> class.
        /// </summary>
        /// <param name="category">category</param>
        /// <param name="stat">stat</param>
        [JsonConstructor]
        public GameTeamStatsTeamStat(string category, string stat)
        {
            Category = category;
            Stat = stat;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Stat
        /// </summary>
        [JsonPropertyName("stat")]
        public string Stat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GameTeamStatsTeamStat {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Stat: ").Append(Stat).Append("\n");
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
    /// A Json converter for type <see cref="GameTeamStatsTeamStat" />
    /// </summary>
    public class GameTeamStatsTeamStatJsonConverter : JsonConverter<GameTeamStatsTeamStat>
    {
        /// <summary>
        /// Deserializes json to <see cref="GameTeamStatsTeamStat" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GameTeamStatsTeamStat Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> category = default;
            Option<string?> stat = default;

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
                        case "category":
                            category = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "stat":
                            stat = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!category.IsSet)
                throw new ArgumentException("Property is required for class GameTeamStatsTeamStat.", nameof(category));

            if (!stat.IsSet)
                throw new ArgumentException("Property is required for class GameTeamStatsTeamStat.", nameof(stat));

            if (category.IsSet && category.Value == null)
                throw new ArgumentNullException(nameof(category), "Property is not nullable for class GameTeamStatsTeamStat.");

            if (stat.IsSet && stat.Value == null)
                throw new ArgumentNullException(nameof(stat), "Property is not nullable for class GameTeamStatsTeamStat.");

            return new GameTeamStatsTeamStat(category.Value!, stat.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GameTeamStatsTeamStat" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gameTeamStatsTeamStat"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GameTeamStatsTeamStat gameTeamStatsTeamStat, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, gameTeamStatsTeamStat, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GameTeamStatsTeamStat" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gameTeamStatsTeamStat"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GameTeamStatsTeamStat gameTeamStatsTeamStat, JsonSerializerOptions jsonSerializerOptions)
        {
            if (gameTeamStatsTeamStat.Category == null)
                throw new ArgumentNullException(nameof(gameTeamStatsTeamStat.Category), "Property is required for class GameTeamStatsTeamStat.");

            if (gameTeamStatsTeamStat.Stat == null)
                throw new ArgumentNullException(nameof(gameTeamStatsTeamStat.Stat), "Property is required for class GameTeamStatsTeamStat.");

            writer.WriteString("category", gameTeamStatsTeamStat.Category);

            writer.WriteString("stat", gameTeamStatsTeamStat.Stat);
        }
    }
}

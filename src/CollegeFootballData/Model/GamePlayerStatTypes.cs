// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.7.0
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
    /// GamePlayerStatTypes
    /// </summary>
    public partial class GamePlayerStatTypes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GamePlayerStatTypes" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="athletes">athletes</param>
        [JsonConstructor]
        public GamePlayerStatTypes(string name, List<GamePlayerStatPlayer> athletes)
        {
            Name = name;
            Athletes = athletes;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Athletes
        /// </summary>
        [JsonPropertyName("athletes")]
        public List<GamePlayerStatPlayer> Athletes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GamePlayerStatTypes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Athletes: ").Append(Athletes).Append("\n");
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
    /// A Json converter for type <see cref="GamePlayerStatTypes" />
    /// </summary>
    public class GamePlayerStatTypesJsonConverter : JsonConverter<GamePlayerStatTypes>
    {
        /// <summary>
        /// Deserializes json to <see cref="GamePlayerStatTypes" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GamePlayerStatTypes Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;
            Option<List<GamePlayerStatPlayer>?> athletes = default;

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
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "athletes":
                            athletes = new Option<List<GamePlayerStatPlayer>?>(JsonSerializer.Deserialize<List<GamePlayerStatPlayer>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class GamePlayerStatTypes.", nameof(name));

            if (!athletes.IsSet)
                throw new ArgumentException("Property is required for class GamePlayerStatTypes.", nameof(athletes));

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class GamePlayerStatTypes.");

            if (athletes.IsSet && athletes.Value == null)
                throw new ArgumentNullException(nameof(athletes), "Property is not nullable for class GamePlayerStatTypes.");

            return new GamePlayerStatTypes(name.Value!, athletes.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GamePlayerStatTypes" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gamePlayerStatTypes"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GamePlayerStatTypes gamePlayerStatTypes, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, gamePlayerStatTypes, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GamePlayerStatTypes" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gamePlayerStatTypes"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GamePlayerStatTypes gamePlayerStatTypes, JsonSerializerOptions jsonSerializerOptions)
        {
            if (gamePlayerStatTypes.Name == null)
                throw new ArgumentNullException(nameof(gamePlayerStatTypes.Name), "Property is required for class GamePlayerStatTypes.");

            if (gamePlayerStatTypes.Athletes == null)
                throw new ArgumentNullException(nameof(gamePlayerStatTypes.Athletes), "Property is required for class GamePlayerStatTypes.");

            writer.WriteString("name", gamePlayerStatTypes.Name);

            writer.WritePropertyName("athletes");
            JsonSerializer.Serialize(writer, gamePlayerStatTypes.Athletes, jsonSerializerOptions);
        }
    }
}

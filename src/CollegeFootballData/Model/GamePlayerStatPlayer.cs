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
    /// GamePlayerStatPlayer
    /// </summary>
    public partial class GamePlayerStatPlayer : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GamePlayerStatPlayer" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">name</param>
        /// <param name="stat">stat</param>
        [JsonConstructor]
        public GamePlayerStatPlayer(string id, string name, string stat)
        {
            Id = id;
            Name = name;
            Stat = stat;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

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
            sb.Append("class GamePlayerStatPlayer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
    /// A Json converter for type <see cref="GamePlayerStatPlayer" />
    /// </summary>
    public class GamePlayerStatPlayerJsonConverter : JsonConverter<GamePlayerStatPlayer>
    {
        /// <summary>
        /// Deserializes json to <see cref="GamePlayerStatPlayer" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GamePlayerStatPlayer Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<string?> name = default;
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
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "stat":
                            stat = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class GamePlayerStatPlayer.", nameof(id));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class GamePlayerStatPlayer.", nameof(name));

            if (!stat.IsSet)
                throw new ArgumentException("Property is required for class GamePlayerStatPlayer.", nameof(stat));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class GamePlayerStatPlayer.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class GamePlayerStatPlayer.");

            if (stat.IsSet && stat.Value == null)
                throw new ArgumentNullException(nameof(stat), "Property is not nullable for class GamePlayerStatPlayer.");

            return new GamePlayerStatPlayer(id.Value!, name.Value!, stat.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GamePlayerStatPlayer" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gamePlayerStatPlayer"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GamePlayerStatPlayer gamePlayerStatPlayer, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, gamePlayerStatPlayer, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GamePlayerStatPlayer" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gamePlayerStatPlayer"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GamePlayerStatPlayer gamePlayerStatPlayer, JsonSerializerOptions jsonSerializerOptions)
        {
            if (gamePlayerStatPlayer.Id == null)
                throw new ArgumentNullException(nameof(gamePlayerStatPlayer.Id), "Property is required for class GamePlayerStatPlayer.");

            if (gamePlayerStatPlayer.Name == null)
                throw new ArgumentNullException(nameof(gamePlayerStatPlayer.Name), "Property is required for class GamePlayerStatPlayer.");

            if (gamePlayerStatPlayer.Stat == null)
                throw new ArgumentNullException(nameof(gamePlayerStatPlayer.Stat), "Property is required for class GamePlayerStatPlayer.");

            writer.WriteString("id", gamePlayerStatPlayer.Id);

            writer.WriteString("name", gamePlayerStatPlayer.Name);

            writer.WriteString("stat", gamePlayerStatPlayer.Stat);
        }
    }
}

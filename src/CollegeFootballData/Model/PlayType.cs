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
    /// PlayType
    /// </summary>
    public partial class PlayType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayType" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="text">text</param>
        /// <param name="abbreviation">abbreviation</param>
        [JsonConstructor]
        public PlayType(int id, string text, string? abbreviation = default)
        {
            Id = id;
            Text = text;
            Abbreviation = abbreviation;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Abbreviation
        /// </summary>
        [JsonPropertyName("abbreviation")]
        public string? Abbreviation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
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
    /// A Json converter for type <see cref="PlayType" />
    /// </summary>
    public class PlayTypeJsonConverter : JsonConverter<PlayType>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayType" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayType Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> id = default;
            Option<string?> text = default;
            Option<string?> abbreviation = default;

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
                        case "text":
                            text = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "abbreviation":
                            abbreviation = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class PlayType.", nameof(id));

            if (!text.IsSet)
                throw new ArgumentException("Property is required for class PlayType.", nameof(text));

            if (!abbreviation.IsSet)
                throw new ArgumentException("Property is required for class PlayType.", nameof(abbreviation));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class PlayType.");

            if (text.IsSet && text.Value == null)
                throw new ArgumentNullException(nameof(text), "Property is not nullable for class PlayType.");

            return new PlayType(id.Value!.Value!, text.Value!, abbreviation.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="PlayType" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playType"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayType playType, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playType, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayType" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playType"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayType playType, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playType.Text == null)
                throw new ArgumentNullException(nameof(playType.Text), "Property is required for class PlayType.");

            writer.WriteNumber("id", playType.Id);

            writer.WriteString("text", playType.Text);

            if (playType.Abbreviation != null)
                writer.WriteString("abbreviation", playType.Abbreviation);
            else
                writer.WriteNull("abbreviation");
        }
    }
}

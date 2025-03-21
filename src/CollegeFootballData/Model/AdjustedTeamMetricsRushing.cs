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
    /// AdjustedTeamMetricsRushing
    /// </summary>
    public partial class AdjustedTeamMetricsRushing : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdjustedTeamMetricsRushing" /> class.
        /// </summary>
        /// <param name="highlightYards">highlightYards</param>
        /// <param name="openFieldYards">openFieldYards</param>
        /// <param name="secondLevelYards">secondLevelYards</param>
        /// <param name="lineYards">lineYards</param>
        [JsonConstructor]
        public AdjustedTeamMetricsRushing(double highlightYards, double openFieldYards, double secondLevelYards, double lineYards)
        {
            HighlightYards = highlightYards;
            OpenFieldYards = openFieldYards;
            SecondLevelYards = secondLevelYards;
            LineYards = lineYards;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets HighlightYards
        /// </summary>
        [JsonPropertyName("highlightYards")]
        public double HighlightYards { get; set; }

        /// <summary>
        /// Gets or Sets OpenFieldYards
        /// </summary>
        [JsonPropertyName("openFieldYards")]
        public double OpenFieldYards { get; set; }

        /// <summary>
        /// Gets or Sets SecondLevelYards
        /// </summary>
        [JsonPropertyName("secondLevelYards")]
        public double SecondLevelYards { get; set; }

        /// <summary>
        /// Gets or Sets LineYards
        /// </summary>
        [JsonPropertyName("lineYards")]
        public double LineYards { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdjustedTeamMetricsRushing {\n");
            sb.Append("  HighlightYards: ").Append(HighlightYards).Append("\n");
            sb.Append("  OpenFieldYards: ").Append(OpenFieldYards).Append("\n");
            sb.Append("  SecondLevelYards: ").Append(SecondLevelYards).Append("\n");
            sb.Append("  LineYards: ").Append(LineYards).Append("\n");
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
    /// A Json converter for type <see cref="AdjustedTeamMetricsRushing" />
    /// </summary>
    public class AdjustedTeamMetricsRushingJsonConverter : JsonConverter<AdjustedTeamMetricsRushing>
    {
        /// <summary>
        /// Deserializes json to <see cref="AdjustedTeamMetricsRushing" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AdjustedTeamMetricsRushing Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double?> highlightYards = default;
            Option<double?> openFieldYards = default;
            Option<double?> secondLevelYards = default;
            Option<double?> lineYards = default;

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
                        case "highlightYards":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                highlightYards = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "openFieldYards":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                openFieldYards = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "secondLevelYards":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                secondLevelYards = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "lineYards":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lineYards = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!highlightYards.IsSet)
                throw new ArgumentException("Property is required for class AdjustedTeamMetricsRushing.", nameof(highlightYards));

            if (!openFieldYards.IsSet)
                throw new ArgumentException("Property is required for class AdjustedTeamMetricsRushing.", nameof(openFieldYards));

            if (!secondLevelYards.IsSet)
                throw new ArgumentException("Property is required for class AdjustedTeamMetricsRushing.", nameof(secondLevelYards));

            if (!lineYards.IsSet)
                throw new ArgumentException("Property is required for class AdjustedTeamMetricsRushing.", nameof(lineYards));

            if (highlightYards.IsSet && highlightYards.Value == null)
                throw new ArgumentNullException(nameof(highlightYards), "Property is not nullable for class AdjustedTeamMetricsRushing.");

            if (openFieldYards.IsSet && openFieldYards.Value == null)
                throw new ArgumentNullException(nameof(openFieldYards), "Property is not nullable for class AdjustedTeamMetricsRushing.");

            if (secondLevelYards.IsSet && secondLevelYards.Value == null)
                throw new ArgumentNullException(nameof(secondLevelYards), "Property is not nullable for class AdjustedTeamMetricsRushing.");

            if (lineYards.IsSet && lineYards.Value == null)
                throw new ArgumentNullException(nameof(lineYards), "Property is not nullable for class AdjustedTeamMetricsRushing.");

            return new AdjustedTeamMetricsRushing(highlightYards.Value!.Value!, openFieldYards.Value!.Value!, secondLevelYards.Value!.Value!, lineYards.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AdjustedTeamMetricsRushing" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="adjustedTeamMetricsRushing"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AdjustedTeamMetricsRushing adjustedTeamMetricsRushing, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, adjustedTeamMetricsRushing, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AdjustedTeamMetricsRushing" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="adjustedTeamMetricsRushing"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AdjustedTeamMetricsRushing adjustedTeamMetricsRushing, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("highlightYards", adjustedTeamMetricsRushing.HighlightYards);

            writer.WriteNumber("openFieldYards", adjustedTeamMetricsRushing.OpenFieldYards);

            writer.WriteNumber("secondLevelYards", adjustedTeamMetricsRushing.SecondLevelYards);

            writer.WriteNumber("lineYards", adjustedTeamMetricsRushing.LineYards);
        }
    }
}

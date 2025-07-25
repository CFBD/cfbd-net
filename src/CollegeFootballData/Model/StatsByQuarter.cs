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
    /// StatsByQuarter
    /// </summary>
    public partial class StatsByQuarter : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatsByQuarter" /> class.
        /// </summary>
        /// <param name="total">total</param>
        /// <param name="quarter1">quarter1</param>
        /// <param name="quarter2">quarter2</param>
        /// <param name="quarter3">quarter3</param>
        /// <param name="quarter4">quarter4</param>
        [JsonConstructor]
        public StatsByQuarter(double total, double? quarter1 = default, double? quarter2 = default, double? quarter3 = default, double? quarter4 = default)
        {
            Total = total;
            Quarter1 = quarter1;
            Quarter2 = quarter2;
            Quarter3 = quarter3;
            Quarter4 = quarter4;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [JsonPropertyName("total")]
        public double Total { get; set; }

        /// <summary>
        /// Gets or Sets Quarter1
        /// </summary>
        [JsonPropertyName("quarter1")]
        public double? Quarter1 { get; set; }

        /// <summary>
        /// Gets or Sets Quarter2
        /// </summary>
        [JsonPropertyName("quarter2")]
        public double? Quarter2 { get; set; }

        /// <summary>
        /// Gets or Sets Quarter3
        /// </summary>
        [JsonPropertyName("quarter3")]
        public double? Quarter3 { get; set; }

        /// <summary>
        /// Gets or Sets Quarter4
        /// </summary>
        [JsonPropertyName("quarter4")]
        public double? Quarter4 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StatsByQuarter {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Quarter1: ").Append(Quarter1).Append("\n");
            sb.Append("  Quarter2: ").Append(Quarter2).Append("\n");
            sb.Append("  Quarter3: ").Append(Quarter3).Append("\n");
            sb.Append("  Quarter4: ").Append(Quarter4).Append("\n");
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
    /// A Json converter for type <see cref="StatsByQuarter" />
    /// </summary>
    public class StatsByQuarterJsonConverter : JsonConverter<StatsByQuarter>
    {
        /// <summary>
        /// Deserializes json to <see cref="StatsByQuarter" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override StatsByQuarter Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double?> total = default;
            Option<double?> quarter1 = default;
            Option<double?> quarter2 = default;
            Option<double?> quarter3 = default;
            Option<double?> quarter4 = default;

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
                        case "total":
                            total = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "quarter1":
                            quarter1 = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "quarter2":
                            quarter2 = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "quarter3":
                            quarter3 = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "quarter4":
                            quarter4 = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!total.IsSet)
                throw new ArgumentException("Property is required for class StatsByQuarter.", nameof(total));

            if (!quarter1.IsSet)
                throw new ArgumentException("Property is required for class StatsByQuarter.", nameof(quarter1));

            if (!quarter2.IsSet)
                throw new ArgumentException("Property is required for class StatsByQuarter.", nameof(quarter2));

            if (!quarter3.IsSet)
                throw new ArgumentException("Property is required for class StatsByQuarter.", nameof(quarter3));

            if (!quarter4.IsSet)
                throw new ArgumentException("Property is required for class StatsByQuarter.", nameof(quarter4));

            if (total.IsSet && total.Value == null)
                throw new ArgumentNullException(nameof(total), "Property is not nullable for class StatsByQuarter.");

            return new StatsByQuarter(total.Value!.Value!, quarter1.Value!, quarter2.Value!, quarter3.Value!, quarter4.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="StatsByQuarter" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="statsByQuarter"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, StatsByQuarter statsByQuarter, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, statsByQuarter, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="StatsByQuarter" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="statsByQuarter"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, StatsByQuarter statsByQuarter, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("total", statsByQuarter.Total);

            if (statsByQuarter.Quarter1 != null)
                writer.WriteNumber("quarter1", statsByQuarter.Quarter1.Value);
            else
                writer.WriteNull("quarter1");

            if (statsByQuarter.Quarter2 != null)
                writer.WriteNumber("quarter2", statsByQuarter.Quarter2.Value);
            else
                writer.WriteNull("quarter2");

            if (statsByQuarter.Quarter3 != null)
                writer.WriteNumber("quarter3", statsByQuarter.Quarter3.Value);
            else
                writer.WriteNull("quarter3");

            if (statsByQuarter.Quarter4 != null)
                writer.WriteNumber("quarter4", statsByQuarter.Quarter4.Value);
            else
                writer.WriteNull("quarter4");
        }
    }
}

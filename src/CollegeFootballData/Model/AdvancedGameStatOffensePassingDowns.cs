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
    /// AdvancedGameStatOffensePassingDowns
    /// </summary>
    public partial class AdvancedGameStatOffensePassingDowns : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedGameStatOffensePassingDowns" /> class.
        /// </summary>
        /// <param name="explosiveness">explosiveness</param>
        /// <param name="successRate">successRate</param>
        /// <param name="ppa">ppa</param>
        [JsonConstructor]
        public AdvancedGameStatOffensePassingDowns(double explosiveness, double successRate, double ppa)
        {
            Explosiveness = explosiveness;
            SuccessRate = successRate;
            Ppa = ppa;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Explosiveness
        /// </summary>
        [JsonPropertyName("explosiveness")]
        public double Explosiveness { get; set; }

        /// <summary>
        /// Gets or Sets SuccessRate
        /// </summary>
        [JsonPropertyName("successRate")]
        public double SuccessRate { get; set; }

        /// <summary>
        /// Gets or Sets Ppa
        /// </summary>
        [JsonPropertyName("ppa")]
        public double Ppa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdvancedGameStatOffensePassingDowns {\n");
            sb.Append("  Explosiveness: ").Append(Explosiveness).Append("\n");
            sb.Append("  SuccessRate: ").Append(SuccessRate).Append("\n");
            sb.Append("  Ppa: ").Append(Ppa).Append("\n");
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
    /// A Json converter for type <see cref="AdvancedGameStatOffensePassingDowns" />
    /// </summary>
    public class AdvancedGameStatOffensePassingDownsJsonConverter : JsonConverter<AdvancedGameStatOffensePassingDowns>
    {
        /// <summary>
        /// Deserializes json to <see cref="AdvancedGameStatOffensePassingDowns" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AdvancedGameStatOffensePassingDowns Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double?> explosiveness = default;
            Option<double?> successRate = default;
            Option<double?> ppa = default;

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
                        case "explosiveness":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                explosiveness = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "successRate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                successRate = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "ppa":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                ppa = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!explosiveness.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffensePassingDowns.", nameof(explosiveness));

            if (!successRate.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffensePassingDowns.", nameof(successRate));

            if (!ppa.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffensePassingDowns.", nameof(ppa));

            if (explosiveness.IsSet && explosiveness.Value == null)
                throw new ArgumentNullException(nameof(explosiveness), "Property is not nullable for class AdvancedGameStatOffensePassingDowns.");

            if (successRate.IsSet && successRate.Value == null)
                throw new ArgumentNullException(nameof(successRate), "Property is not nullable for class AdvancedGameStatOffensePassingDowns.");

            if (ppa.IsSet && ppa.Value == null)
                throw new ArgumentNullException(nameof(ppa), "Property is not nullable for class AdvancedGameStatOffensePassingDowns.");

            return new AdvancedGameStatOffensePassingDowns(explosiveness.Value!.Value!, successRate.Value!.Value!, ppa.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AdvancedGameStatOffensePassingDowns" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedGameStatOffensePassingDowns"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AdvancedGameStatOffensePassingDowns advancedGameStatOffensePassingDowns, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, advancedGameStatOffensePassingDowns, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AdvancedGameStatOffensePassingDowns" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedGameStatOffensePassingDowns"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AdvancedGameStatOffensePassingDowns advancedGameStatOffensePassingDowns, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("explosiveness", advancedGameStatOffensePassingDowns.Explosiveness);

            writer.WriteNumber("successRate", advancedGameStatOffensePassingDowns.SuccessRate);

            writer.WriteNumber("ppa", advancedGameStatOffensePassingDowns.Ppa);
        }
    }
}

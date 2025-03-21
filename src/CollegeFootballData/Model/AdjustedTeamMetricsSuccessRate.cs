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
    /// AdjustedTeamMetricsSuccessRate
    /// </summary>
    public partial class AdjustedTeamMetricsSuccessRate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdjustedTeamMetricsSuccessRate" /> class.
        /// </summary>
        /// <param name="passingDowns">passingDowns</param>
        /// <param name="standardDowns">standardDowns</param>
        /// <param name="total">total</param>
        [JsonConstructor]
        public AdjustedTeamMetricsSuccessRate(double passingDowns, double standardDowns, double total)
        {
            PassingDowns = passingDowns;
            StandardDowns = standardDowns;
            Total = total;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets PassingDowns
        /// </summary>
        [JsonPropertyName("passingDowns")]
        public double PassingDowns { get; set; }

        /// <summary>
        /// Gets or Sets StandardDowns
        /// </summary>
        [JsonPropertyName("standardDowns")]
        public double StandardDowns { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [JsonPropertyName("total")]
        public double Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdjustedTeamMetricsSuccessRate {\n");
            sb.Append("  PassingDowns: ").Append(PassingDowns).Append("\n");
            sb.Append("  StandardDowns: ").Append(StandardDowns).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
    /// A Json converter for type <see cref="AdjustedTeamMetricsSuccessRate" />
    /// </summary>
    public class AdjustedTeamMetricsSuccessRateJsonConverter : JsonConverter<AdjustedTeamMetricsSuccessRate>
    {
        /// <summary>
        /// Deserializes json to <see cref="AdjustedTeamMetricsSuccessRate" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AdjustedTeamMetricsSuccessRate Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double?> passingDowns = default;
            Option<double?> standardDowns = default;
            Option<double?> total = default;

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
                        case "passingDowns":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                passingDowns = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "standardDowns":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                standardDowns = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "total":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                total = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!passingDowns.IsSet)
                throw new ArgumentException("Property is required for class AdjustedTeamMetricsSuccessRate.", nameof(passingDowns));

            if (!standardDowns.IsSet)
                throw new ArgumentException("Property is required for class AdjustedTeamMetricsSuccessRate.", nameof(standardDowns));

            if (!total.IsSet)
                throw new ArgumentException("Property is required for class AdjustedTeamMetricsSuccessRate.", nameof(total));

            if (passingDowns.IsSet && passingDowns.Value == null)
                throw new ArgumentNullException(nameof(passingDowns), "Property is not nullable for class AdjustedTeamMetricsSuccessRate.");

            if (standardDowns.IsSet && standardDowns.Value == null)
                throw new ArgumentNullException(nameof(standardDowns), "Property is not nullable for class AdjustedTeamMetricsSuccessRate.");

            if (total.IsSet && total.Value == null)
                throw new ArgumentNullException(nameof(total), "Property is not nullable for class AdjustedTeamMetricsSuccessRate.");

            return new AdjustedTeamMetricsSuccessRate(passingDowns.Value!.Value!, standardDowns.Value!.Value!, total.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AdjustedTeamMetricsSuccessRate" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="adjustedTeamMetricsSuccessRate"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AdjustedTeamMetricsSuccessRate adjustedTeamMetricsSuccessRate, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, adjustedTeamMetricsSuccessRate, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AdjustedTeamMetricsSuccessRate" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="adjustedTeamMetricsSuccessRate"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AdjustedTeamMetricsSuccessRate adjustedTeamMetricsSuccessRate, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("passingDowns", adjustedTeamMetricsSuccessRate.PassingDowns);

            writer.WriteNumber("standardDowns", adjustedTeamMetricsSuccessRate.StandardDowns);

            writer.WriteNumber("total", adjustedTeamMetricsSuccessRate.Total);
        }
    }
}

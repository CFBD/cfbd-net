// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.10
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
    /// AdjustedTeamMetricsEpa
    /// </summary>
    public partial class AdjustedTeamMetricsEpa : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdjustedTeamMetricsEpa" /> class.
        /// </summary>
        /// <param name="rushing">rushing</param>
        /// <param name="passing">passing</param>
        /// <param name="total">total</param>
        [JsonConstructor]
        public AdjustedTeamMetricsEpa(double rushing, double passing, double total)
        {
            Rushing = rushing;
            Passing = passing;
            Total = total;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Rushing
        /// </summary>
        [JsonPropertyName("rushing")]
        public double Rushing { get; set; }

        /// <summary>
        /// Gets or Sets Passing
        /// </summary>
        [JsonPropertyName("passing")]
        public double Passing { get; set; }

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
            sb.Append("class AdjustedTeamMetricsEpa {\n");
            sb.Append("  Rushing: ").Append(Rushing).Append("\n");
            sb.Append("  Passing: ").Append(Passing).Append("\n");
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
    /// A Json converter for type <see cref="AdjustedTeamMetricsEpa" />
    /// </summary>
    public class AdjustedTeamMetricsEpaJsonConverter : JsonConverter<AdjustedTeamMetricsEpa>
    {
        /// <summary>
        /// Deserializes json to <see cref="AdjustedTeamMetricsEpa" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AdjustedTeamMetricsEpa Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double?> rushing = default;
            Option<double?> passing = default;
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
                        case "rushing":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rushing = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "passing":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                passing = new Option<double?>(utf8JsonReader.GetDouble());
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

            if (!rushing.IsSet)
                throw new ArgumentException("Property is required for class AdjustedTeamMetricsEpa.", nameof(rushing));

            if (!passing.IsSet)
                throw new ArgumentException("Property is required for class AdjustedTeamMetricsEpa.", nameof(passing));

            if (!total.IsSet)
                throw new ArgumentException("Property is required for class AdjustedTeamMetricsEpa.", nameof(total));

            if (rushing.IsSet && rushing.Value == null)
                throw new ArgumentNullException(nameof(rushing), "Property is not nullable for class AdjustedTeamMetricsEpa.");

            if (passing.IsSet && passing.Value == null)
                throw new ArgumentNullException(nameof(passing), "Property is not nullable for class AdjustedTeamMetricsEpa.");

            if (total.IsSet && total.Value == null)
                throw new ArgumentNullException(nameof(total), "Property is not nullable for class AdjustedTeamMetricsEpa.");

            return new AdjustedTeamMetricsEpa(rushing.Value!.Value!, passing.Value!.Value!, total.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AdjustedTeamMetricsEpa" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="adjustedTeamMetricsEpa"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AdjustedTeamMetricsEpa adjustedTeamMetricsEpa, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, adjustedTeamMetricsEpa, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AdjustedTeamMetricsEpa" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="adjustedTeamMetricsEpa"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AdjustedTeamMetricsEpa adjustedTeamMetricsEpa, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("rushing", adjustedTeamMetricsEpa.Rushing);

            writer.WriteNumber("passing", adjustedTeamMetricsEpa.Passing);

            writer.WriteNumber("total", adjustedTeamMetricsEpa.Total);
        }
    }
}

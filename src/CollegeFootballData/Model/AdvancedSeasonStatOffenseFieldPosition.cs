// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.7
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
    /// AdvancedSeasonStatOffenseFieldPosition
    /// </summary>
    public partial class AdvancedSeasonStatOffenseFieldPosition : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedSeasonStatOffenseFieldPosition" /> class.
        /// </summary>
        /// <param name="averagePredictedPoints">averagePredictedPoints</param>
        /// <param name="averageStart">averageStart</param>
        [JsonConstructor]
        public AdvancedSeasonStatOffenseFieldPosition(double? averagePredictedPoints = default, double? averageStart = default)
        {
            AveragePredictedPoints = averagePredictedPoints;
            AverageStart = averageStart;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets AveragePredictedPoints
        /// </summary>
        [JsonPropertyName("averagePredictedPoints")]
        public double? AveragePredictedPoints { get; set; }

        /// <summary>
        /// Gets or Sets AverageStart
        /// </summary>
        [JsonPropertyName("averageStart")]
        public double? AverageStart { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdvancedSeasonStatOffenseFieldPosition {\n");
            sb.Append("  AveragePredictedPoints: ").Append(AveragePredictedPoints).Append("\n");
            sb.Append("  AverageStart: ").Append(AverageStart).Append("\n");
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
    /// A Json converter for type <see cref="AdvancedSeasonStatOffenseFieldPosition" />
    /// </summary>
    public class AdvancedSeasonStatOffenseFieldPositionJsonConverter : JsonConverter<AdvancedSeasonStatOffenseFieldPosition>
    {
        /// <summary>
        /// Deserializes json to <see cref="AdvancedSeasonStatOffenseFieldPosition" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AdvancedSeasonStatOffenseFieldPosition Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double?> averagePredictedPoints = default;
            Option<double?> averageStart = default;

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
                        case "averagePredictedPoints":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                averagePredictedPoints = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "averageStart":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                averageStart = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!averagePredictedPoints.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffenseFieldPosition.", nameof(averagePredictedPoints));

            if (!averageStart.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffenseFieldPosition.", nameof(averageStart));

            return new AdvancedSeasonStatOffenseFieldPosition(averagePredictedPoints.Value!, averageStart.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AdvancedSeasonStatOffenseFieldPosition" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedSeasonStatOffenseFieldPosition"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AdvancedSeasonStatOffenseFieldPosition advancedSeasonStatOffenseFieldPosition, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, advancedSeasonStatOffenseFieldPosition, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AdvancedSeasonStatOffenseFieldPosition" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedSeasonStatOffenseFieldPosition"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AdvancedSeasonStatOffenseFieldPosition advancedSeasonStatOffenseFieldPosition, JsonSerializerOptions jsonSerializerOptions)
        {
            if (advancedSeasonStatOffenseFieldPosition.AveragePredictedPoints != null)
                writer.WriteNumber("averagePredictedPoints", advancedSeasonStatOffenseFieldPosition.AveragePredictedPoints.Value);
            else
                writer.WriteNull("averagePredictedPoints");

            if (advancedSeasonStatOffenseFieldPosition.AverageStart != null)
                writer.WriteNumber("averageStart", advancedSeasonStatOffenseFieldPosition.AverageStart.Value);
            else
                writer.WriteNull("averageStart");
        }
    }
}

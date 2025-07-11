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
    /// FieldGoalEP
    /// </summary>
    public partial class FieldGoalEP : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldGoalEP" /> class.
        /// </summary>
        /// <param name="yardsToGoal">yardsToGoal</param>
        /// <param name="distance">distance</param>
        /// <param name="expectedPoints">expectedPoints</param>
        [JsonConstructor]
        public FieldGoalEP(int yardsToGoal, int distance, double expectedPoints)
        {
            YardsToGoal = yardsToGoal;
            Distance = distance;
            ExpectedPoints = expectedPoints;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets YardsToGoal
        /// </summary>
        [JsonPropertyName("yardsToGoal")]
        public int YardsToGoal { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [JsonPropertyName("distance")]
        public int Distance { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedPoints
        /// </summary>
        [JsonPropertyName("expectedPoints")]
        public double ExpectedPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FieldGoalEP {\n");
            sb.Append("  YardsToGoal: ").Append(YardsToGoal).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  ExpectedPoints: ").Append(ExpectedPoints).Append("\n");
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
    /// A Json converter for type <see cref="FieldGoalEP" />
    /// </summary>
    public class FieldGoalEPJsonConverter : JsonConverter<FieldGoalEP>
    {
        /// <summary>
        /// Deserializes json to <see cref="FieldGoalEP" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override FieldGoalEP Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> yardsToGoal = default;
            Option<int?> distance = default;
            Option<double?> expectedPoints = default;

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
                        case "yardsToGoal":
                            yardsToGoal = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "distance":
                            distance = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "expectedPoints":
                            expectedPoints = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!yardsToGoal.IsSet)
                throw new ArgumentException("Property is required for class FieldGoalEP.", nameof(yardsToGoal));

            if (!distance.IsSet)
                throw new ArgumentException("Property is required for class FieldGoalEP.", nameof(distance));

            if (!expectedPoints.IsSet)
                throw new ArgumentException("Property is required for class FieldGoalEP.", nameof(expectedPoints));

            if (yardsToGoal.IsSet && yardsToGoal.Value == null)
                throw new ArgumentNullException(nameof(yardsToGoal), "Property is not nullable for class FieldGoalEP.");

            if (distance.IsSet && distance.Value == null)
                throw new ArgumentNullException(nameof(distance), "Property is not nullable for class FieldGoalEP.");

            if (expectedPoints.IsSet && expectedPoints.Value == null)
                throw new ArgumentNullException(nameof(expectedPoints), "Property is not nullable for class FieldGoalEP.");

            return new FieldGoalEP(yardsToGoal.Value!.Value!, distance.Value!.Value!, expectedPoints.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="FieldGoalEP" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fieldGoalEP"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, FieldGoalEP fieldGoalEP, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, fieldGoalEP, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="FieldGoalEP" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fieldGoalEP"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, FieldGoalEP fieldGoalEP, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("yardsToGoal", fieldGoalEP.YardsToGoal);

            writer.WriteNumber("distance", fieldGoalEP.Distance);

            writer.WriteNumber("expectedPoints", fieldGoalEP.ExpectedPoints);
        }
    }
}

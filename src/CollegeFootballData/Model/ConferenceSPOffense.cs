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
    /// ConferenceSPOffense
    /// </summary>
    public partial class ConferenceSPOffense : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceSPOffense" /> class.
        /// </summary>
        /// <param name="rating">rating</param>
        /// <param name="pace">pace</param>
        /// <param name="runRate">runRate</param>
        /// <param name="passingDowns">passingDowns</param>
        /// <param name="standardDowns">standardDowns</param>
        /// <param name="passing">passing</param>
        /// <param name="rushing">rushing</param>
        /// <param name="explosiveness">explosiveness</param>
        /// <param name="success">success</param>
        [JsonConstructor]
        public ConferenceSPOffense(double rating, double? pace = default, double? runRate = default, double? passingDowns = default, double? standardDowns = default, double? passing = default, double? rushing = default, double? explosiveness = default, double? success = default)
        {
            Rating = rating;
            Pace = pace;
            RunRate = runRate;
            PassingDowns = passingDowns;
            StandardDowns = standardDowns;
            Passing = passing;
            Rushing = rushing;
            Explosiveness = explosiveness;
            Success = success;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [JsonPropertyName("rating")]
        public double Rating { get; set; }

        /// <summary>
        /// Gets or Sets Pace
        /// </summary>
        [JsonPropertyName("pace")]
        public double? Pace { get; set; }

        /// <summary>
        /// Gets or Sets RunRate
        /// </summary>
        [JsonPropertyName("runRate")]
        public double? RunRate { get; set; }

        /// <summary>
        /// Gets or Sets PassingDowns
        /// </summary>
        [JsonPropertyName("passingDowns")]
        public double? PassingDowns { get; set; }

        /// <summary>
        /// Gets or Sets StandardDowns
        /// </summary>
        [JsonPropertyName("standardDowns")]
        public double? StandardDowns { get; set; }

        /// <summary>
        /// Gets or Sets Passing
        /// </summary>
        [JsonPropertyName("passing")]
        public double? Passing { get; set; }

        /// <summary>
        /// Gets or Sets Rushing
        /// </summary>
        [JsonPropertyName("rushing")]
        public double? Rushing { get; set; }

        /// <summary>
        /// Gets or Sets Explosiveness
        /// </summary>
        [JsonPropertyName("explosiveness")]
        public double? Explosiveness { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [JsonPropertyName("success")]
        public double? Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConferenceSPOffense {\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Pace: ").Append(Pace).Append("\n");
            sb.Append("  RunRate: ").Append(RunRate).Append("\n");
            sb.Append("  PassingDowns: ").Append(PassingDowns).Append("\n");
            sb.Append("  StandardDowns: ").Append(StandardDowns).Append("\n");
            sb.Append("  Passing: ").Append(Passing).Append("\n");
            sb.Append("  Rushing: ").Append(Rushing).Append("\n");
            sb.Append("  Explosiveness: ").Append(Explosiveness).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
    /// A Json converter for type <see cref="ConferenceSPOffense" />
    /// </summary>
    public class ConferenceSPOffenseJsonConverter : JsonConverter<ConferenceSPOffense>
    {
        /// <summary>
        /// Deserializes json to <see cref="ConferenceSPOffense" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ConferenceSPOffense Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double?> rating = default;
            Option<double?> pace = default;
            Option<double?> runRate = default;
            Option<double?> passingDowns = default;
            Option<double?> standardDowns = default;
            Option<double?> passing = default;
            Option<double?> rushing = default;
            Option<double?> explosiveness = default;
            Option<double?> success = default;

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
                        case "rating":
                            rating = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "pace":
                            pace = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "runRate":
                            runRate = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "passingDowns":
                            passingDowns = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "standardDowns":
                            standardDowns = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "passing":
                            passing = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "rushing":
                            rushing = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "explosiveness":
                            explosiveness = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "success":
                            success = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!rating.IsSet)
                throw new ArgumentException("Property is required for class ConferenceSPOffense.", nameof(rating));

            if (!pace.IsSet)
                throw new ArgumentException("Property is required for class ConferenceSPOffense.", nameof(pace));

            if (!runRate.IsSet)
                throw new ArgumentException("Property is required for class ConferenceSPOffense.", nameof(runRate));

            if (!passingDowns.IsSet)
                throw new ArgumentException("Property is required for class ConferenceSPOffense.", nameof(passingDowns));

            if (!standardDowns.IsSet)
                throw new ArgumentException("Property is required for class ConferenceSPOffense.", nameof(standardDowns));

            if (!passing.IsSet)
                throw new ArgumentException("Property is required for class ConferenceSPOffense.", nameof(passing));

            if (!rushing.IsSet)
                throw new ArgumentException("Property is required for class ConferenceSPOffense.", nameof(rushing));

            if (!explosiveness.IsSet)
                throw new ArgumentException("Property is required for class ConferenceSPOffense.", nameof(explosiveness));

            if (!success.IsSet)
                throw new ArgumentException("Property is required for class ConferenceSPOffense.", nameof(success));

            if (rating.IsSet && rating.Value == null)
                throw new ArgumentNullException(nameof(rating), "Property is not nullable for class ConferenceSPOffense.");

            return new ConferenceSPOffense(rating.Value!.Value!, pace.Value!, runRate.Value!, passingDowns.Value!, standardDowns.Value!, passing.Value!, rushing.Value!, explosiveness.Value!, success.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="ConferenceSPOffense" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="conferenceSPOffense"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ConferenceSPOffense conferenceSPOffense, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, conferenceSPOffense, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ConferenceSPOffense" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="conferenceSPOffense"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ConferenceSPOffense conferenceSPOffense, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("rating", conferenceSPOffense.Rating);

            if (conferenceSPOffense.Pace != null)
                writer.WriteNumber("pace", conferenceSPOffense.Pace.Value);
            else
                writer.WriteNull("pace");

            if (conferenceSPOffense.RunRate != null)
                writer.WriteNumber("runRate", conferenceSPOffense.RunRate.Value);
            else
                writer.WriteNull("runRate");

            if (conferenceSPOffense.PassingDowns != null)
                writer.WriteNumber("passingDowns", conferenceSPOffense.PassingDowns.Value);
            else
                writer.WriteNull("passingDowns");

            if (conferenceSPOffense.StandardDowns != null)
                writer.WriteNumber("standardDowns", conferenceSPOffense.StandardDowns.Value);
            else
                writer.WriteNull("standardDowns");

            if (conferenceSPOffense.Passing != null)
                writer.WriteNumber("passing", conferenceSPOffense.Passing.Value);
            else
                writer.WriteNull("passing");

            if (conferenceSPOffense.Rushing != null)
                writer.WriteNumber("rushing", conferenceSPOffense.Rushing.Value);
            else
                writer.WriteNull("rushing");

            if (conferenceSPOffense.Explosiveness != null)
                writer.WriteNumber("explosiveness", conferenceSPOffense.Explosiveness.Value);
            else
                writer.WriteNull("explosiveness");

            if (conferenceSPOffense.Success != null)
                writer.WriteNumber("success", conferenceSPOffense.Success.Value);
            else
                writer.WriteNull("success");
        }
    }
}

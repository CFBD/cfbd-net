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
    /// TeamGamePredictedPointsAddedOffense
    /// </summary>
    public partial class TeamGamePredictedPointsAddedOffense : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamGamePredictedPointsAddedOffense" /> class.
        /// </summary>
        /// <param name="thirdDown">thirdDown</param>
        /// <param name="secondDown">secondDown</param>
        /// <param name="firstDown">firstDown</param>
        /// <param name="rushing">rushing</param>
        /// <param name="passing">passing</param>
        /// <param name="overall">overall</param>
        [JsonConstructor]
        public TeamGamePredictedPointsAddedOffense(double thirdDown, double secondDown, double firstDown, double rushing, double passing, double overall)
        {
            ThirdDown = thirdDown;
            SecondDown = secondDown;
            FirstDown = firstDown;
            Rushing = rushing;
            Passing = passing;
            Overall = overall;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets ThirdDown
        /// </summary>
        [JsonPropertyName("thirdDown")]
        public double ThirdDown { get; set; }

        /// <summary>
        /// Gets or Sets SecondDown
        /// </summary>
        [JsonPropertyName("secondDown")]
        public double SecondDown { get; set; }

        /// <summary>
        /// Gets or Sets FirstDown
        /// </summary>
        [JsonPropertyName("firstDown")]
        public double FirstDown { get; set; }

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
        /// Gets or Sets Overall
        /// </summary>
        [JsonPropertyName("overall")]
        public double Overall { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamGamePredictedPointsAddedOffense {\n");
            sb.Append("  ThirdDown: ").Append(ThirdDown).Append("\n");
            sb.Append("  SecondDown: ").Append(SecondDown).Append("\n");
            sb.Append("  FirstDown: ").Append(FirstDown).Append("\n");
            sb.Append("  Rushing: ").Append(Rushing).Append("\n");
            sb.Append("  Passing: ").Append(Passing).Append("\n");
            sb.Append("  Overall: ").Append(Overall).Append("\n");
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
    /// A Json converter for type <see cref="TeamGamePredictedPointsAddedOffense" />
    /// </summary>
    public class TeamGamePredictedPointsAddedOffenseJsonConverter : JsonConverter<TeamGamePredictedPointsAddedOffense>
    {
        /// <summary>
        /// Deserializes json to <see cref="TeamGamePredictedPointsAddedOffense" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TeamGamePredictedPointsAddedOffense Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double?> thirdDown = default;
            Option<double?> secondDown = default;
            Option<double?> firstDown = default;
            Option<double?> rushing = default;
            Option<double?> passing = default;
            Option<double?> overall = default;

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
                        case "thirdDown":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                thirdDown = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "secondDown":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                secondDown = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "firstDown":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                firstDown = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "rushing":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rushing = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "passing":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                passing = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "overall":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                overall = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!thirdDown.IsSet)
                throw new ArgumentException("Property is required for class TeamGamePredictedPointsAddedOffense.", nameof(thirdDown));

            if (!secondDown.IsSet)
                throw new ArgumentException("Property is required for class TeamGamePredictedPointsAddedOffense.", nameof(secondDown));

            if (!firstDown.IsSet)
                throw new ArgumentException("Property is required for class TeamGamePredictedPointsAddedOffense.", nameof(firstDown));

            if (!rushing.IsSet)
                throw new ArgumentException("Property is required for class TeamGamePredictedPointsAddedOffense.", nameof(rushing));

            if (!passing.IsSet)
                throw new ArgumentException("Property is required for class TeamGamePredictedPointsAddedOffense.", nameof(passing));

            if (!overall.IsSet)
                throw new ArgumentException("Property is required for class TeamGamePredictedPointsAddedOffense.", nameof(overall));

            if (thirdDown.IsSet && thirdDown.Value == null)
                throw new ArgumentNullException(nameof(thirdDown), "Property is not nullable for class TeamGamePredictedPointsAddedOffense.");

            if (secondDown.IsSet && secondDown.Value == null)
                throw new ArgumentNullException(nameof(secondDown), "Property is not nullable for class TeamGamePredictedPointsAddedOffense.");

            if (firstDown.IsSet && firstDown.Value == null)
                throw new ArgumentNullException(nameof(firstDown), "Property is not nullable for class TeamGamePredictedPointsAddedOffense.");

            if (rushing.IsSet && rushing.Value == null)
                throw new ArgumentNullException(nameof(rushing), "Property is not nullable for class TeamGamePredictedPointsAddedOffense.");

            if (passing.IsSet && passing.Value == null)
                throw new ArgumentNullException(nameof(passing), "Property is not nullable for class TeamGamePredictedPointsAddedOffense.");

            if (overall.IsSet && overall.Value == null)
                throw new ArgumentNullException(nameof(overall), "Property is not nullable for class TeamGamePredictedPointsAddedOffense.");

            return new TeamGamePredictedPointsAddedOffense(thirdDown.Value!.Value!, secondDown.Value!.Value!, firstDown.Value!.Value!, rushing.Value!.Value!, passing.Value!.Value!, overall.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="TeamGamePredictedPointsAddedOffense" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamGamePredictedPointsAddedOffense"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TeamGamePredictedPointsAddedOffense teamGamePredictedPointsAddedOffense, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, teamGamePredictedPointsAddedOffense, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TeamGamePredictedPointsAddedOffense" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamGamePredictedPointsAddedOffense"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TeamGamePredictedPointsAddedOffense teamGamePredictedPointsAddedOffense, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("thirdDown", teamGamePredictedPointsAddedOffense.ThirdDown);

            writer.WriteNumber("secondDown", teamGamePredictedPointsAddedOffense.SecondDown);

            writer.WriteNumber("firstDown", teamGamePredictedPointsAddedOffense.FirstDown);

            writer.WriteNumber("rushing", teamGamePredictedPointsAddedOffense.Rushing);

            writer.WriteNumber("passing", teamGamePredictedPointsAddedOffense.Passing);

            writer.WriteNumber("overall", teamGamePredictedPointsAddedOffense.Overall);
        }
    }
}

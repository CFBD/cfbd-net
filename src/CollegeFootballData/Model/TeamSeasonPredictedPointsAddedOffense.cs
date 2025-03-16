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
    /// TeamSeasonPredictedPointsAddedOffense
    /// </summary>
    public partial class TeamSeasonPredictedPointsAddedOffense : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSeasonPredictedPointsAddedOffense" /> class.
        /// </summary>
        /// <param name="cumulative">cumulative</param>
        /// <param name="thirdDown">thirdDown</param>
        /// <param name="secondDown">secondDown</param>
        /// <param name="firstDown">firstDown</param>
        /// <param name="rushing">rushing</param>
        /// <param name="passing">passing</param>
        /// <param name="overall">overall</param>
        [JsonConstructor]
        public TeamSeasonPredictedPointsAddedOffense(AdjustedTeamMetricsEpa cumulative, double thirdDown, double secondDown, double firstDown, double rushing, double passing, double overall)
        {
            Cumulative = cumulative;
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
        /// Gets or Sets Cumulative
        /// </summary>
        [JsonPropertyName("cumulative")]
        public AdjustedTeamMetricsEpa Cumulative { get; set; }

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
            sb.Append("class TeamSeasonPredictedPointsAddedOffense {\n");
            sb.Append("  Cumulative: ").Append(Cumulative).Append("\n");
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
    /// A Json converter for type <see cref="TeamSeasonPredictedPointsAddedOffense" />
    /// </summary>
    public class TeamSeasonPredictedPointsAddedOffenseJsonConverter : JsonConverter<TeamSeasonPredictedPointsAddedOffense>
    {
        /// <summary>
        /// Deserializes json to <see cref="TeamSeasonPredictedPointsAddedOffense" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TeamSeasonPredictedPointsAddedOffense Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<AdjustedTeamMetricsEpa?> cumulative = default;
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
                        case "cumulative":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                cumulative = new Option<AdjustedTeamMetricsEpa?>(JsonSerializer.Deserialize<AdjustedTeamMetricsEpa>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
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

            if (!cumulative.IsSet)
                throw new ArgumentException("Property is required for class TeamSeasonPredictedPointsAddedOffense.", nameof(cumulative));

            if (!thirdDown.IsSet)
                throw new ArgumentException("Property is required for class TeamSeasonPredictedPointsAddedOffense.", nameof(thirdDown));

            if (!secondDown.IsSet)
                throw new ArgumentException("Property is required for class TeamSeasonPredictedPointsAddedOffense.", nameof(secondDown));

            if (!firstDown.IsSet)
                throw new ArgumentException("Property is required for class TeamSeasonPredictedPointsAddedOffense.", nameof(firstDown));

            if (!rushing.IsSet)
                throw new ArgumentException("Property is required for class TeamSeasonPredictedPointsAddedOffense.", nameof(rushing));

            if (!passing.IsSet)
                throw new ArgumentException("Property is required for class TeamSeasonPredictedPointsAddedOffense.", nameof(passing));

            if (!overall.IsSet)
                throw new ArgumentException("Property is required for class TeamSeasonPredictedPointsAddedOffense.", nameof(overall));

            if (cumulative.IsSet && cumulative.Value == null)
                throw new ArgumentNullException(nameof(cumulative), "Property is not nullable for class TeamSeasonPredictedPointsAddedOffense.");

            if (thirdDown.IsSet && thirdDown.Value == null)
                throw new ArgumentNullException(nameof(thirdDown), "Property is not nullable for class TeamSeasonPredictedPointsAddedOffense.");

            if (secondDown.IsSet && secondDown.Value == null)
                throw new ArgumentNullException(nameof(secondDown), "Property is not nullable for class TeamSeasonPredictedPointsAddedOffense.");

            if (firstDown.IsSet && firstDown.Value == null)
                throw new ArgumentNullException(nameof(firstDown), "Property is not nullable for class TeamSeasonPredictedPointsAddedOffense.");

            if (rushing.IsSet && rushing.Value == null)
                throw new ArgumentNullException(nameof(rushing), "Property is not nullable for class TeamSeasonPredictedPointsAddedOffense.");

            if (passing.IsSet && passing.Value == null)
                throw new ArgumentNullException(nameof(passing), "Property is not nullable for class TeamSeasonPredictedPointsAddedOffense.");

            if (overall.IsSet && overall.Value == null)
                throw new ArgumentNullException(nameof(overall), "Property is not nullable for class TeamSeasonPredictedPointsAddedOffense.");

            return new TeamSeasonPredictedPointsAddedOffense(cumulative.Value!, thirdDown.Value!.Value!, secondDown.Value!.Value!, firstDown.Value!.Value!, rushing.Value!.Value!, passing.Value!.Value!, overall.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="TeamSeasonPredictedPointsAddedOffense" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamSeasonPredictedPointsAddedOffense"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TeamSeasonPredictedPointsAddedOffense teamSeasonPredictedPointsAddedOffense, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, teamSeasonPredictedPointsAddedOffense, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TeamSeasonPredictedPointsAddedOffense" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamSeasonPredictedPointsAddedOffense"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TeamSeasonPredictedPointsAddedOffense teamSeasonPredictedPointsAddedOffense, JsonSerializerOptions jsonSerializerOptions)
        {
            if (teamSeasonPredictedPointsAddedOffense.Cumulative == null)
                throw new ArgumentNullException(nameof(teamSeasonPredictedPointsAddedOffense.Cumulative), "Property is required for class TeamSeasonPredictedPointsAddedOffense.");

            writer.WritePropertyName("cumulative");
            JsonSerializer.Serialize(writer, teamSeasonPredictedPointsAddedOffense.Cumulative, jsonSerializerOptions);
            writer.WriteNumber("thirdDown", teamSeasonPredictedPointsAddedOffense.ThirdDown);

            writer.WriteNumber("secondDown", teamSeasonPredictedPointsAddedOffense.SecondDown);

            writer.WriteNumber("firstDown", teamSeasonPredictedPointsAddedOffense.FirstDown);

            writer.WriteNumber("rushing", teamSeasonPredictedPointsAddedOffense.Rushing);

            writer.WriteNumber("passing", teamSeasonPredictedPointsAddedOffense.Passing);

            writer.WriteNumber("overall", teamSeasonPredictedPointsAddedOffense.Overall);
        }
    }
}

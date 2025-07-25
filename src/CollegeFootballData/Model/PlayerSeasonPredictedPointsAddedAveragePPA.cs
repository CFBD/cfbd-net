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
    /// PlayerSeasonPredictedPointsAddedAveragePPA
    /// </summary>
    public partial class PlayerSeasonPredictedPointsAddedAveragePPA : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerSeasonPredictedPointsAddedAveragePPA" /> class.
        /// </summary>
        /// <param name="all">all</param>
        /// <param name="passingDowns">passingDowns</param>
        /// <param name="standardDowns">standardDowns</param>
        /// <param name="thirdDown">thirdDown</param>
        /// <param name="secondDown">secondDown</param>
        /// <param name="firstDown">firstDown</param>
        /// <param name="rush">rush</param>
        /// <param name="pass">pass</param>
        [JsonConstructor]
        public PlayerSeasonPredictedPointsAddedAveragePPA(double all, Option<double?> passingDowns = default, Option<double?> standardDowns = default, Option<double?> thirdDown = default, Option<double?> secondDown = default, Option<double?> firstDown = default, Option<double?> rush = default, Option<double?> pass = default)
        {
            All = all;
            PassingDownsOption = passingDowns;
            StandardDownsOption = standardDowns;
            ThirdDownOption = thirdDown;
            SecondDownOption = secondDown;
            FirstDownOption = firstDown;
            RushOption = rush;
            PassOption = pass;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets All
        /// </summary>
        [JsonPropertyName("all")]
        public double All { get; set; }

        /// <summary>
        /// Used to track the state of PassingDowns
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> PassingDownsOption { get; private set; }

        /// <summary>
        /// Gets or Sets PassingDowns
        /// </summary>
        [JsonPropertyName("passingDowns")]
        public double? PassingDowns { get { return this.PassingDownsOption; } set { this.PassingDownsOption = new(value); } }

        /// <summary>
        /// Used to track the state of StandardDowns
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> StandardDownsOption { get; private set; }

        /// <summary>
        /// Gets or Sets StandardDowns
        /// </summary>
        [JsonPropertyName("standardDowns")]
        public double? StandardDowns { get { return this.StandardDownsOption; } set { this.StandardDownsOption = new(value); } }

        /// <summary>
        /// Used to track the state of ThirdDown
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> ThirdDownOption { get; private set; }

        /// <summary>
        /// Gets or Sets ThirdDown
        /// </summary>
        [JsonPropertyName("thirdDown")]
        public double? ThirdDown { get { return this.ThirdDownOption; } set { this.ThirdDownOption = new(value); } }

        /// <summary>
        /// Used to track the state of SecondDown
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> SecondDownOption { get; private set; }

        /// <summary>
        /// Gets or Sets SecondDown
        /// </summary>
        [JsonPropertyName("secondDown")]
        public double? SecondDown { get { return this.SecondDownOption; } set { this.SecondDownOption = new(value); } }

        /// <summary>
        /// Used to track the state of FirstDown
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> FirstDownOption { get; private set; }

        /// <summary>
        /// Gets or Sets FirstDown
        /// </summary>
        [JsonPropertyName("firstDown")]
        public double? FirstDown { get { return this.FirstDownOption; } set { this.FirstDownOption = new(value); } }

        /// <summary>
        /// Used to track the state of Rush
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> RushOption { get; private set; }

        /// <summary>
        /// Gets or Sets Rush
        /// </summary>
        [JsonPropertyName("rush")]
        public double? Rush { get { return this.RushOption; } set { this.RushOption = new(value); } }

        /// <summary>
        /// Used to track the state of Pass
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> PassOption { get; private set; }

        /// <summary>
        /// Gets or Sets Pass
        /// </summary>
        [JsonPropertyName("pass")]
        public double? Pass { get { return this.PassOption; } set { this.PassOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerSeasonPredictedPointsAddedAveragePPA {\n");
            sb.Append("  All: ").Append(All).Append("\n");
            sb.Append("  PassingDowns: ").Append(PassingDowns).Append("\n");
            sb.Append("  StandardDowns: ").Append(StandardDowns).Append("\n");
            sb.Append("  ThirdDown: ").Append(ThirdDown).Append("\n");
            sb.Append("  SecondDown: ").Append(SecondDown).Append("\n");
            sb.Append("  FirstDown: ").Append(FirstDown).Append("\n");
            sb.Append("  Rush: ").Append(Rush).Append("\n");
            sb.Append("  Pass: ").Append(Pass).Append("\n");
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
    /// A Json converter for type <see cref="PlayerSeasonPredictedPointsAddedAveragePPA" />
    /// </summary>
    public class PlayerSeasonPredictedPointsAddedAveragePPAJsonConverter : JsonConverter<PlayerSeasonPredictedPointsAddedAveragePPA>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerSeasonPredictedPointsAddedAveragePPA" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerSeasonPredictedPointsAddedAveragePPA Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double?> all = default;
            Option<double?> passingDowns = default;
            Option<double?> standardDowns = default;
            Option<double?> thirdDown = default;
            Option<double?> secondDown = default;
            Option<double?> firstDown = default;
            Option<double?> rush = default;
            Option<double?> pass = default;

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
                        case "all":
                            all = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "passingDowns":
                            passingDowns = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "standardDowns":
                            standardDowns = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "thirdDown":
                            thirdDown = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "secondDown":
                            secondDown = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "firstDown":
                            firstDown = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "rush":
                            rush = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "pass":
                            pass = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!all.IsSet)
                throw new ArgumentException("Property is required for class PlayerSeasonPredictedPointsAddedAveragePPA.", nameof(all));

            if (all.IsSet && all.Value == null)
                throw new ArgumentNullException(nameof(all), "Property is not nullable for class PlayerSeasonPredictedPointsAddedAveragePPA.");

            if (passingDowns.IsSet && passingDowns.Value == null)
                throw new ArgumentNullException(nameof(passingDowns), "Property is not nullable for class PlayerSeasonPredictedPointsAddedAveragePPA.");

            if (standardDowns.IsSet && standardDowns.Value == null)
                throw new ArgumentNullException(nameof(standardDowns), "Property is not nullable for class PlayerSeasonPredictedPointsAddedAveragePPA.");

            if (thirdDown.IsSet && thirdDown.Value == null)
                throw new ArgumentNullException(nameof(thirdDown), "Property is not nullable for class PlayerSeasonPredictedPointsAddedAveragePPA.");

            if (secondDown.IsSet && secondDown.Value == null)
                throw new ArgumentNullException(nameof(secondDown), "Property is not nullable for class PlayerSeasonPredictedPointsAddedAveragePPA.");

            if (firstDown.IsSet && firstDown.Value == null)
                throw new ArgumentNullException(nameof(firstDown), "Property is not nullable for class PlayerSeasonPredictedPointsAddedAveragePPA.");

            if (rush.IsSet && rush.Value == null)
                throw new ArgumentNullException(nameof(rush), "Property is not nullable for class PlayerSeasonPredictedPointsAddedAveragePPA.");

            if (pass.IsSet && pass.Value == null)
                throw new ArgumentNullException(nameof(pass), "Property is not nullable for class PlayerSeasonPredictedPointsAddedAveragePPA.");

            return new PlayerSeasonPredictedPointsAddedAveragePPA(all.Value!.Value!, passingDowns, standardDowns, thirdDown, secondDown, firstDown, rush, pass);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerSeasonPredictedPointsAddedAveragePPA" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerSeasonPredictedPointsAddedAveragePPA"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerSeasonPredictedPointsAddedAveragePPA playerSeasonPredictedPointsAddedAveragePPA, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerSeasonPredictedPointsAddedAveragePPA, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerSeasonPredictedPointsAddedAveragePPA" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerSeasonPredictedPointsAddedAveragePPA"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerSeasonPredictedPointsAddedAveragePPA playerSeasonPredictedPointsAddedAveragePPA, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("all", playerSeasonPredictedPointsAddedAveragePPA.All);

            if (playerSeasonPredictedPointsAddedAveragePPA.PassingDownsOption.IsSet)
                writer.WriteNumber("passingDowns", playerSeasonPredictedPointsAddedAveragePPA.PassingDownsOption.Value!.Value);

            if (playerSeasonPredictedPointsAddedAveragePPA.StandardDownsOption.IsSet)
                writer.WriteNumber("standardDowns", playerSeasonPredictedPointsAddedAveragePPA.StandardDownsOption.Value!.Value);

            if (playerSeasonPredictedPointsAddedAveragePPA.ThirdDownOption.IsSet)
                writer.WriteNumber("thirdDown", playerSeasonPredictedPointsAddedAveragePPA.ThirdDownOption.Value!.Value);

            if (playerSeasonPredictedPointsAddedAveragePPA.SecondDownOption.IsSet)
                writer.WriteNumber("secondDown", playerSeasonPredictedPointsAddedAveragePPA.SecondDownOption.Value!.Value);

            if (playerSeasonPredictedPointsAddedAveragePPA.FirstDownOption.IsSet)
                writer.WriteNumber("firstDown", playerSeasonPredictedPointsAddedAveragePPA.FirstDownOption.Value!.Value);

            if (playerSeasonPredictedPointsAddedAveragePPA.RushOption.IsSet)
                writer.WriteNumber("rush", playerSeasonPredictedPointsAddedAveragePPA.RushOption.Value!.Value);

            if (playerSeasonPredictedPointsAddedAveragePPA.PassOption.IsSet)
                writer.WriteNumber("pass", playerSeasonPredictedPointsAddedAveragePPA.PassOption.Value!.Value);
        }
    }
}

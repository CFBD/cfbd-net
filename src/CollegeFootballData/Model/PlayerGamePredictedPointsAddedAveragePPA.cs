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
    /// PlayerGamePredictedPointsAddedAveragePPA
    /// </summary>
    public partial class PlayerGamePredictedPointsAddedAveragePPA : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGamePredictedPointsAddedAveragePPA" /> class.
        /// </summary>
        /// <param name="all">all</param>
        /// <param name="rush">rush</param>
        /// <param name="pass">pass</param>
        [JsonConstructor]
        public PlayerGamePredictedPointsAddedAveragePPA(double all, Option<double?> rush = default, Option<double?> pass = default)
        {
            All = all;
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
            sb.Append("class PlayerGamePredictedPointsAddedAveragePPA {\n");
            sb.Append("  All: ").Append(All).Append("\n");
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
    /// A Json converter for type <see cref="PlayerGamePredictedPointsAddedAveragePPA" />
    /// </summary>
    public class PlayerGamePredictedPointsAddedAveragePPAJsonConverter : JsonConverter<PlayerGamePredictedPointsAddedAveragePPA>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerGamePredictedPointsAddedAveragePPA" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerGamePredictedPointsAddedAveragePPA Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double?> all = default;
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
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                all = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "rush":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rush = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "pass":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                pass = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!all.IsSet)
                throw new ArgumentException("Property is required for class PlayerGamePredictedPointsAddedAveragePPA.", nameof(all));

            if (all.IsSet && all.Value == null)
                throw new ArgumentNullException(nameof(all), "Property is not nullable for class PlayerGamePredictedPointsAddedAveragePPA.");

            if (rush.IsSet && rush.Value == null)
                throw new ArgumentNullException(nameof(rush), "Property is not nullable for class PlayerGamePredictedPointsAddedAveragePPA.");

            if (pass.IsSet && pass.Value == null)
                throw new ArgumentNullException(nameof(pass), "Property is not nullable for class PlayerGamePredictedPointsAddedAveragePPA.");

            return new PlayerGamePredictedPointsAddedAveragePPA(all.Value!.Value!, rush, pass);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerGamePredictedPointsAddedAveragePPA" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGamePredictedPointsAddedAveragePPA"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerGamePredictedPointsAddedAveragePPA playerGamePredictedPointsAddedAveragePPA, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerGamePredictedPointsAddedAveragePPA, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerGamePredictedPointsAddedAveragePPA" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGamePredictedPointsAddedAveragePPA"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerGamePredictedPointsAddedAveragePPA playerGamePredictedPointsAddedAveragePPA, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("all", playerGamePredictedPointsAddedAveragePPA.All);

            if (playerGamePredictedPointsAddedAveragePPA.RushOption.IsSet)
                writer.WriteNumber("rush", playerGamePredictedPointsAddedAveragePPA.RushOption.Value!.Value);

            if (playerGamePredictedPointsAddedAveragePPA.PassOption.IsSet)
                writer.WriteNumber("pass", playerGamePredictedPointsAddedAveragePPA.PassOption.Value!.Value);
        }
    }
}

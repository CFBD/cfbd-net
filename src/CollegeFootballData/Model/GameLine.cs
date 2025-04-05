// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.11
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
    /// GameLine
    /// </summary>
    public partial class GameLine : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameLine" /> class.
        /// </summary>
        /// <param name="provider">provider</param>
        /// <param name="formattedSpread">formattedSpread</param>
        /// <param name="spread">spread</param>
        /// <param name="spreadOpen">spreadOpen</param>
        /// <param name="overUnder">overUnder</param>
        /// <param name="overUnderOpen">overUnderOpen</param>
        /// <param name="homeMoneyline">homeMoneyline</param>
        /// <param name="awayMoneyline">awayMoneyline</param>
        [JsonConstructor]
        public GameLine(string provider, string formattedSpread, double? spread = default, double? spreadOpen = default, double? overUnder = default, double? overUnderOpen = default, double? homeMoneyline = default, double? awayMoneyline = default)
        {
            Provider = provider;
            FormattedSpread = formattedSpread;
            Spread = spread;
            SpreadOpen = spreadOpen;
            OverUnder = overUnder;
            OverUnderOpen = overUnderOpen;
            HomeMoneyline = homeMoneyline;
            AwayMoneyline = awayMoneyline;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or Sets FormattedSpread
        /// </summary>
        [JsonPropertyName("formattedSpread")]
        public string FormattedSpread { get; set; }

        /// <summary>
        /// Gets or Sets Spread
        /// </summary>
        [JsonPropertyName("spread")]
        public double? Spread { get; set; }

        /// <summary>
        /// Gets or Sets SpreadOpen
        /// </summary>
        [JsonPropertyName("spreadOpen")]
        public double? SpreadOpen { get; set; }

        /// <summary>
        /// Gets or Sets OverUnder
        /// </summary>
        [JsonPropertyName("overUnder")]
        public double? OverUnder { get; set; }

        /// <summary>
        /// Gets or Sets OverUnderOpen
        /// </summary>
        [JsonPropertyName("overUnderOpen")]
        public double? OverUnderOpen { get; set; }

        /// <summary>
        /// Gets or Sets HomeMoneyline
        /// </summary>
        [JsonPropertyName("homeMoneyline")]
        public double? HomeMoneyline { get; set; }

        /// <summary>
        /// Gets or Sets AwayMoneyline
        /// </summary>
        [JsonPropertyName("awayMoneyline")]
        public double? AwayMoneyline { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GameLine {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  FormattedSpread: ").Append(FormattedSpread).Append("\n");
            sb.Append("  Spread: ").Append(Spread).Append("\n");
            sb.Append("  SpreadOpen: ").Append(SpreadOpen).Append("\n");
            sb.Append("  OverUnder: ").Append(OverUnder).Append("\n");
            sb.Append("  OverUnderOpen: ").Append(OverUnderOpen).Append("\n");
            sb.Append("  HomeMoneyline: ").Append(HomeMoneyline).Append("\n");
            sb.Append("  AwayMoneyline: ").Append(AwayMoneyline).Append("\n");
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
    /// A Json converter for type <see cref="GameLine" />
    /// </summary>
    public class GameLineJsonConverter : JsonConverter<GameLine>
    {
        /// <summary>
        /// Deserializes json to <see cref="GameLine" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GameLine Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> provider = default;
            Option<string?> formattedSpread = default;
            Option<double?> spread = default;
            Option<double?> spreadOpen = default;
            Option<double?> overUnder = default;
            Option<double?> overUnderOpen = default;
            Option<double?> homeMoneyline = default;
            Option<double?> awayMoneyline = default;

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
                        case "provider":
                            provider = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "formattedSpread":
                            formattedSpread = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "spread":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                spread = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "spreadOpen":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                spreadOpen = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "overUnder":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                overUnder = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "overUnderOpen":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                overUnderOpen = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "homeMoneyline":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                homeMoneyline = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "awayMoneyline":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                awayMoneyline = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!provider.IsSet)
                throw new ArgumentException("Property is required for class GameLine.", nameof(provider));

            if (!formattedSpread.IsSet)
                throw new ArgumentException("Property is required for class GameLine.", nameof(formattedSpread));

            if (!spread.IsSet)
                throw new ArgumentException("Property is required for class GameLine.", nameof(spread));

            if (!spreadOpen.IsSet)
                throw new ArgumentException("Property is required for class GameLine.", nameof(spreadOpen));

            if (!overUnder.IsSet)
                throw new ArgumentException("Property is required for class GameLine.", nameof(overUnder));

            if (!overUnderOpen.IsSet)
                throw new ArgumentException("Property is required for class GameLine.", nameof(overUnderOpen));

            if (!homeMoneyline.IsSet)
                throw new ArgumentException("Property is required for class GameLine.", nameof(homeMoneyline));

            if (!awayMoneyline.IsSet)
                throw new ArgumentException("Property is required for class GameLine.", nameof(awayMoneyline));

            if (provider.IsSet && provider.Value == null)
                throw new ArgumentNullException(nameof(provider), "Property is not nullable for class GameLine.");

            if (formattedSpread.IsSet && formattedSpread.Value == null)
                throw new ArgumentNullException(nameof(formattedSpread), "Property is not nullable for class GameLine.");

            return new GameLine(provider.Value!, formattedSpread.Value!, spread.Value!, spreadOpen.Value!, overUnder.Value!, overUnderOpen.Value!, homeMoneyline.Value!, awayMoneyline.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GameLine" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gameLine"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GameLine gameLine, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, gameLine, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GameLine" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gameLine"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GameLine gameLine, JsonSerializerOptions jsonSerializerOptions)
        {
            if (gameLine.Provider == null)
                throw new ArgumentNullException(nameof(gameLine.Provider), "Property is required for class GameLine.");

            if (gameLine.FormattedSpread == null)
                throw new ArgumentNullException(nameof(gameLine.FormattedSpread), "Property is required for class GameLine.");

            writer.WriteString("provider", gameLine.Provider);

            writer.WriteString("formattedSpread", gameLine.FormattedSpread);

            if (gameLine.Spread != null)
                writer.WriteNumber("spread", gameLine.Spread.Value);
            else
                writer.WriteNull("spread");

            if (gameLine.SpreadOpen != null)
                writer.WriteNumber("spreadOpen", gameLine.SpreadOpen.Value);
            else
                writer.WriteNull("spreadOpen");

            if (gameLine.OverUnder != null)
                writer.WriteNumber("overUnder", gameLine.OverUnder.Value);
            else
                writer.WriteNull("overUnder");

            if (gameLine.OverUnderOpen != null)
                writer.WriteNumber("overUnderOpen", gameLine.OverUnderOpen.Value);
            else
                writer.WriteNull("overUnderOpen");

            if (gameLine.HomeMoneyline != null)
                writer.WriteNumber("homeMoneyline", gameLine.HomeMoneyline.Value);
            else
                writer.WriteNull("homeMoneyline");

            if (gameLine.AwayMoneyline != null)
                writer.WriteNumber("awayMoneyline", gameLine.AwayMoneyline.Value);
            else
                writer.WriteNull("awayMoneyline");
        }
    }
}

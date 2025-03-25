// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.9
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
    /// ScoreboardGameWeather
    /// </summary>
    public partial class ScoreboardGameWeather : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreboardGameWeather" /> class.
        /// </summary>
        /// <param name="windDirection">windDirection</param>
        /// <param name="windSpeed">windSpeed</param>
        /// <param name="description">description</param>
        /// <param name="temperature">temperature</param>
        [JsonConstructor]
        public ScoreboardGameWeather(double? windDirection = default, double? windSpeed = default, string? description = default, double? temperature = default)
        {
            WindDirection = windDirection;
            WindSpeed = windSpeed;
            Description = description;
            Temperature = temperature;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets WindDirection
        /// </summary>
        [JsonPropertyName("windDirection")]
        public double? WindDirection { get; set; }

        /// <summary>
        /// Gets or Sets WindSpeed
        /// </summary>
        [JsonPropertyName("windSpeed")]
        public double? WindSpeed { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or Sets Temperature
        /// </summary>
        [JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScoreboardGameWeather {\n");
            sb.Append("  WindDirection: ").Append(WindDirection).Append("\n");
            sb.Append("  WindSpeed: ").Append(WindSpeed).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
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
    /// A Json converter for type <see cref="ScoreboardGameWeather" />
    /// </summary>
    public class ScoreboardGameWeatherJsonConverter : JsonConverter<ScoreboardGameWeather>
    {
        /// <summary>
        /// Deserializes json to <see cref="ScoreboardGameWeather" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ScoreboardGameWeather Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double?> windDirection = default;
            Option<double?> windSpeed = default;
            Option<string?> description = default;
            Option<double?> temperature = default;

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
                        case "windDirection":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                windDirection = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "windSpeed":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                windSpeed = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "description":
                            description = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "temperature":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                temperature = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!windDirection.IsSet)
                throw new ArgumentException("Property is required for class ScoreboardGameWeather.", nameof(windDirection));

            if (!windSpeed.IsSet)
                throw new ArgumentException("Property is required for class ScoreboardGameWeather.", nameof(windSpeed));

            if (!description.IsSet)
                throw new ArgumentException("Property is required for class ScoreboardGameWeather.", nameof(description));

            if (!temperature.IsSet)
                throw new ArgumentException("Property is required for class ScoreboardGameWeather.", nameof(temperature));

            return new ScoreboardGameWeather(windDirection.Value!, windSpeed.Value!, description.Value!, temperature.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="ScoreboardGameWeather" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="scoreboardGameWeather"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ScoreboardGameWeather scoreboardGameWeather, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, scoreboardGameWeather, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ScoreboardGameWeather" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="scoreboardGameWeather"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ScoreboardGameWeather scoreboardGameWeather, JsonSerializerOptions jsonSerializerOptions)
        {
            if (scoreboardGameWeather.WindDirection != null)
                writer.WriteNumber("windDirection", scoreboardGameWeather.WindDirection.Value);
            else
                writer.WriteNull("windDirection");

            if (scoreboardGameWeather.WindSpeed != null)
                writer.WriteNumber("windSpeed", scoreboardGameWeather.WindSpeed.Value);
            else
                writer.WriteNull("windSpeed");

            if (scoreboardGameWeather.Description != null)
                writer.WriteString("description", scoreboardGameWeather.Description);
            else
                writer.WriteNull("description");

            if (scoreboardGameWeather.Temperature != null)
                writer.WriteNumber("temperature", scoreboardGameWeather.Temperature.Value);
            else
                writer.WriteNull("temperature");
        }
    }
}

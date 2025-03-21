// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.8
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
    /// AdvancedBoxScoreGameInfo
    /// </summary>
    public partial class AdvancedBoxScoreGameInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedBoxScoreGameInfo" /> class.
        /// </summary>
        /// <param name="excitement">excitement</param>
        /// <param name="homeWinner">homeWinner</param>
        /// <param name="awayWinProb">awayWinProb</param>
        /// <param name="awayPoints">awayPoints</param>
        /// <param name="awayTeam">awayTeam</param>
        /// <param name="homeWinProb">homeWinProb</param>
        /// <param name="homePoints">homePoints</param>
        /// <param name="homeTeam">homeTeam</param>
        [JsonConstructor]
        public AdvancedBoxScoreGameInfo(double excitement, bool homeWinner, double awayWinProb, int awayPoints, string awayTeam, double homeWinProb, int homePoints, string homeTeam)
        {
            Excitement = excitement;
            HomeWinner = homeWinner;
            AwayWinProb = awayWinProb;
            AwayPoints = awayPoints;
            AwayTeam = awayTeam;
            HomeWinProb = homeWinProb;
            HomePoints = homePoints;
            HomeTeam = homeTeam;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Excitement
        /// </summary>
        [JsonPropertyName("excitement")]
        public double Excitement { get; set; }

        /// <summary>
        /// Gets or Sets HomeWinner
        /// </summary>
        [JsonPropertyName("homeWinner")]
        public bool HomeWinner { get; set; }

        /// <summary>
        /// Gets or Sets AwayWinProb
        /// </summary>
        [JsonPropertyName("awayWinProb")]
        public double AwayWinProb { get; set; }

        /// <summary>
        /// Gets or Sets AwayPoints
        /// </summary>
        [JsonPropertyName("awayPoints")]
        public int AwayPoints { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeam
        /// </summary>
        [JsonPropertyName("awayTeam")]
        public string AwayTeam { get; set; }

        /// <summary>
        /// Gets or Sets HomeWinProb
        /// </summary>
        [JsonPropertyName("homeWinProb")]
        public double HomeWinProb { get; set; }

        /// <summary>
        /// Gets or Sets HomePoints
        /// </summary>
        [JsonPropertyName("homePoints")]
        public int HomePoints { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeam
        /// </summary>
        [JsonPropertyName("homeTeam")]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdvancedBoxScoreGameInfo {\n");
            sb.Append("  Excitement: ").Append(Excitement).Append("\n");
            sb.Append("  HomeWinner: ").Append(HomeWinner).Append("\n");
            sb.Append("  AwayWinProb: ").Append(AwayWinProb).Append("\n");
            sb.Append("  AwayPoints: ").Append(AwayPoints).Append("\n");
            sb.Append("  AwayTeam: ").Append(AwayTeam).Append("\n");
            sb.Append("  HomeWinProb: ").Append(HomeWinProb).Append("\n");
            sb.Append("  HomePoints: ").Append(HomePoints).Append("\n");
            sb.Append("  HomeTeam: ").Append(HomeTeam).Append("\n");
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
    /// A Json converter for type <see cref="AdvancedBoxScoreGameInfo" />
    /// </summary>
    public class AdvancedBoxScoreGameInfoJsonConverter : JsonConverter<AdvancedBoxScoreGameInfo>
    {
        /// <summary>
        /// Deserializes json to <see cref="AdvancedBoxScoreGameInfo" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AdvancedBoxScoreGameInfo Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double?> excitement = default;
            Option<bool?> homeWinner = default;
            Option<double?> awayWinProb = default;
            Option<int?> awayPoints = default;
            Option<string?> awayTeam = default;
            Option<double?> homeWinProb = default;
            Option<int?> homePoints = default;
            Option<string?> homeTeam = default;

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
                        case "excitement":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                excitement = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "homeWinner":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                homeWinner = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "awayWinProb":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                awayWinProb = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "awayPoints":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                awayPoints = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "awayTeam":
                            awayTeam = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "homeWinProb":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                homeWinProb = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "homePoints":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                homePoints = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "homeTeam":
                            homeTeam = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!excitement.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScoreGameInfo.", nameof(excitement));

            if (!homeWinner.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScoreGameInfo.", nameof(homeWinner));

            if (!awayWinProb.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScoreGameInfo.", nameof(awayWinProb));

            if (!awayPoints.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScoreGameInfo.", nameof(awayPoints));

            if (!awayTeam.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScoreGameInfo.", nameof(awayTeam));

            if (!homeWinProb.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScoreGameInfo.", nameof(homeWinProb));

            if (!homePoints.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScoreGameInfo.", nameof(homePoints));

            if (!homeTeam.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScoreGameInfo.", nameof(homeTeam));

            if (excitement.IsSet && excitement.Value == null)
                throw new ArgumentNullException(nameof(excitement), "Property is not nullable for class AdvancedBoxScoreGameInfo.");

            if (homeWinner.IsSet && homeWinner.Value == null)
                throw new ArgumentNullException(nameof(homeWinner), "Property is not nullable for class AdvancedBoxScoreGameInfo.");

            if (awayWinProb.IsSet && awayWinProb.Value == null)
                throw new ArgumentNullException(nameof(awayWinProb), "Property is not nullable for class AdvancedBoxScoreGameInfo.");

            if (awayPoints.IsSet && awayPoints.Value == null)
                throw new ArgumentNullException(nameof(awayPoints), "Property is not nullable for class AdvancedBoxScoreGameInfo.");

            if (awayTeam.IsSet && awayTeam.Value == null)
                throw new ArgumentNullException(nameof(awayTeam), "Property is not nullable for class AdvancedBoxScoreGameInfo.");

            if (homeWinProb.IsSet && homeWinProb.Value == null)
                throw new ArgumentNullException(nameof(homeWinProb), "Property is not nullable for class AdvancedBoxScoreGameInfo.");

            if (homePoints.IsSet && homePoints.Value == null)
                throw new ArgumentNullException(nameof(homePoints), "Property is not nullable for class AdvancedBoxScoreGameInfo.");

            if (homeTeam.IsSet && homeTeam.Value == null)
                throw new ArgumentNullException(nameof(homeTeam), "Property is not nullable for class AdvancedBoxScoreGameInfo.");

            return new AdvancedBoxScoreGameInfo(excitement.Value!.Value!, homeWinner.Value!.Value!, awayWinProb.Value!.Value!, awayPoints.Value!.Value!, awayTeam.Value!, homeWinProb.Value!.Value!, homePoints.Value!.Value!, homeTeam.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AdvancedBoxScoreGameInfo" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedBoxScoreGameInfo"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AdvancedBoxScoreGameInfo advancedBoxScoreGameInfo, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, advancedBoxScoreGameInfo, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AdvancedBoxScoreGameInfo" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedBoxScoreGameInfo"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AdvancedBoxScoreGameInfo advancedBoxScoreGameInfo, JsonSerializerOptions jsonSerializerOptions)
        {
            if (advancedBoxScoreGameInfo.AwayTeam == null)
                throw new ArgumentNullException(nameof(advancedBoxScoreGameInfo.AwayTeam), "Property is required for class AdvancedBoxScoreGameInfo.");

            if (advancedBoxScoreGameInfo.HomeTeam == null)
                throw new ArgumentNullException(nameof(advancedBoxScoreGameInfo.HomeTeam), "Property is required for class AdvancedBoxScoreGameInfo.");

            writer.WriteNumber("excitement", advancedBoxScoreGameInfo.Excitement);

            writer.WriteBoolean("homeWinner", advancedBoxScoreGameInfo.HomeWinner);

            writer.WriteNumber("awayWinProb", advancedBoxScoreGameInfo.AwayWinProb);

            writer.WriteNumber("awayPoints", advancedBoxScoreGameInfo.AwayPoints);

            writer.WriteString("awayTeam", advancedBoxScoreGameInfo.AwayTeam);

            writer.WriteNumber("homeWinProb", advancedBoxScoreGameInfo.HomeWinProb);

            writer.WriteNumber("homePoints", advancedBoxScoreGameInfo.HomePoints);

            writer.WriteString("homeTeam", advancedBoxScoreGameInfo.HomeTeam);
        }
    }
}

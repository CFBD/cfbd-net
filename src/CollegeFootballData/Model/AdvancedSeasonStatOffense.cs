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
    /// AdvancedSeasonStatOffense
    /// </summary>
    public partial class AdvancedSeasonStatOffense : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedSeasonStatOffense" /> class.
        /// </summary>
        /// <param name="passingPlays">passingPlays</param>
        /// <param name="rushingPlays">rushingPlays</param>
        /// <param name="passingDowns">passingDowns</param>
        /// <param name="standardDowns">standardDowns</param>
        /// <param name="havoc">havoc</param>
        /// <param name="fieldPosition">fieldPosition</param>
        /// <param name="pointsPerOpportunity">pointsPerOpportunity</param>
        /// <param name="totalOpportunies">totalOpportunies</param>
        /// <param name="openFieldYardsTotal">openFieldYardsTotal</param>
        /// <param name="openFieldYards">openFieldYards</param>
        /// <param name="secondLevelYardsTotal">secondLevelYardsTotal</param>
        /// <param name="secondLevelYards">secondLevelYards</param>
        /// <param name="lineYardsTotal">lineYardsTotal</param>
        /// <param name="lineYards">lineYards</param>
        /// <param name="stuffRate">stuffRate</param>
        /// <param name="powerSuccess">powerSuccess</param>
        /// <param name="explosiveness">explosiveness</param>
        /// <param name="successRate">successRate</param>
        /// <param name="totalPPA">totalPPA</param>
        /// <param name="ppa">ppa</param>
        /// <param name="drives">drives</param>
        /// <param name="plays">plays</param>
        [JsonConstructor]
        public AdvancedSeasonStatOffense(AdvancedSeasonStatOffensePassingPlays passingPlays, AdvancedSeasonStatOffensePassingPlays rushingPlays, AdvancedSeasonStatOffensePassingDowns passingDowns, AdvancedSeasonStatOffensePassingDowns standardDowns, AdvancedSeasonStatOffenseHavoc havoc, AdvancedSeasonStatOffenseFieldPosition fieldPosition, double pointsPerOpportunity, int totalOpportunies, int openFieldYardsTotal, double openFieldYards, int secondLevelYardsTotal, double secondLevelYards, int lineYardsTotal, double lineYards, double stuffRate, double powerSuccess, double explosiveness, double successRate, double totalPPA, double ppa, int drives, int plays)
        {
            PassingPlays = passingPlays;
            RushingPlays = rushingPlays;
            PassingDowns = passingDowns;
            StandardDowns = standardDowns;
            Havoc = havoc;
            FieldPosition = fieldPosition;
            PointsPerOpportunity = pointsPerOpportunity;
            TotalOpportunies = totalOpportunies;
            OpenFieldYardsTotal = openFieldYardsTotal;
            OpenFieldYards = openFieldYards;
            SecondLevelYardsTotal = secondLevelYardsTotal;
            SecondLevelYards = secondLevelYards;
            LineYardsTotal = lineYardsTotal;
            LineYards = lineYards;
            StuffRate = stuffRate;
            PowerSuccess = powerSuccess;
            Explosiveness = explosiveness;
            SuccessRate = successRate;
            TotalPPA = totalPPA;
            Ppa = ppa;
            Drives = drives;
            Plays = plays;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets PassingPlays
        /// </summary>
        [JsonPropertyName("passingPlays")]
        public AdvancedSeasonStatOffensePassingPlays PassingPlays { get; set; }

        /// <summary>
        /// Gets or Sets RushingPlays
        /// </summary>
        [JsonPropertyName("rushingPlays")]
        public AdvancedSeasonStatOffensePassingPlays RushingPlays { get; set; }

        /// <summary>
        /// Gets or Sets PassingDowns
        /// </summary>
        [JsonPropertyName("passingDowns")]
        public AdvancedSeasonStatOffensePassingDowns PassingDowns { get; set; }

        /// <summary>
        /// Gets or Sets StandardDowns
        /// </summary>
        [JsonPropertyName("standardDowns")]
        public AdvancedSeasonStatOffensePassingDowns StandardDowns { get; set; }

        /// <summary>
        /// Gets or Sets Havoc
        /// </summary>
        [JsonPropertyName("havoc")]
        public AdvancedSeasonStatOffenseHavoc Havoc { get; set; }

        /// <summary>
        /// Gets or Sets FieldPosition
        /// </summary>
        [JsonPropertyName("fieldPosition")]
        public AdvancedSeasonStatOffenseFieldPosition FieldPosition { get; set; }

        /// <summary>
        /// Gets or Sets PointsPerOpportunity
        /// </summary>
        [JsonPropertyName("pointsPerOpportunity")]
        public double PointsPerOpportunity { get; set; }

        /// <summary>
        /// Gets or Sets TotalOpportunies
        /// </summary>
        [JsonPropertyName("totalOpportunies")]
        public int TotalOpportunies { get; set; }

        /// <summary>
        /// Gets or Sets OpenFieldYardsTotal
        /// </summary>
        [JsonPropertyName("openFieldYardsTotal")]
        public int OpenFieldYardsTotal { get; set; }

        /// <summary>
        /// Gets or Sets OpenFieldYards
        /// </summary>
        [JsonPropertyName("openFieldYards")]
        public double OpenFieldYards { get; set; }

        /// <summary>
        /// Gets or Sets SecondLevelYardsTotal
        /// </summary>
        [JsonPropertyName("secondLevelYardsTotal")]
        public int SecondLevelYardsTotal { get; set; }

        /// <summary>
        /// Gets or Sets SecondLevelYards
        /// </summary>
        [JsonPropertyName("secondLevelYards")]
        public double SecondLevelYards { get; set; }

        /// <summary>
        /// Gets or Sets LineYardsTotal
        /// </summary>
        [JsonPropertyName("lineYardsTotal")]
        public int LineYardsTotal { get; set; }

        /// <summary>
        /// Gets or Sets LineYards
        /// </summary>
        [JsonPropertyName("lineYards")]
        public double LineYards { get; set; }

        /// <summary>
        /// Gets or Sets StuffRate
        /// </summary>
        [JsonPropertyName("stuffRate")]
        public double StuffRate { get; set; }

        /// <summary>
        /// Gets or Sets PowerSuccess
        /// </summary>
        [JsonPropertyName("powerSuccess")]
        public double PowerSuccess { get; set; }

        /// <summary>
        /// Gets or Sets Explosiveness
        /// </summary>
        [JsonPropertyName("explosiveness")]
        public double Explosiveness { get; set; }

        /// <summary>
        /// Gets or Sets SuccessRate
        /// </summary>
        [JsonPropertyName("successRate")]
        public double SuccessRate { get; set; }

        /// <summary>
        /// Gets or Sets TotalPPA
        /// </summary>
        [JsonPropertyName("totalPPA")]
        public double TotalPPA { get; set; }

        /// <summary>
        /// Gets or Sets Ppa
        /// </summary>
        [JsonPropertyName("ppa")]
        public double Ppa { get; set; }

        /// <summary>
        /// Gets or Sets Drives
        /// </summary>
        [JsonPropertyName("drives")]
        public int Drives { get; set; }

        /// <summary>
        /// Gets or Sets Plays
        /// </summary>
        [JsonPropertyName("plays")]
        public int Plays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdvancedSeasonStatOffense {\n");
            sb.Append("  PassingPlays: ").Append(PassingPlays).Append("\n");
            sb.Append("  RushingPlays: ").Append(RushingPlays).Append("\n");
            sb.Append("  PassingDowns: ").Append(PassingDowns).Append("\n");
            sb.Append("  StandardDowns: ").Append(StandardDowns).Append("\n");
            sb.Append("  Havoc: ").Append(Havoc).Append("\n");
            sb.Append("  FieldPosition: ").Append(FieldPosition).Append("\n");
            sb.Append("  PointsPerOpportunity: ").Append(PointsPerOpportunity).Append("\n");
            sb.Append("  TotalOpportunies: ").Append(TotalOpportunies).Append("\n");
            sb.Append("  OpenFieldYardsTotal: ").Append(OpenFieldYardsTotal).Append("\n");
            sb.Append("  OpenFieldYards: ").Append(OpenFieldYards).Append("\n");
            sb.Append("  SecondLevelYardsTotal: ").Append(SecondLevelYardsTotal).Append("\n");
            sb.Append("  SecondLevelYards: ").Append(SecondLevelYards).Append("\n");
            sb.Append("  LineYardsTotal: ").Append(LineYardsTotal).Append("\n");
            sb.Append("  LineYards: ").Append(LineYards).Append("\n");
            sb.Append("  StuffRate: ").Append(StuffRate).Append("\n");
            sb.Append("  PowerSuccess: ").Append(PowerSuccess).Append("\n");
            sb.Append("  Explosiveness: ").Append(Explosiveness).Append("\n");
            sb.Append("  SuccessRate: ").Append(SuccessRate).Append("\n");
            sb.Append("  TotalPPA: ").Append(TotalPPA).Append("\n");
            sb.Append("  Ppa: ").Append(Ppa).Append("\n");
            sb.Append("  Drives: ").Append(Drives).Append("\n");
            sb.Append("  Plays: ").Append(Plays).Append("\n");
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
    /// A Json converter for type <see cref="AdvancedSeasonStatOffense" />
    /// </summary>
    public class AdvancedSeasonStatOffenseJsonConverter : JsonConverter<AdvancedSeasonStatOffense>
    {
        /// <summary>
        /// Deserializes json to <see cref="AdvancedSeasonStatOffense" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AdvancedSeasonStatOffense Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<AdvancedSeasonStatOffensePassingPlays?> passingPlays = default;
            Option<AdvancedSeasonStatOffensePassingPlays?> rushingPlays = default;
            Option<AdvancedSeasonStatOffensePassingDowns?> passingDowns = default;
            Option<AdvancedSeasonStatOffensePassingDowns?> standardDowns = default;
            Option<AdvancedSeasonStatOffenseHavoc?> havoc = default;
            Option<AdvancedSeasonStatOffenseFieldPosition?> fieldPosition = default;
            Option<double?> pointsPerOpportunity = default;
            Option<int?> totalOpportunies = default;
            Option<int?> openFieldYardsTotal = default;
            Option<double?> openFieldYards = default;
            Option<int?> secondLevelYardsTotal = default;
            Option<double?> secondLevelYards = default;
            Option<int?> lineYardsTotal = default;
            Option<double?> lineYards = default;
            Option<double?> stuffRate = default;
            Option<double?> powerSuccess = default;
            Option<double?> explosiveness = default;
            Option<double?> successRate = default;
            Option<double?> totalPPA = default;
            Option<double?> ppa = default;
            Option<int?> drives = default;
            Option<int?> plays = default;

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
                        case "passingPlays":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                passingPlays = new Option<AdvancedSeasonStatOffensePassingPlays?>(JsonSerializer.Deserialize<AdvancedSeasonStatOffensePassingPlays>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "rushingPlays":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rushingPlays = new Option<AdvancedSeasonStatOffensePassingPlays?>(JsonSerializer.Deserialize<AdvancedSeasonStatOffensePassingPlays>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "passingDowns":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                passingDowns = new Option<AdvancedSeasonStatOffensePassingDowns?>(JsonSerializer.Deserialize<AdvancedSeasonStatOffensePassingDowns>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "standardDowns":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                standardDowns = new Option<AdvancedSeasonStatOffensePassingDowns?>(JsonSerializer.Deserialize<AdvancedSeasonStatOffensePassingDowns>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "havoc":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                havoc = new Option<AdvancedSeasonStatOffenseHavoc?>(JsonSerializer.Deserialize<AdvancedSeasonStatOffenseHavoc>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "fieldPosition":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                fieldPosition = new Option<AdvancedSeasonStatOffenseFieldPosition?>(JsonSerializer.Deserialize<AdvancedSeasonStatOffenseFieldPosition>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "pointsPerOpportunity":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                pointsPerOpportunity = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "totalOpportunies":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                totalOpportunies = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "openFieldYardsTotal":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                openFieldYardsTotal = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "openFieldYards":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                openFieldYards = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "secondLevelYardsTotal":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                secondLevelYardsTotal = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "secondLevelYards":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                secondLevelYards = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "lineYardsTotal":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lineYardsTotal = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "lineYards":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lineYards = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "stuffRate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                stuffRate = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "powerSuccess":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                powerSuccess = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "explosiveness":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                explosiveness = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "successRate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                successRate = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "totalPPA":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                totalPPA = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "ppa":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                ppa = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "drives":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                drives = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "plays":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                plays = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!passingPlays.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(passingPlays));

            if (!rushingPlays.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(rushingPlays));

            if (!passingDowns.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(passingDowns));

            if (!standardDowns.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(standardDowns));

            if (!havoc.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(havoc));

            if (!fieldPosition.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(fieldPosition));

            if (!pointsPerOpportunity.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(pointsPerOpportunity));

            if (!totalOpportunies.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(totalOpportunies));

            if (!openFieldYardsTotal.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(openFieldYardsTotal));

            if (!openFieldYards.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(openFieldYards));

            if (!secondLevelYardsTotal.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(secondLevelYardsTotal));

            if (!secondLevelYards.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(secondLevelYards));

            if (!lineYardsTotal.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(lineYardsTotal));

            if (!lineYards.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(lineYards));

            if (!stuffRate.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(stuffRate));

            if (!powerSuccess.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(powerSuccess));

            if (!explosiveness.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(explosiveness));

            if (!successRate.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(successRate));

            if (!totalPPA.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(totalPPA));

            if (!ppa.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(ppa));

            if (!drives.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(drives));

            if (!plays.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStatOffense.", nameof(plays));

            if (passingPlays.IsSet && passingPlays.Value == null)
                throw new ArgumentNullException(nameof(passingPlays), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (rushingPlays.IsSet && rushingPlays.Value == null)
                throw new ArgumentNullException(nameof(rushingPlays), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (passingDowns.IsSet && passingDowns.Value == null)
                throw new ArgumentNullException(nameof(passingDowns), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (standardDowns.IsSet && standardDowns.Value == null)
                throw new ArgumentNullException(nameof(standardDowns), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (havoc.IsSet && havoc.Value == null)
                throw new ArgumentNullException(nameof(havoc), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (fieldPosition.IsSet && fieldPosition.Value == null)
                throw new ArgumentNullException(nameof(fieldPosition), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (pointsPerOpportunity.IsSet && pointsPerOpportunity.Value == null)
                throw new ArgumentNullException(nameof(pointsPerOpportunity), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (totalOpportunies.IsSet && totalOpportunies.Value == null)
                throw new ArgumentNullException(nameof(totalOpportunies), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (openFieldYardsTotal.IsSet && openFieldYardsTotal.Value == null)
                throw new ArgumentNullException(nameof(openFieldYardsTotal), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (openFieldYards.IsSet && openFieldYards.Value == null)
                throw new ArgumentNullException(nameof(openFieldYards), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (secondLevelYardsTotal.IsSet && secondLevelYardsTotal.Value == null)
                throw new ArgumentNullException(nameof(secondLevelYardsTotal), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (secondLevelYards.IsSet && secondLevelYards.Value == null)
                throw new ArgumentNullException(nameof(secondLevelYards), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (lineYardsTotal.IsSet && lineYardsTotal.Value == null)
                throw new ArgumentNullException(nameof(lineYardsTotal), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (lineYards.IsSet && lineYards.Value == null)
                throw new ArgumentNullException(nameof(lineYards), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (stuffRate.IsSet && stuffRate.Value == null)
                throw new ArgumentNullException(nameof(stuffRate), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (powerSuccess.IsSet && powerSuccess.Value == null)
                throw new ArgumentNullException(nameof(powerSuccess), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (explosiveness.IsSet && explosiveness.Value == null)
                throw new ArgumentNullException(nameof(explosiveness), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (successRate.IsSet && successRate.Value == null)
                throw new ArgumentNullException(nameof(successRate), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (totalPPA.IsSet && totalPPA.Value == null)
                throw new ArgumentNullException(nameof(totalPPA), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (ppa.IsSet && ppa.Value == null)
                throw new ArgumentNullException(nameof(ppa), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (drives.IsSet && drives.Value == null)
                throw new ArgumentNullException(nameof(drives), "Property is not nullable for class AdvancedSeasonStatOffense.");

            if (plays.IsSet && plays.Value == null)
                throw new ArgumentNullException(nameof(plays), "Property is not nullable for class AdvancedSeasonStatOffense.");

            return new AdvancedSeasonStatOffense(passingPlays.Value!, rushingPlays.Value!, passingDowns.Value!, standardDowns.Value!, havoc.Value!, fieldPosition.Value!, pointsPerOpportunity.Value!.Value!, totalOpportunies.Value!.Value!, openFieldYardsTotal.Value!.Value!, openFieldYards.Value!.Value!, secondLevelYardsTotal.Value!.Value!, secondLevelYards.Value!.Value!, lineYardsTotal.Value!.Value!, lineYards.Value!.Value!, stuffRate.Value!.Value!, powerSuccess.Value!.Value!, explosiveness.Value!.Value!, successRate.Value!.Value!, totalPPA.Value!.Value!, ppa.Value!.Value!, drives.Value!.Value!, plays.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AdvancedSeasonStatOffense" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedSeasonStatOffense"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AdvancedSeasonStatOffense advancedSeasonStatOffense, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, advancedSeasonStatOffense, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AdvancedSeasonStatOffense" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedSeasonStatOffense"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AdvancedSeasonStatOffense advancedSeasonStatOffense, JsonSerializerOptions jsonSerializerOptions)
        {
            if (advancedSeasonStatOffense.PassingPlays == null)
                throw new ArgumentNullException(nameof(advancedSeasonStatOffense.PassingPlays), "Property is required for class AdvancedSeasonStatOffense.");

            if (advancedSeasonStatOffense.RushingPlays == null)
                throw new ArgumentNullException(nameof(advancedSeasonStatOffense.RushingPlays), "Property is required for class AdvancedSeasonStatOffense.");

            if (advancedSeasonStatOffense.PassingDowns == null)
                throw new ArgumentNullException(nameof(advancedSeasonStatOffense.PassingDowns), "Property is required for class AdvancedSeasonStatOffense.");

            if (advancedSeasonStatOffense.StandardDowns == null)
                throw new ArgumentNullException(nameof(advancedSeasonStatOffense.StandardDowns), "Property is required for class AdvancedSeasonStatOffense.");

            if (advancedSeasonStatOffense.Havoc == null)
                throw new ArgumentNullException(nameof(advancedSeasonStatOffense.Havoc), "Property is required for class AdvancedSeasonStatOffense.");

            if (advancedSeasonStatOffense.FieldPosition == null)
                throw new ArgumentNullException(nameof(advancedSeasonStatOffense.FieldPosition), "Property is required for class AdvancedSeasonStatOffense.");

            writer.WritePropertyName("passingPlays");
            JsonSerializer.Serialize(writer, advancedSeasonStatOffense.PassingPlays, jsonSerializerOptions);
            writer.WritePropertyName("rushingPlays");
            JsonSerializer.Serialize(writer, advancedSeasonStatOffense.RushingPlays, jsonSerializerOptions);
            writer.WritePropertyName("passingDowns");
            JsonSerializer.Serialize(writer, advancedSeasonStatOffense.PassingDowns, jsonSerializerOptions);
            writer.WritePropertyName("standardDowns");
            JsonSerializer.Serialize(writer, advancedSeasonStatOffense.StandardDowns, jsonSerializerOptions);
            writer.WritePropertyName("havoc");
            JsonSerializer.Serialize(writer, advancedSeasonStatOffense.Havoc, jsonSerializerOptions);
            writer.WritePropertyName("fieldPosition");
            JsonSerializer.Serialize(writer, advancedSeasonStatOffense.FieldPosition, jsonSerializerOptions);
            writer.WriteNumber("pointsPerOpportunity", advancedSeasonStatOffense.PointsPerOpportunity);

            writer.WriteNumber("totalOpportunies", advancedSeasonStatOffense.TotalOpportunies);

            writer.WriteNumber("openFieldYardsTotal", advancedSeasonStatOffense.OpenFieldYardsTotal);

            writer.WriteNumber("openFieldYards", advancedSeasonStatOffense.OpenFieldYards);

            writer.WriteNumber("secondLevelYardsTotal", advancedSeasonStatOffense.SecondLevelYardsTotal);

            writer.WriteNumber("secondLevelYards", advancedSeasonStatOffense.SecondLevelYards);

            writer.WriteNumber("lineYardsTotal", advancedSeasonStatOffense.LineYardsTotal);

            writer.WriteNumber("lineYards", advancedSeasonStatOffense.LineYards);

            writer.WriteNumber("stuffRate", advancedSeasonStatOffense.StuffRate);

            writer.WriteNumber("powerSuccess", advancedSeasonStatOffense.PowerSuccess);

            writer.WriteNumber("explosiveness", advancedSeasonStatOffense.Explosiveness);

            writer.WriteNumber("successRate", advancedSeasonStatOffense.SuccessRate);

            writer.WriteNumber("totalPPA", advancedSeasonStatOffense.TotalPPA);

            writer.WriteNumber("ppa", advancedSeasonStatOffense.Ppa);

            writer.WriteNumber("drives", advancedSeasonStatOffense.Drives);

            writer.WriteNumber("plays", advancedSeasonStatOffense.Plays);
        }
    }
}

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
    /// AdvancedGameStatOffense
    /// </summary>
    public partial class AdvancedGameStatOffense : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedGameStatOffense" /> class.
        /// </summary>
        /// <param name="passingPlays">passingPlays</param>
        /// <param name="rushingPlays">rushingPlays</param>
        /// <param name="passingDowns">passingDowns</param>
        /// <param name="standardDowns">standardDowns</param>
        /// <param name="openFieldYardsTotal">openFieldYardsTotal</param>
        /// <param name="secondLevelYardsTotal">secondLevelYardsTotal</param>
        /// <param name="secondLevelYards">secondLevelYards</param>
        /// <param name="lineYardsTotal">lineYardsTotal</param>
        /// <param name="lineYards">lineYards</param>
        /// <param name="stuffRate">stuffRate</param>
        /// <param name="successRate">successRate</param>
        /// <param name="totalPPA">totalPPA</param>
        /// <param name="ppa">ppa</param>
        /// <param name="drives">drives</param>
        /// <param name="plays">plays</param>
        /// <param name="openFieldYards">openFieldYards</param>
        /// <param name="powerSuccess">powerSuccess</param>
        /// <param name="explosiveness">explosiveness</param>
        [JsonConstructor]
        public AdvancedGameStatOffense(AdvancedGameStatOffensePassingPlays passingPlays, AdvancedGameStatOffensePassingPlays rushingPlays, AdvancedGameStatOffensePassingDowns passingDowns, AdvancedGameStatOffensePassingDowns standardDowns, int openFieldYardsTotal, int secondLevelYardsTotal, double secondLevelYards, int lineYardsTotal, double lineYards, double stuffRate, double successRate, double totalPPA, double ppa, int drives, int plays, double? openFieldYards = default, double? powerSuccess = default, double? explosiveness = default)
        {
            PassingPlays = passingPlays;
            RushingPlays = rushingPlays;
            PassingDowns = passingDowns;
            StandardDowns = standardDowns;
            OpenFieldYardsTotal = openFieldYardsTotal;
            SecondLevelYardsTotal = secondLevelYardsTotal;
            SecondLevelYards = secondLevelYards;
            LineYardsTotal = lineYardsTotal;
            LineYards = lineYards;
            StuffRate = stuffRate;
            SuccessRate = successRate;
            TotalPPA = totalPPA;
            Ppa = ppa;
            Drives = drives;
            Plays = plays;
            OpenFieldYards = openFieldYards;
            PowerSuccess = powerSuccess;
            Explosiveness = explosiveness;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets PassingPlays
        /// </summary>
        [JsonPropertyName("passingPlays")]
        public AdvancedGameStatOffensePassingPlays PassingPlays { get; set; }

        /// <summary>
        /// Gets or Sets RushingPlays
        /// </summary>
        [JsonPropertyName("rushingPlays")]
        public AdvancedGameStatOffensePassingPlays RushingPlays { get; set; }

        /// <summary>
        /// Gets or Sets PassingDowns
        /// </summary>
        [JsonPropertyName("passingDowns")]
        public AdvancedGameStatOffensePassingDowns PassingDowns { get; set; }

        /// <summary>
        /// Gets or Sets StandardDowns
        /// </summary>
        [JsonPropertyName("standardDowns")]
        public AdvancedGameStatOffensePassingDowns StandardDowns { get; set; }

        /// <summary>
        /// Gets or Sets OpenFieldYardsTotal
        /// </summary>
        [JsonPropertyName("openFieldYardsTotal")]
        public int OpenFieldYardsTotal { get; set; }

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
        /// Gets or Sets OpenFieldYards
        /// </summary>
        [JsonPropertyName("openFieldYards")]
        public double? OpenFieldYards { get; set; }

        /// <summary>
        /// Gets or Sets PowerSuccess
        /// </summary>
        [JsonPropertyName("powerSuccess")]
        public double? PowerSuccess { get; set; }

        /// <summary>
        /// Gets or Sets Explosiveness
        /// </summary>
        [JsonPropertyName("explosiveness")]
        public double? Explosiveness { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdvancedGameStatOffense {\n");
            sb.Append("  PassingPlays: ").Append(PassingPlays).Append("\n");
            sb.Append("  RushingPlays: ").Append(RushingPlays).Append("\n");
            sb.Append("  PassingDowns: ").Append(PassingDowns).Append("\n");
            sb.Append("  StandardDowns: ").Append(StandardDowns).Append("\n");
            sb.Append("  OpenFieldYardsTotal: ").Append(OpenFieldYardsTotal).Append("\n");
            sb.Append("  SecondLevelYardsTotal: ").Append(SecondLevelYardsTotal).Append("\n");
            sb.Append("  SecondLevelYards: ").Append(SecondLevelYards).Append("\n");
            sb.Append("  LineYardsTotal: ").Append(LineYardsTotal).Append("\n");
            sb.Append("  LineYards: ").Append(LineYards).Append("\n");
            sb.Append("  StuffRate: ").Append(StuffRate).Append("\n");
            sb.Append("  SuccessRate: ").Append(SuccessRate).Append("\n");
            sb.Append("  TotalPPA: ").Append(TotalPPA).Append("\n");
            sb.Append("  Ppa: ").Append(Ppa).Append("\n");
            sb.Append("  Drives: ").Append(Drives).Append("\n");
            sb.Append("  Plays: ").Append(Plays).Append("\n");
            sb.Append("  OpenFieldYards: ").Append(OpenFieldYards).Append("\n");
            sb.Append("  PowerSuccess: ").Append(PowerSuccess).Append("\n");
            sb.Append("  Explosiveness: ").Append(Explosiveness).Append("\n");
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
    /// A Json converter for type <see cref="AdvancedGameStatOffense" />
    /// </summary>
    public class AdvancedGameStatOffenseJsonConverter : JsonConverter<AdvancedGameStatOffense>
    {
        /// <summary>
        /// Deserializes json to <see cref="AdvancedGameStatOffense" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AdvancedGameStatOffense Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<AdvancedGameStatOffensePassingPlays?> passingPlays = default;
            Option<AdvancedGameStatOffensePassingPlays?> rushingPlays = default;
            Option<AdvancedGameStatOffensePassingDowns?> passingDowns = default;
            Option<AdvancedGameStatOffensePassingDowns?> standardDowns = default;
            Option<int?> openFieldYardsTotal = default;
            Option<int?> secondLevelYardsTotal = default;
            Option<double?> secondLevelYards = default;
            Option<int?> lineYardsTotal = default;
            Option<double?> lineYards = default;
            Option<double?> stuffRate = default;
            Option<double?> successRate = default;
            Option<double?> totalPPA = default;
            Option<double?> ppa = default;
            Option<int?> drives = default;
            Option<int?> plays = default;
            Option<double?> openFieldYards = default;
            Option<double?> powerSuccess = default;
            Option<double?> explosiveness = default;

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
                            passingPlays = new Option<AdvancedGameStatOffensePassingPlays?>(JsonSerializer.Deserialize<AdvancedGameStatOffensePassingPlays>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "rushingPlays":
                            rushingPlays = new Option<AdvancedGameStatOffensePassingPlays?>(JsonSerializer.Deserialize<AdvancedGameStatOffensePassingPlays>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "passingDowns":
                            passingDowns = new Option<AdvancedGameStatOffensePassingDowns?>(JsonSerializer.Deserialize<AdvancedGameStatOffensePassingDowns>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "standardDowns":
                            standardDowns = new Option<AdvancedGameStatOffensePassingDowns?>(JsonSerializer.Deserialize<AdvancedGameStatOffensePassingDowns>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "openFieldYardsTotal":
                            openFieldYardsTotal = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "secondLevelYardsTotal":
                            secondLevelYardsTotal = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "secondLevelYards":
                            secondLevelYards = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "lineYardsTotal":
                            lineYardsTotal = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "lineYards":
                            lineYards = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "stuffRate":
                            stuffRate = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "successRate":
                            successRate = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "totalPPA":
                            totalPPA = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "ppa":
                            ppa = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "drives":
                            drives = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "plays":
                            plays = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "openFieldYards":
                            openFieldYards = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "powerSuccess":
                            powerSuccess = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "explosiveness":
                            explosiveness = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!passingPlays.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(passingPlays));

            if (!rushingPlays.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(rushingPlays));

            if (!passingDowns.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(passingDowns));

            if (!standardDowns.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(standardDowns));

            if (!openFieldYardsTotal.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(openFieldYardsTotal));

            if (!secondLevelYardsTotal.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(secondLevelYardsTotal));

            if (!secondLevelYards.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(secondLevelYards));

            if (!lineYardsTotal.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(lineYardsTotal));

            if (!lineYards.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(lineYards));

            if (!stuffRate.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(stuffRate));

            if (!successRate.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(successRate));

            if (!totalPPA.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(totalPPA));

            if (!ppa.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(ppa));

            if (!drives.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(drives));

            if (!plays.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(plays));

            if (!openFieldYards.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(openFieldYards));

            if (!powerSuccess.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(powerSuccess));

            if (!explosiveness.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStatOffense.", nameof(explosiveness));

            if (passingPlays.IsSet && passingPlays.Value == null)
                throw new ArgumentNullException(nameof(passingPlays), "Property is not nullable for class AdvancedGameStatOffense.");

            if (rushingPlays.IsSet && rushingPlays.Value == null)
                throw new ArgumentNullException(nameof(rushingPlays), "Property is not nullable for class AdvancedGameStatOffense.");

            if (passingDowns.IsSet && passingDowns.Value == null)
                throw new ArgumentNullException(nameof(passingDowns), "Property is not nullable for class AdvancedGameStatOffense.");

            if (standardDowns.IsSet && standardDowns.Value == null)
                throw new ArgumentNullException(nameof(standardDowns), "Property is not nullable for class AdvancedGameStatOffense.");

            if (openFieldYardsTotal.IsSet && openFieldYardsTotal.Value == null)
                throw new ArgumentNullException(nameof(openFieldYardsTotal), "Property is not nullable for class AdvancedGameStatOffense.");

            if (secondLevelYardsTotal.IsSet && secondLevelYardsTotal.Value == null)
                throw new ArgumentNullException(nameof(secondLevelYardsTotal), "Property is not nullable for class AdvancedGameStatOffense.");

            if (secondLevelYards.IsSet && secondLevelYards.Value == null)
                throw new ArgumentNullException(nameof(secondLevelYards), "Property is not nullable for class AdvancedGameStatOffense.");

            if (lineYardsTotal.IsSet && lineYardsTotal.Value == null)
                throw new ArgumentNullException(nameof(lineYardsTotal), "Property is not nullable for class AdvancedGameStatOffense.");

            if (lineYards.IsSet && lineYards.Value == null)
                throw new ArgumentNullException(nameof(lineYards), "Property is not nullable for class AdvancedGameStatOffense.");

            if (stuffRate.IsSet && stuffRate.Value == null)
                throw new ArgumentNullException(nameof(stuffRate), "Property is not nullable for class AdvancedGameStatOffense.");

            if (successRate.IsSet && successRate.Value == null)
                throw new ArgumentNullException(nameof(successRate), "Property is not nullable for class AdvancedGameStatOffense.");

            if (totalPPA.IsSet && totalPPA.Value == null)
                throw new ArgumentNullException(nameof(totalPPA), "Property is not nullable for class AdvancedGameStatOffense.");

            if (ppa.IsSet && ppa.Value == null)
                throw new ArgumentNullException(nameof(ppa), "Property is not nullable for class AdvancedGameStatOffense.");

            if (drives.IsSet && drives.Value == null)
                throw new ArgumentNullException(nameof(drives), "Property is not nullable for class AdvancedGameStatOffense.");

            if (plays.IsSet && plays.Value == null)
                throw new ArgumentNullException(nameof(plays), "Property is not nullable for class AdvancedGameStatOffense.");

            return new AdvancedGameStatOffense(passingPlays.Value!, rushingPlays.Value!, passingDowns.Value!, standardDowns.Value!, openFieldYardsTotal.Value!.Value!, secondLevelYardsTotal.Value!.Value!, secondLevelYards.Value!.Value!, lineYardsTotal.Value!.Value!, lineYards.Value!.Value!, stuffRate.Value!.Value!, successRate.Value!.Value!, totalPPA.Value!.Value!, ppa.Value!.Value!, drives.Value!.Value!, plays.Value!.Value!, openFieldYards.Value!, powerSuccess.Value!, explosiveness.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AdvancedGameStatOffense" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedGameStatOffense"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AdvancedGameStatOffense advancedGameStatOffense, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, advancedGameStatOffense, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AdvancedGameStatOffense" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedGameStatOffense"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AdvancedGameStatOffense advancedGameStatOffense, JsonSerializerOptions jsonSerializerOptions)
        {
            if (advancedGameStatOffense.PassingPlays == null)
                throw new ArgumentNullException(nameof(advancedGameStatOffense.PassingPlays), "Property is required for class AdvancedGameStatOffense.");

            if (advancedGameStatOffense.RushingPlays == null)
                throw new ArgumentNullException(nameof(advancedGameStatOffense.RushingPlays), "Property is required for class AdvancedGameStatOffense.");

            if (advancedGameStatOffense.PassingDowns == null)
                throw new ArgumentNullException(nameof(advancedGameStatOffense.PassingDowns), "Property is required for class AdvancedGameStatOffense.");

            if (advancedGameStatOffense.StandardDowns == null)
                throw new ArgumentNullException(nameof(advancedGameStatOffense.StandardDowns), "Property is required for class AdvancedGameStatOffense.");

            writer.WritePropertyName("passingPlays");
            JsonSerializer.Serialize(writer, advancedGameStatOffense.PassingPlays, jsonSerializerOptions);
            writer.WritePropertyName("rushingPlays");
            JsonSerializer.Serialize(writer, advancedGameStatOffense.RushingPlays, jsonSerializerOptions);
            writer.WritePropertyName("passingDowns");
            JsonSerializer.Serialize(writer, advancedGameStatOffense.PassingDowns, jsonSerializerOptions);
            writer.WritePropertyName("standardDowns");
            JsonSerializer.Serialize(writer, advancedGameStatOffense.StandardDowns, jsonSerializerOptions);
            writer.WriteNumber("openFieldYardsTotal", advancedGameStatOffense.OpenFieldYardsTotal);

            writer.WriteNumber("secondLevelYardsTotal", advancedGameStatOffense.SecondLevelYardsTotal);

            writer.WriteNumber("secondLevelYards", advancedGameStatOffense.SecondLevelYards);

            writer.WriteNumber("lineYardsTotal", advancedGameStatOffense.LineYardsTotal);

            writer.WriteNumber("lineYards", advancedGameStatOffense.LineYards);

            writer.WriteNumber("stuffRate", advancedGameStatOffense.StuffRate);

            writer.WriteNumber("successRate", advancedGameStatOffense.SuccessRate);

            writer.WriteNumber("totalPPA", advancedGameStatOffense.TotalPPA);

            writer.WriteNumber("ppa", advancedGameStatOffense.Ppa);

            writer.WriteNumber("drives", advancedGameStatOffense.Drives);

            writer.WriteNumber("plays", advancedGameStatOffense.Plays);

            if (advancedGameStatOffense.OpenFieldYards != null)
                writer.WriteNumber("openFieldYards", advancedGameStatOffense.OpenFieldYards.Value);
            else
                writer.WriteNull("openFieldYards");

            if (advancedGameStatOffense.PowerSuccess != null)
                writer.WriteNumber("powerSuccess", advancedGameStatOffense.PowerSuccess.Value);
            else
                writer.WriteNull("powerSuccess");

            if (advancedGameStatOffense.Explosiveness != null)
                writer.WriteNumber("explosiveness", advancedGameStatOffense.Explosiveness.Value);
            else
                writer.WriteNull("explosiveness");
        }
    }
}

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
    /// AdvancedBoxScoreTeams
    /// </summary>
    public partial class AdvancedBoxScoreTeams : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedBoxScoreTeams" /> class.
        /// </summary>
        /// <param name="fieldPosition">fieldPosition</param>
        /// <param name="scoringOpportunities">scoringOpportunities</param>
        /// <param name="havoc">havoc</param>
        /// <param name="rushing">rushing</param>
        /// <param name="explosiveness">explosiveness</param>
        /// <param name="successRates">successRates</param>
        /// <param name="cumulativePpa">cumulativePpa</param>
        /// <param name="ppa">ppa</param>
        [JsonConstructor]
        public AdvancedBoxScoreTeams(List<TeamFieldPosition> fieldPosition, List<TeamScoringOpportunities> scoringOpportunities, List<TeamHavoc> havoc, List<TeamRushingStats> rushing, List<TeamExplosiveness> explosiveness, List<TeamSuccessRates> successRates, List<TeamPPA> cumulativePpa, List<TeamPPA> ppa)
        {
            FieldPosition = fieldPosition;
            ScoringOpportunities = scoringOpportunities;
            Havoc = havoc;
            Rushing = rushing;
            Explosiveness = explosiveness;
            SuccessRates = successRates;
            CumulativePpa = cumulativePpa;
            Ppa = ppa;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets FieldPosition
        /// </summary>
        [JsonPropertyName("fieldPosition")]
        public List<TeamFieldPosition> FieldPosition { get; set; }

        /// <summary>
        /// Gets or Sets ScoringOpportunities
        /// </summary>
        [JsonPropertyName("scoringOpportunities")]
        public List<TeamScoringOpportunities> ScoringOpportunities { get; set; }

        /// <summary>
        /// Gets or Sets Havoc
        /// </summary>
        [JsonPropertyName("havoc")]
        public List<TeamHavoc> Havoc { get; set; }

        /// <summary>
        /// Gets or Sets Rushing
        /// </summary>
        [JsonPropertyName("rushing")]
        public List<TeamRushingStats> Rushing { get; set; }

        /// <summary>
        /// Gets or Sets Explosiveness
        /// </summary>
        [JsonPropertyName("explosiveness")]
        public List<TeamExplosiveness> Explosiveness { get; set; }

        /// <summary>
        /// Gets or Sets SuccessRates
        /// </summary>
        [JsonPropertyName("successRates")]
        public List<TeamSuccessRates> SuccessRates { get; set; }

        /// <summary>
        /// Gets or Sets CumulativePpa
        /// </summary>
        [JsonPropertyName("cumulativePpa")]
        public List<TeamPPA> CumulativePpa { get; set; }

        /// <summary>
        /// Gets or Sets Ppa
        /// </summary>
        [JsonPropertyName("ppa")]
        public List<TeamPPA> Ppa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdvancedBoxScoreTeams {\n");
            sb.Append("  FieldPosition: ").Append(FieldPosition).Append("\n");
            sb.Append("  ScoringOpportunities: ").Append(ScoringOpportunities).Append("\n");
            sb.Append("  Havoc: ").Append(Havoc).Append("\n");
            sb.Append("  Rushing: ").Append(Rushing).Append("\n");
            sb.Append("  Explosiveness: ").Append(Explosiveness).Append("\n");
            sb.Append("  SuccessRates: ").Append(SuccessRates).Append("\n");
            sb.Append("  CumulativePpa: ").Append(CumulativePpa).Append("\n");
            sb.Append("  Ppa: ").Append(Ppa).Append("\n");
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
    /// A Json converter for type <see cref="AdvancedBoxScoreTeams" />
    /// </summary>
    public class AdvancedBoxScoreTeamsJsonConverter : JsonConverter<AdvancedBoxScoreTeams>
    {
        /// <summary>
        /// Deserializes json to <see cref="AdvancedBoxScoreTeams" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AdvancedBoxScoreTeams Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<TeamFieldPosition>?> fieldPosition = default;
            Option<List<TeamScoringOpportunities>?> scoringOpportunities = default;
            Option<List<TeamHavoc>?> havoc = default;
            Option<List<TeamRushingStats>?> rushing = default;
            Option<List<TeamExplosiveness>?> explosiveness = default;
            Option<List<TeamSuccessRates>?> successRates = default;
            Option<List<TeamPPA>?> cumulativePpa = default;
            Option<List<TeamPPA>?> ppa = default;

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
                        case "fieldPosition":
                            fieldPosition = new Option<List<TeamFieldPosition>?>(JsonSerializer.Deserialize<List<TeamFieldPosition>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "scoringOpportunities":
                            scoringOpportunities = new Option<List<TeamScoringOpportunities>?>(JsonSerializer.Deserialize<List<TeamScoringOpportunities>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "havoc":
                            havoc = new Option<List<TeamHavoc>?>(JsonSerializer.Deserialize<List<TeamHavoc>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "rushing":
                            rushing = new Option<List<TeamRushingStats>?>(JsonSerializer.Deserialize<List<TeamRushingStats>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "explosiveness":
                            explosiveness = new Option<List<TeamExplosiveness>?>(JsonSerializer.Deserialize<List<TeamExplosiveness>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "successRates":
                            successRates = new Option<List<TeamSuccessRates>?>(JsonSerializer.Deserialize<List<TeamSuccessRates>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "cumulativePpa":
                            cumulativePpa = new Option<List<TeamPPA>?>(JsonSerializer.Deserialize<List<TeamPPA>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "ppa":
                            ppa = new Option<List<TeamPPA>?>(JsonSerializer.Deserialize<List<TeamPPA>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!fieldPosition.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScoreTeams.", nameof(fieldPosition));

            if (!scoringOpportunities.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScoreTeams.", nameof(scoringOpportunities));

            if (!havoc.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScoreTeams.", nameof(havoc));

            if (!rushing.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScoreTeams.", nameof(rushing));

            if (!explosiveness.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScoreTeams.", nameof(explosiveness));

            if (!successRates.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScoreTeams.", nameof(successRates));

            if (!cumulativePpa.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScoreTeams.", nameof(cumulativePpa));

            if (!ppa.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScoreTeams.", nameof(ppa));

            if (fieldPosition.IsSet && fieldPosition.Value == null)
                throw new ArgumentNullException(nameof(fieldPosition), "Property is not nullable for class AdvancedBoxScoreTeams.");

            if (scoringOpportunities.IsSet && scoringOpportunities.Value == null)
                throw new ArgumentNullException(nameof(scoringOpportunities), "Property is not nullable for class AdvancedBoxScoreTeams.");

            if (havoc.IsSet && havoc.Value == null)
                throw new ArgumentNullException(nameof(havoc), "Property is not nullable for class AdvancedBoxScoreTeams.");

            if (rushing.IsSet && rushing.Value == null)
                throw new ArgumentNullException(nameof(rushing), "Property is not nullable for class AdvancedBoxScoreTeams.");

            if (explosiveness.IsSet && explosiveness.Value == null)
                throw new ArgumentNullException(nameof(explosiveness), "Property is not nullable for class AdvancedBoxScoreTeams.");

            if (successRates.IsSet && successRates.Value == null)
                throw new ArgumentNullException(nameof(successRates), "Property is not nullable for class AdvancedBoxScoreTeams.");

            if (cumulativePpa.IsSet && cumulativePpa.Value == null)
                throw new ArgumentNullException(nameof(cumulativePpa), "Property is not nullable for class AdvancedBoxScoreTeams.");

            if (ppa.IsSet && ppa.Value == null)
                throw new ArgumentNullException(nameof(ppa), "Property is not nullable for class AdvancedBoxScoreTeams.");

            return new AdvancedBoxScoreTeams(fieldPosition.Value!, scoringOpportunities.Value!, havoc.Value!, rushing.Value!, explosiveness.Value!, successRates.Value!, cumulativePpa.Value!, ppa.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AdvancedBoxScoreTeams" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedBoxScoreTeams"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AdvancedBoxScoreTeams advancedBoxScoreTeams, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, advancedBoxScoreTeams, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AdvancedBoxScoreTeams" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedBoxScoreTeams"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AdvancedBoxScoreTeams advancedBoxScoreTeams, JsonSerializerOptions jsonSerializerOptions)
        {
            if (advancedBoxScoreTeams.FieldPosition == null)
                throw new ArgumentNullException(nameof(advancedBoxScoreTeams.FieldPosition), "Property is required for class AdvancedBoxScoreTeams.");

            if (advancedBoxScoreTeams.ScoringOpportunities == null)
                throw new ArgumentNullException(nameof(advancedBoxScoreTeams.ScoringOpportunities), "Property is required for class AdvancedBoxScoreTeams.");

            if (advancedBoxScoreTeams.Havoc == null)
                throw new ArgumentNullException(nameof(advancedBoxScoreTeams.Havoc), "Property is required for class AdvancedBoxScoreTeams.");

            if (advancedBoxScoreTeams.Rushing == null)
                throw new ArgumentNullException(nameof(advancedBoxScoreTeams.Rushing), "Property is required for class AdvancedBoxScoreTeams.");

            if (advancedBoxScoreTeams.Explosiveness == null)
                throw new ArgumentNullException(nameof(advancedBoxScoreTeams.Explosiveness), "Property is required for class AdvancedBoxScoreTeams.");

            if (advancedBoxScoreTeams.SuccessRates == null)
                throw new ArgumentNullException(nameof(advancedBoxScoreTeams.SuccessRates), "Property is required for class AdvancedBoxScoreTeams.");

            if (advancedBoxScoreTeams.CumulativePpa == null)
                throw new ArgumentNullException(nameof(advancedBoxScoreTeams.CumulativePpa), "Property is required for class AdvancedBoxScoreTeams.");

            if (advancedBoxScoreTeams.Ppa == null)
                throw new ArgumentNullException(nameof(advancedBoxScoreTeams.Ppa), "Property is required for class AdvancedBoxScoreTeams.");

            writer.WritePropertyName("fieldPosition");
            JsonSerializer.Serialize(writer, advancedBoxScoreTeams.FieldPosition, jsonSerializerOptions);
            writer.WritePropertyName("scoringOpportunities");
            JsonSerializer.Serialize(writer, advancedBoxScoreTeams.ScoringOpportunities, jsonSerializerOptions);
            writer.WritePropertyName("havoc");
            JsonSerializer.Serialize(writer, advancedBoxScoreTeams.Havoc, jsonSerializerOptions);
            writer.WritePropertyName("rushing");
            JsonSerializer.Serialize(writer, advancedBoxScoreTeams.Rushing, jsonSerializerOptions);
            writer.WritePropertyName("explosiveness");
            JsonSerializer.Serialize(writer, advancedBoxScoreTeams.Explosiveness, jsonSerializerOptions);
            writer.WritePropertyName("successRates");
            JsonSerializer.Serialize(writer, advancedBoxScoreTeams.SuccessRates, jsonSerializerOptions);
            writer.WritePropertyName("cumulativePpa");
            JsonSerializer.Serialize(writer, advancedBoxScoreTeams.CumulativePpa, jsonSerializerOptions);
            writer.WritePropertyName("ppa");
            JsonSerializer.Serialize(writer, advancedBoxScoreTeams.Ppa, jsonSerializerOptions);
        }
    }
}

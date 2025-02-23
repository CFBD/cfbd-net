/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.2
 * Contact: admin@collegefootballdata.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = CollegeFootballData.Client.OpenAPIDateConverter;

namespace CollegeFootballData.Model
{
    /// <summary>
    /// AdvancedBoxScoreTeams
    /// </summary>
    [DataContract(Name = "AdvancedBoxScore_teams")]
    public partial class AdvancedBoxScoreTeams : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedBoxScoreTeams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdvancedBoxScoreTeams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedBoxScoreTeams" /> class.
        /// </summary>
        /// <param name="fieldPosition">fieldPosition (required).</param>
        /// <param name="scoringOpportunities">scoringOpportunities (required).</param>
        /// <param name="havoc">havoc (required).</param>
        /// <param name="rushing">rushing (required).</param>
        /// <param name="explosiveness">explosiveness (required).</param>
        /// <param name="successRates">successRates (required).</param>
        /// <param name="cumulativePpa">cumulativePpa (required).</param>
        /// <param name="ppa">ppa (required).</param>
        public AdvancedBoxScoreTeams(List<TeamFieldPosition> fieldPosition = default(List<TeamFieldPosition>), List<TeamScoringOpportunities> scoringOpportunities = default(List<TeamScoringOpportunities>), List<TeamHavoc> havoc = default(List<TeamHavoc>), List<TeamRushingStats> rushing = default(List<TeamRushingStats>), List<TeamExplosiveness> explosiveness = default(List<TeamExplosiveness>), List<TeamSuccessRates> successRates = default(List<TeamSuccessRates>), List<TeamPPA> cumulativePpa = default(List<TeamPPA>), List<TeamPPA> ppa = default(List<TeamPPA>))
        {
            // to ensure "fieldPosition" is required (not null)
            if (fieldPosition == null)
            {
                throw new ArgumentNullException("fieldPosition is a required property for AdvancedBoxScoreTeams and cannot be null");
            }
            this.FieldPosition = fieldPosition;
            // to ensure "scoringOpportunities" is required (not null)
            if (scoringOpportunities == null)
            {
                throw new ArgumentNullException("scoringOpportunities is a required property for AdvancedBoxScoreTeams and cannot be null");
            }
            this.ScoringOpportunities = scoringOpportunities;
            // to ensure "havoc" is required (not null)
            if (havoc == null)
            {
                throw new ArgumentNullException("havoc is a required property for AdvancedBoxScoreTeams and cannot be null");
            }
            this.Havoc = havoc;
            // to ensure "rushing" is required (not null)
            if (rushing == null)
            {
                throw new ArgumentNullException("rushing is a required property for AdvancedBoxScoreTeams and cannot be null");
            }
            this.Rushing = rushing;
            // to ensure "explosiveness" is required (not null)
            if (explosiveness == null)
            {
                throw new ArgumentNullException("explosiveness is a required property for AdvancedBoxScoreTeams and cannot be null");
            }
            this.Explosiveness = explosiveness;
            // to ensure "successRates" is required (not null)
            if (successRates == null)
            {
                throw new ArgumentNullException("successRates is a required property for AdvancedBoxScoreTeams and cannot be null");
            }
            this.SuccessRates = successRates;
            // to ensure "cumulativePpa" is required (not null)
            if (cumulativePpa == null)
            {
                throw new ArgumentNullException("cumulativePpa is a required property for AdvancedBoxScoreTeams and cannot be null");
            }
            this.CumulativePpa = cumulativePpa;
            // to ensure "ppa" is required (not null)
            if (ppa == null)
            {
                throw new ArgumentNullException("ppa is a required property for AdvancedBoxScoreTeams and cannot be null");
            }
            this.Ppa = ppa;
        }

        /// <summary>
        /// Gets or Sets FieldPosition
        /// </summary>
        [DataMember(Name = "fieldPosition", IsRequired = true, EmitDefaultValue = true)]
        public List<TeamFieldPosition> FieldPosition { get; set; }

        /// <summary>
        /// Gets or Sets ScoringOpportunities
        /// </summary>
        [DataMember(Name = "scoringOpportunities", IsRequired = true, EmitDefaultValue = true)]
        public List<TeamScoringOpportunities> ScoringOpportunities { get; set; }

        /// <summary>
        /// Gets or Sets Havoc
        /// </summary>
        [DataMember(Name = "havoc", IsRequired = true, EmitDefaultValue = true)]
        public List<TeamHavoc> Havoc { get; set; }

        /// <summary>
        /// Gets or Sets Rushing
        /// </summary>
        [DataMember(Name = "rushing", IsRequired = true, EmitDefaultValue = true)]
        public List<TeamRushingStats> Rushing { get; set; }

        /// <summary>
        /// Gets or Sets Explosiveness
        /// </summary>
        [DataMember(Name = "explosiveness", IsRequired = true, EmitDefaultValue = true)]
        public List<TeamExplosiveness> Explosiveness { get; set; }

        /// <summary>
        /// Gets or Sets SuccessRates
        /// </summary>
        [DataMember(Name = "successRates", IsRequired = true, EmitDefaultValue = true)]
        public List<TeamSuccessRates> SuccessRates { get; set; }

        /// <summary>
        /// Gets or Sets CumulativePpa
        /// </summary>
        [DataMember(Name = "cumulativePpa", IsRequired = true, EmitDefaultValue = true)]
        public List<TeamPPA> CumulativePpa { get; set; }

        /// <summary>
        /// Gets or Sets Ppa
        /// </summary>
        [DataMember(Name = "ppa", IsRequired = true, EmitDefaultValue = true)]
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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

}

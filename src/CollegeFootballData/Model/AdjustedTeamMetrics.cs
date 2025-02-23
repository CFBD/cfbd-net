/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.3
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
    /// AdjustedTeamMetrics
    /// </summary>
    [DataContract(Name = "AdjustedTeamMetrics")]
    public partial class AdjustedTeamMetrics : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdjustedTeamMetrics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdjustedTeamMetrics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdjustedTeamMetrics" /> class.
        /// </summary>
        /// <param name="year">year (required).</param>
        /// <param name="teamId">teamId (required).</param>
        /// <param name="team">team (required).</param>
        /// <param name="conference">conference (required).</param>
        /// <param name="epa">epa (required).</param>
        /// <param name="epaAllowed">epaAllowed (required).</param>
        /// <param name="successRate">successRate (required).</param>
        /// <param name="successRateAllowed">successRateAllowed (required).</param>
        /// <param name="rushing">rushing (required).</param>
        /// <param name="rushingAllowed">rushingAllowed (required).</param>
        /// <param name="explosiveness">explosiveness (required).</param>
        /// <param name="explosivenessAllowed">explosivenessAllowed (required).</param>
        public AdjustedTeamMetrics(int year = default(int), int teamId = default(int), string team = default(string), string conference = default(string), AdjustedTeamMetricsEpa epa = default(AdjustedTeamMetricsEpa), AdjustedTeamMetricsEpa epaAllowed = default(AdjustedTeamMetricsEpa), AdjustedTeamMetricsSuccessRate successRate = default(AdjustedTeamMetricsSuccessRate), AdjustedTeamMetricsSuccessRate successRateAllowed = default(AdjustedTeamMetricsSuccessRate), AdjustedTeamMetricsRushing rushing = default(AdjustedTeamMetricsRushing), AdjustedTeamMetricsRushing rushingAllowed = default(AdjustedTeamMetricsRushing), double explosiveness = default(double), double explosivenessAllowed = default(double))
        {
            this.Year = year;
            this.TeamId = teamId;
            // to ensure "team" is required (not null)
            if (team == null)
            {
                throw new ArgumentNullException("team is a required property for AdjustedTeamMetrics and cannot be null");
            }
            this.Team = team;
            // to ensure "conference" is required (not null)
            if (conference == null)
            {
                throw new ArgumentNullException("conference is a required property for AdjustedTeamMetrics and cannot be null");
            }
            this.Conference = conference;
            // to ensure "epa" is required (not null)
            if (epa == null)
            {
                throw new ArgumentNullException("epa is a required property for AdjustedTeamMetrics and cannot be null");
            }
            this.Epa = epa;
            // to ensure "epaAllowed" is required (not null)
            if (epaAllowed == null)
            {
                throw new ArgumentNullException("epaAllowed is a required property for AdjustedTeamMetrics and cannot be null");
            }
            this.EpaAllowed = epaAllowed;
            // to ensure "successRate" is required (not null)
            if (successRate == null)
            {
                throw new ArgumentNullException("successRate is a required property for AdjustedTeamMetrics and cannot be null");
            }
            this.SuccessRate = successRate;
            // to ensure "successRateAllowed" is required (not null)
            if (successRateAllowed == null)
            {
                throw new ArgumentNullException("successRateAllowed is a required property for AdjustedTeamMetrics and cannot be null");
            }
            this.SuccessRateAllowed = successRateAllowed;
            // to ensure "rushing" is required (not null)
            if (rushing == null)
            {
                throw new ArgumentNullException("rushing is a required property for AdjustedTeamMetrics and cannot be null");
            }
            this.Rushing = rushing;
            // to ensure "rushingAllowed" is required (not null)
            if (rushingAllowed == null)
            {
                throw new ArgumentNullException("rushingAllowed is a required property for AdjustedTeamMetrics and cannot be null");
            }
            this.RushingAllowed = rushingAllowed;
            this.Explosiveness = explosiveness;
            this.ExplosivenessAllowed = explosivenessAllowed;
        }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", IsRequired = true, EmitDefaultValue = true)]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name = "teamId", IsRequired = true, EmitDefaultValue = true)]
        public int TeamId { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", IsRequired = true, EmitDefaultValue = true)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [DataMember(Name = "conference", IsRequired = true, EmitDefaultValue = true)]
        public string Conference { get; set; }

        /// <summary>
        /// Gets or Sets Epa
        /// </summary>
        [DataMember(Name = "epa", IsRequired = true, EmitDefaultValue = true)]
        public AdjustedTeamMetricsEpa Epa { get; set; }

        /// <summary>
        /// Gets or Sets EpaAllowed
        /// </summary>
        [DataMember(Name = "epaAllowed", IsRequired = true, EmitDefaultValue = true)]
        public AdjustedTeamMetricsEpa EpaAllowed { get; set; }

        /// <summary>
        /// Gets or Sets SuccessRate
        /// </summary>
        [DataMember(Name = "successRate", IsRequired = true, EmitDefaultValue = true)]
        public AdjustedTeamMetricsSuccessRate SuccessRate { get; set; }

        /// <summary>
        /// Gets or Sets SuccessRateAllowed
        /// </summary>
        [DataMember(Name = "successRateAllowed", IsRequired = true, EmitDefaultValue = true)]
        public AdjustedTeamMetricsSuccessRate SuccessRateAllowed { get; set; }

        /// <summary>
        /// Gets or Sets Rushing
        /// </summary>
        [DataMember(Name = "rushing", IsRequired = true, EmitDefaultValue = true)]
        public AdjustedTeamMetricsRushing Rushing { get; set; }

        /// <summary>
        /// Gets or Sets RushingAllowed
        /// </summary>
        [DataMember(Name = "rushingAllowed", IsRequired = true, EmitDefaultValue = true)]
        public AdjustedTeamMetricsRushing RushingAllowed { get; set; }

        /// <summary>
        /// Gets or Sets Explosiveness
        /// </summary>
        [DataMember(Name = "explosiveness", IsRequired = true, EmitDefaultValue = true)]
        public double Explosiveness { get; set; }

        /// <summary>
        /// Gets or Sets ExplosivenessAllowed
        /// </summary>
        [DataMember(Name = "explosivenessAllowed", IsRequired = true, EmitDefaultValue = true)]
        public double ExplosivenessAllowed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdjustedTeamMetrics {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Epa: ").Append(Epa).Append("\n");
            sb.Append("  EpaAllowed: ").Append(EpaAllowed).Append("\n");
            sb.Append("  SuccessRate: ").Append(SuccessRate).Append("\n");
            sb.Append("  SuccessRateAllowed: ").Append(SuccessRateAllowed).Append("\n");
            sb.Append("  Rushing: ").Append(Rushing).Append("\n");
            sb.Append("  RushingAllowed: ").Append(RushingAllowed).Append("\n");
            sb.Append("  Explosiveness: ").Append(Explosiveness).Append("\n");
            sb.Append("  ExplosivenessAllowed: ").Append(ExplosivenessAllowed).Append("\n");
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

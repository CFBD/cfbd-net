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
    /// ReturningProduction
    /// </summary>
    [DataContract(Name = "ReturningProduction")]
    public partial class ReturningProduction : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturningProduction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReturningProduction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturningProduction" /> class.
        /// </summary>
        /// <param name="season">season (required).</param>
        /// <param name="team">team (required).</param>
        /// <param name="conference">conference (required).</param>
        /// <param name="totalPPA">totalPPA (required).</param>
        /// <param name="totalPassingPPA">totalPassingPPA (required).</param>
        /// <param name="totalReceivingPPA">totalReceivingPPA (required).</param>
        /// <param name="totalRushingPPA">totalRushingPPA (required).</param>
        /// <param name="percentPPA">percentPPA (required).</param>
        /// <param name="percentPassingPPA">percentPassingPPA (required).</param>
        /// <param name="percentReceivingPPA">percentReceivingPPA (required).</param>
        /// <param name="percentRushingPPA">percentRushingPPA (required).</param>
        /// <param name="usage">usage (required).</param>
        /// <param name="passingUsage">passingUsage (required).</param>
        /// <param name="receivingUsage">receivingUsage (required).</param>
        /// <param name="rushingUsage">rushingUsage (required).</param>
        public ReturningProduction(int season = default(int), string team = default(string), string conference = default(string), double totalPPA = default(double), double totalPassingPPA = default(double), double totalReceivingPPA = default(double), double totalRushingPPA = default(double), double percentPPA = default(double), double percentPassingPPA = default(double), double percentReceivingPPA = default(double), double percentRushingPPA = default(double), double usage = default(double), double passingUsage = default(double), double receivingUsage = default(double), double rushingUsage = default(double))
        {
            this.Season = season;
            // to ensure "team" is required (not null)
            if (team == null)
            {
                throw new ArgumentNullException("team is a required property for ReturningProduction and cannot be null");
            }
            this.Team = team;
            // to ensure "conference" is required (not null)
            if (conference == null)
            {
                throw new ArgumentNullException("conference is a required property for ReturningProduction and cannot be null");
            }
            this.Conference = conference;
            this.TotalPPA = totalPPA;
            this.TotalPassingPPA = totalPassingPPA;
            this.TotalReceivingPPA = totalReceivingPPA;
            this.TotalRushingPPA = totalRushingPPA;
            this.PercentPPA = percentPPA;
            this.PercentPassingPPA = percentPassingPPA;
            this.PercentReceivingPPA = percentReceivingPPA;
            this.PercentRushingPPA = percentRushingPPA;
            this.Usage = usage;
            this.PassingUsage = passingUsage;
            this.ReceivingUsage = receivingUsage;
            this.RushingUsage = rushingUsage;
        }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", IsRequired = true, EmitDefaultValue = true)]
        public int Season { get; set; }

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
        /// Gets or Sets TotalPPA
        /// </summary>
        [DataMember(Name = "totalPPA", IsRequired = true, EmitDefaultValue = true)]
        public double TotalPPA { get; set; }

        /// <summary>
        /// Gets or Sets TotalPassingPPA
        /// </summary>
        [DataMember(Name = "totalPassingPPA", IsRequired = true, EmitDefaultValue = true)]
        public double TotalPassingPPA { get; set; }

        /// <summary>
        /// Gets or Sets TotalReceivingPPA
        /// </summary>
        [DataMember(Name = "totalReceivingPPA", IsRequired = true, EmitDefaultValue = true)]
        public double TotalReceivingPPA { get; set; }

        /// <summary>
        /// Gets or Sets TotalRushingPPA
        /// </summary>
        [DataMember(Name = "totalRushingPPA", IsRequired = true, EmitDefaultValue = true)]
        public double TotalRushingPPA { get; set; }

        /// <summary>
        /// Gets or Sets PercentPPA
        /// </summary>
        [DataMember(Name = "percentPPA", IsRequired = true, EmitDefaultValue = true)]
        public double PercentPPA { get; set; }

        /// <summary>
        /// Gets or Sets PercentPassingPPA
        /// </summary>
        [DataMember(Name = "percentPassingPPA", IsRequired = true, EmitDefaultValue = true)]
        public double PercentPassingPPA { get; set; }

        /// <summary>
        /// Gets or Sets PercentReceivingPPA
        /// </summary>
        [DataMember(Name = "percentReceivingPPA", IsRequired = true, EmitDefaultValue = true)]
        public double PercentReceivingPPA { get; set; }

        /// <summary>
        /// Gets or Sets PercentRushingPPA
        /// </summary>
        [DataMember(Name = "percentRushingPPA", IsRequired = true, EmitDefaultValue = true)]
        public double PercentRushingPPA { get; set; }

        /// <summary>
        /// Gets or Sets Usage
        /// </summary>
        [DataMember(Name = "usage", IsRequired = true, EmitDefaultValue = true)]
        public double Usage { get; set; }

        /// <summary>
        /// Gets or Sets PassingUsage
        /// </summary>
        [DataMember(Name = "passingUsage", IsRequired = true, EmitDefaultValue = true)]
        public double PassingUsage { get; set; }

        /// <summary>
        /// Gets or Sets ReceivingUsage
        /// </summary>
        [DataMember(Name = "receivingUsage", IsRequired = true, EmitDefaultValue = true)]
        public double ReceivingUsage { get; set; }

        /// <summary>
        /// Gets or Sets RushingUsage
        /// </summary>
        [DataMember(Name = "rushingUsage", IsRequired = true, EmitDefaultValue = true)]
        public double RushingUsage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReturningProduction {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  TotalPPA: ").Append(TotalPPA).Append("\n");
            sb.Append("  TotalPassingPPA: ").Append(TotalPassingPPA).Append("\n");
            sb.Append("  TotalReceivingPPA: ").Append(TotalReceivingPPA).Append("\n");
            sb.Append("  TotalRushingPPA: ").Append(TotalRushingPPA).Append("\n");
            sb.Append("  PercentPPA: ").Append(PercentPPA).Append("\n");
            sb.Append("  PercentPassingPPA: ").Append(PercentPassingPPA).Append("\n");
            sb.Append("  PercentReceivingPPA: ").Append(PercentReceivingPPA).Append("\n");
            sb.Append("  PercentRushingPPA: ").Append(PercentRushingPPA).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
            sb.Append("  PassingUsage: ").Append(PassingUsage).Append("\n");
            sb.Append("  ReceivingUsage: ").Append(ReceivingUsage).Append("\n");
            sb.Append("  RushingUsage: ").Append(RushingUsage).Append("\n");
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

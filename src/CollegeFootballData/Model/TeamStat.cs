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
    /// TeamStat
    /// </summary>
    [DataContract(Name = "TeamStat")]
    public partial class TeamStat : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamStat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeamStat() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamStat" /> class.
        /// </summary>
        /// <param name="season">season (required).</param>
        /// <param name="team">team (required).</param>
        /// <param name="conference">conference (required).</param>
        /// <param name="statName">statName (required).</param>
        /// <param name="statValue">statValue (required).</param>
        public TeamStat(int season = default(int), string team = default(string), string conference = default(string), string statName = default(string), TeamStatStatValue statValue = default(TeamStatStatValue))
        {
            this.Season = season;
            // to ensure "team" is required (not null)
            if (team == null)
            {
                throw new ArgumentNullException("team is a required property for TeamStat and cannot be null");
            }
            this.Team = team;
            // to ensure "conference" is required (not null)
            if (conference == null)
            {
                throw new ArgumentNullException("conference is a required property for TeamStat and cannot be null");
            }
            this.Conference = conference;
            // to ensure "statName" is required (not null)
            if (statName == null)
            {
                throw new ArgumentNullException("statName is a required property for TeamStat and cannot be null");
            }
            this.StatName = statName;
            // to ensure "statValue" is required (not null)
            if (statValue == null)
            {
                throw new ArgumentNullException("statValue is a required property for TeamStat and cannot be null");
            }
            this.StatValue = statValue;
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
        /// Gets or Sets StatName
        /// </summary>
        [DataMember(Name = "statName", IsRequired = true, EmitDefaultValue = true)]
        public string StatName { get; set; }

        /// <summary>
        /// Gets or Sets StatValue
        /// </summary>
        [DataMember(Name = "statValue", IsRequired = true, EmitDefaultValue = true)]
        public TeamStatStatValue StatValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamStat {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  StatName: ").Append(StatName).Append("\n");
            sb.Append("  StatValue: ").Append(StatValue).Append("\n");
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

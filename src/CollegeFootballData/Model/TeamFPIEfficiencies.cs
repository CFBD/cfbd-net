/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.5.1
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
    /// TeamFPIEfficiencies
    /// </summary>
    [DataContract(Name = "TeamFPI_efficiencies")]
    public partial class TeamFPIEfficiencies : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamFPIEfficiencies" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeamFPIEfficiencies() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamFPIEfficiencies" /> class.
        /// </summary>
        /// <param name="specialTeams">specialTeams (required).</param>
        /// <param name="defense">defense (required).</param>
        /// <param name="offense">offense (required).</param>
        /// <param name="overall">overall (required).</param>
        public TeamFPIEfficiencies(double? specialTeams = default(double?), double? defense = default(double?), double? offense = default(double?), double? overall = default(double?))
        {
            // to ensure "specialTeams" is required (not null)
            if (specialTeams == null)
            {
                throw new ArgumentNullException("specialTeams is a required property for TeamFPIEfficiencies and cannot be null");
            }
            this.SpecialTeams = specialTeams;
            // to ensure "defense" is required (not null)
            if (defense == null)
            {
                throw new ArgumentNullException("defense is a required property for TeamFPIEfficiencies and cannot be null");
            }
            this.Defense = defense;
            // to ensure "offense" is required (not null)
            if (offense == null)
            {
                throw new ArgumentNullException("offense is a required property for TeamFPIEfficiencies and cannot be null");
            }
            this.Offense = offense;
            // to ensure "overall" is required (not null)
            if (overall == null)
            {
                throw new ArgumentNullException("overall is a required property for TeamFPIEfficiencies and cannot be null");
            }
            this.Overall = overall;
        }

        /// <summary>
        /// Gets or Sets SpecialTeams
        /// </summary>
        [DataMember(Name = "specialTeams", IsRequired = true, EmitDefaultValue = true)]
        public double? SpecialTeams { get; set; }

        /// <summary>
        /// Gets or Sets Defense
        /// </summary>
        [DataMember(Name = "defense", IsRequired = true, EmitDefaultValue = true)]
        public double? Defense { get; set; }

        /// <summary>
        /// Gets or Sets Offense
        /// </summary>
        [DataMember(Name = "offense", IsRequired = true, EmitDefaultValue = true)]
        public double? Offense { get; set; }

        /// <summary>
        /// Gets or Sets Overall
        /// </summary>
        [DataMember(Name = "overall", IsRequired = true, EmitDefaultValue = true)]
        public double? Overall { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamFPIEfficiencies {\n");
            sb.Append("  SpecialTeams: ").Append(SpecialTeams).Append("\n");
            sb.Append("  Defense: ").Append(Defense).Append("\n");
            sb.Append("  Offense: ").Append(Offense).Append("\n");
            sb.Append("  Overall: ").Append(Overall).Append("\n");
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

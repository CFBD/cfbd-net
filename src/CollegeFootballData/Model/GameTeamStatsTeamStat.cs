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
    /// GameTeamStatsTeamStat
    /// </summary>
    [DataContract(Name = "GameTeamStatsTeamStat")]
    public partial class GameTeamStatsTeamStat : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameTeamStatsTeamStat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GameTeamStatsTeamStat() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GameTeamStatsTeamStat" /> class.
        /// </summary>
        /// <param name="category">category (required).</param>
        /// <param name="stat">stat (required).</param>
        public GameTeamStatsTeamStat(string category = default(string), string stat = default(string))
        {
            // to ensure "category" is required (not null)
            if (category == null)
            {
                throw new ArgumentNullException("category is a required property for GameTeamStatsTeamStat and cannot be null");
            }
            this.Category = category;
            // to ensure "stat" is required (not null)
            if (stat == null)
            {
                throw new ArgumentNullException("stat is a required property for GameTeamStatsTeamStat and cannot be null");
            }
            this.Stat = stat;
        }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = true)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Stat
        /// </summary>
        [DataMember(Name = "stat", IsRequired = true, EmitDefaultValue = true)]
        public string Stat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GameTeamStatsTeamStat {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Stat: ").Append(Stat).Append("\n");
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

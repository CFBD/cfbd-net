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
    /// TeamSeasonPredictedPointsAdded
    /// </summary>
    [DataContract(Name = "TeamSeasonPredictedPointsAdded")]
    public partial class TeamSeasonPredictedPointsAdded : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSeasonPredictedPointsAdded" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeamSeasonPredictedPointsAdded() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSeasonPredictedPointsAdded" /> class.
        /// </summary>
        /// <param name="season">season (required).</param>
        /// <param name="conference">conference (required).</param>
        /// <param name="team">team (required).</param>
        /// <param name="offense">offense (required).</param>
        /// <param name="defense">defense (required).</param>
        public TeamSeasonPredictedPointsAdded(int season = default(int), string conference = default(string), string team = default(string), TeamSeasonPredictedPointsAddedOffense offense = default(TeamSeasonPredictedPointsAddedOffense), TeamSeasonPredictedPointsAddedOffense defense = default(TeamSeasonPredictedPointsAddedOffense))
        {
            this.Season = season;
            // to ensure "conference" is required (not null)
            if (conference == null)
            {
                throw new ArgumentNullException("conference is a required property for TeamSeasonPredictedPointsAdded and cannot be null");
            }
            this.Conference = conference;
            // to ensure "team" is required (not null)
            if (team == null)
            {
                throw new ArgumentNullException("team is a required property for TeamSeasonPredictedPointsAdded and cannot be null");
            }
            this.Team = team;
            // to ensure "offense" is required (not null)
            if (offense == null)
            {
                throw new ArgumentNullException("offense is a required property for TeamSeasonPredictedPointsAdded and cannot be null");
            }
            this.Offense = offense;
            // to ensure "defense" is required (not null)
            if (defense == null)
            {
                throw new ArgumentNullException("defense is a required property for TeamSeasonPredictedPointsAdded and cannot be null");
            }
            this.Defense = defense;
        }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", IsRequired = true, EmitDefaultValue = true)]
        public int Season { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [DataMember(Name = "conference", IsRequired = true, EmitDefaultValue = true)]
        public string Conference { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", IsRequired = true, EmitDefaultValue = true)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Offense
        /// </summary>
        [DataMember(Name = "offense", IsRequired = true, EmitDefaultValue = true)]
        public TeamSeasonPredictedPointsAddedOffense Offense { get; set; }

        /// <summary>
        /// Gets or Sets Defense
        /// </summary>
        [DataMember(Name = "defense", IsRequired = true, EmitDefaultValue = true)]
        public TeamSeasonPredictedPointsAddedOffense Defense { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamSeasonPredictedPointsAdded {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Offense: ").Append(Offense).Append("\n");
            sb.Append("  Defense: ").Append(Defense).Append("\n");
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

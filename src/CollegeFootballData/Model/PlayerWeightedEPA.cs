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
    /// PlayerWeightedEPA
    /// </summary>
    [DataContract(Name = "PlayerWeightedEPA")]
    public partial class PlayerWeightedEPA : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerWeightedEPA" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlayerWeightedEPA() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerWeightedEPA" /> class.
        /// </summary>
        /// <param name="year">year (required).</param>
        /// <param name="athleteId">athleteId (required).</param>
        /// <param name="athleteName">athleteName (required).</param>
        /// <param name="position">position (required).</param>
        /// <param name="team">team (required).</param>
        /// <param name="conference">conference (required).</param>
        /// <param name="wepa">wepa (required).</param>
        /// <param name="plays">plays (required).</param>
        public PlayerWeightedEPA(int year = default(int), string athleteId = default(string), string athleteName = default(string), string position = default(string), string team = default(string), string conference = default(string), double wepa = default(double), int plays = default(int))
        {
            this.Year = year;
            // to ensure "athleteId" is required (not null)
            if (athleteId == null)
            {
                throw new ArgumentNullException("athleteId is a required property for PlayerWeightedEPA and cannot be null");
            }
            this.AthleteId = athleteId;
            // to ensure "athleteName" is required (not null)
            if (athleteName == null)
            {
                throw new ArgumentNullException("athleteName is a required property for PlayerWeightedEPA and cannot be null");
            }
            this.AthleteName = athleteName;
            // to ensure "position" is required (not null)
            if (position == null)
            {
                throw new ArgumentNullException("position is a required property for PlayerWeightedEPA and cannot be null");
            }
            this.Position = position;
            // to ensure "team" is required (not null)
            if (team == null)
            {
                throw new ArgumentNullException("team is a required property for PlayerWeightedEPA and cannot be null");
            }
            this.Team = team;
            // to ensure "conference" is required (not null)
            if (conference == null)
            {
                throw new ArgumentNullException("conference is a required property for PlayerWeightedEPA and cannot be null");
            }
            this.Conference = conference;
            this.Wepa = wepa;
            this.Plays = plays;
        }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", IsRequired = true, EmitDefaultValue = true)]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets AthleteId
        /// </summary>
        [DataMember(Name = "athleteId", IsRequired = true, EmitDefaultValue = true)]
        public string AthleteId { get; set; }

        /// <summary>
        /// Gets or Sets AthleteName
        /// </summary>
        [DataMember(Name = "athleteName", IsRequired = true, EmitDefaultValue = true)]
        public string AthleteName { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", IsRequired = true, EmitDefaultValue = true)]
        public string Position { get; set; }

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
        /// Gets or Sets Wepa
        /// </summary>
        [DataMember(Name = "wepa", IsRequired = true, EmitDefaultValue = true)]
        public double Wepa { get; set; }

        /// <summary>
        /// Gets or Sets Plays
        /// </summary>
        [DataMember(Name = "plays", IsRequired = true, EmitDefaultValue = true)]
        public int Plays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerWeightedEPA {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  AthleteId: ").Append(AthleteId).Append("\n");
            sb.Append("  AthleteName: ").Append(AthleteName).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Wepa: ").Append(Wepa).Append("\n");
            sb.Append("  Plays: ").Append(Plays).Append("\n");
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

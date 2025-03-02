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
    /// CoachSeason
    /// </summary>
    [DataContract(Name = "CoachSeason")]
    public partial class CoachSeason : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoachSeason" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CoachSeason() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CoachSeason" /> class.
        /// </summary>
        /// <param name="school">school (required).</param>
        /// <param name="year">year (required).</param>
        /// <param name="games">games (required).</param>
        /// <param name="wins">wins (required).</param>
        /// <param name="losses">losses (required).</param>
        /// <param name="ties">ties (required).</param>
        /// <param name="preseasonRank">preseasonRank (required).</param>
        /// <param name="postseasonRank">postseasonRank (required).</param>
        /// <param name="srs">srs (required).</param>
        /// <param name="spOverall">spOverall (required).</param>
        /// <param name="spOffense">spOffense (required).</param>
        /// <param name="spDefense">spDefense (required).</param>
        public CoachSeason(string school = default(string), int year = default(int), int games = default(int), int wins = default(int), int losses = default(int), int ties = default(int), int? preseasonRank = default(int?), int? postseasonRank = default(int?), double? srs = default(double?), double? spOverall = default(double?), double? spOffense = default(double?), double? spDefense = default(double?))
        {
            // to ensure "school" is required (not null)
            if (school == null)
            {
                throw new ArgumentNullException("school is a required property for CoachSeason and cannot be null");
            }
            this.School = school;
            this.Year = year;
            this.Games = games;
            this.Wins = wins;
            this.Losses = losses;
            this.Ties = ties;
            // to ensure "preseasonRank" is required (not null)
            if (preseasonRank == null)
            {
                throw new ArgumentNullException("preseasonRank is a required property for CoachSeason and cannot be null");
            }
            this.PreseasonRank = preseasonRank;
            // to ensure "postseasonRank" is required (not null)
            if (postseasonRank == null)
            {
                throw new ArgumentNullException("postseasonRank is a required property for CoachSeason and cannot be null");
            }
            this.PostseasonRank = postseasonRank;
            // to ensure "srs" is required (not null)
            if (srs == null)
            {
                throw new ArgumentNullException("srs is a required property for CoachSeason and cannot be null");
            }
            this.Srs = srs;
            // to ensure "spOverall" is required (not null)
            if (spOverall == null)
            {
                throw new ArgumentNullException("spOverall is a required property for CoachSeason and cannot be null");
            }
            this.SpOverall = spOverall;
            // to ensure "spOffense" is required (not null)
            if (spOffense == null)
            {
                throw new ArgumentNullException("spOffense is a required property for CoachSeason and cannot be null");
            }
            this.SpOffense = spOffense;
            // to ensure "spDefense" is required (not null)
            if (spDefense == null)
            {
                throw new ArgumentNullException("spDefense is a required property for CoachSeason and cannot be null");
            }
            this.SpDefense = spDefense;
        }

        /// <summary>
        /// Gets or Sets School
        /// </summary>
        [DataMember(Name = "school", IsRequired = true, EmitDefaultValue = true)]
        public string School { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", IsRequired = true, EmitDefaultValue = true)]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets Games
        /// </summary>
        [DataMember(Name = "games", IsRequired = true, EmitDefaultValue = true)]
        public int Games { get; set; }

        /// <summary>
        /// Gets or Sets Wins
        /// </summary>
        [DataMember(Name = "wins", IsRequired = true, EmitDefaultValue = true)]
        public int Wins { get; set; }

        /// <summary>
        /// Gets or Sets Losses
        /// </summary>
        [DataMember(Name = "losses", IsRequired = true, EmitDefaultValue = true)]
        public int Losses { get; set; }

        /// <summary>
        /// Gets or Sets Ties
        /// </summary>
        [DataMember(Name = "ties", IsRequired = true, EmitDefaultValue = true)]
        public int Ties { get; set; }

        /// <summary>
        /// Gets or Sets PreseasonRank
        /// </summary>
        [DataMember(Name = "preseasonRank", IsRequired = true, EmitDefaultValue = true)]
        public int? PreseasonRank { get; set; }

        /// <summary>
        /// Gets or Sets PostseasonRank
        /// </summary>
        [DataMember(Name = "postseasonRank", IsRequired = true, EmitDefaultValue = true)]
        public int? PostseasonRank { get; set; }

        /// <summary>
        /// Gets or Sets Srs
        /// </summary>
        [DataMember(Name = "srs", IsRequired = true, EmitDefaultValue = true)]
        public double? Srs { get; set; }

        /// <summary>
        /// Gets or Sets SpOverall
        /// </summary>
        [DataMember(Name = "spOverall", IsRequired = true, EmitDefaultValue = true)]
        public double? SpOverall { get; set; }

        /// <summary>
        /// Gets or Sets SpOffense
        /// </summary>
        [DataMember(Name = "spOffense", IsRequired = true, EmitDefaultValue = true)]
        public double? SpOffense { get; set; }

        /// <summary>
        /// Gets or Sets SpDefense
        /// </summary>
        [DataMember(Name = "spDefense", IsRequired = true, EmitDefaultValue = true)]
        public double? SpDefense { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CoachSeason {\n");
            sb.Append("  School: ").Append(School).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Games: ").Append(Games).Append("\n");
            sb.Append("  Wins: ").Append(Wins).Append("\n");
            sb.Append("  Losses: ").Append(Losses).Append("\n");
            sb.Append("  Ties: ").Append(Ties).Append("\n");
            sb.Append("  PreseasonRank: ").Append(PreseasonRank).Append("\n");
            sb.Append("  PostseasonRank: ").Append(PostseasonRank).Append("\n");
            sb.Append("  Srs: ").Append(Srs).Append("\n");
            sb.Append("  SpOverall: ").Append(SpOverall).Append("\n");
            sb.Append("  SpOffense: ").Append(SpOffense).Append("\n");
            sb.Append("  SpDefense: ").Append(SpDefense).Append("\n");
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

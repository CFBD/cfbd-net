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
    /// MatchupGame
    /// </summary>
    [DataContract(Name = "MatchupGame")]
    public partial class MatchupGame : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchupGame" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MatchupGame() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchupGame" /> class.
        /// </summary>
        /// <param name="season">season (required).</param>
        /// <param name="week">week (required).</param>
        /// <param name="seasonType">seasonType (required).</param>
        /// <param name="date">date (required).</param>
        /// <param name="neutralSite">neutralSite (required).</param>
        /// <param name="venue">venue (required).</param>
        /// <param name="homeTeam">homeTeam (required).</param>
        /// <param name="homeScore">homeScore (required).</param>
        /// <param name="awayTeam">awayTeam (required).</param>
        /// <param name="awayScore">awayScore (required).</param>
        /// <param name="winner">winner (required).</param>
        public MatchupGame(int season = default(int), int week = default(int), string seasonType = default(string), string date = default(string), bool neutralSite = default(bool), string venue = default(string), string homeTeam = default(string), int? homeScore = default(int?), string awayTeam = default(string), int? awayScore = default(int?), string winner = default(string))
        {
            this.Season = season;
            this.Week = week;
            // to ensure "seasonType" is required (not null)
            if (seasonType == null)
            {
                throw new ArgumentNullException("seasonType is a required property for MatchupGame and cannot be null");
            }
            this.SeasonType = seasonType;
            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new ArgumentNullException("date is a required property for MatchupGame and cannot be null");
            }
            this.Date = date;
            this.NeutralSite = neutralSite;
            // to ensure "venue" is required (not null)
            if (venue == null)
            {
                throw new ArgumentNullException("venue is a required property for MatchupGame and cannot be null");
            }
            this.Venue = venue;
            // to ensure "homeTeam" is required (not null)
            if (homeTeam == null)
            {
                throw new ArgumentNullException("homeTeam is a required property for MatchupGame and cannot be null");
            }
            this.HomeTeam = homeTeam;
            // to ensure "homeScore" is required (not null)
            if (homeScore == null)
            {
                throw new ArgumentNullException("homeScore is a required property for MatchupGame and cannot be null");
            }
            this.HomeScore = homeScore;
            // to ensure "awayTeam" is required (not null)
            if (awayTeam == null)
            {
                throw new ArgumentNullException("awayTeam is a required property for MatchupGame and cannot be null");
            }
            this.AwayTeam = awayTeam;
            // to ensure "awayScore" is required (not null)
            if (awayScore == null)
            {
                throw new ArgumentNullException("awayScore is a required property for MatchupGame and cannot be null");
            }
            this.AwayScore = awayScore;
            // to ensure "winner" is required (not null)
            if (winner == null)
            {
                throw new ArgumentNullException("winner is a required property for MatchupGame and cannot be null");
            }
            this.Winner = winner;
        }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", IsRequired = true, EmitDefaultValue = true)]
        public int Season { get; set; }

        /// <summary>
        /// Gets or Sets Week
        /// </summary>
        [DataMember(Name = "week", IsRequired = true, EmitDefaultValue = true)]
        public int Week { get; set; }

        /// <summary>
        /// Gets or Sets SeasonType
        /// </summary>
        [DataMember(Name = "seasonType", IsRequired = true, EmitDefaultValue = true)]
        public string SeasonType { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
        public string Date { get; set; }

        /// <summary>
        /// Gets or Sets NeutralSite
        /// </summary>
        [DataMember(Name = "neutralSite", IsRequired = true, EmitDefaultValue = true)]
        public bool NeutralSite { get; set; }

        /// <summary>
        /// Gets or Sets Venue
        /// </summary>
        [DataMember(Name = "venue", IsRequired = true, EmitDefaultValue = true)]
        public string Venue { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeam
        /// </summary>
        [DataMember(Name = "homeTeam", IsRequired = true, EmitDefaultValue = true)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Gets or Sets HomeScore
        /// </summary>
        [DataMember(Name = "homeScore", IsRequired = true, EmitDefaultValue = true)]
        public int? HomeScore { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeam
        /// </summary>
        [DataMember(Name = "awayTeam", IsRequired = true, EmitDefaultValue = true)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// Gets or Sets AwayScore
        /// </summary>
        [DataMember(Name = "awayScore", IsRequired = true, EmitDefaultValue = true)]
        public int? AwayScore { get; set; }

        /// <summary>
        /// Gets or Sets Winner
        /// </summary>
        [DataMember(Name = "winner", IsRequired = true, EmitDefaultValue = true)]
        public string Winner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MatchupGame {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  SeasonType: ").Append(SeasonType).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  NeutralSite: ").Append(NeutralSite).Append("\n");
            sb.Append("  Venue: ").Append(Venue).Append("\n");
            sb.Append("  HomeTeam: ").Append(HomeTeam).Append("\n");
            sb.Append("  HomeScore: ").Append(HomeScore).Append("\n");
            sb.Append("  AwayTeam: ").Append(AwayTeam).Append("\n");
            sb.Append("  AwayScore: ").Append(AwayScore).Append("\n");
            sb.Append("  Winner: ").Append(Winner).Append("\n");
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

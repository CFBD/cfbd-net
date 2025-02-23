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
    /// TeamRecords
    /// </summary>
    [DataContract(Name = "TeamRecords")]
    public partial class TeamRecords : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Classification
        /// </summary>
        [DataMember(Name = "classification", IsRequired = true, EmitDefaultValue = true)]
        public DivisionClassification Classification { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRecords" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeamRecords() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRecords" /> class.
        /// </summary>
        /// <param name="year">year (required).</param>
        /// <param name="teamId">teamId (required).</param>
        /// <param name="team">team (required).</param>
        /// <param name="classification">classification (required).</param>
        /// <param name="conference">conference (required).</param>
        /// <param name="division">division (required).</param>
        /// <param name="expectedWins">expectedWins (required).</param>
        /// <param name="total">total (required).</param>
        /// <param name="conferenceGames">conferenceGames (required).</param>
        /// <param name="homeGames">homeGames (required).</param>
        /// <param name="awayGames">awayGames (required).</param>
        /// <param name="neutralSiteGames">neutralSiteGames (required).</param>
        /// <param name="regularSeason">regularSeason (required).</param>
        /// <param name="postseason">postseason (required).</param>
        public TeamRecords(int year = default(int), int teamId = default(int), string team = default(string), DivisionClassification classification = default(DivisionClassification), string conference = default(string), string division = default(string), double? expectedWins = default(double?), TeamRecord total = default(TeamRecord), TeamRecord conferenceGames = default(TeamRecord), TeamRecord homeGames = default(TeamRecord), TeamRecord awayGames = default(TeamRecord), TeamRecord neutralSiteGames = default(TeamRecord), TeamRecord regularSeason = default(TeamRecord), TeamRecord postseason = default(TeamRecord))
        {
            this.Year = year;
            this.TeamId = teamId;
            // to ensure "team" is required (not null)
            if (team == null)
            {
                throw new ArgumentNullException("team is a required property for TeamRecords and cannot be null");
            }
            this.Team = team;
            this.Classification = classification;
            // to ensure "conference" is required (not null)
            if (conference == null)
            {
                throw new ArgumentNullException("conference is a required property for TeamRecords and cannot be null");
            }
            this.Conference = conference;
            // to ensure "division" is required (not null)
            if (division == null)
            {
                throw new ArgumentNullException("division is a required property for TeamRecords and cannot be null");
            }
            this.Division = division;
            // to ensure "expectedWins" is required (not null)
            if (expectedWins == null)
            {
                throw new ArgumentNullException("expectedWins is a required property for TeamRecords and cannot be null");
            }
            this.ExpectedWins = expectedWins;
            // to ensure "total" is required (not null)
            if (total == null)
            {
                throw new ArgumentNullException("total is a required property for TeamRecords and cannot be null");
            }
            this.Total = total;
            // to ensure "conferenceGames" is required (not null)
            if (conferenceGames == null)
            {
                throw new ArgumentNullException("conferenceGames is a required property for TeamRecords and cannot be null");
            }
            this.ConferenceGames = conferenceGames;
            // to ensure "homeGames" is required (not null)
            if (homeGames == null)
            {
                throw new ArgumentNullException("homeGames is a required property for TeamRecords and cannot be null");
            }
            this.HomeGames = homeGames;
            // to ensure "awayGames" is required (not null)
            if (awayGames == null)
            {
                throw new ArgumentNullException("awayGames is a required property for TeamRecords and cannot be null");
            }
            this.AwayGames = awayGames;
            // to ensure "neutralSiteGames" is required (not null)
            if (neutralSiteGames == null)
            {
                throw new ArgumentNullException("neutralSiteGames is a required property for TeamRecords and cannot be null");
            }
            this.NeutralSiteGames = neutralSiteGames;
            // to ensure "regularSeason" is required (not null)
            if (regularSeason == null)
            {
                throw new ArgumentNullException("regularSeason is a required property for TeamRecords and cannot be null");
            }
            this.RegularSeason = regularSeason;
            // to ensure "postseason" is required (not null)
            if (postseason == null)
            {
                throw new ArgumentNullException("postseason is a required property for TeamRecords and cannot be null");
            }
            this.Postseason = postseason;
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
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name = "division", IsRequired = true, EmitDefaultValue = true)]
        public string Division { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedWins
        /// </summary>
        [DataMember(Name = "expectedWins", IsRequired = true, EmitDefaultValue = true)]
        public double? ExpectedWins { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public TeamRecord Total { get; set; }

        /// <summary>
        /// Gets or Sets ConferenceGames
        /// </summary>
        [DataMember(Name = "conferenceGames", IsRequired = true, EmitDefaultValue = true)]
        public TeamRecord ConferenceGames { get; set; }

        /// <summary>
        /// Gets or Sets HomeGames
        /// </summary>
        [DataMember(Name = "homeGames", IsRequired = true, EmitDefaultValue = true)]
        public TeamRecord HomeGames { get; set; }

        /// <summary>
        /// Gets or Sets AwayGames
        /// </summary>
        [DataMember(Name = "awayGames", IsRequired = true, EmitDefaultValue = true)]
        public TeamRecord AwayGames { get; set; }

        /// <summary>
        /// Gets or Sets NeutralSiteGames
        /// </summary>
        [DataMember(Name = "neutralSiteGames", IsRequired = true, EmitDefaultValue = true)]
        public TeamRecord NeutralSiteGames { get; set; }

        /// <summary>
        /// Gets or Sets RegularSeason
        /// </summary>
        [DataMember(Name = "regularSeason", IsRequired = true, EmitDefaultValue = true)]
        public TeamRecord RegularSeason { get; set; }

        /// <summary>
        /// Gets or Sets Postseason
        /// </summary>
        [DataMember(Name = "postseason", IsRequired = true, EmitDefaultValue = true)]
        public TeamRecord Postseason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamRecords {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  ExpectedWins: ").Append(ExpectedWins).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  ConferenceGames: ").Append(ConferenceGames).Append("\n");
            sb.Append("  HomeGames: ").Append(HomeGames).Append("\n");
            sb.Append("  AwayGames: ").Append(AwayGames).Append("\n");
            sb.Append("  NeutralSiteGames: ").Append(NeutralSiteGames).Append("\n");
            sb.Append("  RegularSeason: ").Append(RegularSeason).Append("\n");
            sb.Append("  Postseason: ").Append(Postseason).Append("\n");
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

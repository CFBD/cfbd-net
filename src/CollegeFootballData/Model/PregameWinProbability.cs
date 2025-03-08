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
    /// PregameWinProbability
    /// </summary>
    [DataContract(Name = "PregameWinProbability")]
    public partial class PregameWinProbability : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets SeasonType
        /// </summary>
        [DataMember(Name = "seasonType", IsRequired = true, EmitDefaultValue = true)]
        public SeasonType SeasonType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PregameWinProbability" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PregameWinProbability() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PregameWinProbability" /> class.
        /// </summary>
        /// <param name="season">season (required).</param>
        /// <param name="seasonType">seasonType (required).</param>
        /// <param name="week">week (required).</param>
        /// <param name="gameId">gameId (required).</param>
        /// <param name="homeTeam">homeTeam (required).</param>
        /// <param name="awayTeam">awayTeam (required).</param>
        /// <param name="spread">spread (required).</param>
        /// <param name="homeWinProbability">homeWinProbability (required).</param>
        public PregameWinProbability(int season = default(int), SeasonType seasonType = default(SeasonType), int week = default(int), int gameId = default(int), string homeTeam = default(string), string awayTeam = default(string), double spread = default(double), double homeWinProbability = default(double))
        {
            this.Season = season;
            this.SeasonType = seasonType;
            this.Week = week;
            this.GameId = gameId;
            // to ensure "homeTeam" is required (not null)
            if (homeTeam == null)
            {
                throw new ArgumentNullException("homeTeam is a required property for PregameWinProbability and cannot be null");
            }
            this.HomeTeam = homeTeam;
            // to ensure "awayTeam" is required (not null)
            if (awayTeam == null)
            {
                throw new ArgumentNullException("awayTeam is a required property for PregameWinProbability and cannot be null");
            }
            this.AwayTeam = awayTeam;
            this.Spread = spread;
            this.HomeWinProbability = homeWinProbability;
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
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name = "gameId", IsRequired = true, EmitDefaultValue = true)]
        public int GameId { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeam
        /// </summary>
        [DataMember(Name = "homeTeam", IsRequired = true, EmitDefaultValue = true)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeam
        /// </summary>
        [DataMember(Name = "awayTeam", IsRequired = true, EmitDefaultValue = true)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// Gets or Sets Spread
        /// </summary>
        [DataMember(Name = "spread", IsRequired = true, EmitDefaultValue = true)]
        public double Spread { get; set; }

        /// <summary>
        /// Gets or Sets HomeWinProbability
        /// </summary>
        [DataMember(Name = "homeWinProbability", IsRequired = true, EmitDefaultValue = true)]
        public double HomeWinProbability { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PregameWinProbability {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  SeasonType: ").Append(SeasonType).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  HomeTeam: ").Append(HomeTeam).Append("\n");
            sb.Append("  AwayTeam: ").Append(AwayTeam).Append("\n");
            sb.Append("  Spread: ").Append(Spread).Append("\n");
            sb.Append("  HomeWinProbability: ").Append(HomeWinProbability).Append("\n");
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

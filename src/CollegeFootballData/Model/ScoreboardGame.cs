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
    /// ScoreboardGame
    /// </summary>
    [DataContract(Name = "ScoreboardGame")]
    public partial class ScoreboardGame : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public GameStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreboardGame" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScoreboardGame() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreboardGame" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="startDate">startDate (required).</param>
        /// <param name="startTimeTBD">startTimeTBD (required).</param>
        /// <param name="tv">tv (required).</param>
        /// <param name="neutralSite">neutralSite (required).</param>
        /// <param name="conferenceGame">conferenceGame (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="period">period (required).</param>
        /// <param name="clock">clock (required).</param>
        /// <param name="situation">situation (required).</param>
        /// <param name="possession">possession (required).</param>
        /// <param name="lastPlay">lastPlay (required).</param>
        /// <param name="venue">venue (required).</param>
        /// <param name="homeTeam">homeTeam (required).</param>
        /// <param name="awayTeam">awayTeam (required).</param>
        /// <param name="weather">weather (required).</param>
        /// <param name="betting">betting (required).</param>
        public ScoreboardGame(int id = default(int), DateTime startDate = default(DateTime), bool startTimeTBD = default(bool), string tv = default(string), bool neutralSite = default(bool), bool conferenceGame = default(bool), GameStatus status = default(GameStatus), int? period = default(int?), string clock = default(string), string situation = default(string), string possession = default(string), string lastPlay = default(string), ScoreboardGameVenue venue = default(ScoreboardGameVenue), ScoreboardGameHomeTeam homeTeam = default(ScoreboardGameHomeTeam), ScoreboardGameHomeTeam awayTeam = default(ScoreboardGameHomeTeam), ScoreboardGameWeather weather = default(ScoreboardGameWeather), ScoreboardGameBetting betting = default(ScoreboardGameBetting))
        {
            this.Id = id;
            this.StartDate = startDate;
            this.StartTimeTBD = startTimeTBD;
            // to ensure "tv" is required (not null)
            if (tv == null)
            {
                throw new ArgumentNullException("tv is a required property for ScoreboardGame and cannot be null");
            }
            this.Tv = tv;
            this.NeutralSite = neutralSite;
            this.ConferenceGame = conferenceGame;
            this.Status = status;
            // to ensure "period" is required (not null)
            if (period == null)
            {
                throw new ArgumentNullException("period is a required property for ScoreboardGame and cannot be null");
            }
            this.Period = period;
            // to ensure "clock" is required (not null)
            if (clock == null)
            {
                throw new ArgumentNullException("clock is a required property for ScoreboardGame and cannot be null");
            }
            this.Clock = clock;
            // to ensure "situation" is required (not null)
            if (situation == null)
            {
                throw new ArgumentNullException("situation is a required property for ScoreboardGame and cannot be null");
            }
            this.Situation = situation;
            // to ensure "possession" is required (not null)
            if (possession == null)
            {
                throw new ArgumentNullException("possession is a required property for ScoreboardGame and cannot be null");
            }
            this.Possession = possession;
            // to ensure "lastPlay" is required (not null)
            if (lastPlay == null)
            {
                throw new ArgumentNullException("lastPlay is a required property for ScoreboardGame and cannot be null");
            }
            this.LastPlay = lastPlay;
            // to ensure "venue" is required (not null)
            if (venue == null)
            {
                throw new ArgumentNullException("venue is a required property for ScoreboardGame and cannot be null");
            }
            this.Venue = venue;
            // to ensure "homeTeam" is required (not null)
            if (homeTeam == null)
            {
                throw new ArgumentNullException("homeTeam is a required property for ScoreboardGame and cannot be null");
            }
            this.HomeTeam = homeTeam;
            // to ensure "awayTeam" is required (not null)
            if (awayTeam == null)
            {
                throw new ArgumentNullException("awayTeam is a required property for ScoreboardGame and cannot be null");
            }
            this.AwayTeam = awayTeam;
            // to ensure "weather" is required (not null)
            if (weather == null)
            {
                throw new ArgumentNullException("weather is a required property for ScoreboardGame and cannot be null");
            }
            this.Weather = weather;
            // to ensure "betting" is required (not null)
            if (betting == null)
            {
                throw new ArgumentNullException("betting is a required property for ScoreboardGame and cannot be null");
            }
            this.Betting = betting;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets StartTimeTBD
        /// </summary>
        [DataMember(Name = "startTimeTBD", IsRequired = true, EmitDefaultValue = true)]
        public bool StartTimeTBD { get; set; }

        /// <summary>
        /// Gets or Sets Tv
        /// </summary>
        [DataMember(Name = "tv", IsRequired = true, EmitDefaultValue = true)]
        public string Tv { get; set; }

        /// <summary>
        /// Gets or Sets NeutralSite
        /// </summary>
        [DataMember(Name = "neutralSite", IsRequired = true, EmitDefaultValue = true)]
        public bool NeutralSite { get; set; }

        /// <summary>
        /// Gets or Sets ConferenceGame
        /// </summary>
        [DataMember(Name = "conferenceGame", IsRequired = true, EmitDefaultValue = true)]
        public bool ConferenceGame { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name = "period", IsRequired = true, EmitDefaultValue = true)]
        public int? Period { get; set; }

        /// <summary>
        /// Gets or Sets Clock
        /// </summary>
        [DataMember(Name = "clock", IsRequired = true, EmitDefaultValue = true)]
        public string Clock { get; set; }

        /// <summary>
        /// Gets or Sets Situation
        /// </summary>
        [DataMember(Name = "situation", IsRequired = true, EmitDefaultValue = true)]
        public string Situation { get; set; }

        /// <summary>
        /// Gets or Sets Possession
        /// </summary>
        [DataMember(Name = "possession", IsRequired = true, EmitDefaultValue = true)]
        public string Possession { get; set; }

        /// <summary>
        /// Gets or Sets LastPlay
        /// </summary>
        [DataMember(Name = "lastPlay", IsRequired = true, EmitDefaultValue = true)]
        public string LastPlay { get; set; }

        /// <summary>
        /// Gets or Sets Venue
        /// </summary>
        [DataMember(Name = "venue", IsRequired = true, EmitDefaultValue = true)]
        public ScoreboardGameVenue Venue { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeam
        /// </summary>
        [DataMember(Name = "homeTeam", IsRequired = true, EmitDefaultValue = true)]
        public ScoreboardGameHomeTeam HomeTeam { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeam
        /// </summary>
        [DataMember(Name = "awayTeam", IsRequired = true, EmitDefaultValue = true)]
        public ScoreboardGameHomeTeam AwayTeam { get; set; }

        /// <summary>
        /// Gets or Sets Weather
        /// </summary>
        [DataMember(Name = "weather", IsRequired = true, EmitDefaultValue = true)]
        public ScoreboardGameWeather Weather { get; set; }

        /// <summary>
        /// Gets or Sets Betting
        /// </summary>
        [DataMember(Name = "betting", IsRequired = true, EmitDefaultValue = true)]
        public ScoreboardGameBetting Betting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScoreboardGame {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  StartTimeTBD: ").Append(StartTimeTBD).Append("\n");
            sb.Append("  Tv: ").Append(Tv).Append("\n");
            sb.Append("  NeutralSite: ").Append(NeutralSite).Append("\n");
            sb.Append("  ConferenceGame: ").Append(ConferenceGame).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Clock: ").Append(Clock).Append("\n");
            sb.Append("  Situation: ").Append(Situation).Append("\n");
            sb.Append("  Possession: ").Append(Possession).Append("\n");
            sb.Append("  LastPlay: ").Append(LastPlay).Append("\n");
            sb.Append("  Venue: ").Append(Venue).Append("\n");
            sb.Append("  HomeTeam: ").Append(HomeTeam).Append("\n");
            sb.Append("  AwayTeam: ").Append(AwayTeam).Append("\n");
            sb.Append("  Weather: ").Append(Weather).Append("\n");
            sb.Append("  Betting: ").Append(Betting).Append("\n");
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

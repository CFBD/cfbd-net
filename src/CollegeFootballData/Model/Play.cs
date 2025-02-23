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
    /// Play
    /// </summary>
    [DataContract(Name = "Play")]
    public partial class Play : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Play" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Play() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Play" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="driveId">driveId (required).</param>
        /// <param name="gameId">gameId (required).</param>
        /// <param name="driveNumber">driveNumber (required).</param>
        /// <param name="playNumber">playNumber (required).</param>
        /// <param name="offense">offense (required).</param>
        /// <param name="offenseConference">offenseConference (required).</param>
        /// <param name="offenseScore">offenseScore (required).</param>
        /// <param name="defense">defense (required).</param>
        /// <param name="home">home (required).</param>
        /// <param name="away">away (required).</param>
        /// <param name="defenseConference">defenseConference (required).</param>
        /// <param name="defenseScore">defenseScore (required).</param>
        /// <param name="period">period (required).</param>
        /// <param name="clock">clock (required).</param>
        /// <param name="offenseTimeouts">offenseTimeouts (required).</param>
        /// <param name="defenseTimeouts">defenseTimeouts (required).</param>
        /// <param name="yardline">yardline (required).</param>
        /// <param name="yardsToGoal">yardsToGoal (required).</param>
        /// <param name="down">down (required).</param>
        /// <param name="distance">distance (required).</param>
        /// <param name="yardsGained">yardsGained (required).</param>
        /// <param name="scoring">scoring (required).</param>
        /// <param name="playType">playType (required).</param>
        /// <param name="playText">playText (required).</param>
        /// <param name="ppa">ppa (required).</param>
        /// <param name="wallclock">wallclock (required).</param>
        public Play(string id = default(string), string driveId = default(string), int gameId = default(int), int? driveNumber = default(int?), int? playNumber = default(int?), string offense = default(string), string offenseConference = default(string), int offenseScore = default(int), string defense = default(string), string home = default(string), string away = default(string), string defenseConference = default(string), int defenseScore = default(int), int period = default(int), PlayClock clock = default(PlayClock), int? offenseTimeouts = default(int?), int? defenseTimeouts = default(int?), int yardline = default(int), int yardsToGoal = default(int), int down = default(int), int distance = default(int), int yardsGained = default(int), bool scoring = default(bool), string playType = default(string), string playText = default(string), double? ppa = default(double?), string wallclock = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Play and cannot be null");
            }
            this.Id = id;
            // to ensure "driveId" is required (not null)
            if (driveId == null)
            {
                throw new ArgumentNullException("driveId is a required property for Play and cannot be null");
            }
            this.DriveId = driveId;
            this.GameId = gameId;
            // to ensure "driveNumber" is required (not null)
            if (driveNumber == null)
            {
                throw new ArgumentNullException("driveNumber is a required property for Play and cannot be null");
            }
            this.DriveNumber = driveNumber;
            // to ensure "playNumber" is required (not null)
            if (playNumber == null)
            {
                throw new ArgumentNullException("playNumber is a required property for Play and cannot be null");
            }
            this.PlayNumber = playNumber;
            // to ensure "offense" is required (not null)
            if (offense == null)
            {
                throw new ArgumentNullException("offense is a required property for Play and cannot be null");
            }
            this.Offense = offense;
            // to ensure "offenseConference" is required (not null)
            if (offenseConference == null)
            {
                throw new ArgumentNullException("offenseConference is a required property for Play and cannot be null");
            }
            this.OffenseConference = offenseConference;
            this.OffenseScore = offenseScore;
            // to ensure "defense" is required (not null)
            if (defense == null)
            {
                throw new ArgumentNullException("defense is a required property for Play and cannot be null");
            }
            this.Defense = defense;
            // to ensure "home" is required (not null)
            if (home == null)
            {
                throw new ArgumentNullException("home is a required property for Play and cannot be null");
            }
            this.Home = home;
            // to ensure "away" is required (not null)
            if (away == null)
            {
                throw new ArgumentNullException("away is a required property for Play and cannot be null");
            }
            this.Away = away;
            // to ensure "defenseConference" is required (not null)
            if (defenseConference == null)
            {
                throw new ArgumentNullException("defenseConference is a required property for Play and cannot be null");
            }
            this.DefenseConference = defenseConference;
            this.DefenseScore = defenseScore;
            this.Period = period;
            // to ensure "clock" is required (not null)
            if (clock == null)
            {
                throw new ArgumentNullException("clock is a required property for Play and cannot be null");
            }
            this.Clock = clock;
            // to ensure "offenseTimeouts" is required (not null)
            if (offenseTimeouts == null)
            {
                throw new ArgumentNullException("offenseTimeouts is a required property for Play and cannot be null");
            }
            this.OffenseTimeouts = offenseTimeouts;
            // to ensure "defenseTimeouts" is required (not null)
            if (defenseTimeouts == null)
            {
                throw new ArgumentNullException("defenseTimeouts is a required property for Play and cannot be null");
            }
            this.DefenseTimeouts = defenseTimeouts;
            this.Yardline = yardline;
            this.YardsToGoal = yardsToGoal;
            this.Down = down;
            this.Distance = distance;
            this.YardsGained = yardsGained;
            this.Scoring = scoring;
            // to ensure "playType" is required (not null)
            if (playType == null)
            {
                throw new ArgumentNullException("playType is a required property for Play and cannot be null");
            }
            this.PlayType = playType;
            // to ensure "playText" is required (not null)
            if (playText == null)
            {
                throw new ArgumentNullException("playText is a required property for Play and cannot be null");
            }
            this.PlayText = playText;
            // to ensure "ppa" is required (not null)
            if (ppa == null)
            {
                throw new ArgumentNullException("ppa is a required property for Play and cannot be null");
            }
            this.Ppa = ppa;
            // to ensure "wallclock" is required (not null)
            if (wallclock == null)
            {
                throw new ArgumentNullException("wallclock is a required property for Play and cannot be null");
            }
            this.Wallclock = wallclock;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets DriveId
        /// </summary>
        [DataMember(Name = "driveId", IsRequired = true, EmitDefaultValue = true)]
        public string DriveId { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name = "gameId", IsRequired = true, EmitDefaultValue = true)]
        public int GameId { get; set; }

        /// <summary>
        /// Gets or Sets DriveNumber
        /// </summary>
        [DataMember(Name = "driveNumber", IsRequired = true, EmitDefaultValue = true)]
        public int? DriveNumber { get; set; }

        /// <summary>
        /// Gets or Sets PlayNumber
        /// </summary>
        [DataMember(Name = "playNumber", IsRequired = true, EmitDefaultValue = true)]
        public int? PlayNumber { get; set; }

        /// <summary>
        /// Gets or Sets Offense
        /// </summary>
        [DataMember(Name = "offense", IsRequired = true, EmitDefaultValue = true)]
        public string Offense { get; set; }

        /// <summary>
        /// Gets or Sets OffenseConference
        /// </summary>
        [DataMember(Name = "offenseConference", IsRequired = true, EmitDefaultValue = true)]
        public string OffenseConference { get; set; }

        /// <summary>
        /// Gets or Sets OffenseScore
        /// </summary>
        [DataMember(Name = "offenseScore", IsRequired = true, EmitDefaultValue = true)]
        public int OffenseScore { get; set; }

        /// <summary>
        /// Gets or Sets Defense
        /// </summary>
        [DataMember(Name = "defense", IsRequired = true, EmitDefaultValue = true)]
        public string Defense { get; set; }

        /// <summary>
        /// Gets or Sets Home
        /// </summary>
        [DataMember(Name = "home", IsRequired = true, EmitDefaultValue = true)]
        public string Home { get; set; }

        /// <summary>
        /// Gets or Sets Away
        /// </summary>
        [DataMember(Name = "away", IsRequired = true, EmitDefaultValue = true)]
        public string Away { get; set; }

        /// <summary>
        /// Gets or Sets DefenseConference
        /// </summary>
        [DataMember(Name = "defenseConference", IsRequired = true, EmitDefaultValue = true)]
        public string DefenseConference { get; set; }

        /// <summary>
        /// Gets or Sets DefenseScore
        /// </summary>
        [DataMember(Name = "defenseScore", IsRequired = true, EmitDefaultValue = true)]
        public int DefenseScore { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name = "period", IsRequired = true, EmitDefaultValue = true)]
        public int Period { get; set; }

        /// <summary>
        /// Gets or Sets Clock
        /// </summary>
        [DataMember(Name = "clock", IsRequired = true, EmitDefaultValue = true)]
        public PlayClock Clock { get; set; }

        /// <summary>
        /// Gets or Sets OffenseTimeouts
        /// </summary>
        [DataMember(Name = "offenseTimeouts", IsRequired = true, EmitDefaultValue = true)]
        public int? OffenseTimeouts { get; set; }

        /// <summary>
        /// Gets or Sets DefenseTimeouts
        /// </summary>
        [DataMember(Name = "defenseTimeouts", IsRequired = true, EmitDefaultValue = true)]
        public int? DefenseTimeouts { get; set; }

        /// <summary>
        /// Gets or Sets Yardline
        /// </summary>
        [DataMember(Name = "yardline", IsRequired = true, EmitDefaultValue = true)]
        public int Yardline { get; set; }

        /// <summary>
        /// Gets or Sets YardsToGoal
        /// </summary>
        [DataMember(Name = "yardsToGoal", IsRequired = true, EmitDefaultValue = true)]
        public int YardsToGoal { get; set; }

        /// <summary>
        /// Gets or Sets Down
        /// </summary>
        [DataMember(Name = "down", IsRequired = true, EmitDefaultValue = true)]
        public int Down { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name = "distance", IsRequired = true, EmitDefaultValue = true)]
        public int Distance { get; set; }

        /// <summary>
        /// Gets or Sets YardsGained
        /// </summary>
        [DataMember(Name = "yardsGained", IsRequired = true, EmitDefaultValue = true)]
        public int YardsGained { get; set; }

        /// <summary>
        /// Gets or Sets Scoring
        /// </summary>
        [DataMember(Name = "scoring", IsRequired = true, EmitDefaultValue = true)]
        public bool Scoring { get; set; }

        /// <summary>
        /// Gets or Sets PlayType
        /// </summary>
        [DataMember(Name = "playType", IsRequired = true, EmitDefaultValue = true)]
        public string PlayType { get; set; }

        /// <summary>
        /// Gets or Sets PlayText
        /// </summary>
        [DataMember(Name = "playText", IsRequired = true, EmitDefaultValue = true)]
        public string PlayText { get; set; }

        /// <summary>
        /// Gets or Sets Ppa
        /// </summary>
        [DataMember(Name = "ppa", IsRequired = true, EmitDefaultValue = true)]
        public double? Ppa { get; set; }

        /// <summary>
        /// Gets or Sets Wallclock
        /// </summary>
        [DataMember(Name = "wallclock", IsRequired = true, EmitDefaultValue = true)]
        public string Wallclock { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Play {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DriveId: ").Append(DriveId).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  DriveNumber: ").Append(DriveNumber).Append("\n");
            sb.Append("  PlayNumber: ").Append(PlayNumber).Append("\n");
            sb.Append("  Offense: ").Append(Offense).Append("\n");
            sb.Append("  OffenseConference: ").Append(OffenseConference).Append("\n");
            sb.Append("  OffenseScore: ").Append(OffenseScore).Append("\n");
            sb.Append("  Defense: ").Append(Defense).Append("\n");
            sb.Append("  Home: ").Append(Home).Append("\n");
            sb.Append("  Away: ").Append(Away).Append("\n");
            sb.Append("  DefenseConference: ").Append(DefenseConference).Append("\n");
            sb.Append("  DefenseScore: ").Append(DefenseScore).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Clock: ").Append(Clock).Append("\n");
            sb.Append("  OffenseTimeouts: ").Append(OffenseTimeouts).Append("\n");
            sb.Append("  DefenseTimeouts: ").Append(DefenseTimeouts).Append("\n");
            sb.Append("  Yardline: ").Append(Yardline).Append("\n");
            sb.Append("  YardsToGoal: ").Append(YardsToGoal).Append("\n");
            sb.Append("  Down: ").Append(Down).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  YardsGained: ").Append(YardsGained).Append("\n");
            sb.Append("  Scoring: ").Append(Scoring).Append("\n");
            sb.Append("  PlayType: ").Append(PlayType).Append("\n");
            sb.Append("  PlayText: ").Append(PlayText).Append("\n");
            sb.Append("  Ppa: ").Append(Ppa).Append("\n");
            sb.Append("  Wallclock: ").Append(Wallclock).Append("\n");
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

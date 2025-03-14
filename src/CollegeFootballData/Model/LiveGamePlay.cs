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
    /// LiveGamePlay
    /// </summary>
    [DataContract(Name = "LiveGamePlay")]
    public partial class LiveGamePlay : IValidatableObject
    {
        /// <summary>
        /// Defines RushPash
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RushPashEnum
        {
            /// <summary>
            /// Enum Rush for value: rush
            /// </summary>
            [EnumMember(Value = "rush")]
            Rush = 1,

            /// <summary>
            /// Enum Pass for value: pass
            /// </summary>
            [EnumMember(Value = "pass")]
            Pass = 2,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 3
        }


        /// <summary>
        /// Gets or Sets RushPash
        /// </summary>
        [DataMember(Name = "rushPash", IsRequired = true, EmitDefaultValue = true)]
        public RushPashEnum RushPash { get; set; }
        /// <summary>
        /// Defines DownType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DownTypeEnum
        {
            /// <summary>
            /// Enum Passing for value: passing
            /// </summary>
            [EnumMember(Value = "passing")]
            Passing = 1,

            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 2
        }


        /// <summary>
        /// Gets or Sets DownType
        /// </summary>
        [DataMember(Name = "downType", IsRequired = true, EmitDefaultValue = true)]
        public DownTypeEnum DownType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LiveGamePlay" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LiveGamePlay() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LiveGamePlay" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="homeScore">homeScore (required).</param>
        /// <param name="awayScore">awayScore (required).</param>
        /// <param name="period">period (required).</param>
        /// <param name="clock">clock (required).</param>
        /// <param name="wallClock">wallClock (required).</param>
        /// <param name="teamId">teamId (required).</param>
        /// <param name="team">team (required).</param>
        /// <param name="down">down (required).</param>
        /// <param name="distance">distance (required).</param>
        /// <param name="yardsToGoal">yardsToGoal (required).</param>
        /// <param name="yardsGained">yardsGained (required).</param>
        /// <param name="playTypeId">playTypeId (required).</param>
        /// <param name="playType">playType (required).</param>
        /// <param name="epa">epa (required).</param>
        /// <param name="garbageTime">garbageTime (required).</param>
        /// <param name="success">success (required).</param>
        /// <param name="rushPash">rushPash (required).</param>
        /// <param name="downType">downType (required).</param>
        /// <param name="playText">playText (required).</param>
        public LiveGamePlay(string id = default(string), int homeScore = default(int), int awayScore = default(int), int period = default(int), string clock = default(string), DateTime wallClock = default(DateTime), int teamId = default(int), string team = default(string), int down = default(int), int distance = default(int), int yardsToGoal = default(int), int yardsGained = default(int), int playTypeId = default(int), string playType = default(string), double? epa = default(double?), bool garbageTime = default(bool), bool success = default(bool), RushPashEnum rushPash = default(RushPashEnum), DownTypeEnum downType = default(DownTypeEnum), string playText = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for LiveGamePlay and cannot be null");
            }
            this.Id = id;
            this.HomeScore = homeScore;
            this.AwayScore = awayScore;
            this.Period = period;
            // to ensure "clock" is required (not null)
            if (clock == null)
            {
                throw new ArgumentNullException("clock is a required property for LiveGamePlay and cannot be null");
            }
            this.Clock = clock;
            this.WallClock = wallClock;
            this.TeamId = teamId;
            // to ensure "team" is required (not null)
            if (team == null)
            {
                throw new ArgumentNullException("team is a required property for LiveGamePlay and cannot be null");
            }
            this.Team = team;
            this.Down = down;
            this.Distance = distance;
            this.YardsToGoal = yardsToGoal;
            this.YardsGained = yardsGained;
            this.PlayTypeId = playTypeId;
            // to ensure "playType" is required (not null)
            if (playType == null)
            {
                throw new ArgumentNullException("playType is a required property for LiveGamePlay and cannot be null");
            }
            this.PlayType = playType;
            // to ensure "epa" is required (not null)
            if (epa == null)
            {
                throw new ArgumentNullException("epa is a required property for LiveGamePlay and cannot be null");
            }
            this.Epa = epa;
            this.GarbageTime = garbageTime;
            this.Success = success;
            this.RushPash = rushPash;
            this.DownType = downType;
            // to ensure "playText" is required (not null)
            if (playText == null)
            {
                throw new ArgumentNullException("playText is a required property for LiveGamePlay and cannot be null");
            }
            this.PlayText = playText;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets HomeScore
        /// </summary>
        [DataMember(Name = "homeScore", IsRequired = true, EmitDefaultValue = true)]
        public int HomeScore { get; set; }

        /// <summary>
        /// Gets or Sets AwayScore
        /// </summary>
        [DataMember(Name = "awayScore", IsRequired = true, EmitDefaultValue = true)]
        public int AwayScore { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name = "period", IsRequired = true, EmitDefaultValue = true)]
        public int Period { get; set; }

        /// <summary>
        /// Gets or Sets Clock
        /// </summary>
        [DataMember(Name = "clock", IsRequired = true, EmitDefaultValue = true)]
        public string Clock { get; set; }

        /// <summary>
        /// Gets or Sets WallClock
        /// </summary>
        [DataMember(Name = "wallClock", IsRequired = true, EmitDefaultValue = true)]
        public DateTime WallClock { get; set; }

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
        /// Gets or Sets YardsToGoal
        /// </summary>
        [DataMember(Name = "yardsToGoal", IsRequired = true, EmitDefaultValue = true)]
        public int YardsToGoal { get; set; }

        /// <summary>
        /// Gets or Sets YardsGained
        /// </summary>
        [DataMember(Name = "yardsGained", IsRequired = true, EmitDefaultValue = true)]
        public int YardsGained { get; set; }

        /// <summary>
        /// Gets or Sets PlayTypeId
        /// </summary>
        [DataMember(Name = "playTypeId", IsRequired = true, EmitDefaultValue = true)]
        public int PlayTypeId { get; set; }

        /// <summary>
        /// Gets or Sets PlayType
        /// </summary>
        [DataMember(Name = "playType", IsRequired = true, EmitDefaultValue = true)]
        public string PlayType { get; set; }

        /// <summary>
        /// Gets or Sets Epa
        /// </summary>
        [DataMember(Name = "epa", IsRequired = true, EmitDefaultValue = true)]
        public double? Epa { get; set; }

        /// <summary>
        /// Gets or Sets GarbageTime
        /// </summary>
        [DataMember(Name = "garbageTime", IsRequired = true, EmitDefaultValue = true)]
        public bool GarbageTime { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", IsRequired = true, EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets PlayText
        /// </summary>
        [DataMember(Name = "playText", IsRequired = true, EmitDefaultValue = true)]
        public string PlayText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LiveGamePlay {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  HomeScore: ").Append(HomeScore).Append("\n");
            sb.Append("  AwayScore: ").Append(AwayScore).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Clock: ").Append(Clock).Append("\n");
            sb.Append("  WallClock: ").Append(WallClock).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Down: ").Append(Down).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  YardsToGoal: ").Append(YardsToGoal).Append("\n");
            sb.Append("  YardsGained: ").Append(YardsGained).Append("\n");
            sb.Append("  PlayTypeId: ").Append(PlayTypeId).Append("\n");
            sb.Append("  PlayType: ").Append(PlayType).Append("\n");
            sb.Append("  Epa: ").Append(Epa).Append("\n");
            sb.Append("  GarbageTime: ").Append(GarbageTime).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  RushPash: ").Append(RushPash).Append("\n");
            sb.Append("  DownType: ").Append(DownType).Append("\n");
            sb.Append("  PlayText: ").Append(PlayText).Append("\n");
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

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
    /// PlayerStat
    /// </summary>
    [DataContract(Name = "PlayerStat")]
    public partial class PlayerStat : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerStat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlayerStat() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerStat" /> class.
        /// </summary>
        /// <param name="season">season (required).</param>
        /// <param name="playerId">playerId (required).</param>
        /// <param name="player">player (required).</param>
        /// <param name="team">team (required).</param>
        /// <param name="conference">conference (required).</param>
        /// <param name="category">category (required).</param>
        /// <param name="statType">statType (required).</param>
        /// <param name="stat">stat (required).</param>
        public PlayerStat(int season = default(int), string playerId = default(string), string player = default(string), string team = default(string), string conference = default(string), string category = default(string), string statType = default(string), string stat = default(string))
        {
            this.Season = season;
            // to ensure "playerId" is required (not null)
            if (playerId == null)
            {
                throw new ArgumentNullException("playerId is a required property for PlayerStat and cannot be null");
            }
            this.PlayerId = playerId;
            // to ensure "player" is required (not null)
            if (player == null)
            {
                throw new ArgumentNullException("player is a required property for PlayerStat and cannot be null");
            }
            this.Player = player;
            // to ensure "team" is required (not null)
            if (team == null)
            {
                throw new ArgumentNullException("team is a required property for PlayerStat and cannot be null");
            }
            this.Team = team;
            // to ensure "conference" is required (not null)
            if (conference == null)
            {
                throw new ArgumentNullException("conference is a required property for PlayerStat and cannot be null");
            }
            this.Conference = conference;
            // to ensure "category" is required (not null)
            if (category == null)
            {
                throw new ArgumentNullException("category is a required property for PlayerStat and cannot be null");
            }
            this.Category = category;
            // to ensure "statType" is required (not null)
            if (statType == null)
            {
                throw new ArgumentNullException("statType is a required property for PlayerStat and cannot be null");
            }
            this.StatType = statType;
            // to ensure "stat" is required (not null)
            if (stat == null)
            {
                throw new ArgumentNullException("stat is a required property for PlayerStat and cannot be null");
            }
            this.Stat = stat;
        }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", IsRequired = true, EmitDefaultValue = true)]
        public int Season { get; set; }

        /// <summary>
        /// Gets or Sets PlayerId
        /// </summary>
        [DataMember(Name = "playerId", IsRequired = true, EmitDefaultValue = true)]
        public string PlayerId { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", IsRequired = true, EmitDefaultValue = true)]
        public string Player { get; set; }

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
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = true)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets StatType
        /// </summary>
        [DataMember(Name = "statType", IsRequired = true, EmitDefaultValue = true)]
        public string StatType { get; set; }

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
            sb.Append("class PlayerStat {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  PlayerId: ").Append(PlayerId).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  StatType: ").Append(StatType).Append("\n");
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

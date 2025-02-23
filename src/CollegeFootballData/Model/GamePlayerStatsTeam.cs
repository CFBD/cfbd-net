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
    /// GamePlayerStatsTeam
    /// </summary>
    [DataContract(Name = "GamePlayerStatsTeam")]
    public partial class GamePlayerStatsTeam : IValidatableObject
    {
        /// <summary>
        /// Defines HomeAway
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HomeAwayEnum
        {
            /// <summary>
            /// Enum Home for value: home
            /// </summary>
            [EnumMember(Value = "home")]
            Home = 1,

            /// <summary>
            /// Enum Away for value: away
            /// </summary>
            [EnumMember(Value = "away")]
            Away = 2
        }


        /// <summary>
        /// Gets or Sets HomeAway
        /// </summary>
        [DataMember(Name = "homeAway", IsRequired = true, EmitDefaultValue = true)]
        public HomeAwayEnum HomeAway { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GamePlayerStatsTeam" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GamePlayerStatsTeam() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GamePlayerStatsTeam" /> class.
        /// </summary>
        /// <param name="team">team (required).</param>
        /// <param name="conference">conference (required).</param>
        /// <param name="homeAway">homeAway (required).</param>
        /// <param name="points">points (required).</param>
        /// <param name="categories">categories (required).</param>
        public GamePlayerStatsTeam(string team = default(string), string conference = default(string), HomeAwayEnum homeAway = default(HomeAwayEnum), int? points = default(int?), List<GamePlayerStatCategories> categories = default(List<GamePlayerStatCategories>))
        {
            // to ensure "team" is required (not null)
            if (team == null)
            {
                throw new ArgumentNullException("team is a required property for GamePlayerStatsTeam and cannot be null");
            }
            this.Team = team;
            // to ensure "conference" is required (not null)
            if (conference == null)
            {
                throw new ArgumentNullException("conference is a required property for GamePlayerStatsTeam and cannot be null");
            }
            this.Conference = conference;
            this.HomeAway = homeAway;
            // to ensure "points" is required (not null)
            if (points == null)
            {
                throw new ArgumentNullException("points is a required property for GamePlayerStatsTeam and cannot be null");
            }
            this.Points = points;
            // to ensure "categories" is required (not null)
            if (categories == null)
            {
                throw new ArgumentNullException("categories is a required property for GamePlayerStatsTeam and cannot be null");
            }
            this.Categories = categories;
        }

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
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name = "points", IsRequired = true, EmitDefaultValue = true)]
        public int? Points { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name = "categories", IsRequired = true, EmitDefaultValue = true)]
        public List<GamePlayerStatCategories> Categories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GamePlayerStatsTeam {\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  HomeAway: ").Append(HomeAway).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
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

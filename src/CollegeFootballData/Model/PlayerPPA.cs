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
    /// PlayerPPA
    /// </summary>
    [DataContract(Name = "PlayerPPA")]
    public partial class PlayerPPA : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerPPA" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlayerPPA() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerPPA" /> class.
        /// </summary>
        /// <param name="player">player (required).</param>
        /// <param name="team">team (required).</param>
        /// <param name="position">position (required).</param>
        /// <param name="average">average (required).</param>
        /// <param name="cumulative">cumulative (required).</param>
        public PlayerPPA(string player = default(string), string team = default(string), string position = default(string), PlayerStatsByQuarter average = default(PlayerStatsByQuarter), PlayerStatsByQuarter cumulative = default(PlayerStatsByQuarter))
        {
            // to ensure "player" is required (not null)
            if (player == null)
            {
                throw new ArgumentNullException("player is a required property for PlayerPPA and cannot be null");
            }
            this.Player = player;
            // to ensure "team" is required (not null)
            if (team == null)
            {
                throw new ArgumentNullException("team is a required property for PlayerPPA and cannot be null");
            }
            this.Team = team;
            // to ensure "position" is required (not null)
            if (position == null)
            {
                throw new ArgumentNullException("position is a required property for PlayerPPA and cannot be null");
            }
            this.Position = position;
            // to ensure "average" is required (not null)
            if (average == null)
            {
                throw new ArgumentNullException("average is a required property for PlayerPPA and cannot be null");
            }
            this.Average = average;
            // to ensure "cumulative" is required (not null)
            if (cumulative == null)
            {
                throw new ArgumentNullException("cumulative is a required property for PlayerPPA and cannot be null");
            }
            this.Cumulative = cumulative;
        }

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
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", IsRequired = true, EmitDefaultValue = true)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or Sets Average
        /// </summary>
        [DataMember(Name = "average", IsRequired = true, EmitDefaultValue = true)]
        public PlayerStatsByQuarter Average { get; set; }

        /// <summary>
        /// Gets or Sets Cumulative
        /// </summary>
        [DataMember(Name = "cumulative", IsRequired = true, EmitDefaultValue = true)]
        public PlayerStatsByQuarter Cumulative { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerPPA {\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Average: ").Append(Average).Append("\n");
            sb.Append("  Cumulative: ").Append(Cumulative).Append("\n");
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

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
    /// GameTeamStats
    /// </summary>
    [DataContract(Name = "GameTeamStats")]
    public partial class GameTeamStats : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameTeamStats" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GameTeamStats() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GameTeamStats" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="teams">teams (required).</param>
        public GameTeamStats(int id = default(int), List<GameTeamStatsTeam> teams = default(List<GameTeamStatsTeam>))
        {
            this.Id = id;
            // to ensure "teams" is required (not null)
            if (teams == null)
            {
                throw new ArgumentNullException("teams is a required property for GameTeamStats and cannot be null");
            }
            this.Teams = teams;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name = "teams", IsRequired = true, EmitDefaultValue = true)]
        public List<GameTeamStatsTeam> Teams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GameTeamStats {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
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

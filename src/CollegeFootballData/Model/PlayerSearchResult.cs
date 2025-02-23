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
    /// PlayerSearchResult
    /// </summary>
    [DataContract(Name = "PlayerSearchResult")]
    public partial class PlayerSearchResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerSearchResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlayerSearchResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerSearchResult" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="team">team (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="lastName">lastName (required).</param>
        /// <param name="weight">weight (required).</param>
        /// <param name="height">height (required).</param>
        /// <param name="jersey">jersey (required).</param>
        /// <param name="position">position (required).</param>
        /// <param name="hometown">hometown (required).</param>
        /// <param name="teamColor">teamColor (required).</param>
        /// <param name="teamColorSecondary">teamColorSecondary (required).</param>
        public PlayerSearchResult(string id = default(string), string team = default(string), string name = default(string), string firstName = default(string), string lastName = default(string), int? weight = default(int?), int? height = default(int?), int? jersey = default(int?), string position = default(string), string hometown = default(string), string teamColor = default(string), string teamColorSecondary = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for PlayerSearchResult and cannot be null");
            }
            this.Id = id;
            // to ensure "team" is required (not null)
            if (team == null)
            {
                throw new ArgumentNullException("team is a required property for PlayerSearchResult and cannot be null");
            }
            this.Team = team;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PlayerSearchResult and cannot be null");
            }
            this.Name = name;
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new ArgumentNullException("firstName is a required property for PlayerSearchResult and cannot be null");
            }
            this.FirstName = firstName;
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new ArgumentNullException("lastName is a required property for PlayerSearchResult and cannot be null");
            }
            this.LastName = lastName;
            // to ensure "weight" is required (not null)
            if (weight == null)
            {
                throw new ArgumentNullException("weight is a required property for PlayerSearchResult and cannot be null");
            }
            this.Weight = weight;
            // to ensure "height" is required (not null)
            if (height == null)
            {
                throw new ArgumentNullException("height is a required property for PlayerSearchResult and cannot be null");
            }
            this.Height = height;
            // to ensure "jersey" is required (not null)
            if (jersey == null)
            {
                throw new ArgumentNullException("jersey is a required property for PlayerSearchResult and cannot be null");
            }
            this.Jersey = jersey;
            // to ensure "position" is required (not null)
            if (position == null)
            {
                throw new ArgumentNullException("position is a required property for PlayerSearchResult and cannot be null");
            }
            this.Position = position;
            // to ensure "hometown" is required (not null)
            if (hometown == null)
            {
                throw new ArgumentNullException("hometown is a required property for PlayerSearchResult and cannot be null");
            }
            this.Hometown = hometown;
            // to ensure "teamColor" is required (not null)
            if (teamColor == null)
            {
                throw new ArgumentNullException("teamColor is a required property for PlayerSearchResult and cannot be null");
            }
            this.TeamColor = teamColor;
            // to ensure "teamColorSecondary" is required (not null)
            if (teamColorSecondary == null)
            {
                throw new ArgumentNullException("teamColorSecondary is a required property for PlayerSearchResult and cannot be null");
            }
            this.TeamColorSecondary = teamColorSecondary;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", IsRequired = true, EmitDefaultValue = true)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", IsRequired = true, EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", IsRequired = true, EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", IsRequired = true, EmitDefaultValue = true)]
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", IsRequired = true, EmitDefaultValue = true)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or Sets Jersey
        /// </summary>
        [DataMember(Name = "jersey", IsRequired = true, EmitDefaultValue = true)]
        public int? Jersey { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", IsRequired = true, EmitDefaultValue = true)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or Sets Hometown
        /// </summary>
        [DataMember(Name = "hometown", IsRequired = true, EmitDefaultValue = true)]
        public string Hometown { get; set; }

        /// <summary>
        /// Gets or Sets TeamColor
        /// </summary>
        [DataMember(Name = "teamColor", IsRequired = true, EmitDefaultValue = true)]
        public string TeamColor { get; set; }

        /// <summary>
        /// Gets or Sets TeamColorSecondary
        /// </summary>
        [DataMember(Name = "teamColorSecondary", IsRequired = true, EmitDefaultValue = true)]
        public string TeamColorSecondary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerSearchResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Jersey: ").Append(Jersey).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Hometown: ").Append(Hometown).Append("\n");
            sb.Append("  TeamColor: ").Append(TeamColor).Append("\n");
            sb.Append("  TeamColorSecondary: ").Append(TeamColorSecondary).Append("\n");
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

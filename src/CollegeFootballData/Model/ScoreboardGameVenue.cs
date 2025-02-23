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
    /// ScoreboardGameVenue
    /// </summary>
    [DataContract(Name = "ScoreboardGame_venue")]
    public partial class ScoreboardGameVenue : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreboardGameVenue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScoreboardGameVenue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreboardGameVenue" /> class.
        /// </summary>
        /// <param name="state">state (required).</param>
        /// <param name="city">city (required).</param>
        /// <param name="name">name (required).</param>
        public ScoreboardGameVenue(string state = default(string), string city = default(string), string name = default(string))
        {
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for ScoreboardGameVenue and cannot be null");
            }
            this.State = state;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for ScoreboardGameVenue and cannot be null");
            }
            this.City = city;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ScoreboardGameVenue and cannot be null");
            }
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScoreboardGameVenue {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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

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
    /// TeamSPDefense
    /// </summary>
    [DataContract(Name = "TeamSP_defense")]
    public partial class TeamSPDefense : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSPDefense" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeamSPDefense() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSPDefense" /> class.
        /// </summary>
        /// <param name="havoc">havoc (required).</param>
        /// <param name="passingDowns">passingDowns (required).</param>
        /// <param name="standardDowns">standardDowns (required).</param>
        /// <param name="passing">passing (required).</param>
        /// <param name="rushing">rushing (required).</param>
        /// <param name="explosiveness">explosiveness (required).</param>
        /// <param name="success">success (required).</param>
        /// <param name="rating">rating (required).</param>
        /// <param name="ranking">ranking (required).</param>
        public TeamSPDefense(AdvancedSeasonStatOffenseHavoc havoc = default(AdvancedSeasonStatOffenseHavoc), double? passingDowns = default(double?), double? standardDowns = default(double?), double? passing = default(double?), double? rushing = default(double?), double? explosiveness = default(double?), double? success = default(double?), double rating = default(double), int ranking = default(int))
        {
            // to ensure "havoc" is required (not null)
            if (havoc == null)
            {
                throw new ArgumentNullException("havoc is a required property for TeamSPDefense and cannot be null");
            }
            this.Havoc = havoc;
            // to ensure "passingDowns" is required (not null)
            if (passingDowns == null)
            {
                throw new ArgumentNullException("passingDowns is a required property for TeamSPDefense and cannot be null");
            }
            this.PassingDowns = passingDowns;
            // to ensure "standardDowns" is required (not null)
            if (standardDowns == null)
            {
                throw new ArgumentNullException("standardDowns is a required property for TeamSPDefense and cannot be null");
            }
            this.StandardDowns = standardDowns;
            // to ensure "passing" is required (not null)
            if (passing == null)
            {
                throw new ArgumentNullException("passing is a required property for TeamSPDefense and cannot be null");
            }
            this.Passing = passing;
            // to ensure "rushing" is required (not null)
            if (rushing == null)
            {
                throw new ArgumentNullException("rushing is a required property for TeamSPDefense and cannot be null");
            }
            this.Rushing = rushing;
            // to ensure "explosiveness" is required (not null)
            if (explosiveness == null)
            {
                throw new ArgumentNullException("explosiveness is a required property for TeamSPDefense and cannot be null");
            }
            this.Explosiveness = explosiveness;
            // to ensure "success" is required (not null)
            if (success == null)
            {
                throw new ArgumentNullException("success is a required property for TeamSPDefense and cannot be null");
            }
            this.Success = success;
            this.Rating = rating;
            this.Ranking = ranking;
        }

        /// <summary>
        /// Gets or Sets Havoc
        /// </summary>
        [DataMember(Name = "havoc", IsRequired = true, EmitDefaultValue = true)]
        public AdvancedSeasonStatOffenseHavoc Havoc { get; set; }

        /// <summary>
        /// Gets or Sets PassingDowns
        /// </summary>
        [DataMember(Name = "passingDowns", IsRequired = true, EmitDefaultValue = true)]
        public double? PassingDowns { get; set; }

        /// <summary>
        /// Gets or Sets StandardDowns
        /// </summary>
        [DataMember(Name = "standardDowns", IsRequired = true, EmitDefaultValue = true)]
        public double? StandardDowns { get; set; }

        /// <summary>
        /// Gets or Sets Passing
        /// </summary>
        [DataMember(Name = "passing", IsRequired = true, EmitDefaultValue = true)]
        public double? Passing { get; set; }

        /// <summary>
        /// Gets or Sets Rushing
        /// </summary>
        [DataMember(Name = "rushing", IsRequired = true, EmitDefaultValue = true)]
        public double? Rushing { get; set; }

        /// <summary>
        /// Gets or Sets Explosiveness
        /// </summary>
        [DataMember(Name = "explosiveness", IsRequired = true, EmitDefaultValue = true)]
        public double? Explosiveness { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", IsRequired = true, EmitDefaultValue = true)]
        public double? Success { get; set; }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name = "rating", IsRequired = true, EmitDefaultValue = true)]
        public double Rating { get; set; }

        /// <summary>
        /// Gets or Sets Ranking
        /// </summary>
        [DataMember(Name = "ranking", IsRequired = true, EmitDefaultValue = true)]
        public int Ranking { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamSPDefense {\n");
            sb.Append("  Havoc: ").Append(Havoc).Append("\n");
            sb.Append("  PassingDowns: ").Append(PassingDowns).Append("\n");
            sb.Append("  StandardDowns: ").Append(StandardDowns).Append("\n");
            sb.Append("  Passing: ").Append(Passing).Append("\n");
            sb.Append("  Rushing: ").Append(Rushing).Append("\n");
            sb.Append("  Explosiveness: ").Append(Explosiveness).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Ranking: ").Append(Ranking).Append("\n");
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

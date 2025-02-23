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
    /// AdvancedSeasonStatOffenseFieldPosition
    /// </summary>
    [DataContract(Name = "AdvancedSeasonStat_offense_fieldPosition")]
    public partial class AdvancedSeasonStatOffenseFieldPosition : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedSeasonStatOffenseFieldPosition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdvancedSeasonStatOffenseFieldPosition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedSeasonStatOffenseFieldPosition" /> class.
        /// </summary>
        /// <param name="averagePredictedPoints">averagePredictedPoints (required).</param>
        /// <param name="averageStart">averageStart (required).</param>
        public AdvancedSeasonStatOffenseFieldPosition(double? averagePredictedPoints = default(double?), double? averageStart = default(double?))
        {
            // to ensure "averagePredictedPoints" is required (not null)
            if (averagePredictedPoints == null)
            {
                throw new ArgumentNullException("averagePredictedPoints is a required property for AdvancedSeasonStatOffenseFieldPosition and cannot be null");
            }
            this.AveragePredictedPoints = averagePredictedPoints;
            // to ensure "averageStart" is required (not null)
            if (averageStart == null)
            {
                throw new ArgumentNullException("averageStart is a required property for AdvancedSeasonStatOffenseFieldPosition and cannot be null");
            }
            this.AverageStart = averageStart;
        }

        /// <summary>
        /// Gets or Sets AveragePredictedPoints
        /// </summary>
        [DataMember(Name = "averagePredictedPoints", IsRequired = true, EmitDefaultValue = true)]
        public double? AveragePredictedPoints { get; set; }

        /// <summary>
        /// Gets or Sets AverageStart
        /// </summary>
        [DataMember(Name = "averageStart", IsRequired = true, EmitDefaultValue = true)]
        public double? AverageStart { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdvancedSeasonStatOffenseFieldPosition {\n");
            sb.Append("  AveragePredictedPoints: ").Append(AveragePredictedPoints).Append("\n");
            sb.Append("  AverageStart: ").Append(AverageStart).Append("\n");
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

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
    /// StatsByQuarter
    /// </summary>
    [DataContract(Name = "StatsByQuarter")]
    public partial class StatsByQuarter : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatsByQuarter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StatsByQuarter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StatsByQuarter" /> class.
        /// </summary>
        /// <param name="total">total (required).</param>
        /// <param name="quarter1">quarter1 (required).</param>
        /// <param name="quarter2">quarter2 (required).</param>
        /// <param name="quarter3">quarter3 (required).</param>
        /// <param name="quarter4">quarter4 (required).</param>
        public StatsByQuarter(double total = default(double), double quarter1 = default(double), double quarter2 = default(double), double quarter3 = default(double), double quarter4 = default(double))
        {
            this.Total = total;
            this.Quarter1 = quarter1;
            this.Quarter2 = quarter2;
            this.Quarter3 = quarter3;
            this.Quarter4 = quarter4;
        }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public double Total { get; set; }

        /// <summary>
        /// Gets or Sets Quarter1
        /// </summary>
        [DataMember(Name = "quarter1", IsRequired = true, EmitDefaultValue = true)]
        public double Quarter1 { get; set; }

        /// <summary>
        /// Gets or Sets Quarter2
        /// </summary>
        [DataMember(Name = "quarter2", IsRequired = true, EmitDefaultValue = true)]
        public double Quarter2 { get; set; }

        /// <summary>
        /// Gets or Sets Quarter3
        /// </summary>
        [DataMember(Name = "quarter3", IsRequired = true, EmitDefaultValue = true)]
        public double Quarter3 { get; set; }

        /// <summary>
        /// Gets or Sets Quarter4
        /// </summary>
        [DataMember(Name = "quarter4", IsRequired = true, EmitDefaultValue = true)]
        public double Quarter4 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StatsByQuarter {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Quarter1: ").Append(Quarter1).Append("\n");
            sb.Append("  Quarter2: ").Append(Quarter2).Append("\n");
            sb.Append("  Quarter3: ").Append(Quarter3).Append("\n");
            sb.Append("  Quarter4: ").Append(Quarter4).Append("\n");
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

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
    /// Poll
    /// </summary>
    [DataContract(Name = "Poll")]
    public partial class Poll : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Poll" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Poll() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Poll" /> class.
        /// </summary>
        /// <param name="varPoll">varPoll (required).</param>
        /// <param name="ranks">ranks (required).</param>
        public Poll(string varPoll = default(string), List<PollRank> ranks = default(List<PollRank>))
        {
            // to ensure "varPoll" is required (not null)
            if (varPoll == null)
            {
                throw new ArgumentNullException("varPoll is a required property for Poll and cannot be null");
            }
            this.VarPoll = varPoll;
            // to ensure "ranks" is required (not null)
            if (ranks == null)
            {
                throw new ArgumentNullException("ranks is a required property for Poll and cannot be null");
            }
            this.Ranks = ranks;
        }

        /// <summary>
        /// Gets or Sets VarPoll
        /// </summary>
        [DataMember(Name = "poll", IsRequired = true, EmitDefaultValue = true)]
        public string VarPoll { get; set; }

        /// <summary>
        /// Gets or Sets Ranks
        /// </summary>
        [DataMember(Name = "ranks", IsRequired = true, EmitDefaultValue = true)]
        public List<PollRank> Ranks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Poll {\n");
            sb.Append("  VarPoll: ").Append(VarPoll).Append("\n");
            sb.Append("  Ranks: ").Append(Ranks).Append("\n");
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

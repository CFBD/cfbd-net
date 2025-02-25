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
    /// CalendarWeek
    /// </summary>
    [DataContract(Name = "CalendarWeek")]
    public partial class CalendarWeek : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets SeasonType
        /// </summary>
        [DataMember(Name = "seasonType", IsRequired = true, EmitDefaultValue = true)]
        public SeasonType SeasonType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarWeek" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CalendarWeek() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarWeek" /> class.
        /// </summary>
        /// <param name="season">season (required).</param>
        /// <param name="week">week (required).</param>
        /// <param name="seasonType">seasonType (required).</param>
        /// <param name="startDate">startDate (required).</param>
        /// <param name="endDate">endDate (required).</param>
        /// <param name="firstGameStart">firstGameStart (required).</param>
        /// <param name="lastGameStart">lastGameStart (required).</param>
        public CalendarWeek(int season = default(int), int week = default(int), SeasonType seasonType = default(SeasonType), DateTime startDate = default(DateTime), DateTime endDate = default(DateTime), DateTime firstGameStart = default(DateTime), DateTime lastGameStart = default(DateTime))
        {
            this.Season = season;
            this.Week = week;
            this.SeasonType = seasonType;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.FirstGameStart = firstGameStart;
            this.LastGameStart = lastGameStart;
        }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", IsRequired = true, EmitDefaultValue = true)]
        public int Season { get; set; }

        /// <summary>
        /// Gets or Sets Week
        /// </summary>
        [DataMember(Name = "week", IsRequired = true, EmitDefaultValue = true)]
        public int Week { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or Sets FirstGameStart
        /// </summary>
        [DataMember(Name = "firstGameStart", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public DateTime FirstGameStart { get; set; }

        /// <summary>
        /// Gets or Sets LastGameStart
        /// </summary>
        [DataMember(Name = "lastGameStart", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public DateTime LastGameStart { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CalendarWeek {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  SeasonType: ").Append(SeasonType).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  FirstGameStart: ").Append(FirstGameStart).Append("\n");
            sb.Append("  LastGameStart: ").Append(LastGameStart).Append("\n");
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

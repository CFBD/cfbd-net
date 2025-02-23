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
    /// DraftPickHometownInfo
    /// </summary>
    [DataContract(Name = "DraftPick_hometownInfo")]
    public partial class DraftPickHometownInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DraftPickHometownInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DraftPickHometownInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DraftPickHometownInfo" /> class.
        /// </summary>
        /// <param name="countyFips">countyFips (required).</param>
        /// <param name="longitude">longitude (required).</param>
        /// <param name="latitude">latitude (required).</param>
        /// <param name="country">country (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="city">city (required).</param>
        public DraftPickHometownInfo(string countyFips = default(string), string longitude = default(string), string latitude = default(string), string country = default(string), string state = default(string), string city = default(string))
        {
            // to ensure "countyFips" is required (not null)
            if (countyFips == null)
            {
                throw new ArgumentNullException("countyFips is a required property for DraftPickHometownInfo and cannot be null");
            }
            this.CountyFips = countyFips;
            // to ensure "longitude" is required (not null)
            if (longitude == null)
            {
                throw new ArgumentNullException("longitude is a required property for DraftPickHometownInfo and cannot be null");
            }
            this.Longitude = longitude;
            // to ensure "latitude" is required (not null)
            if (latitude == null)
            {
                throw new ArgumentNullException("latitude is a required property for DraftPickHometownInfo and cannot be null");
            }
            this.Latitude = latitude;
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new ArgumentNullException("country is a required property for DraftPickHometownInfo and cannot be null");
            }
            this.Country = country;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for DraftPickHometownInfo and cannot be null");
            }
            this.State = state;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for DraftPickHometownInfo and cannot be null");
            }
            this.City = city;
        }

        /// <summary>
        /// Gets or Sets CountyFips
        /// </summary>
        [DataMember(Name = "countyFips", IsRequired = true, EmitDefaultValue = true)]
        public string CountyFips { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name = "longitude", IsRequired = true, EmitDefaultValue = true)]
        public string Longitude { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name = "latitude", IsRequired = true, EmitDefaultValue = true)]
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = true)]
        public string Country { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DraftPickHometownInfo {\n");
            sb.Append("  CountyFips: ").Append(CountyFips).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
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

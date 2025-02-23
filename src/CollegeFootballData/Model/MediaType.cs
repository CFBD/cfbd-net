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
    /// Defines MediaType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MediaType
    {
        /// <summary>
        /// Enum Tv for value: tv
        /// </summary>
        [EnumMember(Value = "tv")]
        Tv = 1,

        /// <summary>
        /// Enum Radio for value: radio
        /// </summary>
        [EnumMember(Value = "radio")]
        Radio = 2,

        /// <summary>
        /// Enum Web for value: web
        /// </summary>
        [EnumMember(Value = "web")]
        Web = 3,

        /// <summary>
        /// Enum Ppv for value: ppv
        /// </summary>
        [EnumMember(Value = "ppv")]
        Ppv = 4,

        /// <summary>
        /// Enum Mobile for value: mobile
        /// </summary>
        [EnumMember(Value = "mobile")]
        Mobile = 5
    }

}

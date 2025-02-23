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
    /// Defines DivisionClassification
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DivisionClassification
    {
        /// <summary>
        /// Enum Fbs for value: fbs
        /// </summary>
        [EnumMember(Value = "fbs")]
        Fbs = 1,

        /// <summary>
        /// Enum Fcs for value: fcs
        /// </summary>
        [EnumMember(Value = "fcs")]
        Fcs = 2,

        /// <summary>
        /// Enum Ii for value: ii
        /// </summary>
        [EnumMember(Value = "ii")]
        Ii = 3,

        /// <summary>
        /// Enum Iii for value: iii
        /// </summary>
        [EnumMember(Value = "iii")]
        Iii = 4
    }

}

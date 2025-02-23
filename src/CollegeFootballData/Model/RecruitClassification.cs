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
    /// Defines RecruitClassification
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecruitClassification
    {
        /// <summary>
        /// Enum JUCO for value: JUCO
        /// </summary>
        [EnumMember(Value = "JUCO")]
        JUCO = 1,

        /// <summary>
        /// Enum PrepSchool for value: PrepSchool
        /// </summary>
        [EnumMember(Value = "PrepSchool")]
        PrepSchool = 2,

        /// <summary>
        /// Enum HighSchool for value: HighSchool
        /// </summary>
        [EnumMember(Value = "HighSchool")]
        HighSchool = 3
    }

}

// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.8
 * Contact: admin@collegefootballdata.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using CollegeFootballData.Client;

namespace CollegeFootballData.Model
{
    /// <summary>
    /// Defines DivisionClassification
    /// </summary>
    public enum DivisionClassification
    {
        /// <summary>
        /// Enum Fbs for value: fbs
        /// </summary>
        Fbs = 1,

        /// <summary>
        /// Enum Fcs for value: fcs
        /// </summary>
        Fcs = 2,

        /// <summary>
        /// Enum Ii for value: ii
        /// </summary>
        Ii = 3,

        /// <summary>
        /// Enum Iii for value: iii
        /// </summary>
        Iii = 4
    }

    /// <summary>
    /// Converts <see cref="DivisionClassification"/> to and from the JSON value
    /// </summary>
    public static class DivisionClassificationValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="DivisionClassification"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DivisionClassification FromString(string value)
        {
            if (value.Equals("fbs"))
                return DivisionClassification.Fbs;

            if (value.Equals("fcs"))
                return DivisionClassification.Fcs;

            if (value.Equals("ii"))
                return DivisionClassification.Ii;

            if (value.Equals("iii"))
                return DivisionClassification.Iii;

            throw new NotImplementedException($"Could not convert value to type DivisionClassification: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="DivisionClassification"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DivisionClassification? FromStringOrDefault(string value)
        {
            if (value.Equals("fbs"))
                return DivisionClassification.Fbs;

            if (value.Equals("fcs"))
                return DivisionClassification.Fcs;

            if (value.Equals("ii"))
                return DivisionClassification.Ii;

            if (value.Equals("iii"))
                return DivisionClassification.Iii;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="DivisionClassification"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(DivisionClassification value)
        {
            if (value == DivisionClassification.Fbs)
                return "fbs";

            if (value == DivisionClassification.Fcs)
                return "fcs";

            if (value == DivisionClassification.Ii)
                return "ii";

            if (value == DivisionClassification.Iii)
                return "iii";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="DivisionClassification"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class DivisionClassificationJsonConverter : JsonConverter<DivisionClassification>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override DivisionClassification Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            DivisionClassification? result = rawValue == null
                ? null
                : DivisionClassificationValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DivisionClassification to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="divisionClassification"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, DivisionClassification divisionClassification, JsonSerializerOptions options)
        {
            writer.WriteStringValue(divisionClassification.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="DivisionClassification"/>
    /// </summary>
    public class DivisionClassificationNullableJsonConverter : JsonConverter<DivisionClassification?>
    {
        /// <summary>
        /// Returns a DivisionClassification from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override DivisionClassification? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            DivisionClassification? result = rawValue == null
                ? null
                : DivisionClassificationValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="divisionClassification"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, DivisionClassification? divisionClassification, JsonSerializerOptions options)
        {
            writer.WriteStringValue(divisionClassification?.ToString() ?? "null");
        }
    }
}

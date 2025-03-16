// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.7
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
    /// Defines TransferEligibility
    /// </summary>
    public enum TransferEligibility
    {
        /// <summary>
        /// Enum Withdrawn for value: Withdrawn
        /// </summary>
        Withdrawn = 1,

        /// <summary>
        /// Enum TBD for value: TBD
        /// </summary>
        TBD = 2,

        /// <summary>
        /// Enum PendingAppeal for value: PendingAppeal
        /// </summary>
        PendingAppeal = 3,

        /// <summary>
        /// Enum SittingOne for value: SittingOne
        /// </summary>
        SittingOne = 4,

        /// <summary>
        /// Enum Immediate for value: Immediate
        /// </summary>
        Immediate = 5
    }

    /// <summary>
    /// Converts <see cref="TransferEligibility"/> to and from the JSON value
    /// </summary>
    public static class TransferEligibilityValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="TransferEligibility"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TransferEligibility FromString(string value)
        {
            if (value.Equals("Withdrawn"))
                return TransferEligibility.Withdrawn;

            if (value.Equals("TBD"))
                return TransferEligibility.TBD;

            if (value.Equals("PendingAppeal"))
                return TransferEligibility.PendingAppeal;

            if (value.Equals("SittingOne"))
                return TransferEligibility.SittingOne;

            if (value.Equals("Immediate"))
                return TransferEligibility.Immediate;

            throw new NotImplementedException($"Could not convert value to type TransferEligibility: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="TransferEligibility"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TransferEligibility? FromStringOrDefault(string value)
        {
            if (value.Equals("Withdrawn"))
                return TransferEligibility.Withdrawn;

            if (value.Equals("TBD"))
                return TransferEligibility.TBD;

            if (value.Equals("PendingAppeal"))
                return TransferEligibility.PendingAppeal;

            if (value.Equals("SittingOne"))
                return TransferEligibility.SittingOne;

            if (value.Equals("Immediate"))
                return TransferEligibility.Immediate;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="TransferEligibility"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(TransferEligibility value)
        {
            if (value == TransferEligibility.Withdrawn)
                return "Withdrawn";

            if (value == TransferEligibility.TBD)
                return "TBD";

            if (value == TransferEligibility.PendingAppeal)
                return "PendingAppeal";

            if (value == TransferEligibility.SittingOne)
                return "SittingOne";

            if (value == TransferEligibility.Immediate)
                return "Immediate";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="TransferEligibility"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class TransferEligibilityJsonConverter : JsonConverter<TransferEligibility>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override TransferEligibility Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            TransferEligibility? result = rawValue == null
                ? null
                : TransferEligibilityValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the TransferEligibility to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="transferEligibility"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, TransferEligibility transferEligibility, JsonSerializerOptions options)
        {
            writer.WriteStringValue(transferEligibility.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="TransferEligibility"/>
    /// </summary>
    public class TransferEligibilityNullableJsonConverter : JsonConverter<TransferEligibility?>
    {
        /// <summary>
        /// Returns a TransferEligibility from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override TransferEligibility? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            TransferEligibility? result = rawValue == null
                ? null
                : TransferEligibilityValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="transferEligibility"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, TransferEligibility? transferEligibility, JsonSerializerOptions options)
        {
            writer.WriteStringValue(transferEligibility?.ToString() ?? "null");
        }
    }
}

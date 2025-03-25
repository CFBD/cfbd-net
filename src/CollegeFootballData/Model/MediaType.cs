// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.9
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
    /// Defines MediaType
    /// </summary>
    public enum MediaType
    {
        /// <summary>
        /// Enum Tv for value: tv
        /// </summary>
        Tv = 1,

        /// <summary>
        /// Enum Radio for value: radio
        /// </summary>
        Radio = 2,

        /// <summary>
        /// Enum Web for value: web
        /// </summary>
        Web = 3,

        /// <summary>
        /// Enum Ppv for value: ppv
        /// </summary>
        Ppv = 4,

        /// <summary>
        /// Enum Mobile for value: mobile
        /// </summary>
        Mobile = 5
    }

    /// <summary>
    /// Converts <see cref="MediaType"/> to and from the JSON value
    /// </summary>
    public static class MediaTypeValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="MediaType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static MediaType FromString(string value)
        {
            if (value.Equals("tv"))
                return MediaType.Tv;

            if (value.Equals("radio"))
                return MediaType.Radio;

            if (value.Equals("web"))
                return MediaType.Web;

            if (value.Equals("ppv"))
                return MediaType.Ppv;

            if (value.Equals("mobile"))
                return MediaType.Mobile;

            throw new NotImplementedException($"Could not convert value to type MediaType: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="MediaType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static MediaType? FromStringOrDefault(string value)
        {
            if (value.Equals("tv"))
                return MediaType.Tv;

            if (value.Equals("radio"))
                return MediaType.Radio;

            if (value.Equals("web"))
                return MediaType.Web;

            if (value.Equals("ppv"))
                return MediaType.Ppv;

            if (value.Equals("mobile"))
                return MediaType.Mobile;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="MediaType"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(MediaType value)
        {
            if (value == MediaType.Tv)
                return "tv";

            if (value == MediaType.Radio)
                return "radio";

            if (value == MediaType.Web)
                return "web";

            if (value == MediaType.Ppv)
                return "ppv";

            if (value == MediaType.Mobile)
                return "mobile";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="MediaType"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class MediaTypeJsonConverter : JsonConverter<MediaType>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override MediaType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            MediaType? result = rawValue == null
                ? null
                : MediaTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the MediaType to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mediaType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, MediaType mediaType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(mediaType.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="MediaType"/>
    /// </summary>
    public class MediaTypeNullableJsonConverter : JsonConverter<MediaType?>
    {
        /// <summary>
        /// Returns a MediaType from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override MediaType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            MediaType? result = rawValue == null
                ? null
                : MediaTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mediaType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, MediaType? mediaType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(mediaType?.ToString() ?? "null");
        }
    }
}

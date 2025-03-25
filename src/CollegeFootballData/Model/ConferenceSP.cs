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
    /// ConferenceSP
    /// </summary>
    public partial class ConferenceSP : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceSP" /> class.
        /// </summary>
        /// <param name="year">year</param>
        /// <param name="conference">conference</param>
        /// <param name="rating">rating</param>
        /// <param name="offense">offense</param>
        /// <param name="defense">defense</param>
        /// <param name="specialTeams">specialTeams</param>
        /// <param name="secondOrderWins">secondOrderWins</param>
        /// <param name="sos">sos</param>
        [JsonConstructor]
        public ConferenceSP(int year, string conference, double rating, ConferenceSPOffense offense, ConferenceSPDefense defense, TeamSPSpecialTeams specialTeams, double? secondOrderWins = default, double? sos = default)
        {
            Year = year;
            Conference = conference;
            Rating = rating;
            Offense = offense;
            Defense = defense;
            SpecialTeams = specialTeams;
            SecondOrderWins = secondOrderWins;
            Sos = sos;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [JsonPropertyName("year")]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [JsonPropertyName("conference")]
        public string Conference { get; set; }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [JsonPropertyName("rating")]
        public double Rating { get; set; }

        /// <summary>
        /// Gets or Sets Offense
        /// </summary>
        [JsonPropertyName("offense")]
        public ConferenceSPOffense Offense { get; set; }

        /// <summary>
        /// Gets or Sets Defense
        /// </summary>
        [JsonPropertyName("defense")]
        public ConferenceSPDefense Defense { get; set; }

        /// <summary>
        /// Gets or Sets SpecialTeams
        /// </summary>
        [JsonPropertyName("specialTeams")]
        public TeamSPSpecialTeams SpecialTeams { get; set; }

        /// <summary>
        /// Gets or Sets SecondOrderWins
        /// </summary>
        [JsonPropertyName("secondOrderWins")]
        public double? SecondOrderWins { get; set; }

        /// <summary>
        /// Gets or Sets Sos
        /// </summary>
        [JsonPropertyName("sos")]
        public double? Sos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConferenceSP {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Offense: ").Append(Offense).Append("\n");
            sb.Append("  Defense: ").Append(Defense).Append("\n");
            sb.Append("  SpecialTeams: ").Append(SpecialTeams).Append("\n");
            sb.Append("  SecondOrderWins: ").Append(SecondOrderWins).Append("\n");
            sb.Append("  Sos: ").Append(Sos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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

    /// <summary>
    /// A Json converter for type <see cref="ConferenceSP" />
    /// </summary>
    public class ConferenceSPJsonConverter : JsonConverter<ConferenceSP>
    {
        /// <summary>
        /// Deserializes json to <see cref="ConferenceSP" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ConferenceSP Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> year = default;
            Option<string?> conference = default;
            Option<double?> rating = default;
            Option<ConferenceSPOffense?> offense = default;
            Option<ConferenceSPDefense?> defense = default;
            Option<TeamSPSpecialTeams?> specialTeams = default;
            Option<double?> secondOrderWins = default;
            Option<double?> sos = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "year":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                year = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "conference":
                            conference = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "rating":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rating = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "offense":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                offense = new Option<ConferenceSPOffense?>(JsonSerializer.Deserialize<ConferenceSPOffense>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "defense":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                defense = new Option<ConferenceSPDefense?>(JsonSerializer.Deserialize<ConferenceSPDefense>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "specialTeams":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                specialTeams = new Option<TeamSPSpecialTeams?>(JsonSerializer.Deserialize<TeamSPSpecialTeams>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "secondOrderWins":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                secondOrderWins = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "sos":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                sos = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!year.IsSet)
                throw new ArgumentException("Property is required for class ConferenceSP.", nameof(year));

            if (!conference.IsSet)
                throw new ArgumentException("Property is required for class ConferenceSP.", nameof(conference));

            if (!rating.IsSet)
                throw new ArgumentException("Property is required for class ConferenceSP.", nameof(rating));

            if (!offense.IsSet)
                throw new ArgumentException("Property is required for class ConferenceSP.", nameof(offense));

            if (!defense.IsSet)
                throw new ArgumentException("Property is required for class ConferenceSP.", nameof(defense));

            if (!specialTeams.IsSet)
                throw new ArgumentException("Property is required for class ConferenceSP.", nameof(specialTeams));

            if (!secondOrderWins.IsSet)
                throw new ArgumentException("Property is required for class ConferenceSP.", nameof(secondOrderWins));

            if (!sos.IsSet)
                throw new ArgumentException("Property is required for class ConferenceSP.", nameof(sos));

            if (year.IsSet && year.Value == null)
                throw new ArgumentNullException(nameof(year), "Property is not nullable for class ConferenceSP.");

            if (conference.IsSet && conference.Value == null)
                throw new ArgumentNullException(nameof(conference), "Property is not nullable for class ConferenceSP.");

            if (rating.IsSet && rating.Value == null)
                throw new ArgumentNullException(nameof(rating), "Property is not nullable for class ConferenceSP.");

            if (offense.IsSet && offense.Value == null)
                throw new ArgumentNullException(nameof(offense), "Property is not nullable for class ConferenceSP.");

            if (defense.IsSet && defense.Value == null)
                throw new ArgumentNullException(nameof(defense), "Property is not nullable for class ConferenceSP.");

            if (specialTeams.IsSet && specialTeams.Value == null)
                throw new ArgumentNullException(nameof(specialTeams), "Property is not nullable for class ConferenceSP.");

            return new ConferenceSP(year.Value!.Value!, conference.Value!, rating.Value!.Value!, offense.Value!, defense.Value!, specialTeams.Value!, secondOrderWins.Value!, sos.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="ConferenceSP" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="conferenceSP"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ConferenceSP conferenceSP, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, conferenceSP, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ConferenceSP" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="conferenceSP"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ConferenceSP conferenceSP, JsonSerializerOptions jsonSerializerOptions)
        {
            if (conferenceSP.Conference == null)
                throw new ArgumentNullException(nameof(conferenceSP.Conference), "Property is required for class ConferenceSP.");

            if (conferenceSP.Offense == null)
                throw new ArgumentNullException(nameof(conferenceSP.Offense), "Property is required for class ConferenceSP.");

            if (conferenceSP.Defense == null)
                throw new ArgumentNullException(nameof(conferenceSP.Defense), "Property is required for class ConferenceSP.");

            if (conferenceSP.SpecialTeams == null)
                throw new ArgumentNullException(nameof(conferenceSP.SpecialTeams), "Property is required for class ConferenceSP.");

            writer.WriteNumber("year", conferenceSP.Year);

            writer.WriteString("conference", conferenceSP.Conference);

            writer.WriteNumber("rating", conferenceSP.Rating);

            writer.WritePropertyName("offense");
            JsonSerializer.Serialize(writer, conferenceSP.Offense, jsonSerializerOptions);
            writer.WritePropertyName("defense");
            JsonSerializer.Serialize(writer, conferenceSP.Defense, jsonSerializerOptions);
            writer.WritePropertyName("specialTeams");
            JsonSerializer.Serialize(writer, conferenceSP.SpecialTeams, jsonSerializerOptions);
            if (conferenceSP.SecondOrderWins != null)
                writer.WriteNumber("secondOrderWins", conferenceSP.SecondOrderWins.Value);
            else
                writer.WriteNull("secondOrderWins");

            if (conferenceSP.Sos != null)
                writer.WriteNumber("sos", conferenceSP.Sos.Value);
            else
                writer.WriteNull("sos");
        }
    }
}

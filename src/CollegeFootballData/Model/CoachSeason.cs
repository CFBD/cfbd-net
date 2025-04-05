// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.10
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
    /// CoachSeason
    /// </summary>
    public partial class CoachSeason : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoachSeason" /> class.
        /// </summary>
        /// <param name="school">school</param>
        /// <param name="year">year</param>
        /// <param name="games">games</param>
        /// <param name="wins">wins</param>
        /// <param name="losses">losses</param>
        /// <param name="ties">ties</param>
        /// <param name="preseasonRank">preseasonRank</param>
        /// <param name="postseasonRank">postseasonRank</param>
        /// <param name="srs">srs</param>
        /// <param name="spOverall">spOverall</param>
        /// <param name="spOffense">spOffense</param>
        /// <param name="spDefense">spDefense</param>
        [JsonConstructor]
        public CoachSeason(string school, int year, int games, int wins, int losses, int ties, int? preseasonRank = default, int? postseasonRank = default, double? srs = default, double? spOverall = default, double? spOffense = default, double? spDefense = default)
        {
            School = school;
            Year = year;
            Games = games;
            Wins = wins;
            Losses = losses;
            Ties = ties;
            PreseasonRank = preseasonRank;
            PostseasonRank = postseasonRank;
            Srs = srs;
            SpOverall = spOverall;
            SpOffense = spOffense;
            SpDefense = spDefense;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets School
        /// </summary>
        [JsonPropertyName("school")]
        public string School { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [JsonPropertyName("year")]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets Games
        /// </summary>
        [JsonPropertyName("games")]
        public int Games { get; set; }

        /// <summary>
        /// Gets or Sets Wins
        /// </summary>
        [JsonPropertyName("wins")]
        public int Wins { get; set; }

        /// <summary>
        /// Gets or Sets Losses
        /// </summary>
        [JsonPropertyName("losses")]
        public int Losses { get; set; }

        /// <summary>
        /// Gets or Sets Ties
        /// </summary>
        [JsonPropertyName("ties")]
        public int Ties { get; set; }

        /// <summary>
        /// Gets or Sets PreseasonRank
        /// </summary>
        [JsonPropertyName("preseasonRank")]
        public int? PreseasonRank { get; set; }

        /// <summary>
        /// Gets or Sets PostseasonRank
        /// </summary>
        [JsonPropertyName("postseasonRank")]
        public int? PostseasonRank { get; set; }

        /// <summary>
        /// Gets or Sets Srs
        /// </summary>
        [JsonPropertyName("srs")]
        public double? Srs { get; set; }

        /// <summary>
        /// Gets or Sets SpOverall
        /// </summary>
        [JsonPropertyName("spOverall")]
        public double? SpOverall { get; set; }

        /// <summary>
        /// Gets or Sets SpOffense
        /// </summary>
        [JsonPropertyName("spOffense")]
        public double? SpOffense { get; set; }

        /// <summary>
        /// Gets or Sets SpDefense
        /// </summary>
        [JsonPropertyName("spDefense")]
        public double? SpDefense { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CoachSeason {\n");
            sb.Append("  School: ").Append(School).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Games: ").Append(Games).Append("\n");
            sb.Append("  Wins: ").Append(Wins).Append("\n");
            sb.Append("  Losses: ").Append(Losses).Append("\n");
            sb.Append("  Ties: ").Append(Ties).Append("\n");
            sb.Append("  PreseasonRank: ").Append(PreseasonRank).Append("\n");
            sb.Append("  PostseasonRank: ").Append(PostseasonRank).Append("\n");
            sb.Append("  Srs: ").Append(Srs).Append("\n");
            sb.Append("  SpOverall: ").Append(SpOverall).Append("\n");
            sb.Append("  SpOffense: ").Append(SpOffense).Append("\n");
            sb.Append("  SpDefense: ").Append(SpDefense).Append("\n");
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
    /// A Json converter for type <see cref="CoachSeason" />
    /// </summary>
    public class CoachSeasonJsonConverter : JsonConverter<CoachSeason>
    {
        /// <summary>
        /// Deserializes json to <see cref="CoachSeason" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CoachSeason Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> school = default;
            Option<int?> year = default;
            Option<int?> games = default;
            Option<int?> wins = default;
            Option<int?> losses = default;
            Option<int?> ties = default;
            Option<int?> preseasonRank = default;
            Option<int?> postseasonRank = default;
            Option<double?> srs = default;
            Option<double?> spOverall = default;
            Option<double?> spOffense = default;
            Option<double?> spDefense = default;

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
                        case "school":
                            school = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "year":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                year = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "games":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                games = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "wins":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                wins = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "losses":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                losses = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "ties":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                ties = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "preseasonRank":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                preseasonRank = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "postseasonRank":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                postseasonRank = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "srs":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                srs = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "spOverall":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                spOverall = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "spOffense":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                spOffense = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "spDefense":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                spDefense = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!school.IsSet)
                throw new ArgumentException("Property is required for class CoachSeason.", nameof(school));

            if (!year.IsSet)
                throw new ArgumentException("Property is required for class CoachSeason.", nameof(year));

            if (!games.IsSet)
                throw new ArgumentException("Property is required for class CoachSeason.", nameof(games));

            if (!wins.IsSet)
                throw new ArgumentException("Property is required for class CoachSeason.", nameof(wins));

            if (!losses.IsSet)
                throw new ArgumentException("Property is required for class CoachSeason.", nameof(losses));

            if (!ties.IsSet)
                throw new ArgumentException("Property is required for class CoachSeason.", nameof(ties));

            if (!preseasonRank.IsSet)
                throw new ArgumentException("Property is required for class CoachSeason.", nameof(preseasonRank));

            if (!postseasonRank.IsSet)
                throw new ArgumentException("Property is required for class CoachSeason.", nameof(postseasonRank));

            if (!srs.IsSet)
                throw new ArgumentException("Property is required for class CoachSeason.", nameof(srs));

            if (!spOverall.IsSet)
                throw new ArgumentException("Property is required for class CoachSeason.", nameof(spOverall));

            if (!spOffense.IsSet)
                throw new ArgumentException("Property is required for class CoachSeason.", nameof(spOffense));

            if (!spDefense.IsSet)
                throw new ArgumentException("Property is required for class CoachSeason.", nameof(spDefense));

            if (school.IsSet && school.Value == null)
                throw new ArgumentNullException(nameof(school), "Property is not nullable for class CoachSeason.");

            if (year.IsSet && year.Value == null)
                throw new ArgumentNullException(nameof(year), "Property is not nullable for class CoachSeason.");

            if (games.IsSet && games.Value == null)
                throw new ArgumentNullException(nameof(games), "Property is not nullable for class CoachSeason.");

            if (wins.IsSet && wins.Value == null)
                throw new ArgumentNullException(nameof(wins), "Property is not nullable for class CoachSeason.");

            if (losses.IsSet && losses.Value == null)
                throw new ArgumentNullException(nameof(losses), "Property is not nullable for class CoachSeason.");

            if (ties.IsSet && ties.Value == null)
                throw new ArgumentNullException(nameof(ties), "Property is not nullable for class CoachSeason.");

            return new CoachSeason(school.Value!, year.Value!.Value!, games.Value!.Value!, wins.Value!.Value!, losses.Value!.Value!, ties.Value!.Value!, preseasonRank.Value!, postseasonRank.Value!, srs.Value!, spOverall.Value!, spOffense.Value!, spDefense.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="CoachSeason" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="coachSeason"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CoachSeason coachSeason, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, coachSeason, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CoachSeason" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="coachSeason"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CoachSeason coachSeason, JsonSerializerOptions jsonSerializerOptions)
        {
            if (coachSeason.School == null)
                throw new ArgumentNullException(nameof(coachSeason.School), "Property is required for class CoachSeason.");

            writer.WriteString("school", coachSeason.School);

            writer.WriteNumber("year", coachSeason.Year);

            writer.WriteNumber("games", coachSeason.Games);

            writer.WriteNumber("wins", coachSeason.Wins);

            writer.WriteNumber("losses", coachSeason.Losses);

            writer.WriteNumber("ties", coachSeason.Ties);

            if (coachSeason.PreseasonRank != null)
                writer.WriteNumber("preseasonRank", coachSeason.PreseasonRank.Value);
            else
                writer.WriteNull("preseasonRank");

            if (coachSeason.PostseasonRank != null)
                writer.WriteNumber("postseasonRank", coachSeason.PostseasonRank.Value);
            else
                writer.WriteNull("postseasonRank");

            if (coachSeason.Srs != null)
                writer.WriteNumber("srs", coachSeason.Srs.Value);
            else
                writer.WriteNull("srs");

            if (coachSeason.SpOverall != null)
                writer.WriteNumber("spOverall", coachSeason.SpOverall.Value);
            else
                writer.WriteNull("spOverall");

            if (coachSeason.SpOffense != null)
                writer.WriteNumber("spOffense", coachSeason.SpOffense.Value);
            else
                writer.WriteNull("spOffense");

            if (coachSeason.SpDefense != null)
                writer.WriteNumber("spDefense", coachSeason.SpDefense.Value);
            else
                writer.WriteNull("spDefense");
        }
    }
}

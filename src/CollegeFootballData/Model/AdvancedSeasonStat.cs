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
    /// AdvancedSeasonStat
    /// </summary>
    public partial class AdvancedSeasonStat : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedSeasonStat" /> class.
        /// </summary>
        /// <param name="season">season</param>
        /// <param name="team">team</param>
        /// <param name="conference">conference</param>
        /// <param name="offense">offense</param>
        /// <param name="defense">defense</param>
        [JsonConstructor]
        public AdvancedSeasonStat(int season, string team, string conference, AdvancedSeasonStatOffense offense, AdvancedSeasonStatDefense defense)
        {
            Season = season;
            Team = team;
            Conference = conference;
            Offense = offense;
            Defense = defense;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [JsonPropertyName("season")]
        public int Season { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [JsonPropertyName("team")]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [JsonPropertyName("conference")]
        public string Conference { get; set; }

        /// <summary>
        /// Gets or Sets Offense
        /// </summary>
        [JsonPropertyName("offense")]
        public AdvancedSeasonStatOffense Offense { get; set; }

        /// <summary>
        /// Gets or Sets Defense
        /// </summary>
        [JsonPropertyName("defense")]
        public AdvancedSeasonStatDefense Defense { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdvancedSeasonStat {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Offense: ").Append(Offense).Append("\n");
            sb.Append("  Defense: ").Append(Defense).Append("\n");
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
    /// A Json converter for type <see cref="AdvancedSeasonStat" />
    /// </summary>
    public class AdvancedSeasonStatJsonConverter : JsonConverter<AdvancedSeasonStat>
    {
        /// <summary>
        /// Deserializes json to <see cref="AdvancedSeasonStat" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AdvancedSeasonStat Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> season = default;
            Option<string?> team = default;
            Option<string?> conference = default;
            Option<AdvancedSeasonStatOffense?> offense = default;
            Option<AdvancedSeasonStatDefense?> defense = default;

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
                        case "season":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                season = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "team":
                            team = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "conference":
                            conference = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "offense":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                offense = new Option<AdvancedSeasonStatOffense?>(JsonSerializer.Deserialize<AdvancedSeasonStatOffense>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "defense":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                defense = new Option<AdvancedSeasonStatDefense?>(JsonSerializer.Deserialize<AdvancedSeasonStatDefense>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!season.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStat.", nameof(season));

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStat.", nameof(team));

            if (!conference.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStat.", nameof(conference));

            if (!offense.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStat.", nameof(offense));

            if (!defense.IsSet)
                throw new ArgumentException("Property is required for class AdvancedSeasonStat.", nameof(defense));

            if (season.IsSet && season.Value == null)
                throw new ArgumentNullException(nameof(season), "Property is not nullable for class AdvancedSeasonStat.");

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class AdvancedSeasonStat.");

            if (conference.IsSet && conference.Value == null)
                throw new ArgumentNullException(nameof(conference), "Property is not nullable for class AdvancedSeasonStat.");

            if (offense.IsSet && offense.Value == null)
                throw new ArgumentNullException(nameof(offense), "Property is not nullable for class AdvancedSeasonStat.");

            if (defense.IsSet && defense.Value == null)
                throw new ArgumentNullException(nameof(defense), "Property is not nullable for class AdvancedSeasonStat.");

            return new AdvancedSeasonStat(season.Value!.Value!, team.Value!, conference.Value!, offense.Value!, defense.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AdvancedSeasonStat" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedSeasonStat"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AdvancedSeasonStat advancedSeasonStat, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, advancedSeasonStat, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AdvancedSeasonStat" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedSeasonStat"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AdvancedSeasonStat advancedSeasonStat, JsonSerializerOptions jsonSerializerOptions)
        {
            if (advancedSeasonStat.Team == null)
                throw new ArgumentNullException(nameof(advancedSeasonStat.Team), "Property is required for class AdvancedSeasonStat.");

            if (advancedSeasonStat.Conference == null)
                throw new ArgumentNullException(nameof(advancedSeasonStat.Conference), "Property is required for class AdvancedSeasonStat.");

            if (advancedSeasonStat.Offense == null)
                throw new ArgumentNullException(nameof(advancedSeasonStat.Offense), "Property is required for class AdvancedSeasonStat.");

            if (advancedSeasonStat.Defense == null)
                throw new ArgumentNullException(nameof(advancedSeasonStat.Defense), "Property is required for class AdvancedSeasonStat.");

            writer.WriteNumber("season", advancedSeasonStat.Season);

            writer.WriteString("team", advancedSeasonStat.Team);

            writer.WriteString("conference", advancedSeasonStat.Conference);

            writer.WritePropertyName("offense");
            JsonSerializer.Serialize(writer, advancedSeasonStat.Offense, jsonSerializerOptions);
            writer.WritePropertyName("defense");
            JsonSerializer.Serialize(writer, advancedSeasonStat.Defense, jsonSerializerOptions);
        }
    }
}

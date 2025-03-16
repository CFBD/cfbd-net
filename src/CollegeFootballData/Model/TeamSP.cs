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
    /// TeamSP
    /// </summary>
    public partial class TeamSP : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSP" /> class.
        /// </summary>
        /// <param name="year">year</param>
        /// <param name="team">team</param>
        /// <param name="conference">conference</param>
        /// <param name="rating">rating</param>
        /// <param name="ranking">ranking</param>
        /// <param name="offense">offense</param>
        /// <param name="defense">defense</param>
        /// <param name="specialTeams">specialTeams</param>
        /// <param name="secondOrderWins">secondOrderWins</param>
        /// <param name="sos">sos</param>
        [JsonConstructor]
        public TeamSP(int year, string team, string conference, double rating, int ranking, TeamSPOffense offense, TeamSPDefense defense, TeamSPSpecialTeams specialTeams, double? secondOrderWins = default, double? sos = default)
        {
            Year = year;
            Team = team;
            Conference = conference;
            Rating = rating;
            Ranking = ranking;
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
        /// Gets or Sets Rating
        /// </summary>
        [JsonPropertyName("rating")]
        public double Rating { get; set; }

        /// <summary>
        /// Gets or Sets Ranking
        /// </summary>
        [JsonPropertyName("ranking")]
        public int Ranking { get; set; }

        /// <summary>
        /// Gets or Sets Offense
        /// </summary>
        [JsonPropertyName("offense")]
        public TeamSPOffense Offense { get; set; }

        /// <summary>
        /// Gets or Sets Defense
        /// </summary>
        [JsonPropertyName("defense")]
        public TeamSPDefense Defense { get; set; }

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
            sb.Append("class TeamSP {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Ranking: ").Append(Ranking).Append("\n");
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
    /// A Json converter for type <see cref="TeamSP" />
    /// </summary>
    public class TeamSPJsonConverter : JsonConverter<TeamSP>
    {
        /// <summary>
        /// Deserializes json to <see cref="TeamSP" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TeamSP Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> year = default;
            Option<string?> team = default;
            Option<string?> conference = default;
            Option<double?> rating = default;
            Option<int?> ranking = default;
            Option<TeamSPOffense?> offense = default;
            Option<TeamSPDefense?> defense = default;
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
                        case "team":
                            team = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "conference":
                            conference = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "rating":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rating = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "ranking":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                ranking = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "offense":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                offense = new Option<TeamSPOffense?>(JsonSerializer.Deserialize<TeamSPOffense>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "defense":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                defense = new Option<TeamSPDefense?>(JsonSerializer.Deserialize<TeamSPDefense>(ref utf8JsonReader, jsonSerializerOptions)!);
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
                throw new ArgumentException("Property is required for class TeamSP.", nameof(year));

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class TeamSP.", nameof(team));

            if (!conference.IsSet)
                throw new ArgumentException("Property is required for class TeamSP.", nameof(conference));

            if (!rating.IsSet)
                throw new ArgumentException("Property is required for class TeamSP.", nameof(rating));

            if (!ranking.IsSet)
                throw new ArgumentException("Property is required for class TeamSP.", nameof(ranking));

            if (!offense.IsSet)
                throw new ArgumentException("Property is required for class TeamSP.", nameof(offense));

            if (!defense.IsSet)
                throw new ArgumentException("Property is required for class TeamSP.", nameof(defense));

            if (!specialTeams.IsSet)
                throw new ArgumentException("Property is required for class TeamSP.", nameof(specialTeams));

            if (!secondOrderWins.IsSet)
                throw new ArgumentException("Property is required for class TeamSP.", nameof(secondOrderWins));

            if (!sos.IsSet)
                throw new ArgumentException("Property is required for class TeamSP.", nameof(sos));

            if (year.IsSet && year.Value == null)
                throw new ArgumentNullException(nameof(year), "Property is not nullable for class TeamSP.");

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class TeamSP.");

            if (conference.IsSet && conference.Value == null)
                throw new ArgumentNullException(nameof(conference), "Property is not nullable for class TeamSP.");

            if (rating.IsSet && rating.Value == null)
                throw new ArgumentNullException(nameof(rating), "Property is not nullable for class TeamSP.");

            if (ranking.IsSet && ranking.Value == null)
                throw new ArgumentNullException(nameof(ranking), "Property is not nullable for class TeamSP.");

            if (offense.IsSet && offense.Value == null)
                throw new ArgumentNullException(nameof(offense), "Property is not nullable for class TeamSP.");

            if (defense.IsSet && defense.Value == null)
                throw new ArgumentNullException(nameof(defense), "Property is not nullable for class TeamSP.");

            if (specialTeams.IsSet && specialTeams.Value == null)
                throw new ArgumentNullException(nameof(specialTeams), "Property is not nullable for class TeamSP.");

            return new TeamSP(year.Value!.Value!, team.Value!, conference.Value!, rating.Value!.Value!, ranking.Value!.Value!, offense.Value!, defense.Value!, specialTeams.Value!, secondOrderWins.Value!, sos.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="TeamSP" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamSP"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TeamSP teamSP, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, teamSP, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TeamSP" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamSP"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TeamSP teamSP, JsonSerializerOptions jsonSerializerOptions)
        {
            if (teamSP.Team == null)
                throw new ArgumentNullException(nameof(teamSP.Team), "Property is required for class TeamSP.");

            if (teamSP.Conference == null)
                throw new ArgumentNullException(nameof(teamSP.Conference), "Property is required for class TeamSP.");

            if (teamSP.Offense == null)
                throw new ArgumentNullException(nameof(teamSP.Offense), "Property is required for class TeamSP.");

            if (teamSP.Defense == null)
                throw new ArgumentNullException(nameof(teamSP.Defense), "Property is required for class TeamSP.");

            if (teamSP.SpecialTeams == null)
                throw new ArgumentNullException(nameof(teamSP.SpecialTeams), "Property is required for class TeamSP.");

            writer.WriteNumber("year", teamSP.Year);

            writer.WriteString("team", teamSP.Team);

            writer.WriteString("conference", teamSP.Conference);

            writer.WriteNumber("rating", teamSP.Rating);

            writer.WriteNumber("ranking", teamSP.Ranking);

            writer.WritePropertyName("offense");
            JsonSerializer.Serialize(writer, teamSP.Offense, jsonSerializerOptions);
            writer.WritePropertyName("defense");
            JsonSerializer.Serialize(writer, teamSP.Defense, jsonSerializerOptions);
            writer.WritePropertyName("specialTeams");
            JsonSerializer.Serialize(writer, teamSP.SpecialTeams, jsonSerializerOptions);
            if (teamSP.SecondOrderWins != null)
                writer.WriteNumber("secondOrderWins", teamSP.SecondOrderWins.Value);
            else
                writer.WriteNull("secondOrderWins");

            if (teamSP.Sos != null)
                writer.WriteNumber("sos", teamSP.Sos.Value);
            else
                writer.WriteNull("sos");
        }
    }
}

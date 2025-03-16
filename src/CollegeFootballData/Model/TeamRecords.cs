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
    /// TeamRecords
    /// </summary>
    public partial class TeamRecords : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRecords" /> class.
        /// </summary>
        /// <param name="year">year</param>
        /// <param name="teamId">teamId</param>
        /// <param name="team">team</param>
        /// <param name="conference">conference</param>
        /// <param name="division">division</param>
        /// <param name="total">total</param>
        /// <param name="conferenceGames">conferenceGames</param>
        /// <param name="homeGames">homeGames</param>
        /// <param name="awayGames">awayGames</param>
        /// <param name="neutralSiteGames">neutralSiteGames</param>
        /// <param name="regularSeason">regularSeason</param>
        /// <param name="postseason">postseason</param>
        /// <param name="classification">classification</param>
        /// <param name="expectedWins">expectedWins</param>
        [JsonConstructor]
        public TeamRecords(int year, int teamId, string team, string conference, string division, TeamRecord total, TeamRecord conferenceGames, TeamRecord homeGames, TeamRecord awayGames, TeamRecord neutralSiteGames, TeamRecord regularSeason, TeamRecord postseason, DivisionClassification? classification = default, double? expectedWins = default)
        {
            Year = year;
            TeamId = teamId;
            Team = team;
            Conference = conference;
            Division = division;
            Total = total;
            ConferenceGames = conferenceGames;
            HomeGames = homeGames;
            AwayGames = awayGames;
            NeutralSiteGames = neutralSiteGames;
            RegularSeason = regularSeason;
            Postseason = postseason;
            Classification = classification;
            ExpectedWins = expectedWins;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Classification
        /// </summary>
        [JsonPropertyName("classification")]
        public DivisionClassification? Classification { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [JsonPropertyName("year")]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [JsonPropertyName("teamId")]
        public int TeamId { get; set; }

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
        /// Gets or Sets Division
        /// </summary>
        [JsonPropertyName("division")]
        public string Division { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [JsonPropertyName("total")]
        public TeamRecord Total { get; set; }

        /// <summary>
        /// Gets or Sets ConferenceGames
        /// </summary>
        [JsonPropertyName("conferenceGames")]
        public TeamRecord ConferenceGames { get; set; }

        /// <summary>
        /// Gets or Sets HomeGames
        /// </summary>
        [JsonPropertyName("homeGames")]
        public TeamRecord HomeGames { get; set; }

        /// <summary>
        /// Gets or Sets AwayGames
        /// </summary>
        [JsonPropertyName("awayGames")]
        public TeamRecord AwayGames { get; set; }

        /// <summary>
        /// Gets or Sets NeutralSiteGames
        /// </summary>
        [JsonPropertyName("neutralSiteGames")]
        public TeamRecord NeutralSiteGames { get; set; }

        /// <summary>
        /// Gets or Sets RegularSeason
        /// </summary>
        [JsonPropertyName("regularSeason")]
        public TeamRecord RegularSeason { get; set; }

        /// <summary>
        /// Gets or Sets Postseason
        /// </summary>
        [JsonPropertyName("postseason")]
        public TeamRecord Postseason { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedWins
        /// </summary>
        [JsonPropertyName("expectedWins")]
        public double? ExpectedWins { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamRecords {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  ConferenceGames: ").Append(ConferenceGames).Append("\n");
            sb.Append("  HomeGames: ").Append(HomeGames).Append("\n");
            sb.Append("  AwayGames: ").Append(AwayGames).Append("\n");
            sb.Append("  NeutralSiteGames: ").Append(NeutralSiteGames).Append("\n");
            sb.Append("  RegularSeason: ").Append(RegularSeason).Append("\n");
            sb.Append("  Postseason: ").Append(Postseason).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  ExpectedWins: ").Append(ExpectedWins).Append("\n");
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
    /// A Json converter for type <see cref="TeamRecords" />
    /// </summary>
    public class TeamRecordsJsonConverter : JsonConverter<TeamRecords>
    {
        /// <summary>
        /// Deserializes json to <see cref="TeamRecords" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TeamRecords Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> year = default;
            Option<int?> teamId = default;
            Option<string?> team = default;
            Option<string?> conference = default;
            Option<string?> division = default;
            Option<TeamRecord?> total = default;
            Option<TeamRecord?> conferenceGames = default;
            Option<TeamRecord?> homeGames = default;
            Option<TeamRecord?> awayGames = default;
            Option<TeamRecord?> neutralSiteGames = default;
            Option<TeamRecord?> regularSeason = default;
            Option<TeamRecord?> postseason = default;
            Option<DivisionClassification?> classification = default;
            Option<double?> expectedWins = default;

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
                        case "teamId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                teamId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "team":
                            team = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "conference":
                            conference = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "division":
                            division = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "total":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                total = new Option<TeamRecord?>(JsonSerializer.Deserialize<TeamRecord>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "conferenceGames":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                conferenceGames = new Option<TeamRecord?>(JsonSerializer.Deserialize<TeamRecord>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "homeGames":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                homeGames = new Option<TeamRecord?>(JsonSerializer.Deserialize<TeamRecord>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "awayGames":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                awayGames = new Option<TeamRecord?>(JsonSerializer.Deserialize<TeamRecord>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "neutralSiteGames":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                neutralSiteGames = new Option<TeamRecord?>(JsonSerializer.Deserialize<TeamRecord>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "regularSeason":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                regularSeason = new Option<TeamRecord?>(JsonSerializer.Deserialize<TeamRecord>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "postseason":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                postseason = new Option<TeamRecord?>(JsonSerializer.Deserialize<TeamRecord>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "classification":
                            string? classificationRawValue = utf8JsonReader.GetString();
                            if (classificationRawValue != null)
                                classification = new Option<DivisionClassification?>(DivisionClassificationValueConverter.FromStringOrDefault(classificationRawValue));
                            break;
                        case "expectedWins":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                expectedWins = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!year.IsSet)
                throw new ArgumentException("Property is required for class TeamRecords.", nameof(year));

            if (!teamId.IsSet)
                throw new ArgumentException("Property is required for class TeamRecords.", nameof(teamId));

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class TeamRecords.", nameof(team));

            if (!conference.IsSet)
                throw new ArgumentException("Property is required for class TeamRecords.", nameof(conference));

            if (!division.IsSet)
                throw new ArgumentException("Property is required for class TeamRecords.", nameof(division));

            if (!total.IsSet)
                throw new ArgumentException("Property is required for class TeamRecords.", nameof(total));

            if (!conferenceGames.IsSet)
                throw new ArgumentException("Property is required for class TeamRecords.", nameof(conferenceGames));

            if (!homeGames.IsSet)
                throw new ArgumentException("Property is required for class TeamRecords.", nameof(homeGames));

            if (!awayGames.IsSet)
                throw new ArgumentException("Property is required for class TeamRecords.", nameof(awayGames));

            if (!neutralSiteGames.IsSet)
                throw new ArgumentException("Property is required for class TeamRecords.", nameof(neutralSiteGames));

            if (!regularSeason.IsSet)
                throw new ArgumentException("Property is required for class TeamRecords.", nameof(regularSeason));

            if (!postseason.IsSet)
                throw new ArgumentException("Property is required for class TeamRecords.", nameof(postseason));

            if (!classification.IsSet)
                throw new ArgumentException("Property is required for class TeamRecords.", nameof(classification));

            if (!expectedWins.IsSet)
                throw new ArgumentException("Property is required for class TeamRecords.", nameof(expectedWins));

            if (year.IsSet && year.Value == null)
                throw new ArgumentNullException(nameof(year), "Property is not nullable for class TeamRecords.");

            if (teamId.IsSet && teamId.Value == null)
                throw new ArgumentNullException(nameof(teamId), "Property is not nullable for class TeamRecords.");

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class TeamRecords.");

            if (conference.IsSet && conference.Value == null)
                throw new ArgumentNullException(nameof(conference), "Property is not nullable for class TeamRecords.");

            if (division.IsSet && division.Value == null)
                throw new ArgumentNullException(nameof(division), "Property is not nullable for class TeamRecords.");

            if (total.IsSet && total.Value == null)
                throw new ArgumentNullException(nameof(total), "Property is not nullable for class TeamRecords.");

            if (conferenceGames.IsSet && conferenceGames.Value == null)
                throw new ArgumentNullException(nameof(conferenceGames), "Property is not nullable for class TeamRecords.");

            if (homeGames.IsSet && homeGames.Value == null)
                throw new ArgumentNullException(nameof(homeGames), "Property is not nullable for class TeamRecords.");

            if (awayGames.IsSet && awayGames.Value == null)
                throw new ArgumentNullException(nameof(awayGames), "Property is not nullable for class TeamRecords.");

            if (neutralSiteGames.IsSet && neutralSiteGames.Value == null)
                throw new ArgumentNullException(nameof(neutralSiteGames), "Property is not nullable for class TeamRecords.");

            if (regularSeason.IsSet && regularSeason.Value == null)
                throw new ArgumentNullException(nameof(regularSeason), "Property is not nullable for class TeamRecords.");

            if (postseason.IsSet && postseason.Value == null)
                throw new ArgumentNullException(nameof(postseason), "Property is not nullable for class TeamRecords.");

            return new TeamRecords(year.Value!.Value!, teamId.Value!.Value!, team.Value!, conference.Value!, division.Value!, total.Value!, conferenceGames.Value!, homeGames.Value!, awayGames.Value!, neutralSiteGames.Value!, regularSeason.Value!, postseason.Value!, classification.Value!, expectedWins.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="TeamRecords" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamRecords"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TeamRecords teamRecords, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, teamRecords, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TeamRecords" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamRecords"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TeamRecords teamRecords, JsonSerializerOptions jsonSerializerOptions)
        {
            if (teamRecords.Team == null)
                throw new ArgumentNullException(nameof(teamRecords.Team), "Property is required for class TeamRecords.");

            if (teamRecords.Conference == null)
                throw new ArgumentNullException(nameof(teamRecords.Conference), "Property is required for class TeamRecords.");

            if (teamRecords.Division == null)
                throw new ArgumentNullException(nameof(teamRecords.Division), "Property is required for class TeamRecords.");

            if (teamRecords.Total == null)
                throw new ArgumentNullException(nameof(teamRecords.Total), "Property is required for class TeamRecords.");

            if (teamRecords.ConferenceGames == null)
                throw new ArgumentNullException(nameof(teamRecords.ConferenceGames), "Property is required for class TeamRecords.");

            if (teamRecords.HomeGames == null)
                throw new ArgumentNullException(nameof(teamRecords.HomeGames), "Property is required for class TeamRecords.");

            if (teamRecords.AwayGames == null)
                throw new ArgumentNullException(nameof(teamRecords.AwayGames), "Property is required for class TeamRecords.");

            if (teamRecords.NeutralSiteGames == null)
                throw new ArgumentNullException(nameof(teamRecords.NeutralSiteGames), "Property is required for class TeamRecords.");

            if (teamRecords.RegularSeason == null)
                throw new ArgumentNullException(nameof(teamRecords.RegularSeason), "Property is required for class TeamRecords.");

            if (teamRecords.Postseason == null)
                throw new ArgumentNullException(nameof(teamRecords.Postseason), "Property is required for class TeamRecords.");

            writer.WriteNumber("year", teamRecords.Year);

            writer.WriteNumber("teamId", teamRecords.TeamId);

            writer.WriteString("team", teamRecords.Team);

            writer.WriteString("conference", teamRecords.Conference);

            writer.WriteString("division", teamRecords.Division);

            writer.WritePropertyName("total");
            JsonSerializer.Serialize(writer, teamRecords.Total, jsonSerializerOptions);
            writer.WritePropertyName("conferenceGames");
            JsonSerializer.Serialize(writer, teamRecords.ConferenceGames, jsonSerializerOptions);
            writer.WritePropertyName("homeGames");
            JsonSerializer.Serialize(writer, teamRecords.HomeGames, jsonSerializerOptions);
            writer.WritePropertyName("awayGames");
            JsonSerializer.Serialize(writer, teamRecords.AwayGames, jsonSerializerOptions);
            writer.WritePropertyName("neutralSiteGames");
            JsonSerializer.Serialize(writer, teamRecords.NeutralSiteGames, jsonSerializerOptions);
            writer.WritePropertyName("regularSeason");
            JsonSerializer.Serialize(writer, teamRecords.RegularSeason, jsonSerializerOptions);
            writer.WritePropertyName("postseason");
            JsonSerializer.Serialize(writer, teamRecords.Postseason, jsonSerializerOptions);
            if (teamRecords.Classification == null)
                writer.WriteNull("classification");
            else
            {
                var classificationRawValue = DivisionClassificationValueConverter.ToJsonValue(teamRecords.Classification.Value);
                if (classificationRawValue != null)
                    writer.WriteString("classification", classificationRawValue);
                else
                    writer.WriteNull("classification");
            }

            if (teamRecords.ExpectedWins != null)
                writer.WriteNumber("expectedWins", teamRecords.ExpectedWins.Value);
            else
                writer.WriteNull("expectedWins");
        }
    }
}

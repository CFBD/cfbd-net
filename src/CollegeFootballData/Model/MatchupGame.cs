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
    /// MatchupGame
    /// </summary>
    public partial class MatchupGame : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchupGame" /> class.
        /// </summary>
        /// <param name="season">season</param>
        /// <param name="week">week</param>
        /// <param name="seasonType">seasonType</param>
        /// <param name="date">date</param>
        /// <param name="neutralSite">neutralSite</param>
        /// <param name="homeTeam">homeTeam</param>
        /// <param name="awayTeam">awayTeam</param>
        /// <param name="venue">venue</param>
        /// <param name="homeScore">homeScore</param>
        /// <param name="awayScore">awayScore</param>
        /// <param name="winner">winner</param>
        [JsonConstructor]
        public MatchupGame(int season, int week, string seasonType, string date, bool neutralSite, string homeTeam, string awayTeam, string? venue = default, int? homeScore = default, int? awayScore = default, string? winner = default)
        {
            Season = season;
            Week = week;
            SeasonType = seasonType;
            Date = date;
            NeutralSite = neutralSite;
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            Venue = venue;
            HomeScore = homeScore;
            AwayScore = awayScore;
            Winner = winner;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [JsonPropertyName("season")]
        public int Season { get; set; }

        /// <summary>
        /// Gets or Sets Week
        /// </summary>
        [JsonPropertyName("week")]
        public int Week { get; set; }

        /// <summary>
        /// Gets or Sets SeasonType
        /// </summary>
        [JsonPropertyName("seasonType")]
        public string SeasonType { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// Gets or Sets NeutralSite
        /// </summary>
        [JsonPropertyName("neutralSite")]
        public bool NeutralSite { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeam
        /// </summary>
        [JsonPropertyName("homeTeam")]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeam
        /// </summary>
        [JsonPropertyName("awayTeam")]
        public string AwayTeam { get; set; }

        /// <summary>
        /// Gets or Sets Venue
        /// </summary>
        [JsonPropertyName("venue")]
        public string? Venue { get; set; }

        /// <summary>
        /// Gets or Sets HomeScore
        /// </summary>
        [JsonPropertyName("homeScore")]
        public int? HomeScore { get; set; }

        /// <summary>
        /// Gets or Sets AwayScore
        /// </summary>
        [JsonPropertyName("awayScore")]
        public int? AwayScore { get; set; }

        /// <summary>
        /// Gets or Sets Winner
        /// </summary>
        [JsonPropertyName("winner")]
        public string? Winner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MatchupGame {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  SeasonType: ").Append(SeasonType).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  NeutralSite: ").Append(NeutralSite).Append("\n");
            sb.Append("  HomeTeam: ").Append(HomeTeam).Append("\n");
            sb.Append("  AwayTeam: ").Append(AwayTeam).Append("\n");
            sb.Append("  Venue: ").Append(Venue).Append("\n");
            sb.Append("  HomeScore: ").Append(HomeScore).Append("\n");
            sb.Append("  AwayScore: ").Append(AwayScore).Append("\n");
            sb.Append("  Winner: ").Append(Winner).Append("\n");
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
    /// A Json converter for type <see cref="MatchupGame" />
    /// </summary>
    public class MatchupGameJsonConverter : JsonConverter<MatchupGame>
    {
        /// <summary>
        /// Deserializes json to <see cref="MatchupGame" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override MatchupGame Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> season = default;
            Option<int?> week = default;
            Option<string?> seasonType = default;
            Option<string?> date = default;
            Option<bool?> neutralSite = default;
            Option<string?> homeTeam = default;
            Option<string?> awayTeam = default;
            Option<string?> venue = default;
            Option<int?> homeScore = default;
            Option<int?> awayScore = default;
            Option<string?> winner = default;

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
                        case "week":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                week = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "seasonType":
                            seasonType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "date":
                            date = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "neutralSite":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                neutralSite = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "homeTeam":
                            homeTeam = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "awayTeam":
                            awayTeam = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "venue":
                            venue = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "homeScore":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                homeScore = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "awayScore":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                awayScore = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "winner":
                            winner = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!season.IsSet)
                throw new ArgumentException("Property is required for class MatchupGame.", nameof(season));

            if (!week.IsSet)
                throw new ArgumentException("Property is required for class MatchupGame.", nameof(week));

            if (!seasonType.IsSet)
                throw new ArgumentException("Property is required for class MatchupGame.", nameof(seasonType));

            if (!date.IsSet)
                throw new ArgumentException("Property is required for class MatchupGame.", nameof(date));

            if (!neutralSite.IsSet)
                throw new ArgumentException("Property is required for class MatchupGame.", nameof(neutralSite));

            if (!homeTeam.IsSet)
                throw new ArgumentException("Property is required for class MatchupGame.", nameof(homeTeam));

            if (!awayTeam.IsSet)
                throw new ArgumentException("Property is required for class MatchupGame.", nameof(awayTeam));

            if (!venue.IsSet)
                throw new ArgumentException("Property is required for class MatchupGame.", nameof(venue));

            if (!homeScore.IsSet)
                throw new ArgumentException("Property is required for class MatchupGame.", nameof(homeScore));

            if (!awayScore.IsSet)
                throw new ArgumentException("Property is required for class MatchupGame.", nameof(awayScore));

            if (!winner.IsSet)
                throw new ArgumentException("Property is required for class MatchupGame.", nameof(winner));

            if (season.IsSet && season.Value == null)
                throw new ArgumentNullException(nameof(season), "Property is not nullable for class MatchupGame.");

            if (week.IsSet && week.Value == null)
                throw new ArgumentNullException(nameof(week), "Property is not nullable for class MatchupGame.");

            if (seasonType.IsSet && seasonType.Value == null)
                throw new ArgumentNullException(nameof(seasonType), "Property is not nullable for class MatchupGame.");

            if (date.IsSet && date.Value == null)
                throw new ArgumentNullException(nameof(date), "Property is not nullable for class MatchupGame.");

            if (neutralSite.IsSet && neutralSite.Value == null)
                throw new ArgumentNullException(nameof(neutralSite), "Property is not nullable for class MatchupGame.");

            if (homeTeam.IsSet && homeTeam.Value == null)
                throw new ArgumentNullException(nameof(homeTeam), "Property is not nullable for class MatchupGame.");

            if (awayTeam.IsSet && awayTeam.Value == null)
                throw new ArgumentNullException(nameof(awayTeam), "Property is not nullable for class MatchupGame.");

            return new MatchupGame(season.Value!.Value!, week.Value!.Value!, seasonType.Value!, date.Value!, neutralSite.Value!.Value!, homeTeam.Value!, awayTeam.Value!, venue.Value!, homeScore.Value!, awayScore.Value!, winner.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="MatchupGame" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="matchupGame"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, MatchupGame matchupGame, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, matchupGame, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="MatchupGame" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="matchupGame"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, MatchupGame matchupGame, JsonSerializerOptions jsonSerializerOptions)
        {
            if (matchupGame.SeasonType == null)
                throw new ArgumentNullException(nameof(matchupGame.SeasonType), "Property is required for class MatchupGame.");

            if (matchupGame.Date == null)
                throw new ArgumentNullException(nameof(matchupGame.Date), "Property is required for class MatchupGame.");

            if (matchupGame.HomeTeam == null)
                throw new ArgumentNullException(nameof(matchupGame.HomeTeam), "Property is required for class MatchupGame.");

            if (matchupGame.AwayTeam == null)
                throw new ArgumentNullException(nameof(matchupGame.AwayTeam), "Property is required for class MatchupGame.");

            writer.WriteNumber("season", matchupGame.Season);

            writer.WriteNumber("week", matchupGame.Week);

            writer.WriteString("seasonType", matchupGame.SeasonType);

            writer.WriteString("date", matchupGame.Date);

            writer.WriteBoolean("neutralSite", matchupGame.NeutralSite);

            writer.WriteString("homeTeam", matchupGame.HomeTeam);

            writer.WriteString("awayTeam", matchupGame.AwayTeam);

            if (matchupGame.Venue != null)
                writer.WriteString("venue", matchupGame.Venue);
            else
                writer.WriteNull("venue");

            if (matchupGame.HomeScore != null)
                writer.WriteNumber("homeScore", matchupGame.HomeScore.Value);
            else
                writer.WriteNull("homeScore");

            if (matchupGame.AwayScore != null)
                writer.WriteNumber("awayScore", matchupGame.AwayScore.Value);
            else
                writer.WriteNull("awayScore");

            if (matchupGame.Winner != null)
                writer.WriteString("winner", matchupGame.Winner);
            else
                writer.WriteNull("winner");
        }
    }
}

// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.7.0
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
    /// GameTeamStatsTeam
    /// </summary>
    public partial class GameTeamStatsTeam : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameTeamStatsTeam" /> class.
        /// </summary>
        /// <param name="teamId">teamId</param>
        /// <param name="team">team</param>
        /// <param name="homeAway">homeAway</param>
        /// <param name="stats">stats</param>
        /// <param name="conference">conference</param>
        /// <param name="points">points</param>
        [JsonConstructor]
        public GameTeamStatsTeam(int teamId, string team, HomeAwayEnum homeAway, List<GameTeamStatsTeamStat> stats, string? conference = default, int? points = default)
        {
            TeamId = teamId;
            Team = team;
            HomeAway = homeAway;
            Stats = stats;
            Conference = conference;
            Points = points;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines HomeAway
        /// </summary>
        public enum HomeAwayEnum
        {
            /// <summary>
            /// Enum Home for value: home
            /// </summary>
            Home = 1,

            /// <summary>
            /// Enum Away for value: away
            /// </summary>
            Away = 2
        }

        /// <summary>
        /// Returns a <see cref="HomeAwayEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static HomeAwayEnum HomeAwayEnumFromString(string value)
        {
            if (value.Equals("home"))
                return HomeAwayEnum.Home;

            if (value.Equals("away"))
                return HomeAwayEnum.Away;

            throw new NotImplementedException($"Could not convert value to type HomeAwayEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="HomeAwayEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static HomeAwayEnum? HomeAwayEnumFromStringOrDefault(string value)
        {
            if (value.Equals("home"))
                return HomeAwayEnum.Home;

            if (value.Equals("away"))
                return HomeAwayEnum.Away;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="HomeAwayEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string HomeAwayEnumToJsonValue(HomeAwayEnum value)
        {
            if (value == HomeAwayEnum.Home)
                return "home";

            if (value == HomeAwayEnum.Away)
                return "away";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets HomeAway
        /// </summary>
        [JsonPropertyName("homeAway")]
        public HomeAwayEnum HomeAway { get; set; }

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
        /// Gets or Sets Stats
        /// </summary>
        [JsonPropertyName("stats")]
        public List<GameTeamStatsTeamStat> Stats { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [JsonPropertyName("conference")]
        public string? Conference { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [JsonPropertyName("points")]
        public int? Points { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GameTeamStatsTeam {\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  HomeAway: ").Append(HomeAway).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
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
    /// A Json converter for type <see cref="GameTeamStatsTeam" />
    /// </summary>
    public class GameTeamStatsTeamJsonConverter : JsonConverter<GameTeamStatsTeam>
    {
        /// <summary>
        /// Deserializes json to <see cref="GameTeamStatsTeam" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GameTeamStatsTeam Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> teamId = default;
            Option<string?> team = default;
            Option<GameTeamStatsTeam.HomeAwayEnum?> homeAway = default;
            Option<List<GameTeamStatsTeamStat>?> stats = default;
            Option<string?> conference = default;
            Option<int?> points = default;

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
                        case "teamId":
                            teamId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "team":
                            team = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "homeAway":
                            string? homeAwayRawValue = utf8JsonReader.GetString();
                            if (homeAwayRawValue != null)
                                homeAway = new Option<GameTeamStatsTeam.HomeAwayEnum?>(GameTeamStatsTeam.HomeAwayEnumFromStringOrDefault(homeAwayRawValue));
                            break;
                        case "stats":
                            stats = new Option<List<GameTeamStatsTeamStat>?>(JsonSerializer.Deserialize<List<GameTeamStatsTeamStat>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "conference":
                            conference = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "points":
                            points = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!teamId.IsSet)
                throw new ArgumentException("Property is required for class GameTeamStatsTeam.", nameof(teamId));

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class GameTeamStatsTeam.", nameof(team));

            if (!homeAway.IsSet)
                throw new ArgumentException("Property is required for class GameTeamStatsTeam.", nameof(homeAway));

            if (!stats.IsSet)
                throw new ArgumentException("Property is required for class GameTeamStatsTeam.", nameof(stats));

            if (!conference.IsSet)
                throw new ArgumentException("Property is required for class GameTeamStatsTeam.", nameof(conference));

            if (!points.IsSet)
                throw new ArgumentException("Property is required for class GameTeamStatsTeam.", nameof(points));

            if (teamId.IsSet && teamId.Value == null)
                throw new ArgumentNullException(nameof(teamId), "Property is not nullable for class GameTeamStatsTeam.");

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class GameTeamStatsTeam.");

            if (homeAway.IsSet && homeAway.Value == null)
                throw new ArgumentNullException(nameof(homeAway), "Property is not nullable for class GameTeamStatsTeam.");

            if (stats.IsSet && stats.Value == null)
                throw new ArgumentNullException(nameof(stats), "Property is not nullable for class GameTeamStatsTeam.");

            return new GameTeamStatsTeam(teamId.Value!.Value!, team.Value!, homeAway.Value!.Value!, stats.Value!, conference.Value!, points.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GameTeamStatsTeam" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gameTeamStatsTeam"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GameTeamStatsTeam gameTeamStatsTeam, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, gameTeamStatsTeam, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GameTeamStatsTeam" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gameTeamStatsTeam"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GameTeamStatsTeam gameTeamStatsTeam, JsonSerializerOptions jsonSerializerOptions)
        {
            if (gameTeamStatsTeam.Team == null)
                throw new ArgumentNullException(nameof(gameTeamStatsTeam.Team), "Property is required for class GameTeamStatsTeam.");

            if (gameTeamStatsTeam.Stats == null)
                throw new ArgumentNullException(nameof(gameTeamStatsTeam.Stats), "Property is required for class GameTeamStatsTeam.");

            writer.WriteNumber("teamId", gameTeamStatsTeam.TeamId);

            writer.WriteString("team", gameTeamStatsTeam.Team);

            var homeAwayRawValue = GameTeamStatsTeam.HomeAwayEnumToJsonValue(gameTeamStatsTeam.HomeAway);
            writer.WriteString("homeAway", homeAwayRawValue);
            writer.WritePropertyName("stats");
            JsonSerializer.Serialize(writer, gameTeamStatsTeam.Stats, jsonSerializerOptions);
            if (gameTeamStatsTeam.Conference != null)
                writer.WriteString("conference", gameTeamStatsTeam.Conference);
            else
                writer.WriteNull("conference");

            if (gameTeamStatsTeam.Points != null)
                writer.WriteNumber("points", gameTeamStatsTeam.Points.Value);
            else
                writer.WriteNull("points");
        }
    }
}

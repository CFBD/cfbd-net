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
    /// GamePlayerStatsTeam
    /// </summary>
    public partial class GamePlayerStatsTeam : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GamePlayerStatsTeam" /> class.
        /// </summary>
        /// <param name="team">team</param>
        /// <param name="homeAway">homeAway</param>
        /// <param name="categories">categories</param>
        /// <param name="conference">conference</param>
        /// <param name="points">points</param>
        [JsonConstructor]
        public GamePlayerStatsTeam(string team, HomeAwayEnum homeAway, List<GamePlayerStatCategories> categories, string? conference = default, int? points = default)
        {
            Team = team;
            HomeAway = homeAway;
            Categories = categories;
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
        /// Gets or Sets Team
        /// </summary>
        [JsonPropertyName("team")]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [JsonPropertyName("categories")]
        public List<GamePlayerStatCategories> Categories { get; set; }

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
            sb.Append("class GamePlayerStatsTeam {\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  HomeAway: ").Append(HomeAway).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
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
    /// A Json converter for type <see cref="GamePlayerStatsTeam" />
    /// </summary>
    public class GamePlayerStatsTeamJsonConverter : JsonConverter<GamePlayerStatsTeam>
    {
        /// <summary>
        /// Deserializes json to <see cref="GamePlayerStatsTeam" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GamePlayerStatsTeam Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> team = default;
            Option<GamePlayerStatsTeam.HomeAwayEnum?> homeAway = default;
            Option<List<GamePlayerStatCategories>?> categories = default;
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
                        case "team":
                            team = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "homeAway":
                            string? homeAwayRawValue = utf8JsonReader.GetString();
                            if (homeAwayRawValue != null)
                                homeAway = new Option<GamePlayerStatsTeam.HomeAwayEnum?>(GamePlayerStatsTeam.HomeAwayEnumFromStringOrDefault(homeAwayRawValue));
                            break;
                        case "categories":
                            categories = new Option<List<GamePlayerStatCategories>?>(JsonSerializer.Deserialize<List<GamePlayerStatCategories>>(ref utf8JsonReader, jsonSerializerOptions)!);
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

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class GamePlayerStatsTeam.", nameof(team));

            if (!homeAway.IsSet)
                throw new ArgumentException("Property is required for class GamePlayerStatsTeam.", nameof(homeAway));

            if (!categories.IsSet)
                throw new ArgumentException("Property is required for class GamePlayerStatsTeam.", nameof(categories));

            if (!conference.IsSet)
                throw new ArgumentException("Property is required for class GamePlayerStatsTeam.", nameof(conference));

            if (!points.IsSet)
                throw new ArgumentException("Property is required for class GamePlayerStatsTeam.", nameof(points));

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class GamePlayerStatsTeam.");

            if (homeAway.IsSet && homeAway.Value == null)
                throw new ArgumentNullException(nameof(homeAway), "Property is not nullable for class GamePlayerStatsTeam.");

            if (categories.IsSet && categories.Value == null)
                throw new ArgumentNullException(nameof(categories), "Property is not nullable for class GamePlayerStatsTeam.");

            return new GamePlayerStatsTeam(team.Value!, homeAway.Value!.Value!, categories.Value!, conference.Value!, points.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GamePlayerStatsTeam" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gamePlayerStatsTeam"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GamePlayerStatsTeam gamePlayerStatsTeam, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, gamePlayerStatsTeam, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GamePlayerStatsTeam" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gamePlayerStatsTeam"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GamePlayerStatsTeam gamePlayerStatsTeam, JsonSerializerOptions jsonSerializerOptions)
        {
            if (gamePlayerStatsTeam.Team == null)
                throw new ArgumentNullException(nameof(gamePlayerStatsTeam.Team), "Property is required for class GamePlayerStatsTeam.");

            if (gamePlayerStatsTeam.Categories == null)
                throw new ArgumentNullException(nameof(gamePlayerStatsTeam.Categories), "Property is required for class GamePlayerStatsTeam.");

            writer.WriteString("team", gamePlayerStatsTeam.Team);

            var homeAwayRawValue = GamePlayerStatsTeam.HomeAwayEnumToJsonValue(gamePlayerStatsTeam.HomeAway);
            writer.WriteString("homeAway", homeAwayRawValue);
            writer.WritePropertyName("categories");
            JsonSerializer.Serialize(writer, gamePlayerStatsTeam.Categories, jsonSerializerOptions);
            if (gamePlayerStatsTeam.Conference != null)
                writer.WriteString("conference", gamePlayerStatsTeam.Conference);
            else
                writer.WriteNull("conference");

            if (gamePlayerStatsTeam.Points != null)
                writer.WriteNumber("points", gamePlayerStatsTeam.Points.Value);
            else
                writer.WriteNull("points");
        }
    }
}

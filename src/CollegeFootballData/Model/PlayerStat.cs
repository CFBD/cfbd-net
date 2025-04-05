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
    /// PlayerStat
    /// </summary>
    public partial class PlayerStat : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerStat" /> class.
        /// </summary>
        /// <param name="season">season</param>
        /// <param name="playerId">playerId</param>
        /// <param name="player">player</param>
        /// <param name="team">team</param>
        /// <param name="conference">conference</param>
        /// <param name="category">category</param>
        /// <param name="statType">statType</param>
        /// <param name="stat">stat</param>
        [JsonConstructor]
        public PlayerStat(int season, string playerId, string player, string team, string conference, string category, string statType, string stat)
        {
            Season = season;
            PlayerId = playerId;
            Player = player;
            Team = team;
            Conference = conference;
            Category = category;
            StatType = statType;
            Stat = stat;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [JsonPropertyName("season")]
        public int Season { get; set; }

        /// <summary>
        /// Gets or Sets PlayerId
        /// </summary>
        [JsonPropertyName("playerId")]
        public string PlayerId { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [JsonPropertyName("player")]
        public string Player { get; set; }

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
        /// Gets or Sets Category
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets StatType
        /// </summary>
        [JsonPropertyName("statType")]
        public string StatType { get; set; }

        /// <summary>
        /// Gets or Sets Stat
        /// </summary>
        [JsonPropertyName("stat")]
        public string Stat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerStat {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  PlayerId: ").Append(PlayerId).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  StatType: ").Append(StatType).Append("\n");
            sb.Append("  Stat: ").Append(Stat).Append("\n");
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
    /// A Json converter for type <see cref="PlayerStat" />
    /// </summary>
    public class PlayerStatJsonConverter : JsonConverter<PlayerStat>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerStat" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerStat Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> season = default;
            Option<string?> playerId = default;
            Option<string?> player = default;
            Option<string?> team = default;
            Option<string?> conference = default;
            Option<string?> category = default;
            Option<string?> statType = default;
            Option<string?> stat = default;

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
                        case "playerId":
                            playerId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "player":
                            player = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "team":
                            team = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "conference":
                            conference = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "category":
                            category = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "statType":
                            statType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "stat":
                            stat = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!season.IsSet)
                throw new ArgumentException("Property is required for class PlayerStat.", nameof(season));

            if (!playerId.IsSet)
                throw new ArgumentException("Property is required for class PlayerStat.", nameof(playerId));

            if (!player.IsSet)
                throw new ArgumentException("Property is required for class PlayerStat.", nameof(player));

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class PlayerStat.", nameof(team));

            if (!conference.IsSet)
                throw new ArgumentException("Property is required for class PlayerStat.", nameof(conference));

            if (!category.IsSet)
                throw new ArgumentException("Property is required for class PlayerStat.", nameof(category));

            if (!statType.IsSet)
                throw new ArgumentException("Property is required for class PlayerStat.", nameof(statType));

            if (!stat.IsSet)
                throw new ArgumentException("Property is required for class PlayerStat.", nameof(stat));

            if (season.IsSet && season.Value == null)
                throw new ArgumentNullException(nameof(season), "Property is not nullable for class PlayerStat.");

            if (playerId.IsSet && playerId.Value == null)
                throw new ArgumentNullException(nameof(playerId), "Property is not nullable for class PlayerStat.");

            if (player.IsSet && player.Value == null)
                throw new ArgumentNullException(nameof(player), "Property is not nullable for class PlayerStat.");

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class PlayerStat.");

            if (conference.IsSet && conference.Value == null)
                throw new ArgumentNullException(nameof(conference), "Property is not nullable for class PlayerStat.");

            if (category.IsSet && category.Value == null)
                throw new ArgumentNullException(nameof(category), "Property is not nullable for class PlayerStat.");

            if (statType.IsSet && statType.Value == null)
                throw new ArgumentNullException(nameof(statType), "Property is not nullable for class PlayerStat.");

            if (stat.IsSet && stat.Value == null)
                throw new ArgumentNullException(nameof(stat), "Property is not nullable for class PlayerStat.");

            return new PlayerStat(season.Value!.Value!, playerId.Value!, player.Value!, team.Value!, conference.Value!, category.Value!, statType.Value!, stat.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerStat" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerStat"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerStat playerStat, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerStat, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerStat" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerStat"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerStat playerStat, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerStat.PlayerId == null)
                throw new ArgumentNullException(nameof(playerStat.PlayerId), "Property is required for class PlayerStat.");

            if (playerStat.Player == null)
                throw new ArgumentNullException(nameof(playerStat.Player), "Property is required for class PlayerStat.");

            if (playerStat.Team == null)
                throw new ArgumentNullException(nameof(playerStat.Team), "Property is required for class PlayerStat.");

            if (playerStat.Conference == null)
                throw new ArgumentNullException(nameof(playerStat.Conference), "Property is required for class PlayerStat.");

            if (playerStat.Category == null)
                throw new ArgumentNullException(nameof(playerStat.Category), "Property is required for class PlayerStat.");

            if (playerStat.StatType == null)
                throw new ArgumentNullException(nameof(playerStat.StatType), "Property is required for class PlayerStat.");

            if (playerStat.Stat == null)
                throw new ArgumentNullException(nameof(playerStat.Stat), "Property is required for class PlayerStat.");

            writer.WriteNumber("season", playerStat.Season);

            writer.WriteString("playerId", playerStat.PlayerId);

            writer.WriteString("player", playerStat.Player);

            writer.WriteString("team", playerStat.Team);

            writer.WriteString("conference", playerStat.Conference);

            writer.WriteString("category", playerStat.Category);

            writer.WriteString("statType", playerStat.StatType);

            writer.WriteString("stat", playerStat.Stat);
        }
    }
}

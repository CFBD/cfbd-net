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
    /// AdvancedGameStat
    /// </summary>
    public partial class AdvancedGameStat : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedGameStat" /> class.
        /// </summary>
        /// <param name="gameId">gameId</param>
        /// <param name="season">season</param>
        /// <param name="week">week</param>
        /// <param name="team">team</param>
        /// <param name="opponent">opponent</param>
        /// <param name="offense">offense</param>
        /// <param name="defense">defense</param>
        [JsonConstructor]
        public AdvancedGameStat(int gameId, int season, int week, string team, string opponent, AdvancedGameStatOffense offense, AdvancedGameStatDefense defense)
        {
            GameId = gameId;
            Season = season;
            Week = week;
            Team = team;
            Opponent = opponent;
            Offense = offense;
            Defense = defense;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [JsonPropertyName("gameId")]
        public int GameId { get; set; }

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
        /// Gets or Sets Team
        /// </summary>
        [JsonPropertyName("team")]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Opponent
        /// </summary>
        [JsonPropertyName("opponent")]
        public string Opponent { get; set; }

        /// <summary>
        /// Gets or Sets Offense
        /// </summary>
        [JsonPropertyName("offense")]
        public AdvancedGameStatOffense Offense { get; set; }

        /// <summary>
        /// Gets or Sets Defense
        /// </summary>
        [JsonPropertyName("defense")]
        public AdvancedGameStatDefense Defense { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdvancedGameStat {\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Opponent: ").Append(Opponent).Append("\n");
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
    /// A Json converter for type <see cref="AdvancedGameStat" />
    /// </summary>
    public class AdvancedGameStatJsonConverter : JsonConverter<AdvancedGameStat>
    {
        /// <summary>
        /// Deserializes json to <see cref="AdvancedGameStat" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AdvancedGameStat Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> gameId = default;
            Option<int?> season = default;
            Option<int?> week = default;
            Option<string?> team = default;
            Option<string?> opponent = default;
            Option<AdvancedGameStatOffense?> offense = default;
            Option<AdvancedGameStatDefense?> defense = default;

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
                        case "gameId":
                            gameId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "season":
                            season = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "week":
                            week = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "team":
                            team = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "opponent":
                            opponent = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "offense":
                            offense = new Option<AdvancedGameStatOffense?>(JsonSerializer.Deserialize<AdvancedGameStatOffense>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "defense":
                            defense = new Option<AdvancedGameStatDefense?>(JsonSerializer.Deserialize<AdvancedGameStatDefense>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!gameId.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStat.", nameof(gameId));

            if (!season.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStat.", nameof(season));

            if (!week.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStat.", nameof(week));

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStat.", nameof(team));

            if (!opponent.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStat.", nameof(opponent));

            if (!offense.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStat.", nameof(offense));

            if (!defense.IsSet)
                throw new ArgumentException("Property is required for class AdvancedGameStat.", nameof(defense));

            if (gameId.IsSet && gameId.Value == null)
                throw new ArgumentNullException(nameof(gameId), "Property is not nullable for class AdvancedGameStat.");

            if (season.IsSet && season.Value == null)
                throw new ArgumentNullException(nameof(season), "Property is not nullable for class AdvancedGameStat.");

            if (week.IsSet && week.Value == null)
                throw new ArgumentNullException(nameof(week), "Property is not nullable for class AdvancedGameStat.");

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class AdvancedGameStat.");

            if (opponent.IsSet && opponent.Value == null)
                throw new ArgumentNullException(nameof(opponent), "Property is not nullable for class AdvancedGameStat.");

            if (offense.IsSet && offense.Value == null)
                throw new ArgumentNullException(nameof(offense), "Property is not nullable for class AdvancedGameStat.");

            if (defense.IsSet && defense.Value == null)
                throw new ArgumentNullException(nameof(defense), "Property is not nullable for class AdvancedGameStat.");

            return new AdvancedGameStat(gameId.Value!.Value!, season.Value!.Value!, week.Value!.Value!, team.Value!, opponent.Value!, offense.Value!, defense.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AdvancedGameStat" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedGameStat"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AdvancedGameStat advancedGameStat, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, advancedGameStat, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AdvancedGameStat" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedGameStat"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AdvancedGameStat advancedGameStat, JsonSerializerOptions jsonSerializerOptions)
        {
            if (advancedGameStat.Team == null)
                throw new ArgumentNullException(nameof(advancedGameStat.Team), "Property is required for class AdvancedGameStat.");

            if (advancedGameStat.Opponent == null)
                throw new ArgumentNullException(nameof(advancedGameStat.Opponent), "Property is required for class AdvancedGameStat.");

            if (advancedGameStat.Offense == null)
                throw new ArgumentNullException(nameof(advancedGameStat.Offense), "Property is required for class AdvancedGameStat.");

            if (advancedGameStat.Defense == null)
                throw new ArgumentNullException(nameof(advancedGameStat.Defense), "Property is required for class AdvancedGameStat.");

            writer.WriteNumber("gameId", advancedGameStat.GameId);

            writer.WriteNumber("season", advancedGameStat.Season);

            writer.WriteNumber("week", advancedGameStat.Week);

            writer.WriteString("team", advancedGameStat.Team);

            writer.WriteString("opponent", advancedGameStat.Opponent);

            writer.WritePropertyName("offense");
            JsonSerializer.Serialize(writer, advancedGameStat.Offense, jsonSerializerOptions);
            writer.WritePropertyName("defense");
            JsonSerializer.Serialize(writer, advancedGameStat.Defense, jsonSerializerOptions);
        }
    }
}

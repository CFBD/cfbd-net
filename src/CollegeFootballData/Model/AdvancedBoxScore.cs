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
    /// AdvancedBoxScore
    /// </summary>
    public partial class AdvancedBoxScore : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedBoxScore" /> class.
        /// </summary>
        /// <param name="gameInfo">gameInfo</param>
        /// <param name="teams">teams</param>
        /// <param name="players">players</param>
        [JsonConstructor]
        public AdvancedBoxScore(AdvancedBoxScoreGameInfo gameInfo, AdvancedBoxScoreTeams teams, AdvancedBoxScorePlayers players)
        {
            GameInfo = gameInfo;
            Teams = teams;
            Players = players;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets GameInfo
        /// </summary>
        [JsonPropertyName("gameInfo")]
        public AdvancedBoxScoreGameInfo GameInfo { get; set; }

        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [JsonPropertyName("teams")]
        public AdvancedBoxScoreTeams Teams { get; set; }

        /// <summary>
        /// Gets or Sets Players
        /// </summary>
        [JsonPropertyName("players")]
        public AdvancedBoxScorePlayers Players { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdvancedBoxScore {\n");
            sb.Append("  GameInfo: ").Append(GameInfo).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
            sb.Append("  Players: ").Append(Players).Append("\n");
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
    /// A Json converter for type <see cref="AdvancedBoxScore" />
    /// </summary>
    public class AdvancedBoxScoreJsonConverter : JsonConverter<AdvancedBoxScore>
    {
        /// <summary>
        /// Deserializes json to <see cref="AdvancedBoxScore" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AdvancedBoxScore Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<AdvancedBoxScoreGameInfo?> gameInfo = default;
            Option<AdvancedBoxScoreTeams?> teams = default;
            Option<AdvancedBoxScorePlayers?> players = default;

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
                        case "gameInfo":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                gameInfo = new Option<AdvancedBoxScoreGameInfo?>(JsonSerializer.Deserialize<AdvancedBoxScoreGameInfo>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "teams":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                teams = new Option<AdvancedBoxScoreTeams?>(JsonSerializer.Deserialize<AdvancedBoxScoreTeams>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "players":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                players = new Option<AdvancedBoxScorePlayers?>(JsonSerializer.Deserialize<AdvancedBoxScorePlayers>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!gameInfo.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScore.", nameof(gameInfo));

            if (!teams.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScore.", nameof(teams));

            if (!players.IsSet)
                throw new ArgumentException("Property is required for class AdvancedBoxScore.", nameof(players));

            if (gameInfo.IsSet && gameInfo.Value == null)
                throw new ArgumentNullException(nameof(gameInfo), "Property is not nullable for class AdvancedBoxScore.");

            if (teams.IsSet && teams.Value == null)
                throw new ArgumentNullException(nameof(teams), "Property is not nullable for class AdvancedBoxScore.");

            if (players.IsSet && players.Value == null)
                throw new ArgumentNullException(nameof(players), "Property is not nullable for class AdvancedBoxScore.");

            return new AdvancedBoxScore(gameInfo.Value!, teams.Value!, players.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AdvancedBoxScore" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedBoxScore"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AdvancedBoxScore advancedBoxScore, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, advancedBoxScore, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AdvancedBoxScore" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="advancedBoxScore"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AdvancedBoxScore advancedBoxScore, JsonSerializerOptions jsonSerializerOptions)
        {
            if (advancedBoxScore.GameInfo == null)
                throw new ArgumentNullException(nameof(advancedBoxScore.GameInfo), "Property is required for class AdvancedBoxScore.");

            if (advancedBoxScore.Teams == null)
                throw new ArgumentNullException(nameof(advancedBoxScore.Teams), "Property is required for class AdvancedBoxScore.");

            if (advancedBoxScore.Players == null)
                throw new ArgumentNullException(nameof(advancedBoxScore.Players), "Property is required for class AdvancedBoxScore.");

            writer.WritePropertyName("gameInfo");
            JsonSerializer.Serialize(writer, advancedBoxScore.GameInfo, jsonSerializerOptions);
            writer.WritePropertyName("teams");
            JsonSerializer.Serialize(writer, advancedBoxScore.Teams, jsonSerializerOptions);
            writer.WritePropertyName("players");
            JsonSerializer.Serialize(writer, advancedBoxScore.Players, jsonSerializerOptions);
        }
    }
}

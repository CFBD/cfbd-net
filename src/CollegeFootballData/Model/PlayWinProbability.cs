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
    /// PlayWinProbability
    /// </summary>
    public partial class PlayWinProbability : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayWinProbability" /> class.
        /// </summary>
        /// <param name="gameId">gameId</param>
        /// <param name="playId">playId</param>
        /// <param name="playText">playText</param>
        /// <param name="homeId">homeId</param>
        /// <param name="home">home</param>
        /// <param name="awayId">awayId</param>
        /// <param name="away">away</param>
        /// <param name="spread">spread</param>
        /// <param name="homeBall">homeBall</param>
        /// <param name="homeScore">homeScore</param>
        /// <param name="awayScore">awayScore</param>
        /// <param name="yardLine">yardLine</param>
        /// <param name="down">down</param>
        /// <param name="distance">distance</param>
        /// <param name="homeWinProbability">homeWinProbability</param>
        /// <param name="playNumber">playNumber</param>
        [JsonConstructor]
        public PlayWinProbability(int gameId, string playId, string playText, int homeId, string home, int awayId, string away, double spread, bool homeBall, int homeScore, int awayScore, int yardLine, int down, int distance, double homeWinProbability, int playNumber)
        {
            GameId = gameId;
            PlayId = playId;
            PlayText = playText;
            HomeId = homeId;
            Home = home;
            AwayId = awayId;
            Away = away;
            Spread = spread;
            HomeBall = homeBall;
            HomeScore = homeScore;
            AwayScore = awayScore;
            YardLine = yardLine;
            Down = down;
            Distance = distance;
            HomeWinProbability = homeWinProbability;
            PlayNumber = playNumber;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [JsonPropertyName("gameId")]
        public int GameId { get; set; }

        /// <summary>
        /// Gets or Sets PlayId
        /// </summary>
        [JsonPropertyName("playId")]
        public string PlayId { get; set; }

        /// <summary>
        /// Gets or Sets PlayText
        /// </summary>
        [JsonPropertyName("playText")]
        public string PlayText { get; set; }

        /// <summary>
        /// Gets or Sets HomeId
        /// </summary>
        [JsonPropertyName("homeId")]
        public int HomeId { get; set; }

        /// <summary>
        /// Gets or Sets Home
        /// </summary>
        [JsonPropertyName("home")]
        public string Home { get; set; }

        /// <summary>
        /// Gets or Sets AwayId
        /// </summary>
        [JsonPropertyName("awayId")]
        public int AwayId { get; set; }

        /// <summary>
        /// Gets or Sets Away
        /// </summary>
        [JsonPropertyName("away")]
        public string Away { get; set; }

        /// <summary>
        /// Gets or Sets Spread
        /// </summary>
        [JsonPropertyName("spread")]
        public double Spread { get; set; }

        /// <summary>
        /// Gets or Sets HomeBall
        /// </summary>
        [JsonPropertyName("homeBall")]
        public bool HomeBall { get; set; }

        /// <summary>
        /// Gets or Sets HomeScore
        /// </summary>
        [JsonPropertyName("homeScore")]
        public int HomeScore { get; set; }

        /// <summary>
        /// Gets or Sets AwayScore
        /// </summary>
        [JsonPropertyName("awayScore")]
        public int AwayScore { get; set; }

        /// <summary>
        /// Gets or Sets YardLine
        /// </summary>
        [JsonPropertyName("yardLine")]
        public int YardLine { get; set; }

        /// <summary>
        /// Gets or Sets Down
        /// </summary>
        [JsonPropertyName("down")]
        public int Down { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [JsonPropertyName("distance")]
        public int Distance { get; set; }

        /// <summary>
        /// Gets or Sets HomeWinProbability
        /// </summary>
        [JsonPropertyName("homeWinProbability")]
        public double HomeWinProbability { get; set; }

        /// <summary>
        /// Gets or Sets PlayNumber
        /// </summary>
        [JsonPropertyName("playNumber")]
        public int PlayNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayWinProbability {\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  PlayId: ").Append(PlayId).Append("\n");
            sb.Append("  PlayText: ").Append(PlayText).Append("\n");
            sb.Append("  HomeId: ").Append(HomeId).Append("\n");
            sb.Append("  Home: ").Append(Home).Append("\n");
            sb.Append("  AwayId: ").Append(AwayId).Append("\n");
            sb.Append("  Away: ").Append(Away).Append("\n");
            sb.Append("  Spread: ").Append(Spread).Append("\n");
            sb.Append("  HomeBall: ").Append(HomeBall).Append("\n");
            sb.Append("  HomeScore: ").Append(HomeScore).Append("\n");
            sb.Append("  AwayScore: ").Append(AwayScore).Append("\n");
            sb.Append("  YardLine: ").Append(YardLine).Append("\n");
            sb.Append("  Down: ").Append(Down).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  HomeWinProbability: ").Append(HomeWinProbability).Append("\n");
            sb.Append("  PlayNumber: ").Append(PlayNumber).Append("\n");
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
    /// A Json converter for type <see cref="PlayWinProbability" />
    /// </summary>
    public class PlayWinProbabilityJsonConverter : JsonConverter<PlayWinProbability>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayWinProbability" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayWinProbability Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> gameId = default;
            Option<string?> playId = default;
            Option<string?> playText = default;
            Option<int?> homeId = default;
            Option<string?> home = default;
            Option<int?> awayId = default;
            Option<string?> away = default;
            Option<double?> spread = default;
            Option<bool?> homeBall = default;
            Option<int?> homeScore = default;
            Option<int?> awayScore = default;
            Option<int?> yardLine = default;
            Option<int?> down = default;
            Option<int?> distance = default;
            Option<double?> homeWinProbability = default;
            Option<int?> playNumber = default;

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
                        case "playId":
                            playId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "playText":
                            playText = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "homeId":
                            homeId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "home":
                            home = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "awayId":
                            awayId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "away":
                            away = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "spread":
                            spread = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "homeBall":
                            homeBall = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "homeScore":
                            homeScore = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "awayScore":
                            awayScore = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "yardLine":
                            yardLine = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "down":
                            down = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "distance":
                            distance = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "homeWinProbability":
                            homeWinProbability = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "playNumber":
                            playNumber = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!gameId.IsSet)
                throw new ArgumentException("Property is required for class PlayWinProbability.", nameof(gameId));

            if (!playId.IsSet)
                throw new ArgumentException("Property is required for class PlayWinProbability.", nameof(playId));

            if (!playText.IsSet)
                throw new ArgumentException("Property is required for class PlayWinProbability.", nameof(playText));

            if (!homeId.IsSet)
                throw new ArgumentException("Property is required for class PlayWinProbability.", nameof(homeId));

            if (!home.IsSet)
                throw new ArgumentException("Property is required for class PlayWinProbability.", nameof(home));

            if (!awayId.IsSet)
                throw new ArgumentException("Property is required for class PlayWinProbability.", nameof(awayId));

            if (!away.IsSet)
                throw new ArgumentException("Property is required for class PlayWinProbability.", nameof(away));

            if (!spread.IsSet)
                throw new ArgumentException("Property is required for class PlayWinProbability.", nameof(spread));

            if (!homeBall.IsSet)
                throw new ArgumentException("Property is required for class PlayWinProbability.", nameof(homeBall));

            if (!homeScore.IsSet)
                throw new ArgumentException("Property is required for class PlayWinProbability.", nameof(homeScore));

            if (!awayScore.IsSet)
                throw new ArgumentException("Property is required for class PlayWinProbability.", nameof(awayScore));

            if (!yardLine.IsSet)
                throw new ArgumentException("Property is required for class PlayWinProbability.", nameof(yardLine));

            if (!down.IsSet)
                throw new ArgumentException("Property is required for class PlayWinProbability.", nameof(down));

            if (!distance.IsSet)
                throw new ArgumentException("Property is required for class PlayWinProbability.", nameof(distance));

            if (!homeWinProbability.IsSet)
                throw new ArgumentException("Property is required for class PlayWinProbability.", nameof(homeWinProbability));

            if (!playNumber.IsSet)
                throw new ArgumentException("Property is required for class PlayWinProbability.", nameof(playNumber));

            if (gameId.IsSet && gameId.Value == null)
                throw new ArgumentNullException(nameof(gameId), "Property is not nullable for class PlayWinProbability.");

            if (playId.IsSet && playId.Value == null)
                throw new ArgumentNullException(nameof(playId), "Property is not nullable for class PlayWinProbability.");

            if (playText.IsSet && playText.Value == null)
                throw new ArgumentNullException(nameof(playText), "Property is not nullable for class PlayWinProbability.");

            if (homeId.IsSet && homeId.Value == null)
                throw new ArgumentNullException(nameof(homeId), "Property is not nullable for class PlayWinProbability.");

            if (home.IsSet && home.Value == null)
                throw new ArgumentNullException(nameof(home), "Property is not nullable for class PlayWinProbability.");

            if (awayId.IsSet && awayId.Value == null)
                throw new ArgumentNullException(nameof(awayId), "Property is not nullable for class PlayWinProbability.");

            if (away.IsSet && away.Value == null)
                throw new ArgumentNullException(nameof(away), "Property is not nullable for class PlayWinProbability.");

            if (spread.IsSet && spread.Value == null)
                throw new ArgumentNullException(nameof(spread), "Property is not nullable for class PlayWinProbability.");

            if (homeBall.IsSet && homeBall.Value == null)
                throw new ArgumentNullException(nameof(homeBall), "Property is not nullable for class PlayWinProbability.");

            if (homeScore.IsSet && homeScore.Value == null)
                throw new ArgumentNullException(nameof(homeScore), "Property is not nullable for class PlayWinProbability.");

            if (awayScore.IsSet && awayScore.Value == null)
                throw new ArgumentNullException(nameof(awayScore), "Property is not nullable for class PlayWinProbability.");

            if (yardLine.IsSet && yardLine.Value == null)
                throw new ArgumentNullException(nameof(yardLine), "Property is not nullable for class PlayWinProbability.");

            if (down.IsSet && down.Value == null)
                throw new ArgumentNullException(nameof(down), "Property is not nullable for class PlayWinProbability.");

            if (distance.IsSet && distance.Value == null)
                throw new ArgumentNullException(nameof(distance), "Property is not nullable for class PlayWinProbability.");

            if (homeWinProbability.IsSet && homeWinProbability.Value == null)
                throw new ArgumentNullException(nameof(homeWinProbability), "Property is not nullable for class PlayWinProbability.");

            if (playNumber.IsSet && playNumber.Value == null)
                throw new ArgumentNullException(nameof(playNumber), "Property is not nullable for class PlayWinProbability.");

            return new PlayWinProbability(gameId.Value!.Value!, playId.Value!, playText.Value!, homeId.Value!.Value!, home.Value!, awayId.Value!.Value!, away.Value!, spread.Value!.Value!, homeBall.Value!.Value!, homeScore.Value!.Value!, awayScore.Value!.Value!, yardLine.Value!.Value!, down.Value!.Value!, distance.Value!.Value!, homeWinProbability.Value!.Value!, playNumber.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="PlayWinProbability" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playWinProbability"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayWinProbability playWinProbability, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playWinProbability, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayWinProbability" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playWinProbability"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayWinProbability playWinProbability, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playWinProbability.PlayId == null)
                throw new ArgumentNullException(nameof(playWinProbability.PlayId), "Property is required for class PlayWinProbability.");

            if (playWinProbability.PlayText == null)
                throw new ArgumentNullException(nameof(playWinProbability.PlayText), "Property is required for class PlayWinProbability.");

            if (playWinProbability.Home == null)
                throw new ArgumentNullException(nameof(playWinProbability.Home), "Property is required for class PlayWinProbability.");

            if (playWinProbability.Away == null)
                throw new ArgumentNullException(nameof(playWinProbability.Away), "Property is required for class PlayWinProbability.");

            writer.WriteNumber("gameId", playWinProbability.GameId);

            writer.WriteString("playId", playWinProbability.PlayId);

            writer.WriteString("playText", playWinProbability.PlayText);

            writer.WriteNumber("homeId", playWinProbability.HomeId);

            writer.WriteString("home", playWinProbability.Home);

            writer.WriteNumber("awayId", playWinProbability.AwayId);

            writer.WriteString("away", playWinProbability.Away);

            writer.WriteNumber("spread", playWinProbability.Spread);

            writer.WriteBoolean("homeBall", playWinProbability.HomeBall);

            writer.WriteNumber("homeScore", playWinProbability.HomeScore);

            writer.WriteNumber("awayScore", playWinProbability.AwayScore);

            writer.WriteNumber("yardLine", playWinProbability.YardLine);

            writer.WriteNumber("down", playWinProbability.Down);

            writer.WriteNumber("distance", playWinProbability.Distance);

            writer.WriteNumber("homeWinProbability", playWinProbability.HomeWinProbability);

            writer.WriteNumber("playNumber", playWinProbability.PlayNumber);
        }
    }
}

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
    /// PlayerGameUsage
    /// </summary>
    public partial class PlayerGameUsage : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGameUsage" /> class.
        /// </summary>
        /// <param name="total">total</param>
        /// <param name="rushing">rushing</param>
        /// <param name="passing">passing</param>
        /// <param name="player">player</param>
        /// <param name="team">team</param>
        /// <param name="position">position</param>
        /// <param name="quarter1">quarter1</param>
        /// <param name="quarter2">quarter2</param>
        /// <param name="quarter3">quarter3</param>
        /// <param name="quarter4">quarter4</param>
        [JsonConstructor]
        public PlayerGameUsage(double total, double rushing, double passing, string player, string team, string position, double? quarter1 = default, double? quarter2 = default, double? quarter3 = default, double? quarter4 = default)
        {
            Total = total;
            Rushing = rushing;
            Passing = passing;
            Player = player;
            Team = team;
            Position = position;
            Quarter1 = quarter1;
            Quarter2 = quarter2;
            Quarter3 = quarter3;
            Quarter4 = quarter4;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [JsonPropertyName("total")]
        public double Total { get; set; }

        /// <summary>
        /// Gets or Sets Rushing
        /// </summary>
        [JsonPropertyName("rushing")]
        public double Rushing { get; set; }

        /// <summary>
        /// Gets or Sets Passing
        /// </summary>
        [JsonPropertyName("passing")]
        public double Passing { get; set; }

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
        /// Gets or Sets Position
        /// </summary>
        [JsonPropertyName("position")]
        public string Position { get; set; }

        /// <summary>
        /// Gets or Sets Quarter1
        /// </summary>
        [JsonPropertyName("quarter1")]
        public double? Quarter1 { get; set; }

        /// <summary>
        /// Gets or Sets Quarter2
        /// </summary>
        [JsonPropertyName("quarter2")]
        public double? Quarter2 { get; set; }

        /// <summary>
        /// Gets or Sets Quarter3
        /// </summary>
        [JsonPropertyName("quarter3")]
        public double? Quarter3 { get; set; }

        /// <summary>
        /// Gets or Sets Quarter4
        /// </summary>
        [JsonPropertyName("quarter4")]
        public double? Quarter4 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerGameUsage {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Rushing: ").Append(Rushing).Append("\n");
            sb.Append("  Passing: ").Append(Passing).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Quarter1: ").Append(Quarter1).Append("\n");
            sb.Append("  Quarter2: ").Append(Quarter2).Append("\n");
            sb.Append("  Quarter3: ").Append(Quarter3).Append("\n");
            sb.Append("  Quarter4: ").Append(Quarter4).Append("\n");
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
    /// A Json converter for type <see cref="PlayerGameUsage" />
    /// </summary>
    public class PlayerGameUsageJsonConverter : JsonConverter<PlayerGameUsage>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerGameUsage" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerGameUsage Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double?> total = default;
            Option<double?> rushing = default;
            Option<double?> passing = default;
            Option<string?> player = default;
            Option<string?> team = default;
            Option<string?> position = default;
            Option<double?> quarter1 = default;
            Option<double?> quarter2 = default;
            Option<double?> quarter3 = default;
            Option<double?> quarter4 = default;

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
                        case "total":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                total = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "rushing":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rushing = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "passing":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                passing = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "player":
                            player = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "team":
                            team = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "position":
                            position = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "quarter1":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                quarter1 = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "quarter2":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                quarter2 = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "quarter3":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                quarter3 = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "quarter4":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                quarter4 = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!total.IsSet)
                throw new ArgumentException("Property is required for class PlayerGameUsage.", nameof(total));

            if (!rushing.IsSet)
                throw new ArgumentException("Property is required for class PlayerGameUsage.", nameof(rushing));

            if (!passing.IsSet)
                throw new ArgumentException("Property is required for class PlayerGameUsage.", nameof(passing));

            if (!player.IsSet)
                throw new ArgumentException("Property is required for class PlayerGameUsage.", nameof(player));

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class PlayerGameUsage.", nameof(team));

            if (!position.IsSet)
                throw new ArgumentException("Property is required for class PlayerGameUsage.", nameof(position));

            if (!quarter1.IsSet)
                throw new ArgumentException("Property is required for class PlayerGameUsage.", nameof(quarter1));

            if (!quarter2.IsSet)
                throw new ArgumentException("Property is required for class PlayerGameUsage.", nameof(quarter2));

            if (!quarter3.IsSet)
                throw new ArgumentException("Property is required for class PlayerGameUsage.", nameof(quarter3));

            if (!quarter4.IsSet)
                throw new ArgumentException("Property is required for class PlayerGameUsage.", nameof(quarter4));

            if (total.IsSet && total.Value == null)
                throw new ArgumentNullException(nameof(total), "Property is not nullable for class PlayerGameUsage.");

            if (rushing.IsSet && rushing.Value == null)
                throw new ArgumentNullException(nameof(rushing), "Property is not nullable for class PlayerGameUsage.");

            if (passing.IsSet && passing.Value == null)
                throw new ArgumentNullException(nameof(passing), "Property is not nullable for class PlayerGameUsage.");

            if (player.IsSet && player.Value == null)
                throw new ArgumentNullException(nameof(player), "Property is not nullable for class PlayerGameUsage.");

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class PlayerGameUsage.");

            if (position.IsSet && position.Value == null)
                throw new ArgumentNullException(nameof(position), "Property is not nullable for class PlayerGameUsage.");

            return new PlayerGameUsage(total.Value!.Value!, rushing.Value!.Value!, passing.Value!.Value!, player.Value!, team.Value!, position.Value!, quarter1.Value!, quarter2.Value!, quarter3.Value!, quarter4.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerGameUsage" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGameUsage"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerGameUsage playerGameUsage, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerGameUsage, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerGameUsage" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGameUsage"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerGameUsage playerGameUsage, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerGameUsage.Player == null)
                throw new ArgumentNullException(nameof(playerGameUsage.Player), "Property is required for class PlayerGameUsage.");

            if (playerGameUsage.Team == null)
                throw new ArgumentNullException(nameof(playerGameUsage.Team), "Property is required for class PlayerGameUsage.");

            if (playerGameUsage.Position == null)
                throw new ArgumentNullException(nameof(playerGameUsage.Position), "Property is required for class PlayerGameUsage.");

            writer.WriteNumber("total", playerGameUsage.Total);

            writer.WriteNumber("rushing", playerGameUsage.Rushing);

            writer.WriteNumber("passing", playerGameUsage.Passing);

            writer.WriteString("player", playerGameUsage.Player);

            writer.WriteString("team", playerGameUsage.Team);

            writer.WriteString("position", playerGameUsage.Position);

            if (playerGameUsage.Quarter1 != null)
                writer.WriteNumber("quarter1", playerGameUsage.Quarter1.Value);
            else
                writer.WriteNull("quarter1");

            if (playerGameUsage.Quarter2 != null)
                writer.WriteNumber("quarter2", playerGameUsage.Quarter2.Value);
            else
                writer.WriteNull("quarter2");

            if (playerGameUsage.Quarter3 != null)
                writer.WriteNumber("quarter3", playerGameUsage.Quarter3.Value);
            else
                writer.WriteNull("quarter3");

            if (playerGameUsage.Quarter4 != null)
                writer.WriteNumber("quarter4", playerGameUsage.Quarter4.Value);
            else
                writer.WriteNull("quarter4");
        }
    }
}

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
    /// PlayerSeasonPredictedPointsAdded
    /// </summary>
    public partial class PlayerSeasonPredictedPointsAdded : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerSeasonPredictedPointsAdded" /> class.
        /// </summary>
        /// <param name="season">season</param>
        /// <param name="id">id</param>
        /// <param name="name">name</param>
        /// <param name="position">position</param>
        /// <param name="team">team</param>
        /// <param name="conference">conference</param>
        /// <param name="averagePPA">averagePPA</param>
        /// <param name="totalPPA">totalPPA</param>
        [JsonConstructor]
        public PlayerSeasonPredictedPointsAdded(int season, string id, string name, string position, string team, string conference, PlayerSeasonPredictedPointsAddedAveragePPA averagePPA, PlayerSeasonPredictedPointsAddedAveragePPA totalPPA)
        {
            Season = season;
            Id = id;
            Name = name;
            Position = position;
            Team = team;
            Conference = conference;
            AveragePPA = averagePPA;
            TotalPPA = totalPPA;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [JsonPropertyName("season")]
        public int Season { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [JsonPropertyName("position")]
        public string Position { get; set; }

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
        /// Gets or Sets AveragePPA
        /// </summary>
        [JsonPropertyName("averagePPA")]
        public PlayerSeasonPredictedPointsAddedAveragePPA AveragePPA { get; set; }

        /// <summary>
        /// Gets or Sets TotalPPA
        /// </summary>
        [JsonPropertyName("totalPPA")]
        public PlayerSeasonPredictedPointsAddedAveragePPA TotalPPA { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerSeasonPredictedPointsAdded {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  AveragePPA: ").Append(AveragePPA).Append("\n");
            sb.Append("  TotalPPA: ").Append(TotalPPA).Append("\n");
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
    /// A Json converter for type <see cref="PlayerSeasonPredictedPointsAdded" />
    /// </summary>
    public class PlayerSeasonPredictedPointsAddedJsonConverter : JsonConverter<PlayerSeasonPredictedPointsAdded>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerSeasonPredictedPointsAdded" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerSeasonPredictedPointsAdded Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> season = default;
            Option<string?> id = default;
            Option<string?> name = default;
            Option<string?> position = default;
            Option<string?> team = default;
            Option<string?> conference = default;
            Option<PlayerSeasonPredictedPointsAddedAveragePPA?> averagePPA = default;
            Option<PlayerSeasonPredictedPointsAddedAveragePPA?> totalPPA = default;

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
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "position":
                            position = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "team":
                            team = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "conference":
                            conference = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "averagePPA":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                averagePPA = new Option<PlayerSeasonPredictedPointsAddedAveragePPA?>(JsonSerializer.Deserialize<PlayerSeasonPredictedPointsAddedAveragePPA>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "totalPPA":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                totalPPA = new Option<PlayerSeasonPredictedPointsAddedAveragePPA?>(JsonSerializer.Deserialize<PlayerSeasonPredictedPointsAddedAveragePPA>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!season.IsSet)
                throw new ArgumentException("Property is required for class PlayerSeasonPredictedPointsAdded.", nameof(season));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class PlayerSeasonPredictedPointsAdded.", nameof(id));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class PlayerSeasonPredictedPointsAdded.", nameof(name));

            if (!position.IsSet)
                throw new ArgumentException("Property is required for class PlayerSeasonPredictedPointsAdded.", nameof(position));

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class PlayerSeasonPredictedPointsAdded.", nameof(team));

            if (!conference.IsSet)
                throw new ArgumentException("Property is required for class PlayerSeasonPredictedPointsAdded.", nameof(conference));

            if (!averagePPA.IsSet)
                throw new ArgumentException("Property is required for class PlayerSeasonPredictedPointsAdded.", nameof(averagePPA));

            if (!totalPPA.IsSet)
                throw new ArgumentException("Property is required for class PlayerSeasonPredictedPointsAdded.", nameof(totalPPA));

            if (season.IsSet && season.Value == null)
                throw new ArgumentNullException(nameof(season), "Property is not nullable for class PlayerSeasonPredictedPointsAdded.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class PlayerSeasonPredictedPointsAdded.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class PlayerSeasonPredictedPointsAdded.");

            if (position.IsSet && position.Value == null)
                throw new ArgumentNullException(nameof(position), "Property is not nullable for class PlayerSeasonPredictedPointsAdded.");

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class PlayerSeasonPredictedPointsAdded.");

            if (conference.IsSet && conference.Value == null)
                throw new ArgumentNullException(nameof(conference), "Property is not nullable for class PlayerSeasonPredictedPointsAdded.");

            if (averagePPA.IsSet && averagePPA.Value == null)
                throw new ArgumentNullException(nameof(averagePPA), "Property is not nullable for class PlayerSeasonPredictedPointsAdded.");

            if (totalPPA.IsSet && totalPPA.Value == null)
                throw new ArgumentNullException(nameof(totalPPA), "Property is not nullable for class PlayerSeasonPredictedPointsAdded.");

            return new PlayerSeasonPredictedPointsAdded(season.Value!.Value!, id.Value!, name.Value!, position.Value!, team.Value!, conference.Value!, averagePPA.Value!, totalPPA.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerSeasonPredictedPointsAdded" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerSeasonPredictedPointsAdded"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerSeasonPredictedPointsAdded playerSeasonPredictedPointsAdded, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerSeasonPredictedPointsAdded, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerSeasonPredictedPointsAdded" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerSeasonPredictedPointsAdded"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerSeasonPredictedPointsAdded playerSeasonPredictedPointsAdded, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerSeasonPredictedPointsAdded.Id == null)
                throw new ArgumentNullException(nameof(playerSeasonPredictedPointsAdded.Id), "Property is required for class PlayerSeasonPredictedPointsAdded.");

            if (playerSeasonPredictedPointsAdded.Name == null)
                throw new ArgumentNullException(nameof(playerSeasonPredictedPointsAdded.Name), "Property is required for class PlayerSeasonPredictedPointsAdded.");

            if (playerSeasonPredictedPointsAdded.Position == null)
                throw new ArgumentNullException(nameof(playerSeasonPredictedPointsAdded.Position), "Property is required for class PlayerSeasonPredictedPointsAdded.");

            if (playerSeasonPredictedPointsAdded.Team == null)
                throw new ArgumentNullException(nameof(playerSeasonPredictedPointsAdded.Team), "Property is required for class PlayerSeasonPredictedPointsAdded.");

            if (playerSeasonPredictedPointsAdded.Conference == null)
                throw new ArgumentNullException(nameof(playerSeasonPredictedPointsAdded.Conference), "Property is required for class PlayerSeasonPredictedPointsAdded.");

            if (playerSeasonPredictedPointsAdded.AveragePPA == null)
                throw new ArgumentNullException(nameof(playerSeasonPredictedPointsAdded.AveragePPA), "Property is required for class PlayerSeasonPredictedPointsAdded.");

            if (playerSeasonPredictedPointsAdded.TotalPPA == null)
                throw new ArgumentNullException(nameof(playerSeasonPredictedPointsAdded.TotalPPA), "Property is required for class PlayerSeasonPredictedPointsAdded.");

            writer.WriteNumber("season", playerSeasonPredictedPointsAdded.Season);

            writer.WriteString("id", playerSeasonPredictedPointsAdded.Id);

            writer.WriteString("name", playerSeasonPredictedPointsAdded.Name);

            writer.WriteString("position", playerSeasonPredictedPointsAdded.Position);

            writer.WriteString("team", playerSeasonPredictedPointsAdded.Team);

            writer.WriteString("conference", playerSeasonPredictedPointsAdded.Conference);

            writer.WritePropertyName("averagePPA");
            JsonSerializer.Serialize(writer, playerSeasonPredictedPointsAdded.AveragePPA, jsonSerializerOptions);
            writer.WritePropertyName("totalPPA");
            JsonSerializer.Serialize(writer, playerSeasonPredictedPointsAdded.TotalPPA, jsonSerializerOptions);
        }
    }
}

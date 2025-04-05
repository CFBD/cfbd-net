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
    /// PlayerUsage
    /// </summary>
    public partial class PlayerUsage : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerUsage" /> class.
        /// </summary>
        /// <param name="season">season</param>
        /// <param name="id">id</param>
        /// <param name="name">name</param>
        /// <param name="position">position</param>
        /// <param name="team">team</param>
        /// <param name="conference">conference</param>
        /// <param name="usage">usage</param>
        [JsonConstructor]
        public PlayerUsage(int season, string id, string name, string position, string team, string conference, PlayerUsageUsage usage)
        {
            Season = season;
            Id = id;
            Name = name;
            Position = position;
            Team = team;
            Conference = conference;
            Usage = usage;
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
        /// Gets or Sets Usage
        /// </summary>
        [JsonPropertyName("usage")]
        public PlayerUsageUsage Usage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerUsage {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
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
    /// A Json converter for type <see cref="PlayerUsage" />
    /// </summary>
    public class PlayerUsageJsonConverter : JsonConverter<PlayerUsage>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerUsage" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerUsage Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
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
            Option<PlayerUsageUsage?> usage = default;

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
                        case "usage":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                usage = new Option<PlayerUsageUsage?>(JsonSerializer.Deserialize<PlayerUsageUsage>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!season.IsSet)
                throw new ArgumentException("Property is required for class PlayerUsage.", nameof(season));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class PlayerUsage.", nameof(id));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class PlayerUsage.", nameof(name));

            if (!position.IsSet)
                throw new ArgumentException("Property is required for class PlayerUsage.", nameof(position));

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class PlayerUsage.", nameof(team));

            if (!conference.IsSet)
                throw new ArgumentException("Property is required for class PlayerUsage.", nameof(conference));

            if (!usage.IsSet)
                throw new ArgumentException("Property is required for class PlayerUsage.", nameof(usage));

            if (season.IsSet && season.Value == null)
                throw new ArgumentNullException(nameof(season), "Property is not nullable for class PlayerUsage.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class PlayerUsage.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class PlayerUsage.");

            if (position.IsSet && position.Value == null)
                throw new ArgumentNullException(nameof(position), "Property is not nullable for class PlayerUsage.");

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class PlayerUsage.");

            if (conference.IsSet && conference.Value == null)
                throw new ArgumentNullException(nameof(conference), "Property is not nullable for class PlayerUsage.");

            if (usage.IsSet && usage.Value == null)
                throw new ArgumentNullException(nameof(usage), "Property is not nullable for class PlayerUsage.");

            return new PlayerUsage(season.Value!.Value!, id.Value!, name.Value!, position.Value!, team.Value!, conference.Value!, usage.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerUsage" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerUsage"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerUsage playerUsage, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerUsage, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerUsage" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerUsage"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerUsage playerUsage, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerUsage.Id == null)
                throw new ArgumentNullException(nameof(playerUsage.Id), "Property is required for class PlayerUsage.");

            if (playerUsage.Name == null)
                throw new ArgumentNullException(nameof(playerUsage.Name), "Property is required for class PlayerUsage.");

            if (playerUsage.Position == null)
                throw new ArgumentNullException(nameof(playerUsage.Position), "Property is required for class PlayerUsage.");

            if (playerUsage.Team == null)
                throw new ArgumentNullException(nameof(playerUsage.Team), "Property is required for class PlayerUsage.");

            if (playerUsage.Conference == null)
                throw new ArgumentNullException(nameof(playerUsage.Conference), "Property is required for class PlayerUsage.");

            if (playerUsage.Usage == null)
                throw new ArgumentNullException(nameof(playerUsage.Usage), "Property is required for class PlayerUsage.");

            writer.WriteNumber("season", playerUsage.Season);

            writer.WriteString("id", playerUsage.Id);

            writer.WriteString("name", playerUsage.Name);

            writer.WriteString("position", playerUsage.Position);

            writer.WriteString("team", playerUsage.Team);

            writer.WriteString("conference", playerUsage.Conference);

            writer.WritePropertyName("usage");
            JsonSerializer.Serialize(writer, playerUsage.Usage, jsonSerializerOptions);
        }
    }
}

// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.9
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
    /// TeamHavoc
    /// </summary>
    public partial class TeamHavoc : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamHavoc" /> class.
        /// </summary>
        /// <param name="team">team</param>
        /// <param name="total">total</param>
        /// <param name="frontSeven">frontSeven</param>
        /// <param name="db">db</param>
        [JsonConstructor]
        public TeamHavoc(string team, double total, double frontSeven, double db)
        {
            Team = team;
            Total = total;
            FrontSeven = frontSeven;
            Db = db;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [JsonPropertyName("team")]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [JsonPropertyName("total")]
        public double Total { get; set; }

        /// <summary>
        /// Gets or Sets FrontSeven
        /// </summary>
        [JsonPropertyName("frontSeven")]
        public double FrontSeven { get; set; }

        /// <summary>
        /// Gets or Sets Db
        /// </summary>
        [JsonPropertyName("db")]
        public double Db { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamHavoc {\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  FrontSeven: ").Append(FrontSeven).Append("\n");
            sb.Append("  Db: ").Append(Db).Append("\n");
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
    /// A Json converter for type <see cref="TeamHavoc" />
    /// </summary>
    public class TeamHavocJsonConverter : JsonConverter<TeamHavoc>
    {
        /// <summary>
        /// Deserializes json to <see cref="TeamHavoc" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TeamHavoc Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> team = default;
            Option<double?> total = default;
            Option<double?> frontSeven = default;
            Option<double?> db = default;

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
                        case "total":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                total = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "frontSeven":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                frontSeven = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "db":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                db = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class TeamHavoc.", nameof(team));

            if (!total.IsSet)
                throw new ArgumentException("Property is required for class TeamHavoc.", nameof(total));

            if (!frontSeven.IsSet)
                throw new ArgumentException("Property is required for class TeamHavoc.", nameof(frontSeven));

            if (!db.IsSet)
                throw new ArgumentException("Property is required for class TeamHavoc.", nameof(db));

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class TeamHavoc.");

            if (total.IsSet && total.Value == null)
                throw new ArgumentNullException(nameof(total), "Property is not nullable for class TeamHavoc.");

            if (frontSeven.IsSet && frontSeven.Value == null)
                throw new ArgumentNullException(nameof(frontSeven), "Property is not nullable for class TeamHavoc.");

            if (db.IsSet && db.Value == null)
                throw new ArgumentNullException(nameof(db), "Property is not nullable for class TeamHavoc.");

            return new TeamHavoc(team.Value!, total.Value!.Value!, frontSeven.Value!.Value!, db.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="TeamHavoc" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamHavoc"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TeamHavoc teamHavoc, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, teamHavoc, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TeamHavoc" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="teamHavoc"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TeamHavoc teamHavoc, JsonSerializerOptions jsonSerializerOptions)
        {
            if (teamHavoc.Team == null)
                throw new ArgumentNullException(nameof(teamHavoc.Team), "Property is required for class TeamHavoc.");

            writer.WriteString("team", teamHavoc.Team);

            writer.WriteNumber("total", teamHavoc.Total);

            writer.WriteNumber("frontSeven", teamHavoc.FrontSeven);

            writer.WriteNumber("db", teamHavoc.Db);
        }
    }
}

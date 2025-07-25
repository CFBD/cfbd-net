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
    /// KickerPAAR
    /// </summary>
    public partial class KickerPAAR : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KickerPAAR" /> class.
        /// </summary>
        /// <param name="year">year</param>
        /// <param name="athleteId">athleteId</param>
        /// <param name="athleteName">athleteName</param>
        /// <param name="team">team</param>
        /// <param name="conference">conference</param>
        /// <param name="paar">paar</param>
        /// <param name="attempts">attempts</param>
        [JsonConstructor]
        public KickerPAAR(int year, string athleteId, string athleteName, string team, string conference, double paar, int attempts)
        {
            Year = year;
            AthleteId = athleteId;
            AthleteName = athleteName;
            Team = team;
            Conference = conference;
            Paar = paar;
            Attempts = attempts;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [JsonPropertyName("year")]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets AthleteId
        /// </summary>
        [JsonPropertyName("athleteId")]
        public string AthleteId { get; set; }

        /// <summary>
        /// Gets or Sets AthleteName
        /// </summary>
        [JsonPropertyName("athleteName")]
        public string AthleteName { get; set; }

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
        /// Gets or Sets Paar
        /// </summary>
        [JsonPropertyName("paar")]
        public double Paar { get; set; }

        /// <summary>
        /// Gets or Sets Attempts
        /// </summary>
        [JsonPropertyName("attempts")]
        public int Attempts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KickerPAAR {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  AthleteId: ").Append(AthleteId).Append("\n");
            sb.Append("  AthleteName: ").Append(AthleteName).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Paar: ").Append(Paar).Append("\n");
            sb.Append("  Attempts: ").Append(Attempts).Append("\n");
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
    /// A Json converter for type <see cref="KickerPAAR" />
    /// </summary>
    public class KickerPAARJsonConverter : JsonConverter<KickerPAAR>
    {
        /// <summary>
        /// Deserializes json to <see cref="KickerPAAR" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KickerPAAR Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> year = default;
            Option<string?> athleteId = default;
            Option<string?> athleteName = default;
            Option<string?> team = default;
            Option<string?> conference = default;
            Option<double?> paar = default;
            Option<int?> attempts = default;

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
                        case "year":
                            year = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "athleteId":
                            athleteId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "athleteName":
                            athleteName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "team":
                            team = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "conference":
                            conference = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "paar":
                            paar = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "attempts":
                            attempts = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!year.IsSet)
                throw new ArgumentException("Property is required for class KickerPAAR.", nameof(year));

            if (!athleteId.IsSet)
                throw new ArgumentException("Property is required for class KickerPAAR.", nameof(athleteId));

            if (!athleteName.IsSet)
                throw new ArgumentException("Property is required for class KickerPAAR.", nameof(athleteName));

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class KickerPAAR.", nameof(team));

            if (!conference.IsSet)
                throw new ArgumentException("Property is required for class KickerPAAR.", nameof(conference));

            if (!paar.IsSet)
                throw new ArgumentException("Property is required for class KickerPAAR.", nameof(paar));

            if (!attempts.IsSet)
                throw new ArgumentException("Property is required for class KickerPAAR.", nameof(attempts));

            if (year.IsSet && year.Value == null)
                throw new ArgumentNullException(nameof(year), "Property is not nullable for class KickerPAAR.");

            if (athleteId.IsSet && athleteId.Value == null)
                throw new ArgumentNullException(nameof(athleteId), "Property is not nullable for class KickerPAAR.");

            if (athleteName.IsSet && athleteName.Value == null)
                throw new ArgumentNullException(nameof(athleteName), "Property is not nullable for class KickerPAAR.");

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class KickerPAAR.");

            if (conference.IsSet && conference.Value == null)
                throw new ArgumentNullException(nameof(conference), "Property is not nullable for class KickerPAAR.");

            if (paar.IsSet && paar.Value == null)
                throw new ArgumentNullException(nameof(paar), "Property is not nullable for class KickerPAAR.");

            if (attempts.IsSet && attempts.Value == null)
                throw new ArgumentNullException(nameof(attempts), "Property is not nullable for class KickerPAAR.");

            return new KickerPAAR(year.Value!.Value!, athleteId.Value!, athleteName.Value!, team.Value!, conference.Value!, paar.Value!.Value!, attempts.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="KickerPAAR" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kickerPAAR"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KickerPAAR kickerPAAR, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kickerPAAR, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KickerPAAR" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kickerPAAR"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KickerPAAR kickerPAAR, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kickerPAAR.AthleteId == null)
                throw new ArgumentNullException(nameof(kickerPAAR.AthleteId), "Property is required for class KickerPAAR.");

            if (kickerPAAR.AthleteName == null)
                throw new ArgumentNullException(nameof(kickerPAAR.AthleteName), "Property is required for class KickerPAAR.");

            if (kickerPAAR.Team == null)
                throw new ArgumentNullException(nameof(kickerPAAR.Team), "Property is required for class KickerPAAR.");

            if (kickerPAAR.Conference == null)
                throw new ArgumentNullException(nameof(kickerPAAR.Conference), "Property is required for class KickerPAAR.");

            writer.WriteNumber("year", kickerPAAR.Year);

            writer.WriteString("athleteId", kickerPAAR.AthleteId);

            writer.WriteString("athleteName", kickerPAAR.AthleteName);

            writer.WriteString("team", kickerPAAR.Team);

            writer.WriteString("conference", kickerPAAR.Conference);

            writer.WriteNumber("paar", kickerPAAR.Paar);

            writer.WriteNumber("attempts", kickerPAAR.Attempts);
        }
    }
}

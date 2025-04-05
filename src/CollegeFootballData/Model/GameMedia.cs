// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.11
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
    /// GameMedia
    /// </summary>
    public partial class GameMedia : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameMedia" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="season">season</param>
        /// <param name="week">week</param>
        /// <param name="seasonType">seasonType</param>
        /// <param name="startTime">startTime</param>
        /// <param name="isStartTimeTBD">isStartTimeTBD</param>
        /// <param name="homeTeam">homeTeam</param>
        /// <param name="awayTeam">awayTeam</param>
        /// <param name="mediaType">mediaType</param>
        /// <param name="outlet">outlet</param>
        /// <param name="homeConference">homeConference</param>
        /// <param name="awayConference">awayConference</param>
        [JsonConstructor]
        public GameMedia(int id, int season, int week, SeasonType seasonType, DateTime startTime, bool isStartTimeTBD, string homeTeam, string awayTeam, MediaType mediaType, string outlet, string? homeConference = default, string? awayConference = default)
        {
            Id = id;
            Season = season;
            Week = week;
            SeasonType = seasonType;
            StartTime = startTime;
            IsStartTimeTBD = isStartTimeTBD;
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            MediaType = mediaType;
            Outlet = outlet;
            HomeConference = homeConference;
            AwayConference = awayConference;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets SeasonType
        /// </summary>
        [JsonPropertyName("seasonType")]
        public SeasonType SeasonType { get; set; }

        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [JsonPropertyName("mediaType")]
        public MediaType MediaType { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

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
        /// Gets or Sets StartTime
        /// </summary>
        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or Sets IsStartTimeTBD
        /// </summary>
        [JsonPropertyName("isStartTimeTBD")]
        public bool IsStartTimeTBD { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeam
        /// </summary>
        [JsonPropertyName("homeTeam")]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeam
        /// </summary>
        [JsonPropertyName("awayTeam")]
        public string AwayTeam { get; set; }

        /// <summary>
        /// Gets or Sets Outlet
        /// </summary>
        [JsonPropertyName("outlet")]
        public string Outlet { get; set; }

        /// <summary>
        /// Gets or Sets HomeConference
        /// </summary>
        [JsonPropertyName("homeConference")]
        public string? HomeConference { get; set; }

        /// <summary>
        /// Gets or Sets AwayConference
        /// </summary>
        [JsonPropertyName("awayConference")]
        public string? AwayConference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GameMedia {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  SeasonType: ").Append(SeasonType).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  IsStartTimeTBD: ").Append(IsStartTimeTBD).Append("\n");
            sb.Append("  HomeTeam: ").Append(HomeTeam).Append("\n");
            sb.Append("  AwayTeam: ").Append(AwayTeam).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Outlet: ").Append(Outlet).Append("\n");
            sb.Append("  HomeConference: ").Append(HomeConference).Append("\n");
            sb.Append("  AwayConference: ").Append(AwayConference).Append("\n");
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
    /// A Json converter for type <see cref="GameMedia" />
    /// </summary>
    public class GameMediaJsonConverter : JsonConverter<GameMedia>
    {
        /// <summary>
        /// The format to use to serialize StartTime
        /// </summary>
        public static string StartTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="GameMedia" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GameMedia Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> id = default;
            Option<int?> season = default;
            Option<int?> week = default;
            Option<SeasonType?> seasonType = default;
            Option<DateTime?> startTime = default;
            Option<bool?> isStartTimeTBD = default;
            Option<string?> homeTeam = default;
            Option<string?> awayTeam = default;
            Option<MediaType?> mediaType = default;
            Option<string?> outlet = default;
            Option<string?> homeConference = default;
            Option<string?> awayConference = default;

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
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "season":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                season = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "week":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                week = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "seasonType":
                            string? seasonTypeRawValue = utf8JsonReader.GetString();
                            if (seasonTypeRawValue != null)
                                seasonType = new Option<SeasonType?>(SeasonTypeValueConverter.FromStringOrDefault(seasonTypeRawValue));
                            break;
                        case "startTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                startTime = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "isStartTimeTBD":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isStartTimeTBD = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "homeTeam":
                            homeTeam = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "awayTeam":
                            awayTeam = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "mediaType":
                            string? mediaTypeRawValue = utf8JsonReader.GetString();
                            if (mediaTypeRawValue != null)
                                mediaType = new Option<MediaType?>(MediaTypeValueConverter.FromStringOrDefault(mediaTypeRawValue));
                            break;
                        case "outlet":
                            outlet = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "homeConference":
                            homeConference = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "awayConference":
                            awayConference = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class GameMedia.", nameof(id));

            if (!season.IsSet)
                throw new ArgumentException("Property is required for class GameMedia.", nameof(season));

            if (!week.IsSet)
                throw new ArgumentException("Property is required for class GameMedia.", nameof(week));

            if (!seasonType.IsSet)
                throw new ArgumentException("Property is required for class GameMedia.", nameof(seasonType));

            if (!startTime.IsSet)
                throw new ArgumentException("Property is required for class GameMedia.", nameof(startTime));

            if (!isStartTimeTBD.IsSet)
                throw new ArgumentException("Property is required for class GameMedia.", nameof(isStartTimeTBD));

            if (!homeTeam.IsSet)
                throw new ArgumentException("Property is required for class GameMedia.", nameof(homeTeam));

            if (!awayTeam.IsSet)
                throw new ArgumentException("Property is required for class GameMedia.", nameof(awayTeam));

            if (!mediaType.IsSet)
                throw new ArgumentException("Property is required for class GameMedia.", nameof(mediaType));

            if (!outlet.IsSet)
                throw new ArgumentException("Property is required for class GameMedia.", nameof(outlet));

            if (!homeConference.IsSet)
                throw new ArgumentException("Property is required for class GameMedia.", nameof(homeConference));

            if (!awayConference.IsSet)
                throw new ArgumentException("Property is required for class GameMedia.", nameof(awayConference));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class GameMedia.");

            if (season.IsSet && season.Value == null)
                throw new ArgumentNullException(nameof(season), "Property is not nullable for class GameMedia.");

            if (week.IsSet && week.Value == null)
                throw new ArgumentNullException(nameof(week), "Property is not nullable for class GameMedia.");

            if (seasonType.IsSet && seasonType.Value == null)
                throw new ArgumentNullException(nameof(seasonType), "Property is not nullable for class GameMedia.");

            if (startTime.IsSet && startTime.Value == null)
                throw new ArgumentNullException(nameof(startTime), "Property is not nullable for class GameMedia.");

            if (isStartTimeTBD.IsSet && isStartTimeTBD.Value == null)
                throw new ArgumentNullException(nameof(isStartTimeTBD), "Property is not nullable for class GameMedia.");

            if (homeTeam.IsSet && homeTeam.Value == null)
                throw new ArgumentNullException(nameof(homeTeam), "Property is not nullable for class GameMedia.");

            if (awayTeam.IsSet && awayTeam.Value == null)
                throw new ArgumentNullException(nameof(awayTeam), "Property is not nullable for class GameMedia.");

            if (mediaType.IsSet && mediaType.Value == null)
                throw new ArgumentNullException(nameof(mediaType), "Property is not nullable for class GameMedia.");

            if (outlet.IsSet && outlet.Value == null)
                throw new ArgumentNullException(nameof(outlet), "Property is not nullable for class GameMedia.");

            return new GameMedia(id.Value!.Value!, season.Value!.Value!, week.Value!.Value!, seasonType.Value!.Value!, startTime.Value!.Value!, isStartTimeTBD.Value!.Value!, homeTeam.Value!, awayTeam.Value!, mediaType.Value!.Value!, outlet.Value!, homeConference.Value!, awayConference.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GameMedia" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gameMedia"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GameMedia gameMedia, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, gameMedia, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GameMedia" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gameMedia"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GameMedia gameMedia, JsonSerializerOptions jsonSerializerOptions)
        {
            if (gameMedia.HomeTeam == null)
                throw new ArgumentNullException(nameof(gameMedia.HomeTeam), "Property is required for class GameMedia.");

            if (gameMedia.AwayTeam == null)
                throw new ArgumentNullException(nameof(gameMedia.AwayTeam), "Property is required for class GameMedia.");

            if (gameMedia.Outlet == null)
                throw new ArgumentNullException(nameof(gameMedia.Outlet), "Property is required for class GameMedia.");

            writer.WriteNumber("id", gameMedia.Id);

            writer.WriteNumber("season", gameMedia.Season);

            writer.WriteNumber("week", gameMedia.Week);

            var seasonTypeRawValue = SeasonTypeValueConverter.ToJsonValue(gameMedia.SeasonType);
            writer.WriteString("seasonType", seasonTypeRawValue);

            writer.WriteString("startTime", gameMedia.StartTime.ToString(StartTimeFormat));

            writer.WriteBoolean("isStartTimeTBD", gameMedia.IsStartTimeTBD);

            writer.WriteString("homeTeam", gameMedia.HomeTeam);

            writer.WriteString("awayTeam", gameMedia.AwayTeam);

            var mediaTypeRawValue = MediaTypeValueConverter.ToJsonValue(gameMedia.MediaType);
            writer.WriteString("mediaType", mediaTypeRawValue);

            writer.WriteString("outlet", gameMedia.Outlet);

            if (gameMedia.HomeConference != null)
                writer.WriteString("homeConference", gameMedia.HomeConference);
            else
                writer.WriteNull("homeConference");

            if (gameMedia.AwayConference != null)
                writer.WriteString("awayConference", gameMedia.AwayConference);
            else
                writer.WriteNull("awayConference");
        }
    }
}

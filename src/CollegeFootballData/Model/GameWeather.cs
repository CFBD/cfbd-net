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
    /// GameWeather
    /// </summary>
    public partial class GameWeather : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameWeather" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="season">season</param>
        /// <param name="week">week</param>
        /// <param name="seasonType">seasonType</param>
        /// <param name="startTime">startTime</param>
        /// <param name="gameIndoors">gameIndoors</param>
        /// <param name="homeTeam">homeTeam</param>
        /// <param name="awayTeam">awayTeam</param>
        /// <param name="venueId">venueId</param>
        /// <param name="venue">venue</param>
        /// <param name="homeConference">homeConference</param>
        /// <param name="awayConference">awayConference</param>
        /// <param name="temperature">temperature</param>
        /// <param name="dewPoint">dewPoint</param>
        /// <param name="humidity">humidity</param>
        /// <param name="precipitation">precipitation</param>
        /// <param name="snowfall">snowfall</param>
        /// <param name="windDirection">windDirection</param>
        /// <param name="windSpeed">windSpeed</param>
        /// <param name="pressure">pressure</param>
        /// <param name="weatherConditionCode">weatherConditionCode</param>
        /// <param name="weatherCondition">weatherCondition</param>
        [JsonConstructor]
        public GameWeather(int id, int season, int week, SeasonType seasonType, DateTime startTime, bool gameIndoors, string homeTeam, string awayTeam, int venueId, string venue, string? homeConference = default, string? awayConference = default, double? temperature = default, double? dewPoint = default, double? humidity = default, double? precipitation = default, double? snowfall = default, double? windDirection = default, double? windSpeed = default, double? pressure = default, double? weatherConditionCode = default, string? weatherCondition = default)
        {
            Id = id;
            Season = season;
            Week = week;
            SeasonType = seasonType;
            StartTime = startTime;
            GameIndoors = gameIndoors;
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            VenueId = venueId;
            Venue = venue;
            HomeConference = homeConference;
            AwayConference = awayConference;
            Temperature = temperature;
            DewPoint = dewPoint;
            Humidity = humidity;
            Precipitation = precipitation;
            Snowfall = snowfall;
            WindDirection = windDirection;
            WindSpeed = windSpeed;
            Pressure = pressure;
            WeatherConditionCode = weatherConditionCode;
            WeatherCondition = weatherCondition;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets SeasonType
        /// </summary>
        [JsonPropertyName("seasonType")]
        public SeasonType SeasonType { get; set; }

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
        /// Gets or Sets GameIndoors
        /// </summary>
        [JsonPropertyName("gameIndoors")]
        public bool GameIndoors { get; set; }

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
        /// Gets or Sets VenueId
        /// </summary>
        [JsonPropertyName("venueId")]
        public int VenueId { get; set; }

        /// <summary>
        /// Gets or Sets Venue
        /// </summary>
        [JsonPropertyName("venue")]
        public string Venue { get; set; }

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
        /// Gets or Sets Temperature
        /// </summary>
        [JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Gets or Sets DewPoint
        /// </summary>
        [JsonPropertyName("dewPoint")]
        public double? DewPoint { get; set; }

        /// <summary>
        /// Gets or Sets Humidity
        /// </summary>
        [JsonPropertyName("humidity")]
        public double? Humidity { get; set; }

        /// <summary>
        /// Gets or Sets Precipitation
        /// </summary>
        [JsonPropertyName("precipitation")]
        public double? Precipitation { get; set; }

        /// <summary>
        /// Gets or Sets Snowfall
        /// </summary>
        [JsonPropertyName("snowfall")]
        public double? Snowfall { get; set; }

        /// <summary>
        /// Gets or Sets WindDirection
        /// </summary>
        [JsonPropertyName("windDirection")]
        public double? WindDirection { get; set; }

        /// <summary>
        /// Gets or Sets WindSpeed
        /// </summary>
        [JsonPropertyName("windSpeed")]
        public double? WindSpeed { get; set; }

        /// <summary>
        /// Gets or Sets Pressure
        /// </summary>
        [JsonPropertyName("pressure")]
        public double? Pressure { get; set; }

        /// <summary>
        /// Gets or Sets WeatherConditionCode
        /// </summary>
        [JsonPropertyName("weatherConditionCode")]
        public double? WeatherConditionCode { get; set; }

        /// <summary>
        /// Gets or Sets WeatherCondition
        /// </summary>
        [JsonPropertyName("weatherCondition")]
        public string? WeatherCondition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GameWeather {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  SeasonType: ").Append(SeasonType).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  GameIndoors: ").Append(GameIndoors).Append("\n");
            sb.Append("  HomeTeam: ").Append(HomeTeam).Append("\n");
            sb.Append("  AwayTeam: ").Append(AwayTeam).Append("\n");
            sb.Append("  VenueId: ").Append(VenueId).Append("\n");
            sb.Append("  Venue: ").Append(Venue).Append("\n");
            sb.Append("  HomeConference: ").Append(HomeConference).Append("\n");
            sb.Append("  AwayConference: ").Append(AwayConference).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  DewPoint: ").Append(DewPoint).Append("\n");
            sb.Append("  Humidity: ").Append(Humidity).Append("\n");
            sb.Append("  Precipitation: ").Append(Precipitation).Append("\n");
            sb.Append("  Snowfall: ").Append(Snowfall).Append("\n");
            sb.Append("  WindDirection: ").Append(WindDirection).Append("\n");
            sb.Append("  WindSpeed: ").Append(WindSpeed).Append("\n");
            sb.Append("  Pressure: ").Append(Pressure).Append("\n");
            sb.Append("  WeatherConditionCode: ").Append(WeatherConditionCode).Append("\n");
            sb.Append("  WeatherCondition: ").Append(WeatherCondition).Append("\n");
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
    /// A Json converter for type <see cref="GameWeather" />
    /// </summary>
    public class GameWeatherJsonConverter : JsonConverter<GameWeather>
    {
        /// <summary>
        /// The format to use to serialize StartTime
        /// </summary>
        public static string StartTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="GameWeather" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GameWeather Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
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
            Option<bool?> gameIndoors = default;
            Option<string?> homeTeam = default;
            Option<string?> awayTeam = default;
            Option<int?> venueId = default;
            Option<string?> venue = default;
            Option<string?> homeConference = default;
            Option<string?> awayConference = default;
            Option<double?> temperature = default;
            Option<double?> dewPoint = default;
            Option<double?> humidity = default;
            Option<double?> precipitation = default;
            Option<double?> snowfall = default;
            Option<double?> windDirection = default;
            Option<double?> windSpeed = default;
            Option<double?> pressure = default;
            Option<double?> weatherConditionCode = default;
            Option<string?> weatherCondition = default;

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
                        case "gameIndoors":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                gameIndoors = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "homeTeam":
                            homeTeam = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "awayTeam":
                            awayTeam = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "venueId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                venueId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "venue":
                            venue = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "homeConference":
                            homeConference = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "awayConference":
                            awayConference = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "temperature":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                temperature = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "dewPoint":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dewPoint = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "humidity":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                humidity = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "precipitation":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                precipitation = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "snowfall":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                snowfall = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "windDirection":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                windDirection = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "windSpeed":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                windSpeed = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "pressure":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                pressure = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "weatherConditionCode":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                weatherConditionCode = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "weatherCondition":
                            weatherCondition = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(id));

            if (!season.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(season));

            if (!week.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(week));

            if (!seasonType.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(seasonType));

            if (!startTime.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(startTime));

            if (!gameIndoors.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(gameIndoors));

            if (!homeTeam.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(homeTeam));

            if (!awayTeam.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(awayTeam));

            if (!venueId.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(venueId));

            if (!venue.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(venue));

            if (!homeConference.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(homeConference));

            if (!awayConference.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(awayConference));

            if (!temperature.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(temperature));

            if (!dewPoint.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(dewPoint));

            if (!humidity.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(humidity));

            if (!precipitation.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(precipitation));

            if (!snowfall.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(snowfall));

            if (!windDirection.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(windDirection));

            if (!windSpeed.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(windSpeed));

            if (!pressure.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(pressure));

            if (!weatherConditionCode.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(weatherConditionCode));

            if (!weatherCondition.IsSet)
                throw new ArgumentException("Property is required for class GameWeather.", nameof(weatherCondition));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class GameWeather.");

            if (season.IsSet && season.Value == null)
                throw new ArgumentNullException(nameof(season), "Property is not nullable for class GameWeather.");

            if (week.IsSet && week.Value == null)
                throw new ArgumentNullException(nameof(week), "Property is not nullable for class GameWeather.");

            if (seasonType.IsSet && seasonType.Value == null)
                throw new ArgumentNullException(nameof(seasonType), "Property is not nullable for class GameWeather.");

            if (startTime.IsSet && startTime.Value == null)
                throw new ArgumentNullException(nameof(startTime), "Property is not nullable for class GameWeather.");

            if (gameIndoors.IsSet && gameIndoors.Value == null)
                throw new ArgumentNullException(nameof(gameIndoors), "Property is not nullable for class GameWeather.");

            if (homeTeam.IsSet && homeTeam.Value == null)
                throw new ArgumentNullException(nameof(homeTeam), "Property is not nullable for class GameWeather.");

            if (awayTeam.IsSet && awayTeam.Value == null)
                throw new ArgumentNullException(nameof(awayTeam), "Property is not nullable for class GameWeather.");

            if (venueId.IsSet && venueId.Value == null)
                throw new ArgumentNullException(nameof(venueId), "Property is not nullable for class GameWeather.");

            if (venue.IsSet && venue.Value == null)
                throw new ArgumentNullException(nameof(venue), "Property is not nullable for class GameWeather.");

            return new GameWeather(id.Value!.Value!, season.Value!.Value!, week.Value!.Value!, seasonType.Value!.Value!, startTime.Value!.Value!, gameIndoors.Value!.Value!, homeTeam.Value!, awayTeam.Value!, venueId.Value!.Value!, venue.Value!, homeConference.Value!, awayConference.Value!, temperature.Value!, dewPoint.Value!, humidity.Value!, precipitation.Value!, snowfall.Value!, windDirection.Value!, windSpeed.Value!, pressure.Value!, weatherConditionCode.Value!, weatherCondition.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GameWeather" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gameWeather"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GameWeather gameWeather, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, gameWeather, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GameWeather" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gameWeather"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GameWeather gameWeather, JsonSerializerOptions jsonSerializerOptions)
        {
            if (gameWeather.HomeTeam == null)
                throw new ArgumentNullException(nameof(gameWeather.HomeTeam), "Property is required for class GameWeather.");

            if (gameWeather.AwayTeam == null)
                throw new ArgumentNullException(nameof(gameWeather.AwayTeam), "Property is required for class GameWeather.");

            if (gameWeather.Venue == null)
                throw new ArgumentNullException(nameof(gameWeather.Venue), "Property is required for class GameWeather.");

            writer.WriteNumber("id", gameWeather.Id);

            writer.WriteNumber("season", gameWeather.Season);

            writer.WriteNumber("week", gameWeather.Week);

            var seasonTypeRawValue = SeasonTypeValueConverter.ToJsonValue(gameWeather.SeasonType);
            writer.WriteString("seasonType", seasonTypeRawValue);

            writer.WriteString("startTime", gameWeather.StartTime.ToString(StartTimeFormat));

            writer.WriteBoolean("gameIndoors", gameWeather.GameIndoors);

            writer.WriteString("homeTeam", gameWeather.HomeTeam);

            writer.WriteString("awayTeam", gameWeather.AwayTeam);

            writer.WriteNumber("venueId", gameWeather.VenueId);

            writer.WriteString("venue", gameWeather.Venue);

            if (gameWeather.HomeConference != null)
                writer.WriteString("homeConference", gameWeather.HomeConference);
            else
                writer.WriteNull("homeConference");

            if (gameWeather.AwayConference != null)
                writer.WriteString("awayConference", gameWeather.AwayConference);
            else
                writer.WriteNull("awayConference");

            if (gameWeather.Temperature != null)
                writer.WriteNumber("temperature", gameWeather.Temperature.Value);
            else
                writer.WriteNull("temperature");

            if (gameWeather.DewPoint != null)
                writer.WriteNumber("dewPoint", gameWeather.DewPoint.Value);
            else
                writer.WriteNull("dewPoint");

            if (gameWeather.Humidity != null)
                writer.WriteNumber("humidity", gameWeather.Humidity.Value);
            else
                writer.WriteNull("humidity");

            if (gameWeather.Precipitation != null)
                writer.WriteNumber("precipitation", gameWeather.Precipitation.Value);
            else
                writer.WriteNull("precipitation");

            if (gameWeather.Snowfall != null)
                writer.WriteNumber("snowfall", gameWeather.Snowfall.Value);
            else
                writer.WriteNull("snowfall");

            if (gameWeather.WindDirection != null)
                writer.WriteNumber("windDirection", gameWeather.WindDirection.Value);
            else
                writer.WriteNull("windDirection");

            if (gameWeather.WindSpeed != null)
                writer.WriteNumber("windSpeed", gameWeather.WindSpeed.Value);
            else
                writer.WriteNull("windSpeed");

            if (gameWeather.Pressure != null)
                writer.WriteNumber("pressure", gameWeather.Pressure.Value);
            else
                writer.WriteNull("pressure");

            if (gameWeather.WeatherConditionCode != null)
                writer.WriteNumber("weatherConditionCode", gameWeather.WeatherConditionCode.Value);
            else
                writer.WriteNull("weatherConditionCode");

            if (gameWeather.WeatherCondition != null)
                writer.WriteString("weatherCondition", gameWeather.WeatherCondition);
            else
                writer.WriteNull("weatherCondition");
        }
    }
}

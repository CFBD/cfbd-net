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
    /// Play
    /// </summary>
    public partial class Play : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Play" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="driveId">driveId</param>
        /// <param name="gameId">gameId</param>
        /// <param name="offense">offense</param>
        /// <param name="offenseScore">offenseScore</param>
        /// <param name="defense">defense</param>
        /// <param name="home">home</param>
        /// <param name="away">away</param>
        /// <param name="defenseScore">defenseScore</param>
        /// <param name="period">period</param>
        /// <param name="clock">clock</param>
        /// <param name="yardline">yardline</param>
        /// <param name="yardsToGoal">yardsToGoal</param>
        /// <param name="down">down</param>
        /// <param name="distance">distance</param>
        /// <param name="yardsGained">yardsGained</param>
        /// <param name="scoring">scoring</param>
        /// <param name="playType">playType</param>
        /// <param name="driveNumber">driveNumber</param>
        /// <param name="playNumber">playNumber</param>
        /// <param name="offenseConference">offenseConference</param>
        /// <param name="defenseConference">defenseConference</param>
        /// <param name="offenseTimeouts">offenseTimeouts</param>
        /// <param name="defenseTimeouts">defenseTimeouts</param>
        /// <param name="playText">playText</param>
        /// <param name="ppa">ppa</param>
        /// <param name="wallclock">wallclock</param>
        [JsonConstructor]
        public Play(string id, string driveId, int gameId, string offense, int offenseScore, string defense, string home, string away, int defenseScore, int period, PlayClock clock, int yardline, int yardsToGoal, int down, int distance, int yardsGained, bool scoring, string playType, int? driveNumber = default, int? playNumber = default, string? offenseConference = default, string? defenseConference = default, int? offenseTimeouts = default, int? defenseTimeouts = default, string? playText = default, double? ppa = default, string? wallclock = default)
        {
            Id = id;
            DriveId = driveId;
            GameId = gameId;
            Offense = offense;
            OffenseScore = offenseScore;
            Defense = defense;
            Home = home;
            Away = away;
            DefenseScore = defenseScore;
            Period = period;
            Clock = clock;
            Yardline = yardline;
            YardsToGoal = yardsToGoal;
            Down = down;
            Distance = distance;
            YardsGained = yardsGained;
            Scoring = scoring;
            PlayType = playType;
            DriveNumber = driveNumber;
            PlayNumber = playNumber;
            OffenseConference = offenseConference;
            DefenseConference = defenseConference;
            OffenseTimeouts = offenseTimeouts;
            DefenseTimeouts = defenseTimeouts;
            PlayText = playText;
            Ppa = ppa;
            Wallclock = wallclock;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets DriveId
        /// </summary>
        [JsonPropertyName("driveId")]
        public string DriveId { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [JsonPropertyName("gameId")]
        public int GameId { get; set; }

        /// <summary>
        /// Gets or Sets Offense
        /// </summary>
        [JsonPropertyName("offense")]
        public string Offense { get; set; }

        /// <summary>
        /// Gets or Sets OffenseScore
        /// </summary>
        [JsonPropertyName("offenseScore")]
        public int OffenseScore { get; set; }

        /// <summary>
        /// Gets or Sets Defense
        /// </summary>
        [JsonPropertyName("defense")]
        public string Defense { get; set; }

        /// <summary>
        /// Gets or Sets Home
        /// </summary>
        [JsonPropertyName("home")]
        public string Home { get; set; }

        /// <summary>
        /// Gets or Sets Away
        /// </summary>
        [JsonPropertyName("away")]
        public string Away { get; set; }

        /// <summary>
        /// Gets or Sets DefenseScore
        /// </summary>
        [JsonPropertyName("defenseScore")]
        public int DefenseScore { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [JsonPropertyName("period")]
        public int Period { get; set; }

        /// <summary>
        /// Gets or Sets Clock
        /// </summary>
        [JsonPropertyName("clock")]
        public PlayClock Clock { get; set; }

        /// <summary>
        /// Gets or Sets Yardline
        /// </summary>
        [JsonPropertyName("yardline")]
        public int Yardline { get; set; }

        /// <summary>
        /// Gets or Sets YardsToGoal
        /// </summary>
        [JsonPropertyName("yardsToGoal")]
        public int YardsToGoal { get; set; }

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
        /// Gets or Sets YardsGained
        /// </summary>
        [JsonPropertyName("yardsGained")]
        public int YardsGained { get; set; }

        /// <summary>
        /// Gets or Sets Scoring
        /// </summary>
        [JsonPropertyName("scoring")]
        public bool Scoring { get; set; }

        /// <summary>
        /// Gets or Sets PlayType
        /// </summary>
        [JsonPropertyName("playType")]
        public string PlayType { get; set; }

        /// <summary>
        /// Gets or Sets DriveNumber
        /// </summary>
        [JsonPropertyName("driveNumber")]
        public int? DriveNumber { get; set; }

        /// <summary>
        /// Gets or Sets PlayNumber
        /// </summary>
        [JsonPropertyName("playNumber")]
        public int? PlayNumber { get; set; }

        /// <summary>
        /// Gets or Sets OffenseConference
        /// </summary>
        [JsonPropertyName("offenseConference")]
        public string? OffenseConference { get; set; }

        /// <summary>
        /// Gets or Sets DefenseConference
        /// </summary>
        [JsonPropertyName("defenseConference")]
        public string? DefenseConference { get; set; }

        /// <summary>
        /// Gets or Sets OffenseTimeouts
        /// </summary>
        [JsonPropertyName("offenseTimeouts")]
        public int? OffenseTimeouts { get; set; }

        /// <summary>
        /// Gets or Sets DefenseTimeouts
        /// </summary>
        [JsonPropertyName("defenseTimeouts")]
        public int? DefenseTimeouts { get; set; }

        /// <summary>
        /// Gets or Sets PlayText
        /// </summary>
        [JsonPropertyName("playText")]
        public string? PlayText { get; set; }

        /// <summary>
        /// Gets or Sets Ppa
        /// </summary>
        [JsonPropertyName("ppa")]
        public double? Ppa { get; set; }

        /// <summary>
        /// Gets or Sets Wallclock
        /// </summary>
        [JsonPropertyName("wallclock")]
        public string? Wallclock { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Play {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DriveId: ").Append(DriveId).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Offense: ").Append(Offense).Append("\n");
            sb.Append("  OffenseScore: ").Append(OffenseScore).Append("\n");
            sb.Append("  Defense: ").Append(Defense).Append("\n");
            sb.Append("  Home: ").Append(Home).Append("\n");
            sb.Append("  Away: ").Append(Away).Append("\n");
            sb.Append("  DefenseScore: ").Append(DefenseScore).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Clock: ").Append(Clock).Append("\n");
            sb.Append("  Yardline: ").Append(Yardline).Append("\n");
            sb.Append("  YardsToGoal: ").Append(YardsToGoal).Append("\n");
            sb.Append("  Down: ").Append(Down).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  YardsGained: ").Append(YardsGained).Append("\n");
            sb.Append("  Scoring: ").Append(Scoring).Append("\n");
            sb.Append("  PlayType: ").Append(PlayType).Append("\n");
            sb.Append("  DriveNumber: ").Append(DriveNumber).Append("\n");
            sb.Append("  PlayNumber: ").Append(PlayNumber).Append("\n");
            sb.Append("  OffenseConference: ").Append(OffenseConference).Append("\n");
            sb.Append("  DefenseConference: ").Append(DefenseConference).Append("\n");
            sb.Append("  OffenseTimeouts: ").Append(OffenseTimeouts).Append("\n");
            sb.Append("  DefenseTimeouts: ").Append(DefenseTimeouts).Append("\n");
            sb.Append("  PlayText: ").Append(PlayText).Append("\n");
            sb.Append("  Ppa: ").Append(Ppa).Append("\n");
            sb.Append("  Wallclock: ").Append(Wallclock).Append("\n");
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
    /// A Json converter for type <see cref="Play" />
    /// </summary>
    public class PlayJsonConverter : JsonConverter<Play>
    {
        /// <summary>
        /// Deserializes json to <see cref="Play" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Play Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<string?> driveId = default;
            Option<int?> gameId = default;
            Option<string?> offense = default;
            Option<int?> offenseScore = default;
            Option<string?> defense = default;
            Option<string?> home = default;
            Option<string?> away = default;
            Option<int?> defenseScore = default;
            Option<int?> period = default;
            Option<PlayClock?> clock = default;
            Option<int?> yardline = default;
            Option<int?> yardsToGoal = default;
            Option<int?> down = default;
            Option<int?> distance = default;
            Option<int?> yardsGained = default;
            Option<bool?> scoring = default;
            Option<string?> playType = default;
            Option<int?> driveNumber = default;
            Option<int?> playNumber = default;
            Option<string?> offenseConference = default;
            Option<string?> defenseConference = default;
            Option<int?> offenseTimeouts = default;
            Option<int?> defenseTimeouts = default;
            Option<string?> playText = default;
            Option<double?> ppa = default;
            Option<string?> wallclock = default;

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
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "driveId":
                            driveId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "gameId":
                            gameId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "offense":
                            offense = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "offenseScore":
                            offenseScore = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "defense":
                            defense = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "home":
                            home = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "away":
                            away = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "defenseScore":
                            defenseScore = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "period":
                            period = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "clock":
                            clock = new Option<PlayClock?>(JsonSerializer.Deserialize<PlayClock>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "yardline":
                            yardline = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "yardsToGoal":
                            yardsToGoal = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "down":
                            down = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "distance":
                            distance = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "yardsGained":
                            yardsGained = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "scoring":
                            scoring = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "playType":
                            playType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "driveNumber":
                            driveNumber = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "playNumber":
                            playNumber = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "offenseConference":
                            offenseConference = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "defenseConference":
                            defenseConference = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "offenseTimeouts":
                            offenseTimeouts = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "defenseTimeouts":
                            defenseTimeouts = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "playText":
                            playText = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "ppa":
                            ppa = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "wallclock":
                            wallclock = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(id));

            if (!driveId.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(driveId));

            if (!gameId.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(gameId));

            if (!offense.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(offense));

            if (!offenseScore.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(offenseScore));

            if (!defense.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(defense));

            if (!home.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(home));

            if (!away.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(away));

            if (!defenseScore.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(defenseScore));

            if (!period.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(period));

            if (!clock.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(clock));

            if (!yardline.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(yardline));

            if (!yardsToGoal.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(yardsToGoal));

            if (!down.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(down));

            if (!distance.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(distance));

            if (!yardsGained.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(yardsGained));

            if (!scoring.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(scoring));

            if (!playType.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(playType));

            if (!driveNumber.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(driveNumber));

            if (!playNumber.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(playNumber));

            if (!offenseConference.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(offenseConference));

            if (!defenseConference.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(defenseConference));

            if (!offenseTimeouts.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(offenseTimeouts));

            if (!defenseTimeouts.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(defenseTimeouts));

            if (!playText.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(playText));

            if (!ppa.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(ppa));

            if (!wallclock.IsSet)
                throw new ArgumentException("Property is required for class Play.", nameof(wallclock));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class Play.");

            if (driveId.IsSet && driveId.Value == null)
                throw new ArgumentNullException(nameof(driveId), "Property is not nullable for class Play.");

            if (gameId.IsSet && gameId.Value == null)
                throw new ArgumentNullException(nameof(gameId), "Property is not nullable for class Play.");

            if (offense.IsSet && offense.Value == null)
                throw new ArgumentNullException(nameof(offense), "Property is not nullable for class Play.");

            if (offenseScore.IsSet && offenseScore.Value == null)
                throw new ArgumentNullException(nameof(offenseScore), "Property is not nullable for class Play.");

            if (defense.IsSet && defense.Value == null)
                throw new ArgumentNullException(nameof(defense), "Property is not nullable for class Play.");

            if (home.IsSet && home.Value == null)
                throw new ArgumentNullException(nameof(home), "Property is not nullable for class Play.");

            if (away.IsSet && away.Value == null)
                throw new ArgumentNullException(nameof(away), "Property is not nullable for class Play.");

            if (defenseScore.IsSet && defenseScore.Value == null)
                throw new ArgumentNullException(nameof(defenseScore), "Property is not nullable for class Play.");

            if (period.IsSet && period.Value == null)
                throw new ArgumentNullException(nameof(period), "Property is not nullable for class Play.");

            if (clock.IsSet && clock.Value == null)
                throw new ArgumentNullException(nameof(clock), "Property is not nullable for class Play.");

            if (yardline.IsSet && yardline.Value == null)
                throw new ArgumentNullException(nameof(yardline), "Property is not nullable for class Play.");

            if (yardsToGoal.IsSet && yardsToGoal.Value == null)
                throw new ArgumentNullException(nameof(yardsToGoal), "Property is not nullable for class Play.");

            if (down.IsSet && down.Value == null)
                throw new ArgumentNullException(nameof(down), "Property is not nullable for class Play.");

            if (distance.IsSet && distance.Value == null)
                throw new ArgumentNullException(nameof(distance), "Property is not nullable for class Play.");

            if (yardsGained.IsSet && yardsGained.Value == null)
                throw new ArgumentNullException(nameof(yardsGained), "Property is not nullable for class Play.");

            if (scoring.IsSet && scoring.Value == null)
                throw new ArgumentNullException(nameof(scoring), "Property is not nullable for class Play.");

            if (playType.IsSet && playType.Value == null)
                throw new ArgumentNullException(nameof(playType), "Property is not nullable for class Play.");

            return new Play(id.Value!, driveId.Value!, gameId.Value!.Value!, offense.Value!, offenseScore.Value!.Value!, defense.Value!, home.Value!, away.Value!, defenseScore.Value!.Value!, period.Value!.Value!, clock.Value!, yardline.Value!.Value!, yardsToGoal.Value!.Value!, down.Value!.Value!, distance.Value!.Value!, yardsGained.Value!.Value!, scoring.Value!.Value!, playType.Value!, driveNumber.Value!, playNumber.Value!, offenseConference.Value!, defenseConference.Value!, offenseTimeouts.Value!, defenseTimeouts.Value!, playText.Value!, ppa.Value!, wallclock.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="Play" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="play"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Play play, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, play, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Play" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="play"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Play play, JsonSerializerOptions jsonSerializerOptions)
        {
            if (play.Id == null)
                throw new ArgumentNullException(nameof(play.Id), "Property is required for class Play.");

            if (play.DriveId == null)
                throw new ArgumentNullException(nameof(play.DriveId), "Property is required for class Play.");

            if (play.Offense == null)
                throw new ArgumentNullException(nameof(play.Offense), "Property is required for class Play.");

            if (play.Defense == null)
                throw new ArgumentNullException(nameof(play.Defense), "Property is required for class Play.");

            if (play.Home == null)
                throw new ArgumentNullException(nameof(play.Home), "Property is required for class Play.");

            if (play.Away == null)
                throw new ArgumentNullException(nameof(play.Away), "Property is required for class Play.");

            if (play.Clock == null)
                throw new ArgumentNullException(nameof(play.Clock), "Property is required for class Play.");

            if (play.PlayType == null)
                throw new ArgumentNullException(nameof(play.PlayType), "Property is required for class Play.");

            writer.WriteString("id", play.Id);

            writer.WriteString("driveId", play.DriveId);

            writer.WriteNumber("gameId", play.GameId);

            writer.WriteString("offense", play.Offense);

            writer.WriteNumber("offenseScore", play.OffenseScore);

            writer.WriteString("defense", play.Defense);

            writer.WriteString("home", play.Home);

            writer.WriteString("away", play.Away);

            writer.WriteNumber("defenseScore", play.DefenseScore);

            writer.WriteNumber("period", play.Period);

            writer.WritePropertyName("clock");
            JsonSerializer.Serialize(writer, play.Clock, jsonSerializerOptions);
            writer.WriteNumber("yardline", play.Yardline);

            writer.WriteNumber("yardsToGoal", play.YardsToGoal);

            writer.WriteNumber("down", play.Down);

            writer.WriteNumber("distance", play.Distance);

            writer.WriteNumber("yardsGained", play.YardsGained);

            writer.WriteBoolean("scoring", play.Scoring);

            writer.WriteString("playType", play.PlayType);

            if (play.DriveNumber != null)
                writer.WriteNumber("driveNumber", play.DriveNumber.Value);
            else
                writer.WriteNull("driveNumber");

            if (play.PlayNumber != null)
                writer.WriteNumber("playNumber", play.PlayNumber.Value);
            else
                writer.WriteNull("playNumber");

            if (play.OffenseConference != null)
                writer.WriteString("offenseConference", play.OffenseConference);
            else
                writer.WriteNull("offenseConference");

            if (play.DefenseConference != null)
                writer.WriteString("defenseConference", play.DefenseConference);
            else
                writer.WriteNull("defenseConference");

            if (play.OffenseTimeouts != null)
                writer.WriteNumber("offenseTimeouts", play.OffenseTimeouts.Value);
            else
                writer.WriteNull("offenseTimeouts");

            if (play.DefenseTimeouts != null)
                writer.WriteNumber("defenseTimeouts", play.DefenseTimeouts.Value);
            else
                writer.WriteNull("defenseTimeouts");

            if (play.PlayText != null)
                writer.WriteString("playText", play.PlayText);
            else
                writer.WriteNull("playText");

            if (play.Ppa != null)
                writer.WriteNumber("ppa", play.Ppa.Value);
            else
                writer.WriteNull("ppa");

            if (play.Wallclock != null)
                writer.WriteString("wallclock", play.Wallclock);
            else
                writer.WriteNull("wallclock");
        }
    }
}

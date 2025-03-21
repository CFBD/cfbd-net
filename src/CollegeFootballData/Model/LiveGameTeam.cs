// <auto-generated>
/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.8
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
    /// LiveGameTeam
    /// </summary>
    public partial class LiveGameTeam : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LiveGameTeam" /> class.
        /// </summary>
        /// <param name="teamId">teamId</param>
        /// <param name="team">team</param>
        /// <param name="homeAway">homeAway</param>
        /// <param name="lineScores">lineScores</param>
        /// <param name="points">points</param>
        /// <param name="drives">drives</param>
        /// <param name="scoringOpportunities">scoringOpportunities</param>
        /// <param name="pointsPerOpportunity">pointsPerOpportunity</param>
        /// <param name="plays">plays</param>
        /// <param name="lineYards">lineYards</param>
        /// <param name="lineYardsPerRush">lineYardsPerRush</param>
        /// <param name="secondLevelYards">secondLevelYards</param>
        /// <param name="secondLevelYardsPerRush">secondLevelYardsPerRush</param>
        /// <param name="openFieldYards">openFieldYards</param>
        /// <param name="openFieldYardsPerRush">openFieldYardsPerRush</param>
        /// <param name="epaPerPlay">epaPerPlay</param>
        /// <param name="totalEpa">totalEpa</param>
        /// <param name="passingEpa">passingEpa</param>
        /// <param name="epaPerPass">epaPerPass</param>
        /// <param name="rushingEpa">rushingEpa</param>
        /// <param name="epaPerRush">epaPerRush</param>
        /// <param name="successRate">successRate</param>
        /// <param name="standardDownSuccessRate">standardDownSuccessRate</param>
        /// <param name="passingDownSuccessRate">passingDownSuccessRate</param>
        /// <param name="explosiveness">explosiveness</param>
        [JsonConstructor]
        public LiveGameTeam(int teamId, string team, HomeAwayEnum homeAway, List<int> lineScores, int points, int drives, int scoringOpportunities, double pointsPerOpportunity, int plays, double lineYards, double lineYardsPerRush, double secondLevelYards, double secondLevelYardsPerRush, double openFieldYards, double openFieldYardsPerRush, double epaPerPlay, double totalEpa, double passingEpa, double epaPerPass, double rushingEpa, double epaPerRush, double successRate, double standardDownSuccessRate, double passingDownSuccessRate, double explosiveness)
        {
            TeamId = teamId;
            Team = team;
            HomeAway = homeAway;
            LineScores = lineScores;
            Points = points;
            Drives = drives;
            ScoringOpportunities = scoringOpportunities;
            PointsPerOpportunity = pointsPerOpportunity;
            Plays = plays;
            LineYards = lineYards;
            LineYardsPerRush = lineYardsPerRush;
            SecondLevelYards = secondLevelYards;
            SecondLevelYardsPerRush = secondLevelYardsPerRush;
            OpenFieldYards = openFieldYards;
            OpenFieldYardsPerRush = openFieldYardsPerRush;
            EpaPerPlay = epaPerPlay;
            TotalEpa = totalEpa;
            PassingEpa = passingEpa;
            EpaPerPass = epaPerPass;
            RushingEpa = rushingEpa;
            EpaPerRush = epaPerRush;
            SuccessRate = successRate;
            StandardDownSuccessRate = standardDownSuccessRate;
            PassingDownSuccessRate = passingDownSuccessRate;
            Explosiveness = explosiveness;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines HomeAway
        /// </summary>
        public enum HomeAwayEnum
        {
            /// <summary>
            /// Enum Home for value: home
            /// </summary>
            Home = 1,

            /// <summary>
            /// Enum Away for value: away
            /// </summary>
            Away = 2
        }

        /// <summary>
        /// Returns a <see cref="HomeAwayEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static HomeAwayEnum HomeAwayEnumFromString(string value)
        {
            if (value.Equals("home"))
                return HomeAwayEnum.Home;

            if (value.Equals("away"))
                return HomeAwayEnum.Away;

            throw new NotImplementedException($"Could not convert value to type HomeAwayEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="HomeAwayEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static HomeAwayEnum? HomeAwayEnumFromStringOrDefault(string value)
        {
            if (value.Equals("home"))
                return HomeAwayEnum.Home;

            if (value.Equals("away"))
                return HomeAwayEnum.Away;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="HomeAwayEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string HomeAwayEnumToJsonValue(HomeAwayEnum value)
        {
            if (value == HomeAwayEnum.Home)
                return "home";

            if (value == HomeAwayEnum.Away)
                return "away";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets HomeAway
        /// </summary>
        [JsonPropertyName("homeAway")]
        public HomeAwayEnum HomeAway { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [JsonPropertyName("teamId")]
        public int TeamId { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [JsonPropertyName("team")]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets LineScores
        /// </summary>
        [JsonPropertyName("lineScores")]
        public List<int> LineScores { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [JsonPropertyName("points")]
        public int Points { get; set; }

        /// <summary>
        /// Gets or Sets Drives
        /// </summary>
        [JsonPropertyName("drives")]
        public int Drives { get; set; }

        /// <summary>
        /// Gets or Sets ScoringOpportunities
        /// </summary>
        [JsonPropertyName("scoringOpportunities")]
        public int ScoringOpportunities { get; set; }

        /// <summary>
        /// Gets or Sets PointsPerOpportunity
        /// </summary>
        [JsonPropertyName("pointsPerOpportunity")]
        public double PointsPerOpportunity { get; set; }

        /// <summary>
        /// Gets or Sets Plays
        /// </summary>
        [JsonPropertyName("plays")]
        public int Plays { get; set; }

        /// <summary>
        /// Gets or Sets LineYards
        /// </summary>
        [JsonPropertyName("lineYards")]
        public double LineYards { get; set; }

        /// <summary>
        /// Gets or Sets LineYardsPerRush
        /// </summary>
        [JsonPropertyName("lineYardsPerRush")]
        public double LineYardsPerRush { get; set; }

        /// <summary>
        /// Gets or Sets SecondLevelYards
        /// </summary>
        [JsonPropertyName("secondLevelYards")]
        public double SecondLevelYards { get; set; }

        /// <summary>
        /// Gets or Sets SecondLevelYardsPerRush
        /// </summary>
        [JsonPropertyName("secondLevelYardsPerRush")]
        public double SecondLevelYardsPerRush { get; set; }

        /// <summary>
        /// Gets or Sets OpenFieldYards
        /// </summary>
        [JsonPropertyName("openFieldYards")]
        public double OpenFieldYards { get; set; }

        /// <summary>
        /// Gets or Sets OpenFieldYardsPerRush
        /// </summary>
        [JsonPropertyName("openFieldYardsPerRush")]
        public double OpenFieldYardsPerRush { get; set; }

        /// <summary>
        /// Gets or Sets EpaPerPlay
        /// </summary>
        [JsonPropertyName("epaPerPlay")]
        public double EpaPerPlay { get; set; }

        /// <summary>
        /// Gets or Sets TotalEpa
        /// </summary>
        [JsonPropertyName("totalEpa")]
        public double TotalEpa { get; set; }

        /// <summary>
        /// Gets or Sets PassingEpa
        /// </summary>
        [JsonPropertyName("passingEpa")]
        public double PassingEpa { get; set; }

        /// <summary>
        /// Gets or Sets EpaPerPass
        /// </summary>
        [JsonPropertyName("epaPerPass")]
        public double EpaPerPass { get; set; }

        /// <summary>
        /// Gets or Sets RushingEpa
        /// </summary>
        [JsonPropertyName("rushingEpa")]
        public double RushingEpa { get; set; }

        /// <summary>
        /// Gets or Sets EpaPerRush
        /// </summary>
        [JsonPropertyName("epaPerRush")]
        public double EpaPerRush { get; set; }

        /// <summary>
        /// Gets or Sets SuccessRate
        /// </summary>
        [JsonPropertyName("successRate")]
        public double SuccessRate { get; set; }

        /// <summary>
        /// Gets or Sets StandardDownSuccessRate
        /// </summary>
        [JsonPropertyName("standardDownSuccessRate")]
        public double StandardDownSuccessRate { get; set; }

        /// <summary>
        /// Gets or Sets PassingDownSuccessRate
        /// </summary>
        [JsonPropertyName("passingDownSuccessRate")]
        public double PassingDownSuccessRate { get; set; }

        /// <summary>
        /// Gets or Sets Explosiveness
        /// </summary>
        [JsonPropertyName("explosiveness")]
        public double Explosiveness { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LiveGameTeam {\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  HomeAway: ").Append(HomeAway).Append("\n");
            sb.Append("  LineScores: ").Append(LineScores).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  Drives: ").Append(Drives).Append("\n");
            sb.Append("  ScoringOpportunities: ").Append(ScoringOpportunities).Append("\n");
            sb.Append("  PointsPerOpportunity: ").Append(PointsPerOpportunity).Append("\n");
            sb.Append("  Plays: ").Append(Plays).Append("\n");
            sb.Append("  LineYards: ").Append(LineYards).Append("\n");
            sb.Append("  LineYardsPerRush: ").Append(LineYardsPerRush).Append("\n");
            sb.Append("  SecondLevelYards: ").Append(SecondLevelYards).Append("\n");
            sb.Append("  SecondLevelYardsPerRush: ").Append(SecondLevelYardsPerRush).Append("\n");
            sb.Append("  OpenFieldYards: ").Append(OpenFieldYards).Append("\n");
            sb.Append("  OpenFieldYardsPerRush: ").Append(OpenFieldYardsPerRush).Append("\n");
            sb.Append("  EpaPerPlay: ").Append(EpaPerPlay).Append("\n");
            sb.Append("  TotalEpa: ").Append(TotalEpa).Append("\n");
            sb.Append("  PassingEpa: ").Append(PassingEpa).Append("\n");
            sb.Append("  EpaPerPass: ").Append(EpaPerPass).Append("\n");
            sb.Append("  RushingEpa: ").Append(RushingEpa).Append("\n");
            sb.Append("  EpaPerRush: ").Append(EpaPerRush).Append("\n");
            sb.Append("  SuccessRate: ").Append(SuccessRate).Append("\n");
            sb.Append("  StandardDownSuccessRate: ").Append(StandardDownSuccessRate).Append("\n");
            sb.Append("  PassingDownSuccessRate: ").Append(PassingDownSuccessRate).Append("\n");
            sb.Append("  Explosiveness: ").Append(Explosiveness).Append("\n");
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
    /// A Json converter for type <see cref="LiveGameTeam" />
    /// </summary>
    public class LiveGameTeamJsonConverter : JsonConverter<LiveGameTeam>
    {
        /// <summary>
        /// Deserializes json to <see cref="LiveGameTeam" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override LiveGameTeam Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> teamId = default;
            Option<string?> team = default;
            Option<LiveGameTeam.HomeAwayEnum?> homeAway = default;
            Option<List<int>?> lineScores = default;
            Option<int?> points = default;
            Option<int?> drives = default;
            Option<int?> scoringOpportunities = default;
            Option<double?> pointsPerOpportunity = default;
            Option<int?> plays = default;
            Option<double?> lineYards = default;
            Option<double?> lineYardsPerRush = default;
            Option<double?> secondLevelYards = default;
            Option<double?> secondLevelYardsPerRush = default;
            Option<double?> openFieldYards = default;
            Option<double?> openFieldYardsPerRush = default;
            Option<double?> epaPerPlay = default;
            Option<double?> totalEpa = default;
            Option<double?> passingEpa = default;
            Option<double?> epaPerPass = default;
            Option<double?> rushingEpa = default;
            Option<double?> epaPerRush = default;
            Option<double?> successRate = default;
            Option<double?> standardDownSuccessRate = default;
            Option<double?> passingDownSuccessRate = default;
            Option<double?> explosiveness = default;

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
                        case "teamId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                teamId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "team":
                            team = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "homeAway":
                            string? homeAwayRawValue = utf8JsonReader.GetString();
                            if (homeAwayRawValue != null)
                                homeAway = new Option<LiveGameTeam.HomeAwayEnum?>(LiveGameTeam.HomeAwayEnumFromStringOrDefault(homeAwayRawValue));
                            break;
                        case "lineScores":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lineScores = new Option<List<int>?>(JsonSerializer.Deserialize<List<int>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "points":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                points = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "drives":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                drives = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "scoringOpportunities":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                scoringOpportunities = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "pointsPerOpportunity":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                pointsPerOpportunity = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "plays":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                plays = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "lineYards":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lineYards = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "lineYardsPerRush":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lineYardsPerRush = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "secondLevelYards":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                secondLevelYards = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "secondLevelYardsPerRush":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                secondLevelYardsPerRush = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "openFieldYards":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                openFieldYards = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "openFieldYardsPerRush":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                openFieldYardsPerRush = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "epaPerPlay":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                epaPerPlay = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "totalEpa":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                totalEpa = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "passingEpa":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                passingEpa = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "epaPerPass":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                epaPerPass = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "rushingEpa":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rushingEpa = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "epaPerRush":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                epaPerRush = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "successRate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                successRate = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "standardDownSuccessRate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                standardDownSuccessRate = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "passingDownSuccessRate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                passingDownSuccessRate = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "explosiveness":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                explosiveness = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!teamId.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(teamId));

            if (!team.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(team));

            if (!homeAway.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(homeAway));

            if (!lineScores.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(lineScores));

            if (!points.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(points));

            if (!drives.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(drives));

            if (!scoringOpportunities.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(scoringOpportunities));

            if (!pointsPerOpportunity.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(pointsPerOpportunity));

            if (!plays.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(plays));

            if (!lineYards.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(lineYards));

            if (!lineYardsPerRush.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(lineYardsPerRush));

            if (!secondLevelYards.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(secondLevelYards));

            if (!secondLevelYardsPerRush.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(secondLevelYardsPerRush));

            if (!openFieldYards.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(openFieldYards));

            if (!openFieldYardsPerRush.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(openFieldYardsPerRush));

            if (!epaPerPlay.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(epaPerPlay));

            if (!totalEpa.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(totalEpa));

            if (!passingEpa.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(passingEpa));

            if (!epaPerPass.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(epaPerPass));

            if (!rushingEpa.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(rushingEpa));

            if (!epaPerRush.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(epaPerRush));

            if (!successRate.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(successRate));

            if (!standardDownSuccessRate.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(standardDownSuccessRate));

            if (!passingDownSuccessRate.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(passingDownSuccessRate));

            if (!explosiveness.IsSet)
                throw new ArgumentException("Property is required for class LiveGameTeam.", nameof(explosiveness));

            if (teamId.IsSet && teamId.Value == null)
                throw new ArgumentNullException(nameof(teamId), "Property is not nullable for class LiveGameTeam.");

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team), "Property is not nullable for class LiveGameTeam.");

            if (homeAway.IsSet && homeAway.Value == null)
                throw new ArgumentNullException(nameof(homeAway), "Property is not nullable for class LiveGameTeam.");

            if (lineScores.IsSet && lineScores.Value == null)
                throw new ArgumentNullException(nameof(lineScores), "Property is not nullable for class LiveGameTeam.");

            if (points.IsSet && points.Value == null)
                throw new ArgumentNullException(nameof(points), "Property is not nullable for class LiveGameTeam.");

            if (drives.IsSet && drives.Value == null)
                throw new ArgumentNullException(nameof(drives), "Property is not nullable for class LiveGameTeam.");

            if (scoringOpportunities.IsSet && scoringOpportunities.Value == null)
                throw new ArgumentNullException(nameof(scoringOpportunities), "Property is not nullable for class LiveGameTeam.");

            if (pointsPerOpportunity.IsSet && pointsPerOpportunity.Value == null)
                throw new ArgumentNullException(nameof(pointsPerOpportunity), "Property is not nullable for class LiveGameTeam.");

            if (plays.IsSet && plays.Value == null)
                throw new ArgumentNullException(nameof(plays), "Property is not nullable for class LiveGameTeam.");

            if (lineYards.IsSet && lineYards.Value == null)
                throw new ArgumentNullException(nameof(lineYards), "Property is not nullable for class LiveGameTeam.");

            if (lineYardsPerRush.IsSet && lineYardsPerRush.Value == null)
                throw new ArgumentNullException(nameof(lineYardsPerRush), "Property is not nullable for class LiveGameTeam.");

            if (secondLevelYards.IsSet && secondLevelYards.Value == null)
                throw new ArgumentNullException(nameof(secondLevelYards), "Property is not nullable for class LiveGameTeam.");

            if (secondLevelYardsPerRush.IsSet && secondLevelYardsPerRush.Value == null)
                throw new ArgumentNullException(nameof(secondLevelYardsPerRush), "Property is not nullable for class LiveGameTeam.");

            if (openFieldYards.IsSet && openFieldYards.Value == null)
                throw new ArgumentNullException(nameof(openFieldYards), "Property is not nullable for class LiveGameTeam.");

            if (openFieldYardsPerRush.IsSet && openFieldYardsPerRush.Value == null)
                throw new ArgumentNullException(nameof(openFieldYardsPerRush), "Property is not nullable for class LiveGameTeam.");

            if (epaPerPlay.IsSet && epaPerPlay.Value == null)
                throw new ArgumentNullException(nameof(epaPerPlay), "Property is not nullable for class LiveGameTeam.");

            if (totalEpa.IsSet && totalEpa.Value == null)
                throw new ArgumentNullException(nameof(totalEpa), "Property is not nullable for class LiveGameTeam.");

            if (passingEpa.IsSet && passingEpa.Value == null)
                throw new ArgumentNullException(nameof(passingEpa), "Property is not nullable for class LiveGameTeam.");

            if (epaPerPass.IsSet && epaPerPass.Value == null)
                throw new ArgumentNullException(nameof(epaPerPass), "Property is not nullable for class LiveGameTeam.");

            if (rushingEpa.IsSet && rushingEpa.Value == null)
                throw new ArgumentNullException(nameof(rushingEpa), "Property is not nullable for class LiveGameTeam.");

            if (epaPerRush.IsSet && epaPerRush.Value == null)
                throw new ArgumentNullException(nameof(epaPerRush), "Property is not nullable for class LiveGameTeam.");

            if (successRate.IsSet && successRate.Value == null)
                throw new ArgumentNullException(nameof(successRate), "Property is not nullable for class LiveGameTeam.");

            if (standardDownSuccessRate.IsSet && standardDownSuccessRate.Value == null)
                throw new ArgumentNullException(nameof(standardDownSuccessRate), "Property is not nullable for class LiveGameTeam.");

            if (passingDownSuccessRate.IsSet && passingDownSuccessRate.Value == null)
                throw new ArgumentNullException(nameof(passingDownSuccessRate), "Property is not nullable for class LiveGameTeam.");

            if (explosiveness.IsSet && explosiveness.Value == null)
                throw new ArgumentNullException(nameof(explosiveness), "Property is not nullable for class LiveGameTeam.");

            return new LiveGameTeam(teamId.Value!.Value!, team.Value!, homeAway.Value!.Value!, lineScores.Value!, points.Value!.Value!, drives.Value!.Value!, scoringOpportunities.Value!.Value!, pointsPerOpportunity.Value!.Value!, plays.Value!.Value!, lineYards.Value!.Value!, lineYardsPerRush.Value!.Value!, secondLevelYards.Value!.Value!, secondLevelYardsPerRush.Value!.Value!, openFieldYards.Value!.Value!, openFieldYardsPerRush.Value!.Value!, epaPerPlay.Value!.Value!, totalEpa.Value!.Value!, passingEpa.Value!.Value!, epaPerPass.Value!.Value!, rushingEpa.Value!.Value!, epaPerRush.Value!.Value!, successRate.Value!.Value!, standardDownSuccessRate.Value!.Value!, passingDownSuccessRate.Value!.Value!, explosiveness.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="LiveGameTeam" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="liveGameTeam"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, LiveGameTeam liveGameTeam, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, liveGameTeam, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="LiveGameTeam" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="liveGameTeam"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, LiveGameTeam liveGameTeam, JsonSerializerOptions jsonSerializerOptions)
        {
            if (liveGameTeam.Team == null)
                throw new ArgumentNullException(nameof(liveGameTeam.Team), "Property is required for class LiveGameTeam.");

            if (liveGameTeam.LineScores == null)
                throw new ArgumentNullException(nameof(liveGameTeam.LineScores), "Property is required for class LiveGameTeam.");

            writer.WriteNumber("teamId", liveGameTeam.TeamId);

            writer.WriteString("team", liveGameTeam.Team);

            var homeAwayRawValue = LiveGameTeam.HomeAwayEnumToJsonValue(liveGameTeam.HomeAway);
            writer.WriteString("homeAway", homeAwayRawValue);
            writer.WritePropertyName("lineScores");
            JsonSerializer.Serialize(writer, liveGameTeam.LineScores, jsonSerializerOptions);
            writer.WriteNumber("points", liveGameTeam.Points);

            writer.WriteNumber("drives", liveGameTeam.Drives);

            writer.WriteNumber("scoringOpportunities", liveGameTeam.ScoringOpportunities);

            writer.WriteNumber("pointsPerOpportunity", liveGameTeam.PointsPerOpportunity);

            writer.WriteNumber("plays", liveGameTeam.Plays);

            writer.WriteNumber("lineYards", liveGameTeam.LineYards);

            writer.WriteNumber("lineYardsPerRush", liveGameTeam.LineYardsPerRush);

            writer.WriteNumber("secondLevelYards", liveGameTeam.SecondLevelYards);

            writer.WriteNumber("secondLevelYardsPerRush", liveGameTeam.SecondLevelYardsPerRush);

            writer.WriteNumber("openFieldYards", liveGameTeam.OpenFieldYards);

            writer.WriteNumber("openFieldYardsPerRush", liveGameTeam.OpenFieldYardsPerRush);

            writer.WriteNumber("epaPerPlay", liveGameTeam.EpaPerPlay);

            writer.WriteNumber("totalEpa", liveGameTeam.TotalEpa);

            writer.WriteNumber("passingEpa", liveGameTeam.PassingEpa);

            writer.WriteNumber("epaPerPass", liveGameTeam.EpaPerPass);

            writer.WriteNumber("rushingEpa", liveGameTeam.RushingEpa);

            writer.WriteNumber("epaPerRush", liveGameTeam.EpaPerRush);

            writer.WriteNumber("successRate", liveGameTeam.SuccessRate);

            writer.WriteNumber("standardDownSuccessRate", liveGameTeam.StandardDownSuccessRate);

            writer.WriteNumber("passingDownSuccessRate", liveGameTeam.PassingDownSuccessRate);

            writer.WriteNumber("explosiveness", liveGameTeam.Explosiveness);
        }
    }
}

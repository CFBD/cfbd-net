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
    /// DraftPick
    /// </summary>
    public partial class DraftPick : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DraftPick" /> class.
        /// </summary>
        /// <param name="nflAthleteId">nflAthleteId</param>
        /// <param name="collegeId">collegeId</param>
        /// <param name="collegeTeam">collegeTeam</param>
        /// <param name="nflTeamId">nflTeamId</param>
        /// <param name="nflTeam">nflTeam</param>
        /// <param name="year">year</param>
        /// <param name="overall">overall</param>
        /// <param name="round">round</param>
        /// <param name="pick">pick</param>
        /// <param name="name">name</param>
        /// <param name="position">position</param>
        /// <param name="hometownInfo">hometownInfo</param>
        /// <param name="collegeAthleteId">collegeAthleteId</param>
        /// <param name="collegeConference">collegeConference</param>
        /// <param name="height">height</param>
        /// <param name="weight">weight</param>
        /// <param name="preDraftRanking">preDraftRanking</param>
        /// <param name="preDraftPositionRanking">preDraftPositionRanking</param>
        /// <param name="preDraftGrade">preDraftGrade</param>
        [JsonConstructor]
        public DraftPick(int nflAthleteId, int collegeId, string collegeTeam, int nflTeamId, string nflTeam, int year, int overall, int round, int pick, string name, string position, DraftPickHometownInfo hometownInfo, int? collegeAthleteId = default, string? collegeConference = default, int? height = default, int? weight = default, int? preDraftRanking = default, int? preDraftPositionRanking = default, int? preDraftGrade = default)
        {
            NflAthleteId = nflAthleteId;
            CollegeId = collegeId;
            CollegeTeam = collegeTeam;
            NflTeamId = nflTeamId;
            NflTeam = nflTeam;
            Year = year;
            Overall = overall;
            Round = round;
            Pick = pick;
            Name = name;
            Position = position;
            HometownInfo = hometownInfo;
            CollegeAthleteId = collegeAthleteId;
            CollegeConference = collegeConference;
            Height = height;
            Weight = weight;
            PreDraftRanking = preDraftRanking;
            PreDraftPositionRanking = preDraftPositionRanking;
            PreDraftGrade = preDraftGrade;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets NflAthleteId
        /// </summary>
        [JsonPropertyName("nflAthleteId")]
        public int NflAthleteId { get; set; }

        /// <summary>
        /// Gets or Sets CollegeId
        /// </summary>
        [JsonPropertyName("collegeId")]
        public int CollegeId { get; set; }

        /// <summary>
        /// Gets or Sets CollegeTeam
        /// </summary>
        [JsonPropertyName("collegeTeam")]
        public string CollegeTeam { get; set; }

        /// <summary>
        /// Gets or Sets NflTeamId
        /// </summary>
        [JsonPropertyName("nflTeamId")]
        public int NflTeamId { get; set; }

        /// <summary>
        /// Gets or Sets NflTeam
        /// </summary>
        [JsonPropertyName("nflTeam")]
        public string NflTeam { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [JsonPropertyName("year")]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets Overall
        /// </summary>
        [JsonPropertyName("overall")]
        public int Overall { get; set; }

        /// <summary>
        /// Gets or Sets Round
        /// </summary>
        [JsonPropertyName("round")]
        public int Round { get; set; }

        /// <summary>
        /// Gets or Sets Pick
        /// </summary>
        [JsonPropertyName("pick")]
        public int Pick { get; set; }

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
        /// Gets or Sets HometownInfo
        /// </summary>
        [JsonPropertyName("hometownInfo")]
        public DraftPickHometownInfo HometownInfo { get; set; }

        /// <summary>
        /// Gets or Sets CollegeAthleteId
        /// </summary>
        [JsonPropertyName("collegeAthleteId")]
        public int? CollegeAthleteId { get; set; }

        /// <summary>
        /// Gets or Sets CollegeConference
        /// </summary>
        [JsonPropertyName("collegeConference")]
        public string? CollegeConference { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [JsonPropertyName("weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or Sets PreDraftRanking
        /// </summary>
        [JsonPropertyName("preDraftRanking")]
        public int? PreDraftRanking { get; set; }

        /// <summary>
        /// Gets or Sets PreDraftPositionRanking
        /// </summary>
        [JsonPropertyName("preDraftPositionRanking")]
        public int? PreDraftPositionRanking { get; set; }

        /// <summary>
        /// Gets or Sets PreDraftGrade
        /// </summary>
        [JsonPropertyName("preDraftGrade")]
        public int? PreDraftGrade { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DraftPick {\n");
            sb.Append("  NflAthleteId: ").Append(NflAthleteId).Append("\n");
            sb.Append("  CollegeId: ").Append(CollegeId).Append("\n");
            sb.Append("  CollegeTeam: ").Append(CollegeTeam).Append("\n");
            sb.Append("  NflTeamId: ").Append(NflTeamId).Append("\n");
            sb.Append("  NflTeam: ").Append(NflTeam).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Overall: ").Append(Overall).Append("\n");
            sb.Append("  Round: ").Append(Round).Append("\n");
            sb.Append("  Pick: ").Append(Pick).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  HometownInfo: ").Append(HometownInfo).Append("\n");
            sb.Append("  CollegeAthleteId: ").Append(CollegeAthleteId).Append("\n");
            sb.Append("  CollegeConference: ").Append(CollegeConference).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  PreDraftRanking: ").Append(PreDraftRanking).Append("\n");
            sb.Append("  PreDraftPositionRanking: ").Append(PreDraftPositionRanking).Append("\n");
            sb.Append("  PreDraftGrade: ").Append(PreDraftGrade).Append("\n");
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
    /// A Json converter for type <see cref="DraftPick" />
    /// </summary>
    public class DraftPickJsonConverter : JsonConverter<DraftPick>
    {
        /// <summary>
        /// Deserializes json to <see cref="DraftPick" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DraftPick Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> nflAthleteId = default;
            Option<int?> collegeId = default;
            Option<string?> collegeTeam = default;
            Option<int?> nflTeamId = default;
            Option<string?> nflTeam = default;
            Option<int?> year = default;
            Option<int?> overall = default;
            Option<int?> round = default;
            Option<int?> pick = default;
            Option<string?> name = default;
            Option<string?> position = default;
            Option<DraftPickHometownInfo?> hometownInfo = default;
            Option<int?> collegeAthleteId = default;
            Option<string?> collegeConference = default;
            Option<int?> height = default;
            Option<int?> weight = default;
            Option<int?> preDraftRanking = default;
            Option<int?> preDraftPositionRanking = default;
            Option<int?> preDraftGrade = default;

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
                        case "nflAthleteId":
                            nflAthleteId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "collegeId":
                            collegeId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "collegeTeam":
                            collegeTeam = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "nflTeamId":
                            nflTeamId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "nflTeam":
                            nflTeam = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "year":
                            year = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "overall":
                            overall = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "round":
                            round = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "pick":
                            pick = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "position":
                            position = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "hometownInfo":
                            hometownInfo = new Option<DraftPickHometownInfo?>(JsonSerializer.Deserialize<DraftPickHometownInfo>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "collegeAthleteId":
                            collegeAthleteId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "collegeConference":
                            collegeConference = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "height":
                            height = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "weight":
                            weight = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "preDraftRanking":
                            preDraftRanking = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "preDraftPositionRanking":
                            preDraftPositionRanking = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "preDraftGrade":
                            preDraftGrade = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!nflAthleteId.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(nflAthleteId));

            if (!collegeId.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(collegeId));

            if (!collegeTeam.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(collegeTeam));

            if (!nflTeamId.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(nflTeamId));

            if (!nflTeam.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(nflTeam));

            if (!year.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(year));

            if (!overall.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(overall));

            if (!round.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(round));

            if (!pick.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(pick));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(name));

            if (!position.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(position));

            if (!hometownInfo.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(hometownInfo));

            if (!collegeAthleteId.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(collegeAthleteId));

            if (!collegeConference.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(collegeConference));

            if (!height.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(height));

            if (!weight.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(weight));

            if (!preDraftRanking.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(preDraftRanking));

            if (!preDraftPositionRanking.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(preDraftPositionRanking));

            if (!preDraftGrade.IsSet)
                throw new ArgumentException("Property is required for class DraftPick.", nameof(preDraftGrade));

            if (nflAthleteId.IsSet && nflAthleteId.Value == null)
                throw new ArgumentNullException(nameof(nflAthleteId), "Property is not nullable for class DraftPick.");

            if (collegeId.IsSet && collegeId.Value == null)
                throw new ArgumentNullException(nameof(collegeId), "Property is not nullable for class DraftPick.");

            if (collegeTeam.IsSet && collegeTeam.Value == null)
                throw new ArgumentNullException(nameof(collegeTeam), "Property is not nullable for class DraftPick.");

            if (nflTeamId.IsSet && nflTeamId.Value == null)
                throw new ArgumentNullException(nameof(nflTeamId), "Property is not nullable for class DraftPick.");

            if (nflTeam.IsSet && nflTeam.Value == null)
                throw new ArgumentNullException(nameof(nflTeam), "Property is not nullable for class DraftPick.");

            if (year.IsSet && year.Value == null)
                throw new ArgumentNullException(nameof(year), "Property is not nullable for class DraftPick.");

            if (overall.IsSet && overall.Value == null)
                throw new ArgumentNullException(nameof(overall), "Property is not nullable for class DraftPick.");

            if (round.IsSet && round.Value == null)
                throw new ArgumentNullException(nameof(round), "Property is not nullable for class DraftPick.");

            if (pick.IsSet && pick.Value == null)
                throw new ArgumentNullException(nameof(pick), "Property is not nullable for class DraftPick.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class DraftPick.");

            if (position.IsSet && position.Value == null)
                throw new ArgumentNullException(nameof(position), "Property is not nullable for class DraftPick.");

            if (hometownInfo.IsSet && hometownInfo.Value == null)
                throw new ArgumentNullException(nameof(hometownInfo), "Property is not nullable for class DraftPick.");

            return new DraftPick(nflAthleteId.Value!.Value!, collegeId.Value!.Value!, collegeTeam.Value!, nflTeamId.Value!.Value!, nflTeam.Value!, year.Value!.Value!, overall.Value!.Value!, round.Value!.Value!, pick.Value!.Value!, name.Value!, position.Value!, hometownInfo.Value!, collegeAthleteId.Value!, collegeConference.Value!, height.Value!, weight.Value!, preDraftRanking.Value!, preDraftPositionRanking.Value!, preDraftGrade.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="DraftPick" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="draftPick"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DraftPick draftPick, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, draftPick, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DraftPick" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="draftPick"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DraftPick draftPick, JsonSerializerOptions jsonSerializerOptions)
        {
            if (draftPick.CollegeTeam == null)
                throw new ArgumentNullException(nameof(draftPick.CollegeTeam), "Property is required for class DraftPick.");

            if (draftPick.NflTeam == null)
                throw new ArgumentNullException(nameof(draftPick.NflTeam), "Property is required for class DraftPick.");

            if (draftPick.Name == null)
                throw new ArgumentNullException(nameof(draftPick.Name), "Property is required for class DraftPick.");

            if (draftPick.Position == null)
                throw new ArgumentNullException(nameof(draftPick.Position), "Property is required for class DraftPick.");

            if (draftPick.HometownInfo == null)
                throw new ArgumentNullException(nameof(draftPick.HometownInfo), "Property is required for class DraftPick.");

            writer.WriteNumber("nflAthleteId", draftPick.NflAthleteId);

            writer.WriteNumber("collegeId", draftPick.CollegeId);

            writer.WriteString("collegeTeam", draftPick.CollegeTeam);

            writer.WriteNumber("nflTeamId", draftPick.NflTeamId);

            writer.WriteString("nflTeam", draftPick.NflTeam);

            writer.WriteNumber("year", draftPick.Year);

            writer.WriteNumber("overall", draftPick.Overall);

            writer.WriteNumber("round", draftPick.Round);

            writer.WriteNumber("pick", draftPick.Pick);

            writer.WriteString("name", draftPick.Name);

            writer.WriteString("position", draftPick.Position);

            writer.WritePropertyName("hometownInfo");
            JsonSerializer.Serialize(writer, draftPick.HometownInfo, jsonSerializerOptions);
            if (draftPick.CollegeAthleteId != null)
                writer.WriteNumber("collegeAthleteId", draftPick.CollegeAthleteId.Value);
            else
                writer.WriteNull("collegeAthleteId");

            if (draftPick.CollegeConference != null)
                writer.WriteString("collegeConference", draftPick.CollegeConference);
            else
                writer.WriteNull("collegeConference");

            if (draftPick.Height != null)
                writer.WriteNumber("height", draftPick.Height.Value);
            else
                writer.WriteNull("height");

            if (draftPick.Weight != null)
                writer.WriteNumber("weight", draftPick.Weight.Value);
            else
                writer.WriteNull("weight");

            if (draftPick.PreDraftRanking != null)
                writer.WriteNumber("preDraftRanking", draftPick.PreDraftRanking.Value);
            else
                writer.WriteNull("preDraftRanking");

            if (draftPick.PreDraftPositionRanking != null)
                writer.WriteNumber("preDraftPositionRanking", draftPick.PreDraftPositionRanking.Value);
            else
                writer.WriteNull("preDraftPositionRanking");

            if (draftPick.PreDraftGrade != null)
                writer.WriteNumber("preDraftGrade", draftPick.PreDraftGrade.Value);
            else
                writer.WriteNull("preDraftGrade");
        }
    }
}

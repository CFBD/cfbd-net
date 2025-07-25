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
    /// Recruit
    /// </summary>
    public partial class Recruit : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Recruit" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="recruitType">recruitType</param>
        /// <param name="year">year</param>
        /// <param name="name">name</param>
        /// <param name="stars">stars</param>
        /// <param name="rating">rating</param>
        /// <param name="hometownInfo">hometownInfo</param>
        /// <param name="athleteId">athleteId</param>
        /// <param name="ranking">ranking</param>
        /// <param name="school">school</param>
        /// <param name="committedTo">committedTo</param>
        /// <param name="position">position</param>
        /// <param name="height">height</param>
        /// <param name="weight">weight</param>
        /// <param name="city">city</param>
        /// <param name="stateProvince">stateProvince</param>
        /// <param name="country">country</param>
        [JsonConstructor]
        public Recruit(string id, RecruitClassification recruitType, int year, string name, int stars, double rating, RecruitHometownInfo hometownInfo, string? athleteId = default, int? ranking = default, string? school = default, string? committedTo = default, string? position = default, int? height = default, int? weight = default, string? city = default, string? stateProvince = default, string? country = default)
        {
            Id = id;
            RecruitType = recruitType;
            Year = year;
            Name = name;
            Stars = stars;
            Rating = rating;
            HometownInfo = hometownInfo;
            AthleteId = athleteId;
            Ranking = ranking;
            School = school;
            CommittedTo = committedTo;
            Position = position;
            Height = height;
            Weight = weight;
            City = city;
            StateProvince = stateProvince;
            Country = country;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets RecruitType
        /// </summary>
        [JsonPropertyName("recruitType")]
        public RecruitClassification RecruitType { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [JsonPropertyName("year")]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Stars
        /// </summary>
        [JsonPropertyName("stars")]
        public int Stars { get; set; }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [JsonPropertyName("rating")]
        public double Rating { get; set; }

        /// <summary>
        /// Gets or Sets HometownInfo
        /// </summary>
        [JsonPropertyName("hometownInfo")]
        public RecruitHometownInfo HometownInfo { get; set; }

        /// <summary>
        /// Gets or Sets AthleteId
        /// </summary>
        [JsonPropertyName("athleteId")]
        public string? AthleteId { get; set; }

        /// <summary>
        /// Gets or Sets Ranking
        /// </summary>
        [JsonPropertyName("ranking")]
        public int? Ranking { get; set; }

        /// <summary>
        /// Gets or Sets School
        /// </summary>
        [JsonPropertyName("school")]
        public string? School { get; set; }

        /// <summary>
        /// Gets or Sets CommittedTo
        /// </summary>
        [JsonPropertyName("committedTo")]
        public string? CommittedTo { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [JsonPropertyName("position")]
        public string? Position { get; set; }

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
        /// Gets or Sets City
        /// </summary>
        [JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// Gets or Sets StateProvince
        /// </summary>
        [JsonPropertyName("stateProvince")]
        public string? StateProvince { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Recruit {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RecruitType: ").Append(RecruitType).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Stars: ").Append(Stars).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  HometownInfo: ").Append(HometownInfo).Append("\n");
            sb.Append("  AthleteId: ").Append(AthleteId).Append("\n");
            sb.Append("  Ranking: ").Append(Ranking).Append("\n");
            sb.Append("  School: ").Append(School).Append("\n");
            sb.Append("  CommittedTo: ").Append(CommittedTo).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
    /// A Json converter for type <see cref="Recruit" />
    /// </summary>
    public class RecruitJsonConverter : JsonConverter<Recruit>
    {
        /// <summary>
        /// Deserializes json to <see cref="Recruit" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Recruit Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<RecruitClassification?> recruitType = default;
            Option<int?> year = default;
            Option<string?> name = default;
            Option<int?> stars = default;
            Option<double?> rating = default;
            Option<RecruitHometownInfo?> hometownInfo = default;
            Option<string?> athleteId = default;
            Option<int?> ranking = default;
            Option<string?> school = default;
            Option<string?> committedTo = default;
            Option<string?> position = default;
            Option<int?> height = default;
            Option<int?> weight = default;
            Option<string?> city = default;
            Option<string?> stateProvince = default;
            Option<string?> country = default;

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
                        case "recruitType":
                            string? recruitTypeRawValue = utf8JsonReader.GetString();
                            if (recruitTypeRawValue != null)
                                recruitType = new Option<RecruitClassification?>(RecruitClassificationValueConverter.FromStringOrDefault(recruitTypeRawValue));
                            break;
                        case "year":
                            year = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "stars":
                            stars = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "rating":
                            rating = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "hometownInfo":
                            hometownInfo = new Option<RecruitHometownInfo?>(JsonSerializer.Deserialize<RecruitHometownInfo>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "athleteId":
                            athleteId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "ranking":
                            ranking = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "school":
                            school = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "committedTo":
                            committedTo = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "position":
                            position = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "height":
                            height = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "weight":
                            weight = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "city":
                            city = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "stateProvince":
                            stateProvince = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "country":
                            country = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class Recruit.", nameof(id));

            if (!recruitType.IsSet)
                throw new ArgumentException("Property is required for class Recruit.", nameof(recruitType));

            if (!year.IsSet)
                throw new ArgumentException("Property is required for class Recruit.", nameof(year));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class Recruit.", nameof(name));

            if (!stars.IsSet)
                throw new ArgumentException("Property is required for class Recruit.", nameof(stars));

            if (!rating.IsSet)
                throw new ArgumentException("Property is required for class Recruit.", nameof(rating));

            if (!hometownInfo.IsSet)
                throw new ArgumentException("Property is required for class Recruit.", nameof(hometownInfo));

            if (!athleteId.IsSet)
                throw new ArgumentException("Property is required for class Recruit.", nameof(athleteId));

            if (!ranking.IsSet)
                throw new ArgumentException("Property is required for class Recruit.", nameof(ranking));

            if (!school.IsSet)
                throw new ArgumentException("Property is required for class Recruit.", nameof(school));

            if (!committedTo.IsSet)
                throw new ArgumentException("Property is required for class Recruit.", nameof(committedTo));

            if (!position.IsSet)
                throw new ArgumentException("Property is required for class Recruit.", nameof(position));

            if (!height.IsSet)
                throw new ArgumentException("Property is required for class Recruit.", nameof(height));

            if (!weight.IsSet)
                throw new ArgumentException("Property is required for class Recruit.", nameof(weight));

            if (!city.IsSet)
                throw new ArgumentException("Property is required for class Recruit.", nameof(city));

            if (!stateProvince.IsSet)
                throw new ArgumentException("Property is required for class Recruit.", nameof(stateProvince));

            if (!country.IsSet)
                throw new ArgumentException("Property is required for class Recruit.", nameof(country));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class Recruit.");

            if (recruitType.IsSet && recruitType.Value == null)
                throw new ArgumentNullException(nameof(recruitType), "Property is not nullable for class Recruit.");

            if (year.IsSet && year.Value == null)
                throw new ArgumentNullException(nameof(year), "Property is not nullable for class Recruit.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class Recruit.");

            if (stars.IsSet && stars.Value == null)
                throw new ArgumentNullException(nameof(stars), "Property is not nullable for class Recruit.");

            if (rating.IsSet && rating.Value == null)
                throw new ArgumentNullException(nameof(rating), "Property is not nullable for class Recruit.");

            if (hometownInfo.IsSet && hometownInfo.Value == null)
                throw new ArgumentNullException(nameof(hometownInfo), "Property is not nullable for class Recruit.");

            return new Recruit(id.Value!, recruitType.Value!.Value!, year.Value!.Value!, name.Value!, stars.Value!.Value!, rating.Value!.Value!, hometownInfo.Value!, athleteId.Value!, ranking.Value!, school.Value!, committedTo.Value!, position.Value!, height.Value!, weight.Value!, city.Value!, stateProvince.Value!, country.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="Recruit" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="recruit"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Recruit recruit, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, recruit, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Recruit" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="recruit"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Recruit recruit, JsonSerializerOptions jsonSerializerOptions)
        {
            if (recruit.Id == null)
                throw new ArgumentNullException(nameof(recruit.Id), "Property is required for class Recruit.");

            if (recruit.Name == null)
                throw new ArgumentNullException(nameof(recruit.Name), "Property is required for class Recruit.");

            if (recruit.HometownInfo == null)
                throw new ArgumentNullException(nameof(recruit.HometownInfo), "Property is required for class Recruit.");

            writer.WriteString("id", recruit.Id);

            var recruitTypeRawValue = RecruitClassificationValueConverter.ToJsonValue(recruit.RecruitType);
            writer.WriteString("recruitType", recruitTypeRawValue);

            writer.WriteNumber("year", recruit.Year);

            writer.WriteString("name", recruit.Name);

            writer.WriteNumber("stars", recruit.Stars);

            writer.WriteNumber("rating", recruit.Rating);

            writer.WritePropertyName("hometownInfo");
            JsonSerializer.Serialize(writer, recruit.HometownInfo, jsonSerializerOptions);
            if (recruit.AthleteId != null)
                writer.WriteString("athleteId", recruit.AthleteId);
            else
                writer.WriteNull("athleteId");

            if (recruit.Ranking != null)
                writer.WriteNumber("ranking", recruit.Ranking.Value);
            else
                writer.WriteNull("ranking");

            if (recruit.School != null)
                writer.WriteString("school", recruit.School);
            else
                writer.WriteNull("school");

            if (recruit.CommittedTo != null)
                writer.WriteString("committedTo", recruit.CommittedTo);
            else
                writer.WriteNull("committedTo");

            if (recruit.Position != null)
                writer.WriteString("position", recruit.Position);
            else
                writer.WriteNull("position");

            if (recruit.Height != null)
                writer.WriteNumber("height", recruit.Height.Value);
            else
                writer.WriteNull("height");

            if (recruit.Weight != null)
                writer.WriteNumber("weight", recruit.Weight.Value);
            else
                writer.WriteNull("weight");

            if (recruit.City != null)
                writer.WriteString("city", recruit.City);
            else
                writer.WriteNull("city");

            if (recruit.StateProvince != null)
                writer.WriteString("stateProvince", recruit.StateProvince);
            else
                writer.WriteNull("stateProvince");

            if (recruit.Country != null)
                writer.WriteString("country", recruit.Country);
            else
                writer.WriteNull("country");
        }
    }
}

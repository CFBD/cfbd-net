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
    /// Venue
    /// </summary>
    public partial class Venue : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Venue" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">name</param>
        /// <param name="city">city</param>
        /// <param name="state">state</param>
        /// <param name="zip">zip</param>
        /// <param name="countryCode">countryCode</param>
        /// <param name="timezone">timezone</param>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        /// <param name="elevation">elevation</param>
        /// <param name="capacity">capacity</param>
        /// <param name="constructionYear">constructionYear</param>
        /// <param name="grass">grass</param>
        /// <param name="dome">dome</param>
        [JsonConstructor]
        public Venue(int? id = default, string? name = default, string? city = default, string? state = default, string? zip = default, string? countryCode = default, string? timezone = default, double? latitude = default, double? longitude = default, string? elevation = default, int? capacity = default, int? constructionYear = default, Option<bool?> grass = default, Option<bool?> dome = default)
        {
            Id = id;
            Name = name;
            City = city;
            State = state;
            Zip = zip;
            CountryCode = countryCode;
            Timezone = timezone;
            Latitude = latitude;
            Longitude = longitude;
            Elevation = elevation;
            Capacity = capacity;
            ConstructionYear = constructionYear;
            GrassOption = grass;
            DomeOption = dome;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [JsonPropertyName("zip")]
        public string? Zip { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [JsonPropertyName("countryCode")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [JsonPropertyName("latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or Sets Elevation
        /// </summary>
        [JsonPropertyName("elevation")]
        public string? Elevation { get; set; }

        /// <summary>
        /// Gets or Sets Capacity
        /// </summary>
        [JsonPropertyName("capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// Gets or Sets ConstructionYear
        /// </summary>
        [JsonPropertyName("constructionYear")]
        public int? ConstructionYear { get; set; }

        /// <summary>
        /// Used to track the state of Grass
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> GrassOption { get; private set; }

        /// <summary>
        /// Gets or Sets Grass
        /// </summary>
        [JsonPropertyName("grass")]
        public bool? Grass { get { return this.GrassOption; } set { this.GrassOption = new(value); } }

        /// <summary>
        /// Used to track the state of Dome
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> DomeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Dome
        /// </summary>
        [JsonPropertyName("dome")]
        public bool? Dome { get { return this.DomeOption; } set { this.DomeOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Venue {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Elevation: ").Append(Elevation).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  ConstructionYear: ").Append(ConstructionYear).Append("\n");
            sb.Append("  Grass: ").Append(Grass).Append("\n");
            sb.Append("  Dome: ").Append(Dome).Append("\n");
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
    /// A Json converter for type <see cref="Venue" />
    /// </summary>
    public class VenueJsonConverter : JsonConverter<Venue>
    {
        /// <summary>
        /// Deserializes json to <see cref="Venue" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Venue Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> id = default;
            Option<string?> name = default;
            Option<string?> city = default;
            Option<string?> state = default;
            Option<string?> zip = default;
            Option<string?> countryCode = default;
            Option<string?> timezone = default;
            Option<double?> latitude = default;
            Option<double?> longitude = default;
            Option<string?> elevation = default;
            Option<int?> capacity = default;
            Option<int?> constructionYear = default;
            Option<bool?> grass = default;
            Option<bool?> dome = default;

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
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "city":
                            city = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "state":
                            state = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "zip":
                            zip = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "countryCode":
                            countryCode = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "timezone":
                            timezone = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "latitude":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                latitude = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "longitude":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                longitude = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "elevation":
                            elevation = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "capacity":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                capacity = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "constructionYear":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                constructionYear = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "grass":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                grass = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "dome":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dome = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class Venue.", nameof(id));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class Venue.", nameof(name));

            if (!city.IsSet)
                throw new ArgumentException("Property is required for class Venue.", nameof(city));

            if (!state.IsSet)
                throw new ArgumentException("Property is required for class Venue.", nameof(state));

            if (!zip.IsSet)
                throw new ArgumentException("Property is required for class Venue.", nameof(zip));

            if (!countryCode.IsSet)
                throw new ArgumentException("Property is required for class Venue.", nameof(countryCode));

            if (!timezone.IsSet)
                throw new ArgumentException("Property is required for class Venue.", nameof(timezone));

            if (!latitude.IsSet)
                throw new ArgumentException("Property is required for class Venue.", nameof(latitude));

            if (!longitude.IsSet)
                throw new ArgumentException("Property is required for class Venue.", nameof(longitude));

            if (!elevation.IsSet)
                throw new ArgumentException("Property is required for class Venue.", nameof(elevation));

            if (!capacity.IsSet)
                throw new ArgumentException("Property is required for class Venue.", nameof(capacity));

            if (!constructionYear.IsSet)
                throw new ArgumentException("Property is required for class Venue.", nameof(constructionYear));

            return new Venue(id.Value!, name.Value!, city.Value!, state.Value!, zip.Value!, countryCode.Value!, timezone.Value!, latitude.Value!, longitude.Value!, elevation.Value!, capacity.Value!, constructionYear.Value!, grass, dome);
        }

        /// <summary>
        /// Serializes a <see cref="Venue" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="venue"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Venue venue, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, venue, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Venue" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="venue"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Venue venue, JsonSerializerOptions jsonSerializerOptions)
        {
            if (venue.Id != null)
                writer.WriteNumber("id", venue.Id.Value);
            else
                writer.WriteNull("id");

            if (venue.Name != null)
                writer.WriteString("name", venue.Name);
            else
                writer.WriteNull("name");

            if (venue.City != null)
                writer.WriteString("city", venue.City);
            else
                writer.WriteNull("city");

            if (venue.State != null)
                writer.WriteString("state", venue.State);
            else
                writer.WriteNull("state");

            if (venue.Zip != null)
                writer.WriteString("zip", venue.Zip);
            else
                writer.WriteNull("zip");

            if (venue.CountryCode != null)
                writer.WriteString("countryCode", venue.CountryCode);
            else
                writer.WriteNull("countryCode");

            if (venue.Timezone != null)
                writer.WriteString("timezone", venue.Timezone);
            else
                writer.WriteNull("timezone");

            if (venue.Latitude != null)
                writer.WriteNumber("latitude", venue.Latitude.Value);
            else
                writer.WriteNull("latitude");

            if (venue.Longitude != null)
                writer.WriteNumber("longitude", venue.Longitude.Value);
            else
                writer.WriteNull("longitude");

            if (venue.Elevation != null)
                writer.WriteString("elevation", venue.Elevation);
            else
                writer.WriteNull("elevation");

            if (venue.Capacity != null)
                writer.WriteNumber("capacity", venue.Capacity.Value);
            else
                writer.WriteNull("capacity");

            if (venue.ConstructionYear != null)
                writer.WriteNumber("constructionYear", venue.ConstructionYear.Value);
            else
                writer.WriteNull("constructionYear");

            if (venue.GrassOption.IsSet)
                if (venue.GrassOption.Value != null)
                    writer.WriteBoolean("grass", venue.GrassOption.Value!.Value);
                else
                    writer.WriteNull("grass");

            if (venue.DomeOption.IsSet)
                if (venue.DomeOption.Value != null)
                    writer.WriteBoolean("dome", venue.DomeOption.Value!.Value);
                else
                    writer.WriteNull("dome");
        }
    }
}

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
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using CollegeFootballData.Client;
using CollegeFootballData.Model;
using System.Diagnostics.CodeAnalysis;

namespace CollegeFootballData.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface ICoachesApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        CoachesApiEvents Events { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves historical head coach information and records
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">Optional first name filter (optional)</param>
        /// <param name="lastName">Optional last name filter (optional)</param>
        /// <param name="team">Optional team filter (optional)</param>
        /// <param name="year">Optional year filter (optional)</param>
        /// <param name="minYear">Optional start year range filter (optional)</param>
        /// <param name="maxYear">Optional end year range filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetCoachesApiResponse"/>&gt;</returns>
        Task<IGetCoachesApiResponse> GetCoachesAsync(Option<string> firstName = default, Option<string> lastName = default, Option<string> team = default, Option<int> year = default, Option<int> minYear = default, Option<int> maxYear = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves historical head coach information and records
        /// </remarks>
        /// <param name="firstName">Optional first name filter (optional)</param>
        /// <param name="lastName">Optional last name filter (optional)</param>
        /// <param name="team">Optional team filter (optional)</param>
        /// <param name="year">Optional year filter (optional)</param>
        /// <param name="minYear">Optional start year range filter (optional)</param>
        /// <param name="maxYear">Optional end year range filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetCoachesApiResponse"/>?&gt;</returns>
        Task<IGetCoachesApiResponse?> GetCoachesOrDefaultAsync(Option<string> firstName = default, Option<string> lastName = default, Option<string> team = default, Option<int> year = default, Option<int> minYear = default, Option<int> maxYear = default, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="IGetCoachesApiResponse"/>
    /// </summary>
    public interface IGetCoachesApiResponse : CollegeFootballData.Client.IApiResponse, IOk<List<Coach>?>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CoachesApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnGetCoaches;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorGetCoaches;

        internal void ExecuteOnGetCoaches(CoachesApi.GetCoachesApiResponse apiResponse)
        {
            OnGetCoaches?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorGetCoaches(Exception exception)
        {
            OnErrorGetCoaches?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class CoachesApi : ICoachesApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<CoachesApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public CoachesApiEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="BearerToken"/>
        /// </summary>
        public TokenProvider<BearerToken> BearerTokenProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoachesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CoachesApi(ILogger<CoachesApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, CoachesApiEvents coachesApiEvents,
            TokenProvider<BearerToken> bearerTokenProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<CoachesApi>();
            HttpClient = httpClient;
            Events = coachesApiEvents;
            BearerTokenProvider = bearerTokenProvider;
        }

        partial void FormatGetCoaches(ref Option<string> firstName, ref Option<string> lastName, ref Option<string> team, ref Option<int> year, ref Option<int> minYear, ref Option<int> maxYear);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="team"></param>
        /// <returns></returns>
        private void ValidateGetCoaches(Option<string> firstName, Option<string> lastName, Option<string> team)
        {
            if (firstName.IsSet && firstName.Value == null)
                throw new ArgumentNullException(nameof(firstName));

            if (lastName.IsSet && lastName.Value == null)
                throw new ArgumentNullException(nameof(lastName));

            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="team"></param>
        /// <param name="year"></param>
        /// <param name="minYear"></param>
        /// <param name="maxYear"></param>
        private void AfterGetCoachesDefaultImplementation(IGetCoachesApiResponse apiResponseLocalVar, Option<string> firstName, Option<string> lastName, Option<string> team, Option<int> year, Option<int> minYear, Option<int> maxYear)
        {
            bool suppressDefaultLog = false;
            AfterGetCoaches(ref suppressDefaultLog, apiResponseLocalVar, firstName, lastName, team, year, minYear, maxYear);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="team"></param>
        /// <param name="year"></param>
        /// <param name="minYear"></param>
        /// <param name="maxYear"></param>
        partial void AfterGetCoaches(ref bool suppressDefaultLog, IGetCoachesApiResponse apiResponseLocalVar, Option<string> firstName, Option<string> lastName, Option<string> team, Option<int> year, Option<int> minYear, Option<int> maxYear);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="team"></param>
        /// <param name="year"></param>
        /// <param name="minYear"></param>
        /// <param name="maxYear"></param>
        private void OnErrorGetCoachesDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> firstName, Option<string> lastName, Option<string> team, Option<int> year, Option<int> minYear, Option<int> maxYear)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorGetCoaches(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, firstName, lastName, team, year, minYear, maxYear);
            if (!suppressDefaultLogLocalVar)
                Logger.LogError(exceptionLocalVar, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLogLocalVar"></param>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="team"></param>
        /// <param name="year"></param>
        /// <param name="minYear"></param>
        /// <param name="maxYear"></param>
        partial void OnErrorGetCoaches(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> firstName, Option<string> lastName, Option<string> team, Option<int> year, Option<int> minYear, Option<int> maxYear);

        /// <summary>
        ///  Retrieves historical head coach information and records
        /// </summary>
        /// <param name="firstName">Optional first name filter (optional)</param>
        /// <param name="lastName">Optional last name filter (optional)</param>
        /// <param name="team">Optional team filter (optional)</param>
        /// <param name="year">Optional year filter (optional)</param>
        /// <param name="minYear">Optional start year range filter (optional)</param>
        /// <param name="maxYear">Optional end year range filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetCoachesApiResponse"/>&gt;</returns>
        public async Task<IGetCoachesApiResponse?> GetCoachesOrDefaultAsync(Option<string> firstName = default, Option<string> lastName = default, Option<string> team = default, Option<int> year = default, Option<int> minYear = default, Option<int> maxYear = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await GetCoachesAsync(firstName, lastName, team, year, minYear, maxYear, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///  Retrieves historical head coach information and records
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">Optional first name filter (optional)</param>
        /// <param name="lastName">Optional last name filter (optional)</param>
        /// <param name="team">Optional team filter (optional)</param>
        /// <param name="year">Optional year filter (optional)</param>
        /// <param name="minYear">Optional start year range filter (optional)</param>
        /// <param name="maxYear">Optional end year range filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetCoachesApiResponse"/>&gt;</returns>
        public async Task<IGetCoachesApiResponse> GetCoachesAsync(Option<string> firstName = default, Option<string> lastName = default, Option<string> team = default, Option<int> year = default, Option<int> minYear = default, Option<int> maxYear = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateGetCoaches(firstName, lastName, team);

                FormatGetCoaches(ref firstName, ref lastName, ref team, ref year, ref minYear, ref maxYear);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/coaches";

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    if (firstName.IsSet)
                        parseQueryStringLocalVar["firstName"] = ClientUtils.ParameterToString(firstName.Value);

                    if (lastName.IsSet)
                        parseQueryStringLocalVar["lastName"] = ClientUtils.ParameterToString(lastName.Value);

                    if (team.IsSet)
                        parseQueryStringLocalVar["team"] = ClientUtils.ParameterToString(team.Value);

                    if (year.IsSet)
                        parseQueryStringLocalVar["year"] = ClientUtils.ParameterToString(year.Value);

                    if (minYear.IsSet)
                        parseQueryStringLocalVar["minYear"] = ClientUtils.ParameterToString(minYear.Value);

                    if (maxYear.IsSet)
                        parseQueryStringLocalVar["maxYear"] = ClientUtils.ParameterToString(maxYear.Value);

                    uriBuilderLocalVar.Query = parseQueryStringLocalVar.ToString();

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();
                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    BearerToken bearerTokenLocalVar1 = (BearerToken) await BearerTokenProvider.GetAsync(cancellation: cancellationToken).ConfigureAwait(false);

                    tokenBaseLocalVars.Add(bearerTokenLocalVar1);

                    bearerTokenLocalVar1.UseInHeader(httpRequestMessageLocalVar, "");

                    string[] acceptLocalVars = new string[] {
                        "application/json"
                    };

                    string? acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Get;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ILogger<GetCoachesApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<GetCoachesApiResponse>();

                        GetCoachesApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/coaches", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterGetCoachesDefaultImplementation(apiResponseLocalVar, firstName, lastName, team, year, minYear, maxYear);

                        Events.ExecuteOnGetCoaches(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorGetCoachesDefaultImplementation(e, "/coaches", uriBuilderLocalVar.Path, firstName, lastName, team, year, minYear, maxYear);
                Events.ExecuteOnErrorGetCoaches(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="GetCoachesApiResponse"/>
        /// </summary>
        public partial class GetCoachesApiResponse : CollegeFootballData.Client.ApiResponse, IGetCoachesApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<GetCoachesApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="GetCoachesApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public GetCoachesApiResponse(ILogger<GetCoachesApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                Logger = logger;
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(global::System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public List<Coach>? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<List<Coach>>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk([NotNullWhen(true)]out List<Coach>? result)
            {
                result = null;

                try
                {
                    result = Ok();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)200);
                }

                return result != null;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                if (!suppressDefaultLog)
                    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }
    }
}

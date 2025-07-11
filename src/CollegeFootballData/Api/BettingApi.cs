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
    public interface IBettingApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        BettingApiEvents Events { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves historical betting data
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">Optional gameId filter (optional)</param>
        /// <param name="year">Year filter, required if game id not specified (optional)</param>
        /// <param name="seasonType">Optional season type filter (optional)</param>
        /// <param name="week">Optional week filter (optional)</param>
        /// <param name="team">Optional team filter (optional)</param>
        /// <param name="home">Optional home team filter (optional)</param>
        /// <param name="away">Optional away team filter (optional)</param>
        /// <param name="conference">Optional conference filter (optional)</param>
        /// <param name="provider">Optional provider name filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetLinesApiResponse"/>&gt;</returns>
        Task<IGetLinesApiResponse> GetLinesAsync(Option<int> gameId = default, Option<int> year = default, Option<SeasonType> seasonType = default, Option<int> week = default, Option<string> team = default, Option<string> home = default, Option<string> away = default, Option<string> conference = default, Option<string> provider = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves historical betting data
        /// </remarks>
        /// <param name="gameId">Optional gameId filter (optional)</param>
        /// <param name="year">Year filter, required if game id not specified (optional)</param>
        /// <param name="seasonType">Optional season type filter (optional)</param>
        /// <param name="week">Optional week filter (optional)</param>
        /// <param name="team">Optional team filter (optional)</param>
        /// <param name="home">Optional home team filter (optional)</param>
        /// <param name="away">Optional away team filter (optional)</param>
        /// <param name="conference">Optional conference filter (optional)</param>
        /// <param name="provider">Optional provider name filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetLinesApiResponse"/>?&gt;</returns>
        Task<IGetLinesApiResponse?> GetLinesOrDefaultAsync(Option<int> gameId = default, Option<int> year = default, Option<SeasonType> seasonType = default, Option<int> week = default, Option<string> team = default, Option<string> home = default, Option<string> away = default, Option<string> conference = default, Option<string> provider = default, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="IGetLinesApiResponse"/>
    /// </summary>
    public interface IGetLinesApiResponse : CollegeFootballData.Client.IApiResponse, IOk<List<BettingGame>?>
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
    public class BettingApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnGetLines;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorGetLines;

        internal void ExecuteOnGetLines(BettingApi.GetLinesApiResponse apiResponse)
        {
            OnGetLines?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorGetLines(Exception exception)
        {
            OnErrorGetLines?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class BettingApi : IBettingApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<BettingApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public BettingApiEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="BearerToken"/>
        /// </summary>
        public TokenProvider<BearerToken> BearerTokenProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BettingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BettingApi(ILogger<BettingApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, BettingApiEvents bettingApiEvents,
            TokenProvider<BearerToken> bearerTokenProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<BettingApi>();
            HttpClient = httpClient;
            Events = bettingApiEvents;
            BearerTokenProvider = bearerTokenProvider;
        }

        partial void FormatGetLines(ref Option<int> gameId, ref Option<int> year, ref Option<SeasonType> seasonType, ref Option<int> week, ref Option<string> team, ref Option<string> home, ref Option<string> away, ref Option<string> conference, ref Option<string> provider);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="team"></param>
        /// <param name="home"></param>
        /// <param name="away"></param>
        /// <param name="conference"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        private void ValidateGetLines(Option<string> team, Option<string> home, Option<string> away, Option<string> conference, Option<string> provider)
        {
            if (team.IsSet && team.Value == null)
                throw new ArgumentNullException(nameof(team));

            if (home.IsSet && home.Value == null)
                throw new ArgumentNullException(nameof(home));

            if (away.IsSet && away.Value == null)
                throw new ArgumentNullException(nameof(away));

            if (conference.IsSet && conference.Value == null)
                throw new ArgumentNullException(nameof(conference));

            if (provider.IsSet && provider.Value == null)
                throw new ArgumentNullException(nameof(provider));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="gameId"></param>
        /// <param name="year"></param>
        /// <param name="seasonType"></param>
        /// <param name="week"></param>
        /// <param name="team"></param>
        /// <param name="home"></param>
        /// <param name="away"></param>
        /// <param name="conference"></param>
        /// <param name="provider"></param>
        private void AfterGetLinesDefaultImplementation(IGetLinesApiResponse apiResponseLocalVar, Option<int> gameId, Option<int> year, Option<SeasonType> seasonType, Option<int> week, Option<string> team, Option<string> home, Option<string> away, Option<string> conference, Option<string> provider)
        {
            bool suppressDefaultLog = false;
            AfterGetLines(ref suppressDefaultLog, apiResponseLocalVar, gameId, year, seasonType, week, team, home, away, conference, provider);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="gameId"></param>
        /// <param name="year"></param>
        /// <param name="seasonType"></param>
        /// <param name="week"></param>
        /// <param name="team"></param>
        /// <param name="home"></param>
        /// <param name="away"></param>
        /// <param name="conference"></param>
        /// <param name="provider"></param>
        partial void AfterGetLines(ref bool suppressDefaultLog, IGetLinesApiResponse apiResponseLocalVar, Option<int> gameId, Option<int> year, Option<SeasonType> seasonType, Option<int> week, Option<string> team, Option<string> home, Option<string> away, Option<string> conference, Option<string> provider);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="gameId"></param>
        /// <param name="year"></param>
        /// <param name="seasonType"></param>
        /// <param name="week"></param>
        /// <param name="team"></param>
        /// <param name="home"></param>
        /// <param name="away"></param>
        /// <param name="conference"></param>
        /// <param name="provider"></param>
        private void OnErrorGetLinesDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<int> gameId, Option<int> year, Option<SeasonType> seasonType, Option<int> week, Option<string> team, Option<string> home, Option<string> away, Option<string> conference, Option<string> provider)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorGetLines(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, gameId, year, seasonType, week, team, home, away, conference, provider);
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
        /// <param name="gameId"></param>
        /// <param name="year"></param>
        /// <param name="seasonType"></param>
        /// <param name="week"></param>
        /// <param name="team"></param>
        /// <param name="home"></param>
        /// <param name="away"></param>
        /// <param name="conference"></param>
        /// <param name="provider"></param>
        partial void OnErrorGetLines(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<int> gameId, Option<int> year, Option<SeasonType> seasonType, Option<int> week, Option<string> team, Option<string> home, Option<string> away, Option<string> conference, Option<string> provider);

        /// <summary>
        ///  Retrieves historical betting data
        /// </summary>
        /// <param name="gameId">Optional gameId filter (optional)</param>
        /// <param name="year">Year filter, required if game id not specified (optional)</param>
        /// <param name="seasonType">Optional season type filter (optional)</param>
        /// <param name="week">Optional week filter (optional)</param>
        /// <param name="team">Optional team filter (optional)</param>
        /// <param name="home">Optional home team filter (optional)</param>
        /// <param name="away">Optional away team filter (optional)</param>
        /// <param name="conference">Optional conference filter (optional)</param>
        /// <param name="provider">Optional provider name filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetLinesApiResponse"/>&gt;</returns>
        public async Task<IGetLinesApiResponse?> GetLinesOrDefaultAsync(Option<int> gameId = default, Option<int> year = default, Option<SeasonType> seasonType = default, Option<int> week = default, Option<string> team = default, Option<string> home = default, Option<string> away = default, Option<string> conference = default, Option<string> provider = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await GetLinesAsync(gameId, year, seasonType, week, team, home, away, conference, provider, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///  Retrieves historical betting data
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">Optional gameId filter (optional)</param>
        /// <param name="year">Year filter, required if game id not specified (optional)</param>
        /// <param name="seasonType">Optional season type filter (optional)</param>
        /// <param name="week">Optional week filter (optional)</param>
        /// <param name="team">Optional team filter (optional)</param>
        /// <param name="home">Optional home team filter (optional)</param>
        /// <param name="away">Optional away team filter (optional)</param>
        /// <param name="conference">Optional conference filter (optional)</param>
        /// <param name="provider">Optional provider name filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetLinesApiResponse"/>&gt;</returns>
        public async Task<IGetLinesApiResponse> GetLinesAsync(Option<int> gameId = default, Option<int> year = default, Option<SeasonType> seasonType = default, Option<int> week = default, Option<string> team = default, Option<string> home = default, Option<string> away = default, Option<string> conference = default, Option<string> provider = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateGetLines(team, home, away, conference, provider);

                FormatGetLines(ref gameId, ref year, ref seasonType, ref week, ref team, ref home, ref away, ref conference, ref provider);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/lines";

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    if (gameId.IsSet)
                        parseQueryStringLocalVar["gameId"] = ClientUtils.ParameterToString(gameId.Value);

                    if (year.IsSet)
                        parseQueryStringLocalVar["year"] = ClientUtils.ParameterToString(year.Value);

                    if (seasonType.IsSet)
                        parseQueryStringLocalVar["seasonType"] = ClientUtils.ParameterToString(seasonType.Value);

                    if (week.IsSet)
                        parseQueryStringLocalVar["week"] = ClientUtils.ParameterToString(week.Value);

                    if (team.IsSet)
                        parseQueryStringLocalVar["team"] = ClientUtils.ParameterToString(team.Value);

                    if (home.IsSet)
                        parseQueryStringLocalVar["home"] = ClientUtils.ParameterToString(home.Value);

                    if (away.IsSet)
                        parseQueryStringLocalVar["away"] = ClientUtils.ParameterToString(away.Value);

                    if (conference.IsSet)
                        parseQueryStringLocalVar["conference"] = ClientUtils.ParameterToString(conference.Value);

                    if (provider.IsSet)
                        parseQueryStringLocalVar["provider"] = ClientUtils.ParameterToString(provider.Value);

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

                        ILogger<GetLinesApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<GetLinesApiResponse>();

                        GetLinesApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/lines", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterGetLinesDefaultImplementation(apiResponseLocalVar, gameId, year, seasonType, week, team, home, away, conference, provider);

                        Events.ExecuteOnGetLines(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorGetLinesDefaultImplementation(e, "/lines", uriBuilderLocalVar.Path, gameId, year, seasonType, week, team, home, away, conference, provider);
                Events.ExecuteOnErrorGetLines(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="GetLinesApiResponse"/>
        /// </summary>
        public partial class GetLinesApiResponse : CollegeFootballData.Client.ApiResponse, IGetLinesApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<GetLinesApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="GetLinesApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public GetLinesApiResponse(ILogger<GetLinesApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
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
            public List<BettingGame>? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<List<BettingGame>>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk([NotNullWhen(true)]out List<BettingGame>? result)
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

/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.3
 * Contact: admin@collegefootballdata.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using CollegeFootballData.Client;
using CollegeFootballData.Model;

namespace CollegeFootballData.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRankingsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves historical poll data
        /// </remarks>
        /// <exception cref="CollegeFootballData.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Required year filter</param>
        /// <param name="seasonType">Optional season type filter (optional)</param>
        /// <param name="week">Optional week filter (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;PollWeek&gt;</returns>
        List<PollWeek> GetRankings(int year, SeasonType? seasonType = default(SeasonType?), double? week = default(double?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves historical poll data
        /// </remarks>
        /// <exception cref="CollegeFootballData.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Required year filter</param>
        /// <param name="seasonType">Optional season type filter (optional)</param>
        /// <param name="week">Optional week filter (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;PollWeek&gt;</returns>
        ApiResponse<List<PollWeek>> GetRankingsWithHttpInfo(int year, SeasonType? seasonType = default(SeasonType?), double? week = default(double?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRankingsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves historical poll data
        /// </remarks>
        /// <exception cref="CollegeFootballData.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Required year filter</param>
        /// <param name="seasonType">Optional season type filter (optional)</param>
        /// <param name="week">Optional week filter (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PollWeek&gt;</returns>
        System.Threading.Tasks.Task<List<PollWeek>> GetRankingsAsync(int year, SeasonType? seasonType = default(SeasonType?), double? week = default(double?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves historical poll data
        /// </remarks>
        /// <exception cref="CollegeFootballData.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Required year filter</param>
        /// <param name="seasonType">Optional season type filter (optional)</param>
        /// <param name="week">Optional week filter (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PollWeek&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PollWeek>>> GetRankingsWithHttpInfoAsync(int year, SeasonType? seasonType = default(SeasonType?), double? week = default(double?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRankingsApi : IRankingsApiSync, IRankingsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RankingsApi : IRankingsApi
    {
        private CollegeFootballData.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RankingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RankingsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RankingsApi(string basePath)
        {
            this.Configuration = CollegeFootballData.Client.Configuration.MergeConfigurations(
                CollegeFootballData.Client.GlobalConfiguration.Instance,
                new CollegeFootballData.Client.Configuration { BasePath = basePath }
            );
            this.Client = new CollegeFootballData.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new CollegeFootballData.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = CollegeFootballData.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RankingsApi(CollegeFootballData.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = CollegeFootballData.Client.Configuration.MergeConfigurations(
                CollegeFootballData.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new CollegeFootballData.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new CollegeFootballData.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = CollegeFootballData.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankingsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public RankingsApi(CollegeFootballData.Client.ISynchronousClient client, CollegeFootballData.Client.IAsynchronousClient asyncClient, CollegeFootballData.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = CollegeFootballData.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public CollegeFootballData.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public CollegeFootballData.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public CollegeFootballData.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CollegeFootballData.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  Retrieves historical poll data
        /// </summary>
        /// <exception cref="CollegeFootballData.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Required year filter</param>
        /// <param name="seasonType">Optional season type filter (optional)</param>
        /// <param name="week">Optional week filter (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;PollWeek&gt;</returns>
        public List<PollWeek> GetRankings(int year, SeasonType? seasonType = default(SeasonType?), double? week = default(double?), int operationIndex = 0)
        {
            CollegeFootballData.Client.ApiResponse<List<PollWeek>> localVarResponse = GetRankingsWithHttpInfo(year, seasonType, week);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves historical poll data
        /// </summary>
        /// <exception cref="CollegeFootballData.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Required year filter</param>
        /// <param name="seasonType">Optional season type filter (optional)</param>
        /// <param name="week">Optional week filter (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;PollWeek&gt;</returns>
        public CollegeFootballData.Client.ApiResponse<List<PollWeek>> GetRankingsWithHttpInfo(int year, SeasonType? seasonType = default(SeasonType?), double? week = default(double?), int operationIndex = 0)
        {
            CollegeFootballData.Client.RequestOptions localVarRequestOptions = new CollegeFootballData.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = CollegeFootballData.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = CollegeFootballData.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "year", year));
            if (seasonType != null)
            {
                localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "seasonType", seasonType));
            }
            if (week != null)
            {
                localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "week", week));
            }

            localVarRequestOptions.Operation = "RankingsApi.GetRankings";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<PollWeek>>("/rankings", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRankings", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves historical poll data
        /// </summary>
        /// <exception cref="CollegeFootballData.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Required year filter</param>
        /// <param name="seasonType">Optional season type filter (optional)</param>
        /// <param name="week">Optional week filter (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PollWeek&gt;</returns>
        public async System.Threading.Tasks.Task<List<PollWeek>> GetRankingsAsync(int year, SeasonType? seasonType = default(SeasonType?), double? week = default(double?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            CollegeFootballData.Client.ApiResponse<List<PollWeek>> localVarResponse = await GetRankingsWithHttpInfoAsync(year, seasonType, week, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves historical poll data
        /// </summary>
        /// <exception cref="CollegeFootballData.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Required year filter</param>
        /// <param name="seasonType">Optional season type filter (optional)</param>
        /// <param name="week">Optional week filter (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PollWeek&gt;)</returns>
        public async System.Threading.Tasks.Task<CollegeFootballData.Client.ApiResponse<List<PollWeek>>> GetRankingsWithHttpInfoAsync(int year, SeasonType? seasonType = default(SeasonType?), double? week = default(double?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            CollegeFootballData.Client.RequestOptions localVarRequestOptions = new CollegeFootballData.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = CollegeFootballData.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = CollegeFootballData.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "year", year));
            if (seasonType != null)
            {
                localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "seasonType", seasonType));
            }
            if (week != null)
            {
                localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "week", week));
            }

            localVarRequestOptions.Operation = "RankingsApi.GetRankings";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<PollWeek>>("/rankings", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRankings", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}

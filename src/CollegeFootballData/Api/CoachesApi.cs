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
    public interface ICoachesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves historical head coach information and records
        /// </remarks>
        /// <exception cref="CollegeFootballData.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">Optional first name filter (optional)</param>
        /// <param name="lastName">Optional last name filter (optional)</param>
        /// <param name="team">Optional team filter (optional)</param>
        /// <param name="year">Optional year filter (optional)</param>
        /// <param name="minYear">Optional start year range filter (optional)</param>
        /// <param name="maxYear">Optional end year range filter (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;Coach&gt;</returns>
        List<Coach> GetCoaches(string? firstName = default(string?), string? lastName = default(string?), string? team = default(string?), int? year = default(int?), int? minYear = default(int?), int? maxYear = default(int?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves historical head coach information and records
        /// </remarks>
        /// <exception cref="CollegeFootballData.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">Optional first name filter (optional)</param>
        /// <param name="lastName">Optional last name filter (optional)</param>
        /// <param name="team">Optional team filter (optional)</param>
        /// <param name="year">Optional year filter (optional)</param>
        /// <param name="minYear">Optional start year range filter (optional)</param>
        /// <param name="maxYear">Optional end year range filter (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;Coach&gt;</returns>
        ApiResponse<List<Coach>> GetCoachesWithHttpInfo(string? firstName = default(string?), string? lastName = default(string?), string? team = default(string?), int? year = default(int?), int? minYear = default(int?), int? maxYear = default(int?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICoachesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves historical head coach information and records
        /// </remarks>
        /// <exception cref="CollegeFootballData.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">Optional first name filter (optional)</param>
        /// <param name="lastName">Optional last name filter (optional)</param>
        /// <param name="team">Optional team filter (optional)</param>
        /// <param name="year">Optional year filter (optional)</param>
        /// <param name="minYear">Optional start year range filter (optional)</param>
        /// <param name="maxYear">Optional end year range filter (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Coach&gt;</returns>
        System.Threading.Tasks.Task<List<Coach>> GetCoachesAsync(string? firstName = default(string?), string? lastName = default(string?), string? team = default(string?), int? year = default(int?), int? minYear = default(int?), int? maxYear = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves historical head coach information and records
        /// </remarks>
        /// <exception cref="CollegeFootballData.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">Optional first name filter (optional)</param>
        /// <param name="lastName">Optional last name filter (optional)</param>
        /// <param name="team">Optional team filter (optional)</param>
        /// <param name="year">Optional year filter (optional)</param>
        /// <param name="minYear">Optional start year range filter (optional)</param>
        /// <param name="maxYear">Optional end year range filter (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Coach&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Coach>>> GetCoachesWithHttpInfoAsync(string? firstName = default(string?), string? lastName = default(string?), string? team = default(string?), int? year = default(int?), int? minYear = default(int?), int? maxYear = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICoachesApi : ICoachesApiSync, ICoachesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CoachesApi : ICoachesApi
    {
        private CollegeFootballData.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CoachesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CoachesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoachesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CoachesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="CoachesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CoachesApi(CollegeFootballData.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="CoachesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CoachesApi(CollegeFootballData.Client.ISynchronousClient client, CollegeFootballData.Client.IAsynchronousClient asyncClient, CollegeFootballData.Client.IReadableConfiguration configuration)
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
        ///  Retrieves historical head coach information and records
        /// </summary>
        /// <exception cref="CollegeFootballData.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">Optional first name filter (optional)</param>
        /// <param name="lastName">Optional last name filter (optional)</param>
        /// <param name="team">Optional team filter (optional)</param>
        /// <param name="year">Optional year filter (optional)</param>
        /// <param name="minYear">Optional start year range filter (optional)</param>
        /// <param name="maxYear">Optional end year range filter (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;Coach&gt;</returns>
        public List<Coach> GetCoaches(string? firstName = default(string?), string? lastName = default(string?), string? team = default(string?), int? year = default(int?), int? minYear = default(int?), int? maxYear = default(int?), int operationIndex = 0)
        {
            CollegeFootballData.Client.ApiResponse<List<Coach>> localVarResponse = GetCoachesWithHttpInfo(firstName, lastName, team, year, minYear, maxYear);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves historical head coach information and records
        /// </summary>
        /// <exception cref="CollegeFootballData.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">Optional first name filter (optional)</param>
        /// <param name="lastName">Optional last name filter (optional)</param>
        /// <param name="team">Optional team filter (optional)</param>
        /// <param name="year">Optional year filter (optional)</param>
        /// <param name="minYear">Optional start year range filter (optional)</param>
        /// <param name="maxYear">Optional end year range filter (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;Coach&gt;</returns>
        public CollegeFootballData.Client.ApiResponse<List<Coach>> GetCoachesWithHttpInfo(string? firstName = default(string?), string? lastName = default(string?), string? team = default(string?), int? year = default(int?), int? minYear = default(int?), int? maxYear = default(int?), int operationIndex = 0)
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

            if (firstName != null)
            {
                localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "firstName", firstName));
            }
            if (lastName != null)
            {
                localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "lastName", lastName));
            }
            if (team != null)
            {
                localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "team", team));
            }
            if (year != null)
            {
                localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "year", year));
            }
            if (minYear != null)
            {
                localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "minYear", minYear));
            }
            if (maxYear != null)
            {
                localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "maxYear", maxYear));
            }

            localVarRequestOptions.Operation = "CoachesApi.GetCoaches";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<Coach>>("/coaches", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCoaches", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves historical head coach information and records
        /// </summary>
        /// <exception cref="CollegeFootballData.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">Optional first name filter (optional)</param>
        /// <param name="lastName">Optional last name filter (optional)</param>
        /// <param name="team">Optional team filter (optional)</param>
        /// <param name="year">Optional year filter (optional)</param>
        /// <param name="minYear">Optional start year range filter (optional)</param>
        /// <param name="maxYear">Optional end year range filter (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Coach&gt;</returns>
        public async System.Threading.Tasks.Task<List<Coach>> GetCoachesAsync(string? firstName = default(string?), string? lastName = default(string?), string? team = default(string?), int? year = default(int?), int? minYear = default(int?), int? maxYear = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            CollegeFootballData.Client.ApiResponse<List<Coach>> localVarResponse = await GetCoachesWithHttpInfoAsync(firstName, lastName, team, year, minYear, maxYear, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves historical head coach information and records
        /// </summary>
        /// <exception cref="CollegeFootballData.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">Optional first name filter (optional)</param>
        /// <param name="lastName">Optional last name filter (optional)</param>
        /// <param name="team">Optional team filter (optional)</param>
        /// <param name="year">Optional year filter (optional)</param>
        /// <param name="minYear">Optional start year range filter (optional)</param>
        /// <param name="maxYear">Optional end year range filter (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Coach&gt;)</returns>
        public async System.Threading.Tasks.Task<CollegeFootballData.Client.ApiResponse<List<Coach>>> GetCoachesWithHttpInfoAsync(string? firstName = default(string?), string? lastName = default(string?), string? team = default(string?), int? year = default(int?), int? minYear = default(int?), int? maxYear = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
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

            if (firstName != null)
            {
                localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "firstName", firstName));
            }
            if (lastName != null)
            {
                localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "lastName", lastName));
            }
            if (team != null)
            {
                localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "team", team));
            }
            if (year != null)
            {
                localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "year", year));
            }
            if (minYear != null)
            {
                localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "minYear", minYear));
            }
            if (maxYear != null)
            {
                localVarRequestOptions.QueryParameters.Add(CollegeFootballData.Client.ClientUtils.ParameterToMultiMap("", "maxYear", maxYear));
            }

            localVarRequestOptions.Operation = "CoachesApi.GetCoaches";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Coach>>("/coaches", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCoaches", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}

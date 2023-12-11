/*
 * Agent API
 *
 * The Neuron® publishes an Agent API that can be used by agents that do not wish to, or are able to, connect to the Neuron® via any of the XMPP bindings available, such as standard binary  socket, websocket or Synchronous HTTP (BOSH). Via the Agent API, the agent is permitted to do  basic tasks, such as send messages, create Agent IDs, and sign contracts with such Agent IDs.  The Full API is 
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace TAG.Networking.Agent.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStateMachinesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create Report
        /// </summary>
        /// <remarks>
        /// Creates a report relating to a state machine associated with a token.
        /// </remarks>
        /// <exception cref="TAG.Networking.Agent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createReportBody"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReportResult</returns>
        ReportResult CreateReport(CreateReportBody createReportBody = default(CreateReportBody), int operationIndex = 0);

        /// <summary>
        /// Create Report
        /// </summary>
        /// <remarks>
        /// Creates a report relating to a state machine associated with a token.
        /// </remarks>
        /// <exception cref="TAG.Networking.Agent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createReportBody"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReportResult</returns>
        ApiResponse<ReportResult> CreateReportWithHttpInfo(CreateReportBody createReportBody = default(CreateReportBody), int operationIndex = 0);
        /// <summary>
        /// Get Current State
        /// </summary>
        /// <remarks>
        /// Gets the current state of a state machine, associated with a token.
        /// </remarks>
        /// <exception cref="TAG.Networking.Agent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getCurrentStateBody"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>StateResult</returns>
        StateResult GetCurrentState(GetCurrentStateBody getCurrentStateBody = default(GetCurrentStateBody), int operationIndex = 0);

        /// <summary>
        /// Get Current State
        /// </summary>
        /// <remarks>
        /// Gets the current state of a state machine, associated with a token.
        /// </remarks>
        /// <exception cref="TAG.Networking.Agent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getCurrentStateBody"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of StateResult</returns>
        ApiResponse<StateResult> GetCurrentStateWithHttpInfo(GetCurrentStateBody getCurrentStateBody = default(GetCurrentStateBody), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStateMachinesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create Report
        /// </summary>
        /// <remarks>
        /// Creates a report relating to a state machine associated with a token.
        /// </remarks>
        /// <exception cref="TAG.Networking.Agent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createReportBody"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReportResult</returns>
        System.Threading.Tasks.Task<ReportResult> CreateReportAsync(CreateReportBody createReportBody = default(CreateReportBody), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create Report
        /// </summary>
        /// <remarks>
        /// Creates a report relating to a state machine associated with a token.
        /// </remarks>
        /// <exception cref="TAG.Networking.Agent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createReportBody"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReportResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportResult>> CreateReportWithHttpInfoAsync(CreateReportBody createReportBody = default(CreateReportBody), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get Current State
        /// </summary>
        /// <remarks>
        /// Gets the current state of a state machine, associated with a token.
        /// </remarks>
        /// <exception cref="TAG.Networking.Agent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getCurrentStateBody"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StateResult</returns>
        System.Threading.Tasks.Task<StateResult> GetCurrentStateAsync(GetCurrentStateBody getCurrentStateBody = default(GetCurrentStateBody), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Current State
        /// </summary>
        /// <remarks>
        /// Gets the current state of a state machine, associated with a token.
        /// </remarks>
        /// <exception cref="TAG.Networking.Agent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getCurrentStateBody"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StateResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<StateResult>> GetCurrentStateWithHttpInfoAsync(GetCurrentStateBody getCurrentStateBody = default(GetCurrentStateBody), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStateMachinesApi : IStateMachinesApiSync, IStateMachinesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StateMachinesApi : IStateMachinesApi
    {
        private TAG.Networking.Agent.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StateMachinesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StateMachinesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateMachinesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StateMachinesApi(string basePath)
        {
            this.Configuration = TAG.Networking.Agent.Client.Configuration.MergeConfigurations(
                TAG.Networking.Agent.Client.GlobalConfiguration.Instance,
                new TAG.Networking.Agent.Client.Configuration { BasePath = basePath }
            );
            this.Client = new TAG.Networking.Agent.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new TAG.Networking.Agent.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = TAG.Networking.Agent.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateMachinesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StateMachinesApi(TAG.Networking.Agent.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = TAG.Networking.Agent.Client.Configuration.MergeConfigurations(
                TAG.Networking.Agent.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new TAG.Networking.Agent.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new TAG.Networking.Agent.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = TAG.Networking.Agent.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateMachinesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public StateMachinesApi(TAG.Networking.Agent.Client.ISynchronousClient client, TAG.Networking.Agent.Client.IAsynchronousClient asyncClient, TAG.Networking.Agent.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = TAG.Networking.Agent.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public TAG.Networking.Agent.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public TAG.Networking.Agent.Client.ISynchronousClient Client { get; set; }

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
        public TAG.Networking.Agent.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public TAG.Networking.Agent.Client.ExceptionFactory ExceptionFactory
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
        /// Create Report Creates a report relating to a state machine associated with a token.
        /// </summary>
        /// <exception cref="TAG.Networking.Agent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createReportBody"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReportResult</returns>
        public ReportResult CreateReport(CreateReportBody createReportBody = default(CreateReportBody), int operationIndex = 0)
        {
            TAG.Networking.Agent.Client.ApiResponse<ReportResult> localVarResponse = CreateReportWithHttpInfo(createReportBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create Report Creates a report relating to a state machine associated with a token.
        /// </summary>
        /// <exception cref="TAG.Networking.Agent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createReportBody"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReportResult</returns>
        public TAG.Networking.Agent.Client.ApiResponse<ReportResult> CreateReportWithHttpInfo(CreateReportBody createReportBody = default(CreateReportBody), int operationIndex = 0)
        {
            TAG.Networking.Agent.Client.RequestOptions localVarRequestOptions = new TAG.Networking.Agent.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/xml"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/xml",
                "text/plain"
            };

            var localVarContentType = TAG.Networking.Agent.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = TAG.Networking.Agent.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = createReportBody;

            localVarRequestOptions.Operation = "StateMachinesApi.CreateReport";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (BearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<ReportResult>("/Agent/StateMachines/CreateReport", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateReport", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create Report Creates a report relating to a state machine associated with a token.
        /// </summary>
        /// <exception cref="TAG.Networking.Agent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createReportBody"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReportResult</returns>
        public async System.Threading.Tasks.Task<ReportResult> CreateReportAsync(CreateReportBody createReportBody = default(CreateReportBody), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            TAG.Networking.Agent.Client.ApiResponse<ReportResult> localVarResponse = await CreateReportWithHttpInfoAsync(createReportBody, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create Report Creates a report relating to a state machine associated with a token.
        /// </summary>
        /// <exception cref="TAG.Networking.Agent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createReportBody"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReportResult)</returns>
        public async System.Threading.Tasks.Task<TAG.Networking.Agent.Client.ApiResponse<ReportResult>> CreateReportWithHttpInfoAsync(CreateReportBody createReportBody = default(CreateReportBody), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            TAG.Networking.Agent.Client.RequestOptions localVarRequestOptions = new TAG.Networking.Agent.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/xml"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/xml",
                "text/plain"
            };

            var localVarContentType = TAG.Networking.Agent.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = TAG.Networking.Agent.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = createReportBody;

            localVarRequestOptions.Operation = "StateMachinesApi.CreateReport";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (BearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ReportResult>("/Agent/StateMachines/CreateReport", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateReport", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Current State Gets the current state of a state machine, associated with a token.
        /// </summary>
        /// <exception cref="TAG.Networking.Agent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getCurrentStateBody"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>StateResult</returns>
        public StateResult GetCurrentState(GetCurrentStateBody getCurrentStateBody = default(GetCurrentStateBody), int operationIndex = 0)
        {
            TAG.Networking.Agent.Client.ApiResponse<StateResult> localVarResponse = GetCurrentStateWithHttpInfo(getCurrentStateBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Current State Gets the current state of a state machine, associated with a token.
        /// </summary>
        /// <exception cref="TAG.Networking.Agent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getCurrentStateBody"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of StateResult</returns>
        public TAG.Networking.Agent.Client.ApiResponse<StateResult> GetCurrentStateWithHttpInfo(GetCurrentStateBody getCurrentStateBody = default(GetCurrentStateBody), int operationIndex = 0)
        {
            TAG.Networking.Agent.Client.RequestOptions localVarRequestOptions = new TAG.Networking.Agent.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/xml"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/xml",
                "text/plain"
            };

            var localVarContentType = TAG.Networking.Agent.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = TAG.Networking.Agent.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = getCurrentStateBody;

            localVarRequestOptions.Operation = "StateMachinesApi.GetCurrentState";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (BearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<StateResult>("/Agent/StateMachines/GetCurrentState", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCurrentState", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Current State Gets the current state of a state machine, associated with a token.
        /// </summary>
        /// <exception cref="TAG.Networking.Agent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getCurrentStateBody"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StateResult</returns>
        public async System.Threading.Tasks.Task<StateResult> GetCurrentStateAsync(GetCurrentStateBody getCurrentStateBody = default(GetCurrentStateBody), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            TAG.Networking.Agent.Client.ApiResponse<StateResult> localVarResponse = await GetCurrentStateWithHttpInfoAsync(getCurrentStateBody, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Current State Gets the current state of a state machine, associated with a token.
        /// </summary>
        /// <exception cref="TAG.Networking.Agent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getCurrentStateBody"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StateResult)</returns>
        public async System.Threading.Tasks.Task<TAG.Networking.Agent.Client.ApiResponse<StateResult>> GetCurrentStateWithHttpInfoAsync(GetCurrentStateBody getCurrentStateBody = default(GetCurrentStateBody), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            TAG.Networking.Agent.Client.RequestOptions localVarRequestOptions = new TAG.Networking.Agent.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/xml"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/xml",
                "text/plain"
            };

            var localVarContentType = TAG.Networking.Agent.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = TAG.Networking.Agent.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = getCurrentStateBody;

            localVarRequestOptions.Operation = "StateMachinesApi.GetCurrentState";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (BearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<StateResult>("/Agent/StateMachines/GetCurrentState", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCurrentState", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}

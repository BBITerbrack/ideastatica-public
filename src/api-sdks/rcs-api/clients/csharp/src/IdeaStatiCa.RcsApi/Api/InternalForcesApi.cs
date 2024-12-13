/*
 * RCS Rest API 1.0
 *
 * IDEA StatiCa RCS API, used for the automated design and calculation of reinforced concrete sections.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: info@ideastatica.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using IdeaRS.OpenModel;
using IdeaStatiCa.Api.RCS.Model;
using IdeaStatiCa.RcsApi.Client;
using IdeaStatiCa.RcsApi.Model;

namespace IdeaStatiCa.RcsApi.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInternalForcesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get section loading
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="sectionId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        string GetSectionLoading(Guid projectId, int sectionId, int operationIndex = 0);

        /// <summary>
        /// Get section loading
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
/// <param name="sectionId"></param>
        /// <param name="requestedType">Requested content type in the response.</param>        
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetSectionLoadingWithHttpInfo(Guid projectId, int sectionId, string requestedType = null, int operationIndex = 0);
        /// <summary>
        /// Set section loading
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="sectionId"></param>
        /// <param name="rcsSectionLoading"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        string SetSectionLoading(Guid projectId, int sectionId, RcsSectionLoading rcsSectionLoading = default(RcsSectionLoading), int operationIndex = 0);

        /// <summary>
        /// Set section loading
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
/// <param name="sectionId"></param>
/// <param name="rcsSectionLoading"> (optional)</param>
        /// <param name="requestedType">Requested content type in the response.</param>        
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> SetSectionLoadingWithHttpInfo(Guid projectId, int sectionId, RcsSectionLoading rcsSectionLoading = default(RcsSectionLoading), string requestedType = null, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInternalForcesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get section loading
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="sectionId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GetSectionLoadingAsync(Guid projectId, int sectionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get section loading
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="sectionId"></param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GetSectionLoadingWithHttpInfoAsync(Guid projectId, int sectionId, string requestedType = null, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Set section loading
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="sectionId"></param>
        /// <param name="rcsSectionLoading"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> SetSectionLoadingAsync(Guid projectId, int sectionId, RcsSectionLoading rcsSectionLoading = default(RcsSectionLoading), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Set section loading
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="sectionId"></param>
        /// <param name="rcsSectionLoading"> (optional)</param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> SetSectionLoadingWithHttpInfoAsync(Guid projectId, int sectionId, RcsSectionLoading rcsSectionLoading = default(RcsSectionLoading), string requestedType = null, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInternalForcesApi : IInternalForcesApiSync, IInternalForcesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InternalForcesApi : IInternalForcesApi
    {
        private IdeaStatiCa.RcsApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalForcesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InternalForcesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalForcesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InternalForcesApi(string basePath)
        {
            this.Configuration = IdeaStatiCa.RcsApi.Client.Configuration.MergeConfigurations(
                IdeaStatiCa.RcsApi.Client.GlobalConfiguration.Instance,
                new IdeaStatiCa.RcsApi.Client.Configuration { BasePath = basePath }
            );
            this.Client = new IdeaStatiCa.RcsApi.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new IdeaStatiCa.RcsApi.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = IdeaStatiCa.RcsApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalForcesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InternalForcesApi(IdeaStatiCa.RcsApi.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = IdeaStatiCa.RcsApi.Client.Configuration.MergeConfigurations(
                IdeaStatiCa.RcsApi.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new IdeaStatiCa.RcsApi.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new IdeaStatiCa.RcsApi.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = IdeaStatiCa.RcsApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalForcesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public InternalForcesApi(IdeaStatiCa.RcsApi.Client.ISynchronousClient client, IdeaStatiCa.RcsApi.Client.IAsynchronousClient asyncClient, IdeaStatiCa.RcsApi.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = IdeaStatiCa.RcsApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public IdeaStatiCa.RcsApi.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public IdeaStatiCa.RcsApi.Client.ISynchronousClient Client { get; set; }

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
        public IdeaStatiCa.RcsApi.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IdeaStatiCa.RcsApi.Client.ExceptionFactory ExceptionFactory
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
        /// Get section loading 
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="sectionId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        public string GetSectionLoading(Guid projectId, int sectionId, int operationIndex = 0)
        {
            IdeaStatiCa.RcsApi.Client.ApiResponse<string> localVarResponse = GetSectionLoadingWithHttpInfo(projectId, sectionId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get section loading 
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
/// <param name="sectionId"></param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        public IdeaStatiCa.RcsApi.Client.ApiResponse<string> GetSectionLoadingWithHttpInfo(Guid projectId, int sectionId, string requestedType = null, int operationIndex = 0)
        {
            IdeaStatiCa.RcsApi.Client.RequestOptions localVarRequestOptions = new IdeaStatiCa.RcsApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = IdeaStatiCa.RcsApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            string localVarAccept = requestedType;

            if(string.IsNullOrEmpty(localVarAccept))
            {
                localVarAccept = IdeaStatiCa.RcsApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
                if (localVarAccept != null)
                {
                    localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
                }
            }

            localVarRequestOptions.PathParameters.Add("projectId", IdeaStatiCa.RcsApi.Client.ClientUtils.ParameterToString(projectId)); // path parameter
            localVarRequestOptions.PathParameters.Add("sectionId", IdeaStatiCa.RcsApi.Client.ClientUtils.ParameterToString(sectionId)); // path parameter

            localVarRequestOptions.Operation = "InternalForcesApi.GetSectionLoading";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<string>("/api/1/projects/{projectId}/sections/{sectionId}/internal-forces", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSectionLoading", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get section loading 
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="sectionId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GetSectionLoadingAsync(Guid projectId, int sectionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            IdeaStatiCa.RcsApi.Client.ApiResponse<string> localVarResponse = await GetSectionLoadingWithHttpInfoAsync(projectId, sectionId, null, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get section loading 
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="sectionId"></param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<IdeaStatiCa.RcsApi.Client.ApiResponse<string>> GetSectionLoadingWithHttpInfoAsync(Guid projectId, int sectionId, string requestedType = null, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            IdeaStatiCa.RcsApi.Client.RequestOptions localVarRequestOptions = new IdeaStatiCa.RcsApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = IdeaStatiCa.RcsApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            string localVarAccept = requestedType;
            if(string.IsNullOrEmpty(localVarAccept))
            {
                localVarAccept = IdeaStatiCa.RcsApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            }

            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("projectId", IdeaStatiCa.RcsApi.Client.ClientUtils.ParameterToString(projectId)); // path parameter
            localVarRequestOptions.PathParameters.Add("sectionId", IdeaStatiCa.RcsApi.Client.ClientUtils.ParameterToString(sectionId)); // path parameter

            localVarRequestOptions.Operation = "InternalForcesApi.GetSectionLoading";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<string>("/api/1/projects/{projectId}/sections/{sectionId}/internal-forces", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSectionLoading", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set section loading 
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="sectionId"></param>
        /// <param name="rcsSectionLoading"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        public string SetSectionLoading(Guid projectId, int sectionId, RcsSectionLoading rcsSectionLoading = default(RcsSectionLoading), int operationIndex = 0)
        {
            IdeaStatiCa.RcsApi.Client.ApiResponse<string> localVarResponse = SetSectionLoadingWithHttpInfo(projectId, sectionId, rcsSectionLoading);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set section loading 
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
/// <param name="sectionId"></param>
/// <param name="rcsSectionLoading"> (optional)</param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        public IdeaStatiCa.RcsApi.Client.ApiResponse<string> SetSectionLoadingWithHttpInfo(Guid projectId, int sectionId, RcsSectionLoading rcsSectionLoading = default(RcsSectionLoading), string requestedType = null, int operationIndex = 0)
        {
            IdeaStatiCa.RcsApi.Client.RequestOptions localVarRequestOptions = new IdeaStatiCa.RcsApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/xml",
                "text/xml",
                "application/*+xml",
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = IdeaStatiCa.RcsApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            string localVarAccept = requestedType;

            if(string.IsNullOrEmpty(localVarAccept))
            {
                localVarAccept = IdeaStatiCa.RcsApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
                if (localVarAccept != null)
                {
                    localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
                }
            }

            localVarRequestOptions.PathParameters.Add("projectId", IdeaStatiCa.RcsApi.Client.ClientUtils.ParameterToString(projectId)); // path parameter
            localVarRequestOptions.PathParameters.Add("sectionId", IdeaStatiCa.RcsApi.Client.ClientUtils.ParameterToString(sectionId)); // path parameter
            localVarRequestOptions.Data = rcsSectionLoading;

            localVarRequestOptions.Operation = "InternalForcesApi.SetSectionLoading";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<string>("/api/1/projects/{projectId}/sections/{sectionId}/internal-forces", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetSectionLoading", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set section loading 
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="sectionId"></param>
        /// <param name="rcsSectionLoading"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> SetSectionLoadingAsync(Guid projectId, int sectionId, RcsSectionLoading rcsSectionLoading = default(RcsSectionLoading), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            IdeaStatiCa.RcsApi.Client.ApiResponse<string> localVarResponse = await SetSectionLoadingWithHttpInfoAsync(projectId, sectionId, rcsSectionLoading, null, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set section loading 
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="sectionId"></param>
        /// <param name="rcsSectionLoading"> (optional)</param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<IdeaStatiCa.RcsApi.Client.ApiResponse<string>> SetSectionLoadingWithHttpInfoAsync(Guid projectId, int sectionId, RcsSectionLoading rcsSectionLoading = default(RcsSectionLoading), string requestedType = null, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            IdeaStatiCa.RcsApi.Client.RequestOptions localVarRequestOptions = new IdeaStatiCa.RcsApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/xml", 
                "text/xml", 
                "application/*+xml", 
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = IdeaStatiCa.RcsApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            string localVarAccept = requestedType;
            if(string.IsNullOrEmpty(localVarAccept))
            {
                localVarAccept = IdeaStatiCa.RcsApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            }

            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("projectId", IdeaStatiCa.RcsApi.Client.ClientUtils.ParameterToString(projectId)); // path parameter
            localVarRequestOptions.PathParameters.Add("sectionId", IdeaStatiCa.RcsApi.Client.ClientUtils.ParameterToString(sectionId)); // path parameter
            localVarRequestOptions.Data = rcsSectionLoading;

            localVarRequestOptions.Operation = "InternalForcesApi.SetSectionLoading";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<string>("/api/1/projects/{projectId}/sections/{sectionId}/internal-forces", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetSectionLoading", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}

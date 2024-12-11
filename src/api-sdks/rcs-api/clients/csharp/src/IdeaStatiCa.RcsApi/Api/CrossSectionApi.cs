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
    public interface ICrossSectionApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Import reinforced cross-section
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="rcsReinforcedCrossSectionImportData"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RcsReinforcedCrossSection</returns>
        RcsReinforcedCrossSection ImportReinforcedCrossSection(Guid projectId, RcsReinforcedCrossSectionImportData rcsReinforcedCrossSectionImportData = default(RcsReinforcedCrossSectionImportData), int operationIndex = 0);

        /// <summary>
        /// Import reinforced cross-section
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
/// <param name="rcsReinforcedCrossSectionImportData"> (optional)</param>
        /// <param name="requestedType">Requested content type in the response.</param>        
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RcsReinforcedCrossSection</returns>
        ApiResponse<RcsReinforcedCrossSection> ImportReinforcedCrossSectionWithHttpInfo(Guid projectId, RcsReinforcedCrossSectionImportData rcsReinforcedCrossSectionImportData = default(RcsReinforcedCrossSectionImportData), string requestedType = null, int operationIndex = 0);
        /// <summary>
        /// Get reinforced cross sections
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;RcsReinforcedCrossSection&gt;</returns>
        List<RcsReinforcedCrossSection> ReinforcedCrossSections(Guid projectId, int operationIndex = 0);

        /// <summary>
        /// Get reinforced cross sections
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="requestedType">Requested content type in the response.</param>        
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;RcsReinforcedCrossSection&gt;</returns>
        ApiResponse<List<RcsReinforcedCrossSection>> ReinforcedCrossSectionsWithHttpInfo(Guid projectId, string requestedType = null, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICrossSectionApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Import reinforced cross-section
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="rcsReinforcedCrossSectionImportData"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RcsReinforcedCrossSection</returns>
        System.Threading.Tasks.Task<RcsReinforcedCrossSection> ImportReinforcedCrossSectionAsync(Guid projectId, RcsReinforcedCrossSectionImportData rcsReinforcedCrossSectionImportData = default(RcsReinforcedCrossSectionImportData), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Import reinforced cross-section
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="rcsReinforcedCrossSectionImportData"> (optional)</param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RcsReinforcedCrossSection)</returns>
        System.Threading.Tasks.Task<ApiResponse<RcsReinforcedCrossSection>> ImportReinforcedCrossSectionWithHttpInfoAsync(Guid projectId, RcsReinforcedCrossSectionImportData rcsReinforcedCrossSectionImportData = default(RcsReinforcedCrossSectionImportData), string requestedType = null, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get reinforced cross sections
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;RcsReinforcedCrossSection&gt;</returns>
        System.Threading.Tasks.Task<List<RcsReinforcedCrossSection>> ReinforcedCrossSectionsAsync(Guid projectId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get reinforced cross sections
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;RcsReinforcedCrossSection&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<RcsReinforcedCrossSection>>> ReinforcedCrossSectionsWithHttpInfoAsync(Guid projectId, string requestedType = null, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICrossSectionApi : ICrossSectionApiSync, ICrossSectionApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CrossSectionApi : ICrossSectionApi
    {
        private IdeaStatiCa.RcsApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossSectionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CrossSectionApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossSectionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CrossSectionApi(string basePath)
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
        /// Initializes a new instance of the <see cref="CrossSectionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CrossSectionApi(IdeaStatiCa.RcsApi.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="CrossSectionApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CrossSectionApi(IdeaStatiCa.RcsApi.Client.ISynchronousClient client, IdeaStatiCa.RcsApi.Client.IAsynchronousClient asyncClient, IdeaStatiCa.RcsApi.Client.IReadableConfiguration configuration)
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
        /// Import reinforced cross-section 
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="rcsReinforcedCrossSectionImportData"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RcsReinforcedCrossSection</returns>
        public RcsReinforcedCrossSection ImportReinforcedCrossSection(Guid projectId, RcsReinforcedCrossSectionImportData rcsReinforcedCrossSectionImportData = default(RcsReinforcedCrossSectionImportData), int operationIndex = 0)
        {
            IdeaStatiCa.RcsApi.Client.ApiResponse<RcsReinforcedCrossSection> localVarResponse = ImportReinforcedCrossSectionWithHttpInfo(projectId, rcsReinforcedCrossSectionImportData);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Import reinforced cross-section 
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
/// <param name="rcsReinforcedCrossSectionImportData"> (optional)</param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RcsReinforcedCrossSection</returns>
        public IdeaStatiCa.RcsApi.Client.ApiResponse<RcsReinforcedCrossSection> ImportReinforcedCrossSectionWithHttpInfo(Guid projectId, RcsReinforcedCrossSectionImportData rcsReinforcedCrossSectionImportData = default(RcsReinforcedCrossSectionImportData), string requestedType = null, int operationIndex = 0)
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
            localVarRequestOptions.Data = rcsReinforcedCrossSectionImportData;

            localVarRequestOptions.Operation = "CrossSectionApi.ImportReinforcedCrossSection";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<RcsReinforcedCrossSection>("/api/1/projects/{projectId}/cross-sections/import-reinforced-cross-section", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ImportReinforcedCrossSection", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Import reinforced cross-section 
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="rcsReinforcedCrossSectionImportData"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RcsReinforcedCrossSection</returns>
        public async System.Threading.Tasks.Task<RcsReinforcedCrossSection> ImportReinforcedCrossSectionAsync(Guid projectId, RcsReinforcedCrossSectionImportData rcsReinforcedCrossSectionImportData = default(RcsReinforcedCrossSectionImportData), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            IdeaStatiCa.RcsApi.Client.ApiResponse<RcsReinforcedCrossSection> localVarResponse = await ImportReinforcedCrossSectionWithHttpInfoAsync(projectId, rcsReinforcedCrossSectionImportData, null, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Import reinforced cross-section 
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="rcsReinforcedCrossSectionImportData"> (optional)</param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RcsReinforcedCrossSection)</returns>
        public async System.Threading.Tasks.Task<IdeaStatiCa.RcsApi.Client.ApiResponse<RcsReinforcedCrossSection>> ImportReinforcedCrossSectionWithHttpInfoAsync(Guid projectId, RcsReinforcedCrossSectionImportData rcsReinforcedCrossSectionImportData = default(RcsReinforcedCrossSectionImportData), string requestedType = null, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            localVarRequestOptions.Data = rcsReinforcedCrossSectionImportData;

            localVarRequestOptions.Operation = "CrossSectionApi.ImportReinforcedCrossSection";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<RcsReinforcedCrossSection>("/api/1/projects/{projectId}/cross-sections/import-reinforced-cross-section", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ImportReinforcedCrossSection", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get reinforced cross sections 
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;RcsReinforcedCrossSection&gt;</returns>
        public List<RcsReinforcedCrossSection> ReinforcedCrossSections(Guid projectId, int operationIndex = 0)
        {
            IdeaStatiCa.RcsApi.Client.ApiResponse<List<RcsReinforcedCrossSection>> localVarResponse = ReinforcedCrossSectionsWithHttpInfo(projectId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get reinforced cross sections 
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;RcsReinforcedCrossSection&gt;</returns>
        public IdeaStatiCa.RcsApi.Client.ApiResponse<List<RcsReinforcedCrossSection>> ReinforcedCrossSectionsWithHttpInfo(Guid projectId, string requestedType = null, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "CrossSectionApi.ReinforcedCrossSections";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<RcsReinforcedCrossSection>>("/api/1/projects/{projectId}/cross-sections/reinforced-cross-sections", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReinforcedCrossSections", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get reinforced cross sections 
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;RcsReinforcedCrossSection&gt;</returns>
        public async System.Threading.Tasks.Task<List<RcsReinforcedCrossSection>> ReinforcedCrossSectionsAsync(Guid projectId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            IdeaStatiCa.RcsApi.Client.ApiResponse<List<RcsReinforcedCrossSection>> localVarResponse = await ReinforcedCrossSectionsWithHttpInfoAsync(projectId, null, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get reinforced cross sections 
        /// </summary>
        /// <exception cref="IdeaStatiCa.RcsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;RcsReinforcedCrossSection&gt;)</returns>
        public async System.Threading.Tasks.Task<IdeaStatiCa.RcsApi.Client.ApiResponse<List<RcsReinforcedCrossSection>>> ReinforcedCrossSectionsWithHttpInfoAsync(Guid projectId, string requestedType = null, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Operation = "CrossSectionApi.ReinforcedCrossSections";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<RcsReinforcedCrossSection>>("/api/1/projects/{projectId}/cross-sections/reinforced-cross-sections", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReinforcedCrossSections", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}

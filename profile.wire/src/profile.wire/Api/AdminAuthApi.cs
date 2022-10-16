/*
 * TP.Profile.Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using profile.wire.Client;
using profile.wire.Model;

namespace profile.wire.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAdminAuthApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="profile.wire.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailPasswordLoginReq"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>LoginRes</returns>
        LoginRes AdminAuthLoginPost(EmailPasswordLoginReq? emailPasswordLoginReq = default(EmailPasswordLoginReq?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="profile.wire.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailPasswordLoginReq"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of LoginRes</returns>
        ApiResponse<LoginRes> AdminAuthLoginPostWithHttpInfo(EmailPasswordLoginReq? emailPasswordLoginReq = default(EmailPasswordLoginReq?), int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="profile.wire.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshTokenReq"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>LoginRes</returns>
        LoginRes AdminAuthRefreshTokenPost(RefreshTokenReq? refreshTokenReq = default(RefreshTokenReq?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="profile.wire.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshTokenReq"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of LoginRes</returns>
        ApiResponse<LoginRes> AdminAuthRefreshTokenPostWithHttpInfo(RefreshTokenReq? refreshTokenReq = default(RefreshTokenReq?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAdminAuthApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="profile.wire.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailPasswordLoginReq"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LoginRes</returns>
        System.Threading.Tasks.Task<LoginRes> AdminAuthLoginPostAsync(EmailPasswordLoginReq? emailPasswordLoginReq = default(EmailPasswordLoginReq?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="profile.wire.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailPasswordLoginReq"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LoginRes)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoginRes>> AdminAuthLoginPostWithHttpInfoAsync(EmailPasswordLoginReq? emailPasswordLoginReq = default(EmailPasswordLoginReq?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="profile.wire.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshTokenReq"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LoginRes</returns>
        System.Threading.Tasks.Task<LoginRes> AdminAuthRefreshTokenPostAsync(RefreshTokenReq? refreshTokenReq = default(RefreshTokenReq?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="profile.wire.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshTokenReq"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LoginRes)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoginRes>> AdminAuthRefreshTokenPostWithHttpInfoAsync(RefreshTokenReq? refreshTokenReq = default(RefreshTokenReq?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAdminAuthApi : IAdminAuthApiSync, IAdminAuthApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AdminAuthApi : IAdminAuthApi
    {
        private profile.wire.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AdminAuthApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AdminAuthApi(string basePath)
        {
            this.Configuration = profile.wire.Client.Configuration.MergeConfigurations(
                profile.wire.Client.GlobalConfiguration.Instance,
                new profile.wire.Client.Configuration { BasePath = basePath }
            );
            this.Client = new profile.wire.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new profile.wire.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = profile.wire.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAuthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AdminAuthApi(profile.wire.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = profile.wire.Client.Configuration.MergeConfigurations(
                profile.wire.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new profile.wire.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new profile.wire.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = profile.wire.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAuthApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AdminAuthApi(profile.wire.Client.ISynchronousClient client, profile.wire.Client.IAsynchronousClient asyncClient, profile.wire.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = profile.wire.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public profile.wire.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public profile.wire.Client.ISynchronousClient Client { get; set; }

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
        public profile.wire.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public profile.wire.Client.ExceptionFactory ExceptionFactory
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
        ///  
        /// </summary>
        /// <exception cref="profile.wire.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailPasswordLoginReq"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>LoginRes</returns>
        public LoginRes AdminAuthLoginPost(EmailPasswordLoginReq? emailPasswordLoginReq = default(EmailPasswordLoginReq?), int operationIndex = 0)
        {
            profile.wire.Client.ApiResponse<LoginRes> localVarResponse = AdminAuthLoginPostWithHttpInfo(emailPasswordLoginReq);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="profile.wire.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailPasswordLoginReq"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of LoginRes</returns>
        public profile.wire.Client.ApiResponse<LoginRes> AdminAuthLoginPostWithHttpInfo(EmailPasswordLoginReq? emailPasswordLoginReq = default(EmailPasswordLoginReq?), int operationIndex = 0)
        {
            profile.wire.Client.RequestOptions localVarRequestOptions = new profile.wire.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = profile.wire.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = profile.wire.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = emailPasswordLoginReq;

            localVarRequestOptions.Operation = "AdminAuthApi.AdminAuthLoginPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<LoginRes>("/AdminAuth/Login", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AdminAuthLoginPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="profile.wire.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailPasswordLoginReq"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LoginRes</returns>
        public async System.Threading.Tasks.Task<LoginRes> AdminAuthLoginPostAsync(EmailPasswordLoginReq? emailPasswordLoginReq = default(EmailPasswordLoginReq?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            profile.wire.Client.ApiResponse<LoginRes> localVarResponse = await AdminAuthLoginPostWithHttpInfoAsync(emailPasswordLoginReq, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="profile.wire.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailPasswordLoginReq"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LoginRes)</returns>
        public async System.Threading.Tasks.Task<profile.wire.Client.ApiResponse<LoginRes>> AdminAuthLoginPostWithHttpInfoAsync(EmailPasswordLoginReq? emailPasswordLoginReq = default(EmailPasswordLoginReq?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            profile.wire.Client.RequestOptions localVarRequestOptions = new profile.wire.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = profile.wire.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = profile.wire.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = emailPasswordLoginReq;

            localVarRequestOptions.Operation = "AdminAuthApi.AdminAuthLoginPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<LoginRes>("/AdminAuth/Login", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AdminAuthLoginPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="profile.wire.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshTokenReq"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>LoginRes</returns>
        public LoginRes AdminAuthRefreshTokenPost(RefreshTokenReq? refreshTokenReq = default(RefreshTokenReq?), int operationIndex = 0)
        {
            profile.wire.Client.ApiResponse<LoginRes> localVarResponse = AdminAuthRefreshTokenPostWithHttpInfo(refreshTokenReq);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="profile.wire.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshTokenReq"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of LoginRes</returns>
        public profile.wire.Client.ApiResponse<LoginRes> AdminAuthRefreshTokenPostWithHttpInfo(RefreshTokenReq? refreshTokenReq = default(RefreshTokenReq?), int operationIndex = 0)
        {
            profile.wire.Client.RequestOptions localVarRequestOptions = new profile.wire.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = profile.wire.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = profile.wire.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = refreshTokenReq;

            localVarRequestOptions.Operation = "AdminAuthApi.AdminAuthRefreshTokenPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<LoginRes>("/AdminAuth/RefreshToken", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AdminAuthRefreshTokenPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="profile.wire.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshTokenReq"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LoginRes</returns>
        public async System.Threading.Tasks.Task<LoginRes> AdminAuthRefreshTokenPostAsync(RefreshTokenReq? refreshTokenReq = default(RefreshTokenReq?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            profile.wire.Client.ApiResponse<LoginRes> localVarResponse = await AdminAuthRefreshTokenPostWithHttpInfoAsync(refreshTokenReq, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="profile.wire.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshTokenReq"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LoginRes)</returns>
        public async System.Threading.Tasks.Task<profile.wire.Client.ApiResponse<LoginRes>> AdminAuthRefreshTokenPostWithHttpInfoAsync(RefreshTokenReq? refreshTokenReq = default(RefreshTokenReq?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            profile.wire.Client.RequestOptions localVarRequestOptions = new profile.wire.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = profile.wire.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = profile.wire.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = refreshTokenReq;

            localVarRequestOptions.Operation = "AdminAuthApi.AdminAuthRefreshTokenPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<LoginRes>("/AdminAuth/RefreshToken", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AdminAuthRefreshTokenPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}

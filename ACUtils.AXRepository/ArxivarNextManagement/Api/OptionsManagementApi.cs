/* 
 * WebAPI - Area Management
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: management
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ACUtils.AXRepository.ArxivarNextManagement.Client;
using ACUtils.AXRepository.ArxivarNextManagement.Model;

namespace ACUtils.AXRepository.ArxivarNextManagement.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOptionsManagementApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This call retrieves options by the given argument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="argument">Argument filter</param>
        /// <returns>List&lt;OptionsDTO&gt;</returns>
        List<OptionsDTO> OptionsManagementGetByArgomento (string argument);

        /// <summary>
        /// This call retrieves options by the given argument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="argument">Argument filter</param>
        /// <returns>ApiResponse of List&lt;OptionsDTO&gt;</returns>
        ApiResponse<List<OptionsDTO>> OptionsManagementGetByArgomentoWithHttpInfo (string argument);
        /// <summary>
        /// This call update options value for a given argument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestDto">Option information</param>
        /// <returns></returns>
        void OptionsManagementSetOptionsValueByArgomento (OptionsRequestDTO requestDto);

        /// <summary>
        /// This call update options value for a given argument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestDto">Option information</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> OptionsManagementSetOptionsValueByArgomentoWithHttpInfo (OptionsRequestDTO requestDto);
        /// <summary>
        /// This call update visible options for given arguments and users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Options information</param>
        /// <returns></returns>
        void OptionsManagementSetOptionsVisibleByArgomentiUtenti (List<OptionsUserVisibleRequestDTO> request);

        /// <summary>
        /// This call update visible options for given arguments and users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Options information</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> OptionsManagementSetOptionsVisibleByArgomentiUtentiWithHttpInfo (List<OptionsUserVisibleRequestDTO> request);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This call retrieves options by the given argument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="argument">Argument filter</param>
        /// <returns>Task of List&lt;OptionsDTO&gt;</returns>
        System.Threading.Tasks.Task<List<OptionsDTO>> OptionsManagementGetByArgomentoAsync (string argument);

        /// <summary>
        /// This call retrieves options by the given argument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="argument">Argument filter</param>
        /// <returns>Task of ApiResponse (List&lt;OptionsDTO&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<OptionsDTO>>> OptionsManagementGetByArgomentoAsyncWithHttpInfo (string argument);
        /// <summary>
        /// This call update options value for a given argument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestDto">Option information</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task OptionsManagementSetOptionsValueByArgomentoAsync (OptionsRequestDTO requestDto);

        /// <summary>
        /// This call update options value for a given argument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestDto">Option information</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> OptionsManagementSetOptionsValueByArgomentoAsyncWithHttpInfo (OptionsRequestDTO requestDto);
        /// <summary>
        /// This call update visible options for given arguments and users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Options information</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task OptionsManagementSetOptionsVisibleByArgomentiUtentiAsync (List<OptionsUserVisibleRequestDTO> request);

        /// <summary>
        /// This call update visible options for given arguments and users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Options information</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> OptionsManagementSetOptionsVisibleByArgomentiUtentiAsyncWithHttpInfo (List<OptionsUserVisibleRequestDTO> request);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OptionsManagementApi : IOptionsManagementApi
    {
        private ACUtils.AXRepository.ArxivarNextManagement.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OptionsManagementApi(String basePath)
        {
            this.Configuration = new ACUtils.AXRepository.ArxivarNextManagement.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ACUtils.AXRepository.ArxivarNextManagement.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OptionsManagementApi(ACUtils.AXRepository.ArxivarNextManagement.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = ACUtils.AXRepository.ArxivarNextManagement.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = ACUtils.AXRepository.ArxivarNextManagement.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ACUtils.AXRepository.ArxivarNextManagement.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ACUtils.AXRepository.ArxivarNextManagement.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// This call retrieves options by the given argument 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="argument">Argument filter</param>
        /// <returns>List&lt;OptionsDTO&gt;</returns>
        public List<OptionsDTO> OptionsManagementGetByArgomento (string argument)
        {
             ApiResponse<List<OptionsDTO>> localVarResponse = OptionsManagementGetByArgomentoWithHttpInfo(argument);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call retrieves options by the given argument 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="argument">Argument filter</param>
        /// <returns>ApiResponse of List&lt;OptionsDTO&gt;</returns>
        public ApiResponse< List<OptionsDTO> > OptionsManagementGetByArgomentoWithHttpInfo (string argument)
        {
            // verify the required parameter 'argument' is set
            if (argument == null)
                throw new ApiException(400, "Missing required parameter 'argument' when calling OptionsManagementApi->OptionsManagementGetByArgomento");

            var localVarPath = "/api/management/Options/topic/{argument}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (argument != null) localVarPathParams.Add("argument", this.Configuration.ApiClient.ParameterToString(argument)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OptionsManagementGetByArgomento", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<OptionsDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OptionsDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OptionsDTO>)));
        }

        /// <summary>
        /// This call retrieves options by the given argument 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="argument">Argument filter</param>
        /// <returns>Task of List&lt;OptionsDTO&gt;</returns>
        public async System.Threading.Tasks.Task<List<OptionsDTO>> OptionsManagementGetByArgomentoAsync (string argument)
        {
             ApiResponse<List<OptionsDTO>> localVarResponse = await OptionsManagementGetByArgomentoAsyncWithHttpInfo(argument);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call retrieves options by the given argument 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="argument">Argument filter</param>
        /// <returns>Task of ApiResponse (List&lt;OptionsDTO&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<OptionsDTO>>> OptionsManagementGetByArgomentoAsyncWithHttpInfo (string argument)
        {
            // verify the required parameter 'argument' is set
            if (argument == null)
                throw new ApiException(400, "Missing required parameter 'argument' when calling OptionsManagementApi->OptionsManagementGetByArgomento");

            var localVarPath = "/api/management/Options/topic/{argument}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (argument != null) localVarPathParams.Add("argument", this.Configuration.ApiClient.ParameterToString(argument)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OptionsManagementGetByArgomento", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<OptionsDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OptionsDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OptionsDTO>)));
        }

        /// <summary>
        /// This call update options value for a given argument 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestDto">Option information</param>
        /// <returns></returns>
        public void OptionsManagementSetOptionsValueByArgomento (OptionsRequestDTO requestDto)
        {
             OptionsManagementSetOptionsValueByArgomentoWithHttpInfo(requestDto);
        }

        /// <summary>
        /// This call update options value for a given argument 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestDto">Option information</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> OptionsManagementSetOptionsValueByArgomentoWithHttpInfo (OptionsRequestDTO requestDto)
        {
            // verify the required parameter 'requestDto' is set
            if (requestDto == null)
                throw new ApiException(400, "Missing required parameter 'requestDto' when calling OptionsManagementApi->OptionsManagementSetOptionsValueByArgomento");

            var localVarPath = "/api/management/Options/topic";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (requestDto != null && requestDto.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(requestDto); // http body (model) parameter
            }
            else
            {
                localVarPostBody = requestDto; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OptionsManagementSetOptionsValueByArgomento", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// This call update options value for a given argument 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestDto">Option information</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task OptionsManagementSetOptionsValueByArgomentoAsync (OptionsRequestDTO requestDto)
        {
             await OptionsManagementSetOptionsValueByArgomentoAsyncWithHttpInfo(requestDto);

        }

        /// <summary>
        /// This call update options value for a given argument 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestDto">Option information</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> OptionsManagementSetOptionsValueByArgomentoAsyncWithHttpInfo (OptionsRequestDTO requestDto)
        {
            // verify the required parameter 'requestDto' is set
            if (requestDto == null)
                throw new ApiException(400, "Missing required parameter 'requestDto' when calling OptionsManagementApi->OptionsManagementSetOptionsValueByArgomento");

            var localVarPath = "/api/management/Options/topic";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (requestDto != null && requestDto.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(requestDto); // http body (model) parameter
            }
            else
            {
                localVarPostBody = requestDto; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OptionsManagementSetOptionsValueByArgomento", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// This call update visible options for given arguments and users 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Options information</param>
        /// <returns></returns>
        public void OptionsManagementSetOptionsVisibleByArgomentiUtenti (List<OptionsUserVisibleRequestDTO> request)
        {
             OptionsManagementSetOptionsVisibleByArgomentiUtentiWithHttpInfo(request);
        }

        /// <summary>
        /// This call update visible options for given arguments and users 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Options information</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> OptionsManagementSetOptionsVisibleByArgomentiUtentiWithHttpInfo (List<OptionsUserVisibleRequestDTO> request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling OptionsManagementApi->OptionsManagementSetOptionsVisibleByArgomentiUtenti");

            var localVarPath = "/api/management/Options/topicsAndUsersVisible";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OptionsManagementSetOptionsVisibleByArgomentiUtenti", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// This call update visible options for given arguments and users 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Options information</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task OptionsManagementSetOptionsVisibleByArgomentiUtentiAsync (List<OptionsUserVisibleRequestDTO> request)
        {
             await OptionsManagementSetOptionsVisibleByArgomentiUtentiAsyncWithHttpInfo(request);

        }

        /// <summary>
        /// This call update visible options for given arguments and users 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Options information</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> OptionsManagementSetOptionsVisibleByArgomentiUtentiAsyncWithHttpInfo (List<OptionsUserVisibleRequestDTO> request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling OptionsManagementApi->OptionsManagementSetOptionsVisibleByArgomentiUtenti");

            var localVarPath = "/api/management/Options/topicsAndUsersVisible";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OptionsManagementSetOptionsVisibleByArgomentiUtenti", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}

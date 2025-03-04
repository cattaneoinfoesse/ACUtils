/* 
 * WebAPI
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: data
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ACUtils.AXRepository.ArxivarNext.Client;
using ACUtils.AXRepository.ArxivarNext.Model;

namespace ACUtils.AXRepository.ArxivarNext.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStatesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This call returns all the states defined in Arxivar by the given document type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentTypeId">Document Type Identifier</param>
        /// <returns>List&lt;StateBaseDto&gt;</returns>
        List<StateBaseDto> StatesGet (int? documentTypeId);

        /// <summary>
        /// This call returns all the states defined in Arxivar by the given document type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentTypeId">Document Type Identifier</param>
        /// <returns>ApiResponse of List&lt;StateBaseDto&gt;</returns>
        ApiResponse<List<StateBaseDto>> StatesGetWithHttpInfo (int? documentTypeId);
        /// <summary>
        /// This call returns the document states for a document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">Document Identifier</param>
        /// <returns>StateBaseDto</returns>
        StateBaseDto StatesGetByDocNumber (int? docnumber);

        /// <summary>
        /// This call returns the document states for a document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">Document Identifier</param>
        /// <returns>ApiResponse of StateBaseDto</returns>
        ApiResponse<StateBaseDto> StatesGetByDocNumberWithHttpInfo (int? docnumber);
        /// <summary>
        /// This call returns all the document states in ARXivar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;StateBaseDto&gt;</returns>
        List<StateBaseDto> StatesGet_0 ();

        /// <summary>
        /// This call returns all the document states in ARXivar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;StateBaseDto&gt;</returns>
        ApiResponse<List<StateBaseDto>> StatesGet_0WithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This call returns all the states defined in Arxivar by the given document type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentTypeId">Document Type Identifier</param>
        /// <returns>Task of List&lt;StateBaseDto&gt;</returns>
        System.Threading.Tasks.Task<List<StateBaseDto>> StatesGetAsync (int? documentTypeId);

        /// <summary>
        /// This call returns all the states defined in Arxivar by the given document type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentTypeId">Document Type Identifier</param>
        /// <returns>Task of ApiResponse (List&lt;StateBaseDto&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<StateBaseDto>>> StatesGetAsyncWithHttpInfo (int? documentTypeId);
        /// <summary>
        /// This call returns the document states for a document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">Document Identifier</param>
        /// <returns>Task of StateBaseDto</returns>
        System.Threading.Tasks.Task<StateBaseDto> StatesGetByDocNumberAsync (int? docnumber);

        /// <summary>
        /// This call returns the document states for a document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">Document Identifier</param>
        /// <returns>Task of ApiResponse (StateBaseDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<StateBaseDto>> StatesGetByDocNumberAsyncWithHttpInfo (int? docnumber);
        /// <summary>
        /// This call returns all the document states in ARXivar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;StateBaseDto&gt;</returns>
        System.Threading.Tasks.Task<List<StateBaseDto>> StatesGet_0Async ();

        /// <summary>
        /// This call returns all the document states in ARXivar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;StateBaseDto&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<StateBaseDto>>> StatesGet_0AsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StatesApi : IStatesApi
    {
        private ACUtils.AXRepository.ArxivarNext.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatesApi(String basePath)
        {
            this.Configuration = new ACUtils.AXRepository.ArxivarNext.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ACUtils.AXRepository.ArxivarNext.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StatesApi(ACUtils.AXRepository.ArxivarNext.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = ACUtils.AXRepository.ArxivarNext.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = ACUtils.AXRepository.ArxivarNext.Client.Configuration.DefaultExceptionFactory;
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
        public ACUtils.AXRepository.ArxivarNext.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ACUtils.AXRepository.ArxivarNext.Client.ExceptionFactory ExceptionFactory
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
        /// This call returns all the states defined in Arxivar by the given document type 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentTypeId">Document Type Identifier</param>
        /// <returns>List&lt;StateBaseDto&gt;</returns>
        public List<StateBaseDto> StatesGet (int? documentTypeId)
        {
             ApiResponse<List<StateBaseDto>> localVarResponse = StatesGetWithHttpInfo(documentTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns all the states defined in Arxivar by the given document type 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentTypeId">Document Type Identifier</param>
        /// <returns>ApiResponse of List&lt;StateBaseDto&gt;</returns>
        public ApiResponse< List<StateBaseDto> > StatesGetWithHttpInfo (int? documentTypeId)
        {
            // verify the required parameter 'documentTypeId' is set
            if (documentTypeId == null)
                throw new ApiException(400, "Missing required parameter 'documentTypeId' when calling StatesApi->StatesGet");

            var localVarPath = "/api/States/{documentTypeId}";
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

            if (documentTypeId != null) localVarPathParams.Add("documentTypeId", this.Configuration.ApiClient.ParameterToString(documentTypeId)); // path parameter

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
                Exception exception = ExceptionFactory("StatesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StateBaseDto>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<StateBaseDto>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StateBaseDto>)));
        }

        /// <summary>
        /// This call returns all the states defined in Arxivar by the given document type 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentTypeId">Document Type Identifier</param>
        /// <returns>Task of List&lt;StateBaseDto&gt;</returns>
        public async System.Threading.Tasks.Task<List<StateBaseDto>> StatesGetAsync (int? documentTypeId)
        {
             ApiResponse<List<StateBaseDto>> localVarResponse = await StatesGetAsyncWithHttpInfo(documentTypeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns all the states defined in Arxivar by the given document type 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentTypeId">Document Type Identifier</param>
        /// <returns>Task of ApiResponse (List&lt;StateBaseDto&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<StateBaseDto>>> StatesGetAsyncWithHttpInfo (int? documentTypeId)
        {
            // verify the required parameter 'documentTypeId' is set
            if (documentTypeId == null)
                throw new ApiException(400, "Missing required parameter 'documentTypeId' when calling StatesApi->StatesGet");

            var localVarPath = "/api/States/{documentTypeId}";
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

            if (documentTypeId != null) localVarPathParams.Add("documentTypeId", this.Configuration.ApiClient.ParameterToString(documentTypeId)); // path parameter

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
                Exception exception = ExceptionFactory("StatesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StateBaseDto>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<StateBaseDto>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StateBaseDto>)));
        }

        /// <summary>
        /// This call returns the document states for a document 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">Document Identifier</param>
        /// <returns>StateBaseDto</returns>
        public StateBaseDto StatesGetByDocNumber (int? docnumber)
        {
             ApiResponse<StateBaseDto> localVarResponse = StatesGetByDocNumberWithHttpInfo(docnumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns the document states for a document 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">Document Identifier</param>
        /// <returns>ApiResponse of StateBaseDto</returns>
        public ApiResponse< StateBaseDto > StatesGetByDocNumberWithHttpInfo (int? docnumber)
        {
            // verify the required parameter 'docnumber' is set
            if (docnumber == null)
                throw new ApiException(400, "Missing required parameter 'docnumber' when calling StatesApi->StatesGetByDocNumber");

            var localVarPath = "/api/States/bydocnumber/{docnumber}";
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

            if (docnumber != null) localVarPathParams.Add("docnumber", this.Configuration.ApiClient.ParameterToString(docnumber)); // path parameter

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
                Exception exception = ExceptionFactory("StatesGetByDocNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StateBaseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StateBaseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StateBaseDto)));
        }

        /// <summary>
        /// This call returns the document states for a document 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">Document Identifier</param>
        /// <returns>Task of StateBaseDto</returns>
        public async System.Threading.Tasks.Task<StateBaseDto> StatesGetByDocNumberAsync (int? docnumber)
        {
             ApiResponse<StateBaseDto> localVarResponse = await StatesGetByDocNumberAsyncWithHttpInfo(docnumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns the document states for a document 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">Document Identifier</param>
        /// <returns>Task of ApiResponse (StateBaseDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StateBaseDto>> StatesGetByDocNumberAsyncWithHttpInfo (int? docnumber)
        {
            // verify the required parameter 'docnumber' is set
            if (docnumber == null)
                throw new ApiException(400, "Missing required parameter 'docnumber' when calling StatesApi->StatesGetByDocNumber");

            var localVarPath = "/api/States/bydocnumber/{docnumber}";
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

            if (docnumber != null) localVarPathParams.Add("docnumber", this.Configuration.ApiClient.ParameterToString(docnumber)); // path parameter

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
                Exception exception = ExceptionFactory("StatesGetByDocNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StateBaseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StateBaseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StateBaseDto)));
        }

        /// <summary>
        /// This call returns all the document states in ARXivar 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;StateBaseDto&gt;</returns>
        public List<StateBaseDto> StatesGet_0 ()
        {
             ApiResponse<List<StateBaseDto>> localVarResponse = StatesGet_0WithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns all the document states in ARXivar 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;StateBaseDto&gt;</returns>
        public ApiResponse< List<StateBaseDto> > StatesGet_0WithHttpInfo ()
        {

            var localVarPath = "/api/States";
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
                Exception exception = ExceptionFactory("StatesGet_0", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StateBaseDto>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<StateBaseDto>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StateBaseDto>)));
        }

        /// <summary>
        /// This call returns all the document states in ARXivar 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;StateBaseDto&gt;</returns>
        public async System.Threading.Tasks.Task<List<StateBaseDto>> StatesGet_0Async ()
        {
             ApiResponse<List<StateBaseDto>> localVarResponse = await StatesGet_0AsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns all the document states in ARXivar 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;StateBaseDto&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<StateBaseDto>>> StatesGet_0AsyncWithHttpInfo ()
        {

            var localVarPath = "/api/States";
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
                Exception exception = ExceptionFactory("StatesGet_0", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StateBaseDto>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<StateBaseDto>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StateBaseDto>)));
        }

    }
}

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
    public interface IBusinessUnitsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This call returns the business unit that the connected user can see
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="criteriaMode">Possible values:  0: Search  1: Archive  2: ArchivePa  (optional)</param>
        /// <param name="criteriaOrderBy">Order (optional)</param>
        /// <returns>List&lt;BusinessUnitDTO&gt;</returns>
        List<BusinessUnitDTO> BusinessUnitsGet (int? criteriaMode = null, string criteriaOrderBy = null);

        /// <summary>
        /// This call returns the business unit that the connected user can see
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="criteriaMode">Possible values:  0: Search  1: Archive  2: ArchivePa  (optional)</param>
        /// <param name="criteriaOrderBy">Order (optional)</param>
        /// <returns>ApiResponse of List&lt;BusinessUnitDTO&gt;</returns>
        ApiResponse<List<BusinessUnitDTO>> BusinessUnitsGetWithHttpInfo (int? criteriaMode = null, string criteriaOrderBy = null);
        /// <summary>
        /// This call returns the last protocol number generated by the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aoo">Business unit code</param>
        /// <returns>string</returns>
        string BusinessUnitsGetLastProtocolValue (string aoo);

        /// <summary>
        /// This call returns the last protocol number generated by the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aoo">Business unit code</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> BusinessUnitsGetLastProtocolValueWithHttpInfo (string aoo);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This call returns the business unit that the connected user can see
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="criteriaMode">Possible values:  0: Search  1: Archive  2: ArchivePa  (optional)</param>
        /// <param name="criteriaOrderBy">Order (optional)</param>
        /// <returns>Task of List&lt;BusinessUnitDTO&gt;</returns>
        System.Threading.Tasks.Task<List<BusinessUnitDTO>> BusinessUnitsGetAsync (int? criteriaMode = null, string criteriaOrderBy = null);

        /// <summary>
        /// This call returns the business unit that the connected user can see
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="criteriaMode">Possible values:  0: Search  1: Archive  2: ArchivePa  (optional)</param>
        /// <param name="criteriaOrderBy">Order (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;BusinessUnitDTO&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<BusinessUnitDTO>>> BusinessUnitsGetAsyncWithHttpInfo (int? criteriaMode = null, string criteriaOrderBy = null);
        /// <summary>
        /// This call returns the last protocol number generated by the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aoo">Business unit code</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> BusinessUnitsGetLastProtocolValueAsync (string aoo);

        /// <summary>
        /// This call returns the last protocol number generated by the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aoo">Business unit code</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> BusinessUnitsGetLastProtocolValueAsyncWithHttpInfo (string aoo);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BusinessUnitsApi : IBusinessUnitsApi
    {
        private ACUtils.AXRepository.ArxivarNext.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessUnitsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BusinessUnitsApi(String basePath)
        {
            this.Configuration = new ACUtils.AXRepository.ArxivarNext.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ACUtils.AXRepository.ArxivarNext.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessUnitsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BusinessUnitsApi(ACUtils.AXRepository.ArxivarNext.Client.Configuration configuration = null)
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
        /// This call returns the business unit that the connected user can see 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="criteriaMode">Possible values:  0: Search  1: Archive  2: ArchivePa  (optional)</param>
        /// <param name="criteriaOrderBy">Order (optional)</param>
        /// <returns>List&lt;BusinessUnitDTO&gt;</returns>
        public List<BusinessUnitDTO> BusinessUnitsGet (int? criteriaMode = null, string criteriaOrderBy = null)
        {
             ApiResponse<List<BusinessUnitDTO>> localVarResponse = BusinessUnitsGetWithHttpInfo(criteriaMode, criteriaOrderBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns the business unit that the connected user can see 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="criteriaMode">Possible values:  0: Search  1: Archive  2: ArchivePa  (optional)</param>
        /// <param name="criteriaOrderBy">Order (optional)</param>
        /// <returns>ApiResponse of List&lt;BusinessUnitDTO&gt;</returns>
        public ApiResponse< List<BusinessUnitDTO> > BusinessUnitsGetWithHttpInfo (int? criteriaMode = null, string criteriaOrderBy = null)
        {

            var localVarPath = "/api/BusinessUnits";
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

            if (criteriaMode != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "criteria.mode", criteriaMode)); // query parameter
            if (criteriaOrderBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "criteria.orderBy", criteriaOrderBy)); // query parameter

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
                Exception exception = ExceptionFactory("BusinessUnitsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BusinessUnitDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BusinessUnitDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BusinessUnitDTO>)));
        }

        /// <summary>
        /// This call returns the business unit that the connected user can see 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="criteriaMode">Possible values:  0: Search  1: Archive  2: ArchivePa  (optional)</param>
        /// <param name="criteriaOrderBy">Order (optional)</param>
        /// <returns>Task of List&lt;BusinessUnitDTO&gt;</returns>
        public async System.Threading.Tasks.Task<List<BusinessUnitDTO>> BusinessUnitsGetAsync (int? criteriaMode = null, string criteriaOrderBy = null)
        {
             ApiResponse<List<BusinessUnitDTO>> localVarResponse = await BusinessUnitsGetAsyncWithHttpInfo(criteriaMode, criteriaOrderBy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns the business unit that the connected user can see 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="criteriaMode">Possible values:  0: Search  1: Archive  2: ArchivePa  (optional)</param>
        /// <param name="criteriaOrderBy">Order (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;BusinessUnitDTO&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<BusinessUnitDTO>>> BusinessUnitsGetAsyncWithHttpInfo (int? criteriaMode = null, string criteriaOrderBy = null)
        {

            var localVarPath = "/api/BusinessUnits";
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

            if (criteriaMode != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "criteria.mode", criteriaMode)); // query parameter
            if (criteriaOrderBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "criteria.orderBy", criteriaOrderBy)); // query parameter

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
                Exception exception = ExceptionFactory("BusinessUnitsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BusinessUnitDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BusinessUnitDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BusinessUnitDTO>)));
        }

        /// <summary>
        /// This call returns the last protocol number generated by the system 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aoo">Business unit code</param>
        /// <returns>string</returns>
        public string BusinessUnitsGetLastProtocolValue (string aoo)
        {
             ApiResponse<string> localVarResponse = BusinessUnitsGetLastProtocolValueWithHttpInfo(aoo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns the last protocol number generated by the system 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aoo">Business unit code</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > BusinessUnitsGetLastProtocolValueWithHttpInfo (string aoo)
        {
            // verify the required parameter 'aoo' is set
            if (aoo == null)
                throw new ApiException(400, "Missing required parameter 'aoo' when calling BusinessUnitsApi->BusinessUnitsGetLastProtocolValue");

            var localVarPath = "/api/BusinessUnits/LastProtocolValue";
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

            if (aoo != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "aoo", aoo)); // query parameter

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
                Exception exception = ExceptionFactory("BusinessUnitsGetLastProtocolValue", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// This call returns the last protocol number generated by the system 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aoo">Business unit code</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> BusinessUnitsGetLastProtocolValueAsync (string aoo)
        {
             ApiResponse<string> localVarResponse = await BusinessUnitsGetLastProtocolValueAsyncWithHttpInfo(aoo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns the last protocol number generated by the system 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aoo">Business unit code</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> BusinessUnitsGetLastProtocolValueAsyncWithHttpInfo (string aoo)
        {
            // verify the required parameter 'aoo' is set
            if (aoo == null)
                throw new ApiException(400, "Missing required parameter 'aoo' when calling BusinessUnitsApi->BusinessUnitsGetLastProtocolValue");

            var localVarPath = "/api/BusinessUnits/LastProtocolValue";
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

            if (aoo != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "aoo", aoo)); // query parameter

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
                Exception exception = ExceptionFactory("BusinessUnitsGetLastProtocolValue", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

    }
}

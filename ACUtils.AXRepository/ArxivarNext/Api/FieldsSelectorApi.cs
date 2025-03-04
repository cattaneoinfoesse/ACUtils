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
    public interface IFieldsSelectorApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This call returns the selector fields for barcode template associated with a specific document type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentType">Document type of first level</param>
        /// <param name="tipo2">Document type of second level</param>
        /// <param name="tipo3">Document type of third level</param>
        /// <returns>List&lt;FieldBaseForSelectDTO&gt;</returns>
        List<FieldBaseForSelectDTO> FieldsSelectorGetForConfigureBarcodeTemplate (int? documentType, int? tipo2, int? tipo3);

        /// <summary>
        /// This call returns the selector fields for barcode template associated with a specific document type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentType">Document type of first level</param>
        /// <param name="tipo2">Document type of second level</param>
        /// <param name="tipo3">Document type of third level</param>
        /// <returns>ApiResponse of List&lt;FieldBaseForSelectDTO&gt;</returns>
        ApiResponse<List<FieldBaseForSelectDTO>> FieldsSelectorGetForConfigureBarcodeTemplateWithHttpInfo (int? documentType, int? tipo2, int? tipo3);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This call returns the selector fields for barcode template associated with a specific document type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentType">Document type of first level</param>
        /// <param name="tipo2">Document type of second level</param>
        /// <param name="tipo3">Document type of third level</param>
        /// <returns>Task of List&lt;FieldBaseForSelectDTO&gt;</returns>
        System.Threading.Tasks.Task<List<FieldBaseForSelectDTO>> FieldsSelectorGetForConfigureBarcodeTemplateAsync (int? documentType, int? tipo2, int? tipo3);

        /// <summary>
        /// This call returns the selector fields for barcode template associated with a specific document type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentType">Document type of first level</param>
        /// <param name="tipo2">Document type of second level</param>
        /// <param name="tipo3">Document type of third level</param>
        /// <returns>Task of ApiResponse (List&lt;FieldBaseForSelectDTO&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<FieldBaseForSelectDTO>>> FieldsSelectorGetForConfigureBarcodeTemplateAsyncWithHttpInfo (int? documentType, int? tipo2, int? tipo3);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FieldsSelectorApi : IFieldsSelectorApi
    {
        private ACUtils.AXRepository.ArxivarNext.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldsSelectorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FieldsSelectorApi(String basePath)
        {
            this.Configuration = new ACUtils.AXRepository.ArxivarNext.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ACUtils.AXRepository.ArxivarNext.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldsSelectorApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FieldsSelectorApi(ACUtils.AXRepository.ArxivarNext.Client.Configuration configuration = null)
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
        /// This call returns the selector fields for barcode template associated with a specific document type 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentType">Document type of first level</param>
        /// <param name="tipo2">Document type of second level</param>
        /// <param name="tipo3">Document type of third level</param>
        /// <returns>List&lt;FieldBaseForSelectDTO&gt;</returns>
        public List<FieldBaseForSelectDTO> FieldsSelectorGetForConfigureBarcodeTemplate (int? documentType, int? tipo2, int? tipo3)
        {
             ApiResponse<List<FieldBaseForSelectDTO>> localVarResponse = FieldsSelectorGetForConfigureBarcodeTemplateWithHttpInfo(documentType, tipo2, tipo3);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns the selector fields for barcode template associated with a specific document type 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentType">Document type of first level</param>
        /// <param name="tipo2">Document type of second level</param>
        /// <param name="tipo3">Document type of third level</param>
        /// <returns>ApiResponse of List&lt;FieldBaseForSelectDTO&gt;</returns>
        public ApiResponse< List<FieldBaseForSelectDTO> > FieldsSelectorGetForConfigureBarcodeTemplateWithHttpInfo (int? documentType, int? tipo2, int? tipo3)
        {
            // verify the required parameter 'documentType' is set
            if (documentType == null)
                throw new ApiException(400, "Missing required parameter 'documentType' when calling FieldsSelectorApi->FieldsSelectorGetForConfigureBarcodeTemplate");
            // verify the required parameter 'tipo2' is set
            if (tipo2 == null)
                throw new ApiException(400, "Missing required parameter 'tipo2' when calling FieldsSelectorApi->FieldsSelectorGetForConfigureBarcodeTemplate");
            // verify the required parameter 'tipo3' is set
            if (tipo3 == null)
                throw new ApiException(400, "Missing required parameter 'tipo3' when calling FieldsSelectorApi->FieldsSelectorGetForConfigureBarcodeTemplate");

            var localVarPath = "/api/FieldsSelector/ForConfigureBarcodeTemplate/byDocumenttype/{documentType}/{tipo2}/{tipo3}";
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

            if (documentType != null) localVarPathParams.Add("documentType", this.Configuration.ApiClient.ParameterToString(documentType)); // path parameter
            if (tipo2 != null) localVarPathParams.Add("tipo2", this.Configuration.ApiClient.ParameterToString(tipo2)); // path parameter
            if (tipo3 != null) localVarPathParams.Add("tipo3", this.Configuration.ApiClient.ParameterToString(tipo3)); // path parameter

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
                Exception exception = ExceptionFactory("FieldsSelectorGetForConfigureBarcodeTemplate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<FieldBaseForSelectDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<FieldBaseForSelectDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<FieldBaseForSelectDTO>)));
        }

        /// <summary>
        /// This call returns the selector fields for barcode template associated with a specific document type 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentType">Document type of first level</param>
        /// <param name="tipo2">Document type of second level</param>
        /// <param name="tipo3">Document type of third level</param>
        /// <returns>Task of List&lt;FieldBaseForSelectDTO&gt;</returns>
        public async System.Threading.Tasks.Task<List<FieldBaseForSelectDTO>> FieldsSelectorGetForConfigureBarcodeTemplateAsync (int? documentType, int? tipo2, int? tipo3)
        {
             ApiResponse<List<FieldBaseForSelectDTO>> localVarResponse = await FieldsSelectorGetForConfigureBarcodeTemplateAsyncWithHttpInfo(documentType, tipo2, tipo3);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns the selector fields for barcode template associated with a specific document type 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentType">Document type of first level</param>
        /// <param name="tipo2">Document type of second level</param>
        /// <param name="tipo3">Document type of third level</param>
        /// <returns>Task of ApiResponse (List&lt;FieldBaseForSelectDTO&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<FieldBaseForSelectDTO>>> FieldsSelectorGetForConfigureBarcodeTemplateAsyncWithHttpInfo (int? documentType, int? tipo2, int? tipo3)
        {
            // verify the required parameter 'documentType' is set
            if (documentType == null)
                throw new ApiException(400, "Missing required parameter 'documentType' when calling FieldsSelectorApi->FieldsSelectorGetForConfigureBarcodeTemplate");
            // verify the required parameter 'tipo2' is set
            if (tipo2 == null)
                throw new ApiException(400, "Missing required parameter 'tipo2' when calling FieldsSelectorApi->FieldsSelectorGetForConfigureBarcodeTemplate");
            // verify the required parameter 'tipo3' is set
            if (tipo3 == null)
                throw new ApiException(400, "Missing required parameter 'tipo3' when calling FieldsSelectorApi->FieldsSelectorGetForConfigureBarcodeTemplate");

            var localVarPath = "/api/FieldsSelector/ForConfigureBarcodeTemplate/byDocumenttype/{documentType}/{tipo2}/{tipo3}";
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

            if (documentType != null) localVarPathParams.Add("documentType", this.Configuration.ApiClient.ParameterToString(documentType)); // path parameter
            if (tipo2 != null) localVarPathParams.Add("tipo2", this.Configuration.ApiClient.ParameterToString(tipo2)); // path parameter
            if (tipo3 != null) localVarPathParams.Add("tipo3", this.Configuration.ApiClient.ParameterToString(tipo3)); // path parameter

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
                Exception exception = ExceptionFactory("FieldsSelectorGetForConfigureBarcodeTemplate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<FieldBaseForSelectDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<FieldBaseForSelectDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<FieldBaseForSelectDTO>)));
        }

    }
}

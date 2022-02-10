using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IArchiveAnalysisApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="fileId"></param>
        /// <returns>List&lt;AnalysisVariantDto&gt;</returns>
        List<AnalysisVariantDto> Analyse (int? fileId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ArchiveAnalysisApi : IArchiveAnalysisApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveAnalysisApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ArchiveAnalysisApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveAnalysisApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ArchiveAnalysisApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="fileId"></param>
        /// <returns>List&lt;AnalysisVariantDto&gt;</returns>
        public List<AnalysisVariantDto> Analyse (int? fileId)
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null) throw new ApiException(400, "Missing required parameter 'fileId' when calling Analyse");
    
            var path = "/api/archive-analysis/{fileId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fileId" + "}", ApiClient.ParameterToString(fileId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Analyse: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Analyse: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AnalysisVariantDto>) ApiClient.Deserialize(response.Content, typeof(List<AnalysisVariantDto>), response.Headers);
        }
    
    }
}

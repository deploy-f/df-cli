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
    public interface IFileApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="fid"></param>
        /// <param name="body"></param>
        /// <returns>FileDto</returns>
        FileDto AddDockerFile (int? fid, DockerFileDto body);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="fid"></param>
        /// <param name="body"></param>
        /// <returns>FileDto</returns>
        FileDto AddDockerFileTemplate (int? fid, AnalysisRenderDto body);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="fid"></param>
        /// <param name="body"></param>
        /// <returns>FileDto</returns>
        FileDto AddDockerFile_1 (int? fid, DockerFileTextDto body);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="user"></param>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns>FileDtoPageDto</returns>
        FileDtoPageDto CallList (string user, int? page, int? count);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="uploadedFile"></param>
        /// <returns>FileDto</returns>
        FileDto Create (Stream uploadedFile);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="uploadedFile"></param>
        /// <returns>FileDto</returns>
        FileDto CreateArchive (Stream uploadedFile);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="fid"></param>
        /// <returns></returns>
        void GetFile (int? fid);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="fid"></param>
        /// <returns></returns>
        void GetImage (int? fid);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FileApi : IFileApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public FileApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FileApi(String basePath)
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
        /// <param name="fid"></param>
        /// <param name="body"></param>
        /// <returns>FileDto</returns>
        public FileDto AddDockerFile (int? fid, DockerFileDto body)
        {
            // verify the required parameter 'fid' is set
            if (fid == null) throw new ApiException(400, "Missing required parameter 'fid' when calling AddDockerFile");
    
            var path = "/api/file/{fid}/add-dockerfile";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fid" + "}", ApiClient.ParameterToString(fid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddDockerFile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddDockerFile: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileDto) ApiClient.Deserialize(response.Content, typeof(FileDto), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="fid"></param>
        /// <param name="body"></param>
        /// <returns>FileDto</returns>
        public FileDto AddDockerFileTemplate (int? fid, AnalysisRenderDto body)
        {
            // verify the required parameter 'fid' is set
            if (fid == null) throw new ApiException(400, "Missing required parameter 'fid' when calling AddDockerFileTemplate");
    
            var path = "/api/file/{fid}/add-dockerfile-template";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fid" + "}", ApiClient.ParameterToString(fid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddDockerFileTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddDockerFileTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileDto) ApiClient.Deserialize(response.Content, typeof(FileDto), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="fid"></param>
        /// <param name="body"></param>
        /// <returns>FileDto</returns>
        public FileDto AddDockerFile_1 (int? fid, DockerFileTextDto body)
        {
            // verify the required parameter 'fid' is set
            if (fid == null) throw new ApiException(400, "Missing required parameter 'fid' when calling AddDockerFile_1");
    
            var path = "/api/file/{fid}/add-dockerfile-text";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fid" + "}", ApiClient.ParameterToString(fid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddDockerFile_1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddDockerFile_1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileDto) ApiClient.Deserialize(response.Content, typeof(FileDto), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="user"></param>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns>FileDtoPageDto</returns>
        public FileDtoPageDto CallList (string user, int? page, int? count)
        {
    
            var path = "/api/file";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (user != null) queryParams.Add("User", ApiClient.ParameterToString(user)); // query parameter
 if (page != null) queryParams.Add("Page", ApiClient.ParameterToString(page)); // query parameter
 if (count != null) queryParams.Add("Count", ApiClient.ParameterToString(count)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CallList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CallList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileDtoPageDto) ApiClient.Deserialize(response.Content, typeof(FileDtoPageDto), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="uploadedFile"></param>
        /// <returns>FileDto</returns>
        public FileDto Create (Stream uploadedFile)
        {
    
            var path = "/api/file";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (uploadedFile != null) fileParams.Add("uploadedFile", ApiClient.ParameterToFile("uploadedFile", uploadedFile));

            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Create: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileDto) ApiClient.Deserialize(response.Content, typeof(FileDto), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="uploadedFile"></param>
        /// <returns>FileDto</returns>
        public FileDto CreateArchive (Stream uploadedFile)
        {
    
            var path = "/api/file/archive";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (uploadedFile != null) fileParams.Add("uploadedFile", ApiClient.ParameterToFile("uploadedFile", uploadedFile));

            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateArchive: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateArchive: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileDto) ApiClient.Deserialize(response.Content, typeof(FileDto), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="fid"></param>
        /// <returns></returns>
        public void GetFile (int? fid)
        {
            // verify the required parameter 'fid' is set
            if (fid == null) throw new ApiException(400, "Missing required parameter 'fid' when calling GetFile");
    
            var path = "/api/file/{fid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fid" + "}", ApiClient.ParameterToString(fid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFile: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="fid"></param>
        /// <returns></returns>
        public void GetImage (int? fid)
        {
            // verify the required parameter 'fid' is set
            if (fid == null) throw new ApiException(400, "Missing required parameter 'fid' when calling GetImage");
    
            var path = "/img/{fid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fid" + "}", ApiClient.ParameterToString(fid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetImage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetImage: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}

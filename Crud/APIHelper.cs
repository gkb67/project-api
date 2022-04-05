using System;
using System.IO;
using Newtonsoft.Json;
using RestSharp;
namespace Crud
{
    //This helper class has the methods for CRUD operations.
    public class APIHelper<T>
    {
        public RestClient restClient;
        public RestRequest restRequest;
        public string baseURL = "https://reqres.in/";

        public RestClient SetUrl(string endUrl)
        {
            var url = Path.Combine(baseURL, endUrl);
            var restClient = new RestClient(url);
            return restClient;
        }

        public RestRequest CreatePostRequest(string payLoad)
        {
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", payLoad, ParameterType.RequestBody);
            return restRequest;
        }

        public RestRequest CreatePutRequest(string payLoad)
        {
            var restRequest = new RestRequest(Method.PUT);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", payLoad, ParameterType.RequestBody);
            return restRequest;
        }

        public RestRequest CreateGetRequest()
        {
            var restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public RestRequest CreateDeleteRequest()
        {
            var restRequest = new RestRequest(Method.DELETE);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public IRestResponse GetResponse(RestClient client, RestRequest request)
        {
            return client.Execute(request);
        }

        public DTO GetContent<DTO>(IRestResponse restResponse)
        {
            var content = restResponse.Content;
            DTO dtoObject = JsonConvert.DeserializeObject<DTO>(content);
            return dtoObject;
        }

        public string Serialize(dynamic content)
        {
            string serializeObject = JsonConvert.SerializeObject(content, Formatting.Indented);
            return serializeObject;
        }
    }
}

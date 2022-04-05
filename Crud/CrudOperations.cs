using System;
using System.Net;
using Newtonsoft.Json;
using RestSharp;

namespace Crud
{
    //This class has the methods for the operations like creating user, updating user, deleting user etc.
    public class CrudOperations<T>
    {
        public ListOfUsers GetUsers(string endPoint)
        {
            var user = new APIHelper<ListOfUsers>();
            var url = user.SetUrl(endPoint);
            var request = user.CreateGetRequest();
            var response = user.GetResponse(url, request);
            ListOfUsers content = user.GetContent<ListOfUsers>(response);
            return content;
        }

        public IRestResponse GetUsersListStatusCode(string endPoint)
        {
            var user = new APIHelper<ListOfUsers>();
            var url = user.SetUrl(endPoint);
            var request = user.CreateGetRequest();
            var response = user.GetResponse(url, request);
            return response;
        }

        public SingleUser GetSingleUser(string endPoint)
        {
            var user = new APIHelper<SingleUser>();
            var url = user.SetUrl(endPoint);
            var request = user.CreateGetRequest();
            var response = user.GetResponse(url, request);
            SingleUser content = user.GetContent<SingleUser>(response);
            return content;
        }

        public IRestResponse GetSingleUserStatusCode(string endPoint)
        {
            var user = new APIHelper<SingleUser>();
            var url = user.SetUrl(endPoint);
            var request = user.CreateGetRequest();
            var response = user.GetResponse(url, request);
            return response;
        }

        public IRestResponse SingleUserNotFoundStatusCode(string endPoint)
        {
            var user = new APIHelper<SingleUserNotFound>();
            var url = user.SetUrl(endPoint);
            var request = user.CreateGetRequest();
            var response = user.GetResponse(url, request);
            return response;
        }


        public HttpStatusCode GetStatusCode(RestClient client, RestRequest request)
        {
            IRestResponse response = client.Execute(request);
            var statusCode = response.StatusCode;
            return statusCode;
        }

        public CreateUser CreateUser(String endPoint, dynamic payLoad)
        {
            var user = new APIHelper<CreateUser>();
            var url = user.SetUrl(endPoint);
            var jsonRequest = user.Serialize(payLoad);
            var request = user.CreatePostRequest(jsonRequest);
            var response = user.GetResponse(url, request);
            CreateUser content = user.GetContent<CreateUser>(response);
            return content;
        }

        public IRestResponse CreateUserStatusCode(String endPoint, dynamic payLoad)
        {
            var user = new APIHelper<CreateUser>();
            var url = user.SetUrl(endPoint);
            var jsonRequest = user.Serialize(payLoad);
            var request = user.CreatePostRequest(jsonRequest);
            var response = user.GetResponse(url, request);
            return response;
        }

        public UpdateUser UpdateUser(String endPoint, dynamic payLoad)
        {
            var user = new APIHelper<UpdateUser>();
            var url = user.SetUrl(endPoint);
            var jsonRequest = user.Serialize(payLoad);
            var request = user.CreatePutRequest(jsonRequest);
            var response = user.GetResponse(url, request);
            UpdateUser content = user.GetContent<UpdateUser>(response);
            return content;
        }

        public IRestResponse UpdateUserStatusCode(String endPoint, dynamic payLoad)
        {
            var user = new APIHelper<UpdateUser>();
            var url = user.SetUrl(endPoint);
            var jsonRequest = user.Serialize(payLoad);
            var request = user.CreatePutRequest(jsonRequest);
            var response = user.GetResponse(url, request);
            return response;
        }

        public IRestResponse DeleteUserStatusCode(string endPoint)
        {
            var user = new APIHelper<SingleUser>();
            var url = user.SetUrl(endPoint);
            var request = user.CreateDeleteRequest();
            var response = user.GetResponse(url, request);
            return response;
        }

        public LoginUser LoginUser(String endPoint, dynamic payLoad)
        {
            var user = new APIHelper<LoginUser>();
            var url = user.SetUrl(endPoint);
            var jsonRequest = user.Serialize(payLoad);
            var request = user.CreatePostRequest(jsonRequest);
            var response = user.GetResponse(url, request);
            LoginUser content = user.GetContent<LoginUser>(response);
            return content;
        }

        public IRestResponse LoginUserStatusCode(String endPoint, dynamic payLoad)
        {
            var user = new APIHelper<LoginUser>();
            var url = user.SetUrl(endPoint);
            var jsonRequest = user.Serialize(payLoad);
            var request = user.CreatePostRequest(jsonRequest);
            var response = user.GetResponse(url, request);
            return response;
        }
    }
}

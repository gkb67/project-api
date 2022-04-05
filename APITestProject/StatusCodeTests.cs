using NUnit.Framework;
using Crud;
using System.Net;
using RestSharp;

namespace APITestProject
{
    public class StatusCodeTests
    {
        HttpStatusCode statusCode;

        //Check the successful status code for listing users
        [Test]
        public void CheckListOfUsersStatusCode()
        {
            var crud = new CrudOperations<ListOfUsers>();
            var response = crud.GetUsersListStatusCode("api/users?page=2");

            statusCode = response.StatusCode;
            var code = (int)statusCode;
            Assert.AreEqual(200, code);
        }

        //Check the successful status code for getting a user

        [Test]
        public void CheckSingleUserStatusCode()
        {
            var crud = new CrudOperations<SingleUser>();
            var response = crud.GetSingleUserStatusCode("api/users/2");

            statusCode = response.StatusCode;
            var code = (int)statusCode;
            Assert.AreEqual(200, code);
        }

        //Check the successful status code for creating a user
        [TestCase("morpheus", "leader")]
        public void CheckCreateUserStatusCode(string name, string job)
        {
            var users = new CreateUserRequest();
            users.name = name;
            users.job = job;

            var crud = new CrudOperations<CreateUser>();
            var response = crud.CreateUserStatusCode("api/users", users);
            statusCode = response.StatusCode;
            var code = (int)statusCode;
            Assert.AreEqual(201, code);
        }

        //Check the successful status code for updating a user
        [TestCase("morpheus", "zion resident")]
        public void CheckUpdateUserStatusCode(string name, string job)
        {
            var users = new UpdateUserRequest();
            users.name = name;
            users.job = job;

            var crud = new CrudOperations<UpdateUser>();
            var response = crud.UpdateUserStatusCode("api/users/2", users);
            statusCode = response.StatusCode;
            var code = (int)statusCode;
            Assert.AreEqual(200, code);
        }

        //Check the successful status code for deleting a user
        [Test]
        public void CheckDeleteStatusCode()
        {
            var crud = new CrudOperations<SingleUser>();
            var response = crud.DeleteUserStatusCode("api/users/2");
            statusCode = response.StatusCode;
            var code = (int)statusCode;
            Assert.AreEqual(204, code);
        }

        //Check the successful status code for a non existing user
        [Test]
        public void CheckSingleUserNotFoundStatusCode()
        {
            var crud = new CrudOperations<SingleUserNotFound>();
            var response = crud.SingleUserNotFoundStatusCode("api/users/23");

            statusCode = response.StatusCode;
            var code = (int)statusCode;
            Assert.AreEqual(404, code);
        }

        //Check the successful status code for loging with a user
        [TestCase("eve.holt@reqres.in", "cityslicka")]
        public void CheckLoginUserStatusCode(string email, string password)
        {
            var credentials = new LoginUserRequest();
            credentials.email = email;
            credentials.password = password;

            var crud = new CrudOperations<LoginUser>();
            var response = crud.LoginUserStatusCode("api/login", credentials);

            statusCode = response.StatusCode;
            var code = (int)statusCode;
            Assert.AreEqual(200, code);
        }
    }
}

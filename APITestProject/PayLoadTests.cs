using System;
using Crud;
using NUnit.Framework;

namespace APITestProject
{
    public class PayLoadTests
    {
        //Check the name users from user list
        [Test]
        public void CheckNamesOfTheUsers()
        {
            var crud = new CrudOperations<ListOfUsers>();
            var user = crud.GetUsers("api/users?page=2");
            Assert.AreEqual("Michael", user.data[0].first_name);
            Assert.AreEqual("Lawson", user.data[0].last_name);
            Assert.AreEqual("Lindsay", user.data[1].first_name);
            Assert.AreEqual("Ferguson", user.data[1].last_name);
        }

        //Check name of a single user 
        [Test]
        public void CheckNamesOfSingleUser()
        {
            var crud = new CrudOperations<SingleUser>();
            var user = crud.GetSingleUser("api/users/2");
            Assert.AreEqual("Janet", user.data.first_name);
            Assert.AreEqual("Weaver", user.data.last_name);
        }

        //Check name of a new user
        [TestCase("morpheus", "leader")]
        public void CheckNameOfNewUser(string name, string job)
        {
            var users = new CreateUserRequest();
            users.name = name;
            users.job = job;

            var crud = new CrudOperations<CreateUser>();
            var user = crud.CreateUser("api/users", users);

            Assert.AreEqual("morpheus", user.name);
        }

        //Check job of a new user
        [TestCase("morpheus", "leader")]
        public void CheckJobOfNewUser(string name, string job)
        {
            var users = new CreateUserRequest();
            users.name = name;
            users.job = job;

            var crud = new CrudOperations<CreateUser>();
            var user = crud.CreateUser("api/users", users);

            Assert.AreEqual("leader", user.job);
        }

        //Check updated job of a user
        [TestCase("morpheus", "zion resident")]
        public void CheckUpdatedJobOfUser(string name, string job)
        {

            var users = new UpdateUserRequest();
            users.name = name;
            users.job = job;

            var crud = new CrudOperations<UpdateUser>();
            var user = crud.UpdateUser("api/users/2", users);

            Assert.AreEqual("zion resident", user.job);
        }

        //Check if login user is successful
        [TestCase("eve.holt@reqres.in", "cityslicka")]
        public void CheckLoginUser(string email, string password)
        {
            var credentials = new LoginUserRequest();
            credentials.email = email;
            credentials.password = password;

            var crud = new CrudOperations<LoginUser>();
            var user = crud.LoginUser("api/login", credentials);
            Assert.That(user.token.Equals(null) == false);

        }
    }
}

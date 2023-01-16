using NUnit.Framework;
using Moq;
using Lumory.Controllers.Users;
using Lumory.Services.Users;
using Lumory.Models;
using Lumory.Repositories.Users;

namespace Lumory.tests
{
    public class Tests
    {
        private UserController userController;
        private Mock<UserService> userServiceMock;
        private Mock<User> user;

        [SetUp]
        public void Setup()
        {
            userServiceMock = new Mock<UserService>();

            var user = new User()
            {
                Id = 99999,
                FirstName = "Jan",
                LastName = "Jansen",
                Email = "Jan@Jansen.nl",
                Password = "TestPassword"
            };
            
            userServiceMock.Setup(c => c.CreateUser(user)).Returns(user);
            
            userController = new UserController(userServiceMock.Object);
        }

        [Test]
            public void AddUserTest()
            {
                var result = userController.Create()
            }
    }
}
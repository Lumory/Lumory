using NUnit.Framework;
using Moq;
using Lumory.Controllers.Users;
using Lumory.Dto;
using Lumory.Services.Users;
using Lumory.Models;
using Lumory.Repositories.Users;

namespace Lumory.tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
            public void AddUserTest()
            {
                var user = new User()
                {
                    Id = 99999,
                    FirstName = "Jan",
                    LastName = "Jansen",
                    Email = "Jan@Jansen.nl",
                    Password = "TestPassword"
                };

                var returnUser = new User()
                {
                    Id = 99999,
                    FirstName = "Jan",
                    LastName = "Jansen",
                    Email = "Jan@Jansen",
                    UserType = "Student",
                    CreatedAt = DateTime.Now
                };
                
                var mock = new Mock<UserService>();
                mock.Setup(c => c.CreateUser(user)).Returns(returnUser);
                UserController userController = new UserController(mock.Object);
                var result = userController.Create(user);
                Assert.AreEqual(user,result);
            }
    }
}
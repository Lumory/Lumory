using Lumory.Controllers.Companies;
using Lumory.Models;
using Lumory.Services.Companies;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace Lumory.Tests.Controllers;

[TestFixture]
public class CompanyControllerTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
            public void AddCompanyTest()
            {
                var user = new Company()
                {
                    Id = 99999,
                    Name = 
                    FirstName = "Jan",
                    LastName = "Jansen",
                    Email = "Company@Company.nl",
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
                var okResult = result as OkObjectResult;

                // assert
                Assert.IsNotNull(okResult);
                Assert.AreEqual(200, okResult.StatusCode);
            }

        [Test]
            public void GetUserByIdTest()
            {
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
                mock.Setup(c => c.FindUser(99999)).Returns(returnUser);
                UserController userController = new UserController(mock.Object);
                var result = userController.Find(99999);
                var okResult = result as OkObjectResult;
                Assert.IsNotNull(okResult);
                Assert.AreEqual(200, okResult.StatusCode);
            }

        [Test]
            public void GetAllUserTest()
            {
                var returnUser = new List<User>()
                {
                    new User
                    {
                        Id = 99999,
                        FirstName = "Jan",
                        LastName = "Jansen",
                        Email = "Jan@Jansen",
                        UserType = "Student",
                        CreatedAt = DateTime.Now
                    },
                    new User
                    {
                        Id = 99998,
                        FirstName = "Peter",
                        LastName = "Peterson",
                        Email = "Peter@Peterson",
                        UserType = "Student",
                        CreatedAt = DateTime.Now
                    }
                };
                
                var mock = new Mock<UserService>();
                mock.Setup(c => c.ListUsers()).Returns(returnUser);
                UserController userController = new UserController(mock.Object);
                var result = userController.Get();
                var okResult = result as OkObjectResult;
                Assert.IsNotNull(okResult);
                Assert.AreEqual(200, okResult.StatusCode);
            }

        [Test]
            public void UpdateUserTest()
            {
                var oldUser = new User()
                    {
                    Id = 99999,
                    FirstName = "Jan",
                    LastName = "Jansen",
                    Email = "Jan@Jansen",
                    UserType = "Student",
                    CreatedAt = DateTime.Now
                };
                var newUser = new User()
                {
                    Id = 99999,
                    FirstName = "Peter",
                    LastName = "Peterson",
                    Email = "Peter@Peterson",
                    UserType = "Student",
                    CreatedAt = DateTime.Now
                };

                var mock = new Mock<UserService>();
                mock.Setup(c => c.FindUser(99999)).Returns(oldUser);
                mock.Setup(c => c.UpdateUser(oldUser, newUser)).Returns(newUser);
                UserController userController = new UserController(mock.Object);
                var result = userController.Update(99999, newUser);
                var okResult = result as OkObjectResult;
                Assert.IsNotNull(okResult);
                Assert.AreEqual(200, okResult.StatusCode);
            }

        [Test]
            public void DeleteUserTest()
            {
                var user = new User()
                {
                    Id = 99999,
                    FirstName = "Jan",
                    LastName = "Jansen",
                    Email = "Jan@Jansen",
                    UserType = "Student",
                    CreatedAt = DateTime.Now
                };
                
                var mock = new Mock<UserService>();
                mock.Setup(c => c.FindUser(99999)).Returns(user);
                mock.Setup(c => c.DeleteUser(user));
                UserController userController = new UserController(mock.Object);
                var result = userController.Delete(99999);
                var okResult = result as OkObjectResult;
                Assert.IsNotNull(okResult);
                Assert.AreEqual(StatusCodes.Status200OK, okResult.StatusCode);
            }
            
                

    }
}
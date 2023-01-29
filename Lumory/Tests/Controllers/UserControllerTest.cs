using Lumory.Controllers.Users;
using Lumory.Models;
using Lumory.Services.Users;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace Lumory.Tests.Controllers
{
    [TestFixture]
    public class Tests
    {
        [Test]
            //Test endpoint Post create a user
            public void AddUserTest()
            {
                //Arrange
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
                
                //Act
                UserController userController = new UserController(mock.Object);
                var result = userController.Create(user);
                var okResult = result as OkObjectResult;

                //Assert
                Assert.IsNotNull(okResult);
                Assert.AreEqual(200, okResult.StatusCode);
            }

        [Test]
            //Test endpoint Get by ID get user by ID
            public void GetUserByIdTest()
            {
                //Arrange
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
                
                //Act
                UserController userController = new UserController(mock.Object);
                var result = userController.Find(99999);
                var okResult = result as OkObjectResult;
                
                //Assert
                Assert.IsNotNull(okResult);
                Assert.AreEqual(200, okResult.StatusCode);
            }

        [Test]
            // Test endpoint Get all users in DB
            public void GetAllUserTest()
            {
                //Arrange
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
                
                //Act
                UserController userController = new UserController(mock.Object);
                var result = userController.Get();
                var okResult = result as OkObjectResult;
                
                //Assert
                Assert.IsNotNull(okResult);
                Assert.AreEqual(200, okResult.StatusCode);
            }

        [Test]
            // Test endpoint Put update user using ID
            public void UpdateUserTest()
            {
                //Arrange
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
                
                //Act
                UserController userController = new UserController(mock.Object);
                var result = userController.Update(99999, newUser);
                var okResult = result as OkObjectResult;
                
                //Assert
                Assert.IsNotNull(okResult);
                Assert.AreEqual(200, okResult.StatusCode);
            }

        [Test]
            // Test endpoint Delete delete user using ID 
            public void DeleteUserTest()
            {
                //Arrange
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
                
                //Act
                UserController userController = new UserController(mock.Object);
                var result = userController.Delete(99999);
                var okResult = result as OkObjectResult;
                
                //Assert
                Assert.IsNotNull(okResult);
                Assert.AreEqual(StatusCodes.Status200OK, okResult.StatusCode);
            }
            
                

    }
}
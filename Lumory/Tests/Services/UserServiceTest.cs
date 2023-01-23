using NUnit.Framework;
using Lumory.Repositories.Users;
using Lumory.Models;
using Lumory.Services.Users;
using Moq;

namespace Lumory.Tests.Services;

[TestFixture]
public class UserServiceTest
{
    [Test]
    // Test CreateUser, create a user
        public void AddUserTest()
        {
            //Arrange
            var user = new User()
            {
                Id = 99999,
                FirstName = "Jan",
                LastName = "Jansen",
                Email = "Jan@Jansen",
                Password = "TestPassword",
                CreatedAt = DateTime.Now
            };

            var returnUser = new User()
            {
                Id = 99999,
                FirstName = "Jan",
                LastName = "Jansen",
                Email = "Jan@Jansen",
                UserType = "Student",
                Password = "TestPassword",
                CreatedAt = DateTime.Now
            };
                    
            var mock = new Mock<UserRepository>();
            mock.Setup(c => c.CreateUser(user)).Returns(returnUser);
            
            //Act
            UserService userService = new UserService(mock.Object);
            var result = userService.CreateUser(user);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(returnUser, result);
        }
    
    [Test]
        // Test FindUser, get user by ID
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
                Password = "TestPassword",
                CreatedAt = DateTime.Now
            };
                    
            var mock = new Mock<UserRepository>();
            mock.Setup(c => c.FindUserById(99999)).Returns(returnUser);
                    
            //Act
            UserService userService = new UserService(mock.Object);
            var result = userService.FindUser(99999);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(returnUser, result);
        }
    
    [Test]
        // Test ListUsers, get all users in DB
        public void GetAllUsersTest()
        {
                //Arrange
                var returnUsers = new List<User>()
                {
                    new User
                    {
                        Id = 99999,
                        FirstName = "Jan",
                        LastName = "Jansen",
                        Email = "Jan@Jansen",
                        UserType = "Student",
                        Password = "TestPassword",
                        CreatedAt = DateTime.Now
                    },
                    new User
                    {
                        Id = 99998,
                        FirstName = "Peter",
                        LastName = "Peterson",
                        Email = "Peter@Peterson",
                        UserType = "Student",
                        Password = "TestPassword2",
                        CreatedAt = DateTime.Now
                    }
                };
                
                var mock = new Mock<UserRepository>();
                mock.Setup(c => c.GetUsers()).Returns(returnUsers);
                
                //Act
                UserService userService = new UserService(mock.Object);
                var result = userService.ListUsers(); 
                
                //Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(returnUsers, result);
        }

    [Test]
        // Test UpdateUser, update user by model
        public void UpdateUserTest()
        {
                //Arrange
                var oldUser = new User
                    {
                        Id = 99999,
                        FirstName = "Jan",
                        LastName = "Jansen",
                        Email = "Jan@Jansen",
                        UserType = "Student",
                        Password = "TestPassword",
                        CreatedAt = DateTime.Now
                };
                var newUser = new User
                {
                    Id = 99999,
                    FirstName = "Jan2",
                    LastName = "Jansen2",
                    Email = "Jan@Jansen2",
                    UserType = "Student",
                    Password = "TestPassword",
                    CreatedAt = DateTime.Now
                };

                var user = new User
                {
                    Id = 99999,
                    FirstName = "Jan2",
                    LastName = "Jansen2",
                    Email = "Jan@Jansen2",
                    UserType = "Student",
                    Password = "TestPassword",
                    CreatedAt = DateTime.Now
                };

                var mock = new Mock<UserRepository>();
                mock.Setup(c => c.UpdateUser(oldUser));
                mock.Setup(c => c.FindUserById(oldUser.Id)).Returns(user);

                //Act
                UserService userService = new UserService(mock.Object);
                userService.UpdateUser(oldUser, newUser);
                var result = userService.FindUser(oldUser.Id);

                //Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(user, result);
        }

    [Test]
        // Test DeleteUser, delete user by model
        public void DeleteUserTest()
        {
                //Arrange
                var user = new User
                {
                    Id = 99999,
                    FirstName = "Jan2",
                    LastName = "Jansen2",
                    Email = "Jan@Jansen2",
                    UserType = "Student",
                    Password = "TestPassword",
                    CreatedAt = DateTime.Now
                };
                
                var mock = new Mock<UserRepository>();
                mock.Setup(c => c.RemoveUser(user));

                //Act
                UserService userService = new UserService(mock.Object);
                userService.DeleteUser(user);

                //Assert
                Assert.IsTrue(true);
        }
            
                

}
﻿using Lumory.Controllers.Users;
using Lumory.Models;
using Lumory.Services.Users;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace Lumory.Tests.Controllers;

[TestFixture]
public class UserQuestionnaireControllerTest
{
    private UserQuestionnaireController controller;
    private Mock<UserService> userServiceMock;
    private Mock<UserQuestionnaireService> userQuestionnaireServiceMock;
    private UserQuestionnaire userQuestionnaire;
    private UserQuestionnaire returnUserQuestionnaire;
    private UserQuestionnaire userQuestionnaireEdit;
    private User user;

    [SetUp]
    public void SetUp()
    {
        userServiceMock = new Mock<UserService>();
        userQuestionnaireServiceMock = new Mock<UserQuestionnaireService>();

        //arrange
        userQuestionnaire = new UserQuestionnaire()
        {
            Id = 99999,
            Problem = "Yes",
            SkillsToLearn = "None",
            StrongQualities = "Hella Smart",
            StrongSkills = "Smart",
            Sector = "IT",
            Teamwork = "Yes",
            Mentorship = "High",
            City = "Utrecht",
            EducationalInstitution = "HU",
            Study = "IT",
            StudyDirection = "Backend",
            StudyNiveau = "HBO",
            AverageGrade = 7,
            InternshipType = "Test",
            DateStart = "zsm",
            Hours = 32,
            Days = "Monday, Tuesday, Wednesday & Thursday",
            CreatedAt = DateTime.Now
        };
        
        returnUserQuestionnaire = new UserQuestionnaire()
        {
            Id = 99999,
            UserId = 1,
            Problem = "Yes",
            SkillsToLearn = "None",
            StrongQualities = "Hella Smart",
            StrongSkills = "Smart",
            Sector = "IT",
            Teamwork = "Yes",
            Mentorship = "High",
            City = "Utrecht",
            EducationalInstitution = "HU",
            Study = "IT",
            StudyDirection = "Backend",
            StudyNiveau = "HBO",
            AverageGrade = 7,
            InternshipType = "Test",
            DateStart = "zsm",
            Hours = 32,
            Days = "Monday, Tuesday, Wednesday & Thursday",
            CreatedAt = DateTime.Now
        };
        
        userQuestionnaireEdit = new UserQuestionnaire()
        {
            Id = 99999,
            Problem = "Yes",
            SkillsToLearn = "None",
            StrongQualities = "Hella Smart",
            StrongSkills = "Smart",
            Sector = "IT",
            Teamwork = "Yes",
            Mentorship = "High",
            City = "Utrecht",
            EducationalInstitution = "HU",
            Study = "IT",
            StudyDirection = "Backend",
            StudyNiveau = "HBO",
            AverageGrade = 7,
            InternshipType = "Test",
            DateStart = "zsm",
            Hours = 32,
            Days = "Monday, Tuesday, Wednesday & Thursday",
            CreatedAt = DateTime.Now
        };
        
        user = new User()
        {
            Id = 1,
            FirstName = "Jan",
            LastName = "Jansen",
            Email = "Jan@Jansen.nl",
            Password = "TestPassword"
        };

        controller = new UserQuestionnaireController(userQuestionnaireServiceMock.Object, userServiceMock.Object);
    }
    
    [Test]
    //Test endpoint Post create a UserQuestionnaire by User ID
    public void CreateUserQuestionnaireByUserIdTest()
    { 
        //Arrange
        userServiceMock.Setup(c => c.FindUser(1)).Returns(user);
        userQuestionnaireServiceMock.Setup(c => c.FindUserQuestionnaireByUserId(1));
        userQuestionnaireServiceMock.Setup(c => c.CreateUserQuestionnaire(userQuestionnaire, 1)).Returns(returnUserQuestionnaire);

        //Act
        var result = controller.Create(1, userQuestionnaire);
        var okResult = result as OkObjectResult;

        //Assert
        Assert.IsNotNull(okResult);
        Assert.AreEqual(200, okResult.StatusCode);
    }
    
    [Test]
    //Test endpoint Get get a UserQuestionnaire by User ID
    public void GetUserQuestionnaireByUserIdTest()
    { 
        //Arrange
        userQuestionnaireServiceMock.Setup(c => c.FindUserQuestionnaireByUserId(1)).Returns(returnUserQuestionnaire);

        //Act
        var result = controller.Find(1);
        var okResult = result as OkObjectResult;
        
        //Assert
        Assert.IsNotNull(okResult);
        Assert.AreEqual(200, okResult.StatusCode);
    }
    
    [Test]
    //Test endpoint Put update a UserQuestionnaire by ID
    public void UpdateUserQuestionnaireByIdTest()
    { 
        //Arrange
        userQuestionnaireServiceMock.Setup(c => c.FindUserQuestionnaire(99999)).Returns(returnUserQuestionnaire);
        userQuestionnaireServiceMock.Setup(c => c.UpdateUserQuestionnaire(returnUserQuestionnaire, userQuestionnaireEdit)).Returns(returnUserQuestionnaire);

        //Act
        var result = controller.Update(99999, userQuestionnaireEdit);
        var okResult = result as OkObjectResult;
        
        //Assert
        Assert.IsNotNull(okResult);
        Assert.AreEqual(200, okResult.StatusCode);
    }
    
    [Test]
    //Test endpoint Delete delete a UserQuestionnaire by ID
    public void DeleteUserQuestionnaireByIdTest()
    { 
        //Arrange
        userQuestionnaireServiceMock.Setup(c => c.FindUserQuestionnaire(99999)).Returns(returnUserQuestionnaire);
        userQuestionnaireServiceMock.Setup(c => c.DeleteUserQuestionnaire(returnUserQuestionnaire));

        //Act
        var result = controller.Delete(99999);
        var okResult = result as OkObjectResult;
        
        //Assert
        Assert.IsNotNull(okResult);
        Assert.AreEqual(200, okResult.StatusCode);
    }
}    
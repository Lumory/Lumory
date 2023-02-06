using Lumory.Models;
using Lumory.Services.Users;
using Lumory.Repositories.Users;
using Moq;
using NUnit.Framework;

namespace Lumory.Tests.Services;

[TestFixture]
public class UserQuestionnaireServiceTest
{
    private UserQuestionnaireService service;
    private Mock<UserQuestionnaireRepository> userQuestionnaireRepository;
    private UserQuestionnaire userQuestionnaire;
    private UserQuestionnaire returnUserQuestionnaire;
    private UserQuestionnaire userQuestionnaireEdit;

    [SetUp]
    public void SetUp()
    {
        userQuestionnaireRepository = new Mock<UserQuestionnaireRepository>();
        
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
        
        service = new UserQuestionnaireService(userQuestionnaireRepository.Object);
    }

    [Test]
    //Test CreateUserQuestionnaire, create user questionnaire
    public void CreateUserQuestionnaireByUserIdTest()
    {
        //Arrange
        userQuestionnaireRepository.Setup(c => c.CreateUserQuestionnaire(userQuestionnaire)).Returns(returnUserQuestionnaire);

        //Act
        var result = service.CreateUserQuestionnaire(userQuestionnaire, 1);
        
        //Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(returnUserQuestionnaire, result);
    }
    
    [Test]
    //Test FindUserQuestionnaire, find user questionnaire by ID
    public void GetUserQuestionnaireByIdTest()
    {
        //Arrange
        userQuestionnaireRepository.Setup(c => c.FindUserQuestionnaireById(99999)).Returns(returnUserQuestionnaire);

        //Act
        var result = service.FindUserQuestionnaire(99999);
        
        //Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(returnUserQuestionnaire, result);
    }
    
    [Test]
    //Test FindUserQuestionnaireByUserId, find user questionnaire by User ID
    public void GetUserQuestionnaireByUserIdTest()
    {
        //Arrange
        userQuestionnaireRepository.Setup(c => c.FindUserQuestionnaireByUserId(1)).Returns(returnUserQuestionnaire);

        //Act
        var result = service.FindUserQuestionnaireByUserId(1);
        
        //Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(returnUserQuestionnaire, result);
    }
    
    
    [Test]
    //Test UpdateUserQuestionnaire, update user questionnaire
    public void UpdateUserQuestionnaireTest()
    {
        //Arrange
        userQuestionnaireRepository.Setup(c => c.UpdateUserQuestionnaire(returnUserQuestionnaire)).Returns(returnUserQuestionnaire);

        //Act
        var result = service.UpdateUserQuestionnaire(returnUserQuestionnaire, userQuestionnaireEdit);
        
        //Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(returnUserQuestionnaire, result);
    }
    
    [Test]
    //Test DeleteUserQuestionnaire, delete user questionnaire
    public void DeleteUserQuestionnaireTest()
    {
        //Arrange
        userQuestionnaireRepository.Setup(c => c.RemoveUserQuestionnaire(returnUserQuestionnaire));

        //Act
        service.DeleteUserQuestionnaire(returnUserQuestionnaire);
        
        //Assert
        Assert.IsTrue(true);
    }
}    
    
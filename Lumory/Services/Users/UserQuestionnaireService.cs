using Lumory.Models;
using Lumory.Repositories.Users;
using Lumory.Services.Users;

namespace Lumory.Services.Users;

public class UserQuestionnaireService
{
    private UserQuestionnaireRepository _repository;


    public UserQuestionnaireService(UserQuestionnaireRepository repository)
    {
        _repository = repository;
    }

    public UserQuestionnaire? FindUserQuestionnaire(int id)
    {
        return _repository.FindUserQuestionnaireById(id);
    }
    
    
    public UserQuestionnaire? FindUserQuestionnaireByUserId(int id)
    {
        return _repository.FindUserQuestionnaireByUserId(id);
    }
    
    public UserQuestionnaire CreateUserQuestionnaire(UserQuestionnaire userQuestionnaire, int UserId)
    {
        userQuestionnaire.UserId = UserId;
        return _repository.CreateUserQuestionnaire(userQuestionnaire);
    }
    
    public UserQuestionnaire UpdateUserQuestionnaire(UserQuestionnaire oldUserQuestionnaire, UserQuestionnaire newUserQuestionnaire)
    {
        oldUserQuestionnaire.Problem = newUserQuestionnaire.Problem;
        oldUserQuestionnaire.SkillsToLearn = newUserQuestionnaire.SkillsToLearn;
        oldUserQuestionnaire.StrongQualities = newUserQuestionnaire.StrongQualities;
        oldUserQuestionnaire.StrongSkills = newUserQuestionnaire.StrongSkills;
        oldUserQuestionnaire.Sector = newUserQuestionnaire.Sector;
        oldUserQuestionnaire.Teamwork = newUserQuestionnaire.Teamwork;
        oldUserQuestionnaire.Mentorship = newUserQuestionnaire.Mentorship;
        oldUserQuestionnaire.City = newUserQuestionnaire.City;
        oldUserQuestionnaire.EducationalInstitution = newUserQuestionnaire.EducationalInstitution;
        oldUserQuestionnaire.Study = newUserQuestionnaire.Study;
        oldUserQuestionnaire.StudyDirection = newUserQuestionnaire.StudyDirection;
        oldUserQuestionnaire.StudyNiveau = newUserQuestionnaire.StudyNiveau;
        oldUserQuestionnaire.AverageGrade = newUserQuestionnaire.AverageGrade;
        oldUserQuestionnaire.InternshipType = newUserQuestionnaire.InternshipType;
        oldUserQuestionnaire.DateStart = newUserQuestionnaire.DateStart;
        oldUserQuestionnaire.Hours = newUserQuestionnaire.Hours;
        oldUserQuestionnaire.Days = newUserQuestionnaire.Days;

        return _repository.UpdateUserQuestionnaire(oldUserQuestionnaire);
    }
    
    public void DeleteUserQuestionnaire(UserQuestionnaire userQuestionnaire)
    {
        _repository.RemoveUserQuestionnaire(userQuestionnaire);
    }
}
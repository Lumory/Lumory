using Lumory.Models;
using Lumory.Repositories.Users;

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
        return _repository.FindUserQuestionnaireByUserId(id);
    }
    
    public UserQuestionnaire CreateUserQuestionnaire(UserQuestionnaire userQuestionnaire, int UserId)
    {
        userQuestionnaire.UserId = UserId;
        return _repository.CreateUserQuestionnaire(userQuestionnaire);
    }
}
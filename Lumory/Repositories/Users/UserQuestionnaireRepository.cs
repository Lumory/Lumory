using Lumory.Data;
using Lumory.Models;

namespace Lumory.Repositories.Users;

public class UserQuestionnaireRepository
{
    private ApplicationDbContext _ctx;

    public UserQuestionnaireRepository(ApplicationDbContext ctx)
    {
        _ctx = ctx;
    }

    public UserQuestionnaire? FindUserQuestionnaireById(int id)
    {
        return _ctx.UserQuestionnaires.Where((UserQuestionnaire uq) => uq.Id == id).SingleOrDefault();
    }
    
    public UserQuestionnaire? FindUserQuestionnaireByUserId(int id)
    {
        return _ctx.UserQuestionnaires.Where((UserQuestionnaire uq) => uq.UserId == id).SingleOrDefault();
    }
    public UserQuestionnaire CreateUserQuestionnaire(UserQuestionnaire userQuestionnaire)
    {
        _ctx.UserQuestionnaires.Add(userQuestionnaire);

        _ctx.SaveChanges();

        return userQuestionnaire;
    }
    
    public UserQuestionnaire UpdateUserQuestionnaire(UserQuestionnaire userQuestionnaire)
    {
        _ctx.UserQuestionnaires.Update(userQuestionnaire);

        _ctx.SaveChanges();

        return FindUserQuestionnaireById(userQuestionnaire.Id);
    }
    
    public void RemoveUserQuestionnaire(UserQuestionnaire userQuestionnaire)
    {
        _ctx.UserQuestionnaires.Remove(userQuestionnaire);

        _ctx.SaveChanges();
    }

}
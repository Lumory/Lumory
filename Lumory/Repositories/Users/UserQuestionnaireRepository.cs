using Lumory.Data;
using Lumory.Models;

namespace Lumory.Repositories.Users;

public class UserQuestionnaireRepository
{
    private ApplicationDbContext _ctx;
    
    //Just here for testing
    public UserQuestionnaireRepository()
    {}

    public UserQuestionnaireRepository(ApplicationDbContext ctx)
    {
        _ctx = ctx;
    }

    public virtual UserQuestionnaire? FindUserQuestionnaireById(int id)
    {
        return _ctx.UserQuestionnaires.Where((UserQuestionnaire uq) => uq.Id == id).SingleOrDefault();
    }
    
    public virtual UserQuestionnaire? FindUserQuestionnaireByUserId(int id)
    {
        return _ctx.UserQuestionnaires.Where((UserQuestionnaire uq) => uq.UserId == id).SingleOrDefault();
    }
    public virtual UserQuestionnaire CreateUserQuestionnaire(UserQuestionnaire userQuestionnaire)
    {
        _ctx.UserQuestionnaires.Add(userQuestionnaire);

        _ctx.SaveChanges();

        return userQuestionnaire;
    }
    
    public virtual UserQuestionnaire UpdateUserQuestionnaire(UserQuestionnaire userQuestionnaire)
    {
        _ctx.UserQuestionnaires.Update(userQuestionnaire);

        _ctx.SaveChanges();

        return FindUserQuestionnaireById(userQuestionnaire.Id);
    }
    
    public virtual void RemoveUserQuestionnaire(UserQuestionnaire userQuestionnaire)
    {
        _ctx.UserQuestionnaires.Remove(userQuestionnaire);

        _ctx.SaveChanges();
    }

}
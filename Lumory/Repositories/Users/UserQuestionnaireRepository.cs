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

}
using Lumory.Data;
using Lumory.Models;

namespace Lumory.Repositories.Users;

public class UserRepository
{
    private ApplicationDbContext _ctx;

    public UserRepository(ApplicationDbContext ctx)
    {
        _ctx = ctx;
    }

    public User CreateUser(User user)
    {
        _ctx.Users.Add(user);

        _ctx.SaveChanges();

        return user;
    }
}
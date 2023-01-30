using Lumory.Data;
using Lumory.Models;

namespace Lumory.Repositories.Users;

public class UserRepository
{
    private ApplicationDbContext _ctx;
    
    //Just here for testing
    public UserRepository()
    {}

    public UserRepository(ApplicationDbContext ctx)
    {
        _ctx = ctx;
    }
    
    public virtual List<User> GetUsers()
    {
        return _ctx.Users.ToList();
    }

    public virtual User CreateUser(User user)
    {
        _ctx.Users.Add(user);

        _ctx.SaveChanges();

        return user;
    }
    
    public virtual User? FindUserById(int id)
    {
        return _ctx.Users.Where((User u) => u.Id == id).SingleOrDefault();
    }
    
    public virtual User? FindUserByEmail(string email)
    {
        return _ctx.Users.Where((User u) => u.Email == email).SingleOrDefault();
    }

    public virtual void RemoveUser(User user)
    {
        _ctx.Users.Remove(user);

        _ctx.SaveChanges();
    }
    
    public virtual User UpdateUser(User user)
    {
        _ctx.Users.Update(user);

        _ctx.SaveChanges();

        return FindUserById(user.Id);
    }
}
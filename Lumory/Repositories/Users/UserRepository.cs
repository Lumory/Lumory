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
    
    public List<User> GetUsers()
    {
        return _ctx.Users.ToList();
    }

    public User CreateUser(User user)
    {
        _ctx.Users.Add(user);

        _ctx.SaveChanges();

        return user;
    }
    
    public User? FindUserById(int id)
    {
        return _ctx.Users.Where((User u) => u.Id == id).SingleOrDefault();
    }
    
    public User? FindUserByEmail(string email)
    {
        return _ctx.Users.Where((User u) => u.Email == email).SingleOrDefault();
    }

    public void RemoveUser(User user)
    {
        _ctx.Users.Remove(user);

        _ctx.SaveChanges();
    }
    
    public User UpdateUser(User user)
    {
        _ctx.Users.Update(user);

        _ctx.SaveChanges();

        return FindUserById(user.Id);
    }
}
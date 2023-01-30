using Lumory.Models;
using Lumory.Repositories.Users;

namespace Lumory.Services.Users;

public class UserService
{
    private UserRepository _repository;
    
    //Just here for testing
    public UserService()
    {}

    public UserService(UserRepository repository)
    {
        _repository = repository;
    }

    public virtual User CreateUser(User user)
    {
        user.UserType = "Student";
        user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
        
        
        return _repository.CreateUser(user);
    }
    
    public virtual List<User> ListUsers()
    {
        return _repository.GetUsers();
    }

    public virtual User? FindUser(int id)
    {
        return _repository.FindUserById(id);
    }
    
    public User? FindUserByEmail(string email)
    {
        return _repository.FindUserByEmail(email);
    }

    public virtual void DeleteUser(User user)
    {
        _repository.RemoveUser(user);
    }

    public virtual User UpdateUser(User oldUser, User newUser)
    {
        oldUser.FirstName = newUser.FirstName;
        oldUser.LastName = newUser.LastName;
        oldUser.Email = newUser.Email;
        oldUser.Password = newUser.Password;
        
        return _repository.UpdateUser(oldUser);
    }
}
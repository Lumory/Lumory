using Lumory.Models;
using Lumory.Repositories.Users;

namespace Lumory.Services.Users;

public class UserService
{
    private UserRepository _repository;

    public UserService(UserRepository repository)
    {
        _repository = repository;
    }

    public User CreateUser(User user)
    {
        user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
        
        return _repository.CreateUser(user);
    }
    
    public List<User> ListUsers()
    {
        return _repository.GetUsers();
    }

    public User? FindUser(int id)
    {
        return _repository.FindUserById(id);
    }

    public void DeleteUser(User user)
    {
        _repository.RemoveUser(user);
    }

    public User UpdateUser(User oldUser, User newUser)
    {
        oldUser.FirstName = newUser.FirstName;
        oldUser.LastName = newUser.LastName;
        oldUser.Email = newUser.Email;
        oldUser.Password = newUser.Password;
        
        return _repository.UpdateUser(oldUser);
    }
}
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
        return _repository.CreateUser(user);
    }
}
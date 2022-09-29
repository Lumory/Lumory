using Lumory.Models;

namespace Lumory.Dto;

public class UserDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public UserDto(User user)
    {
        FirstName = user.FirstName;
        LastName = user.LastName;
        Email = user.Email;
        CreatedAt = user.CreatedAt;
        UpdatedAt = user.UpdatedAt;
    }
}
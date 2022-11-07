using System.Text.Json.Serialization;
using Lumory.Models;

namespace Lumory.Dto;

public class UserLoginDto
{
    public string Email { get; set; }
    
    public string Password { get; set; }

    [JsonConstructor]
    public UserLoginDto(){}
}
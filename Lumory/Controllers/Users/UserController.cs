using Lumory.Dto;
using Lumory.Models;
using Lumory.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace Lumory.Controllers.Users;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private UserService _service;

    public UserController(UserService service)
    {
        _service = service;
    }
    
    
    [HttpPost]
    public IActionResult Create([FromBody] User user)
    {
        user = _service.CreateUser(user);
        
        return Ok(new UserDto(user));
    }
}
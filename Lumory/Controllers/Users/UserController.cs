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
    
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(
            _service.ListUsers()
                .Select(c => new UserDto(c))
        );
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Find(int id)
    {
        var user = _service.FindUser(id);

        if (user == null)
        {
            return NotFound();
        }
        
        return Ok(new UserDto(user));
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult Delete(int id)
    {
        var user = _service.FindUser(id);

        if (user == null)
        {
            return NotFound();
        }

        _service.DeleteUser(user);

        return NoContent();
    }

    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] User newUser)
    {
        var oldUser = _service.FindUser(id);

        if (oldUser == null)
        {
            return NotFound();
        }

        newUser = _service.UpdateUser(oldUser, newUser);
        
        return Ok(new UserDto(newUser));
    }
}
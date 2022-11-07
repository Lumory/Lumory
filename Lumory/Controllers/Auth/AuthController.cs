using Lumory.Dto;
using Lumory.Models;
using Lumory.Services.Auth;
using Lumory.Services.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lumory.Controllers.Auth;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly TokenService _tokenService;
    private readonly UserService _service;
    private readonly ConfigurationManager _config;

    public AuthController(TokenService tokenService, UserService userService, ConfigurationManager config)
    {
        _tokenService = tokenService;
        _service = userService;
        _config = config;
        Console.WriteLine(config["Jwt:Key"]);
    }

    [AllowAnonymous]
    [Route("Login")]
    [HttpPost]
    public IActionResult Login(UserLoginDto userReq)
    {
        Console.WriteLine(_config["Jwt"]);
        if (string.IsNullOrEmpty(userReq.Email) || string.IsNullOrEmpty(userReq.Password))
        {
            return BadRequest();
        }

        User? user = _service.FindUserByEmail(userReq.Email);
        
        if (user == null)
        {
            return NotFound();
        }

        if (!BCrypt.Net.BCrypt.Verify(userReq.Password, user.Password))
        {
            return Unauthorized();
        }

        var generatedToken =
            _tokenService.BuildToken(_config["Jwt:Key"], _config["Jwt:Issuer"], user);

        if (generatedToken == null)
        {
            return BadRequest();
        }

        HttpContext.Session.SetString("Token", generatedToken);
        return Ok(generatedToken);
    }
}
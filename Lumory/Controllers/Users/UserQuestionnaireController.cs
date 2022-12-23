using Lumory.Models;
using Lumory.Dto;
using Microsoft.AspNetCore.Mvc;
using Lumory.Services.Users;

namespace Lumory.Controllers.Users;


[ApiController]
public class UserQuestionnaireController : ControllerBase
{
    private UserQuestionnaireService _service;

    public UserQuestionnaireController(UserQuestionnaireService service)
    {
        _service = service;
    }
    
    [HttpGet]
    [Route("Users/{UserId}/UserQuestionnaire/")]
    public IActionResult Find(int UserId)
    {
        var questionnaire = _service.FindUserQuestionnaire(UserId);

        if (questionnaire == null)
        {
            return NotFound();
        }
        
        return Ok(new UserQuestionnaireDto(questionnaire));
    }
    
    [HttpPost("Users/{UserId}/UserQuestionnaire")]
    public IActionResult Create( int UserId, [FromBody] UserQuestionnaire userQuestionnaire)
    {
        userQuestionnaire = _service.CreateUserQuestionnaire(userQuestionnaire, UserId);
        
        return Ok(new UserQuestionnaireDto(userQuestionnaire));
    }
}
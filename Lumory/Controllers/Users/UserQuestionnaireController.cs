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
        var questionnaire = _service.FindUserQuestionnaireByUserId(UserId);

        if (questionnaire == null)
        {
            return NotFound();
        }

        return Ok(new UserQuestionnaireDto(questionnaire));
    }

    [HttpPost]
    [Route("Users/{UserId}/UserQuestionnaire")]
    public IActionResult Create( int UserId, [FromBody] UserQuestionnaire userQuestionnaire)
    {
        var excistingQuestionnaire = _service.FindUserQuestionnaireByUserId(UserId);

        if (excistingQuestionnaire != null)
        {
            return StatusCode(409, "Existing User Questionnaire");
        }
        userQuestionnaire = _service.CreateUserQuestionnaire(userQuestionnaire, UserId);
        
        return Ok(new UserQuestionnaireDto(userQuestionnaire));
    }
    
    [HttpPut]
    [Route("UserQuestionnaire/{id}")]
    public IActionResult Update(int id, [FromBody] UserQuestionnaire newUserQuestionnaire)
    {
        var oldUserQuestionnaire = _service.FindUserQuestionnaire(id);

        if (oldUserQuestionnaire == null)
        {
            return NotFound();
        }

        newUserQuestionnaire = _service.UpdateUserQuestionnaire(oldUserQuestionnaire, newUserQuestionnaire);
        
        return Ok(new UserQuestionnaireDto(newUserQuestionnaire));
    }
    
    [HttpDelete]
    [Route("UserQuestionnaire/{id}")]
    public IActionResult Delete(int id)
    {
        var userQuestionnaire = _service.FindUserQuestionnaire(id);

        if (userQuestionnaire == null)
        {
            return NotFound();
        }

        _service.DeleteUserQuestionnaire(userQuestionnaire);

        return NoContent();
    }
}
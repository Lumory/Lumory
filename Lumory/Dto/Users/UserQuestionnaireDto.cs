using Lumory.Models;

namespace Lumory.Dto;

public class UserQuestionnaireDto
{
    public int Id { get; set; }
    
    public int UserId { get; set; }
    
    public string Skills { get; set; }
    public DateTime? CreatedAt { get; set; }

    public UserQuestionnaireDto(UserQuestionnaire userQuestionnaire)
    {
        Id = userQuestionnaire.Id;
        UserId = userQuestionnaire.UserId;
        Skills = userQuestionnaire.Skills;
        CreatedAt = userQuestionnaire.CreatedAt;
    }
}
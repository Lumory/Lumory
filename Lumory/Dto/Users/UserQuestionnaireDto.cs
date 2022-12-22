using Lumory.Models;

namespace Lumory.Dto;

public class UserQuestionnaireDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Problem { get; set; }
    public string SkillsToLearn { get; set; }
    public string StrongQualities { get; set; }
    public string StrongSkills { get; set; }
    public string Sector { get; set; }
    public string Teamwork { get; set; }
    public string Mentorship { get; set; }
    public string City { get; set; }
    public string EducationalInstitution { get; set; }
    public string Study { get; set; }
    public string StudyDirection { get; set; }
    public string StudyNiveau { get; set; }
    public float AverageGrade { get; set; }
    public string InternshipType { get; set; }
    public string DateStart { get; set; }
    public int Hours { get; set; }
    public string Days { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public UserQuestionnaireDto(UserQuestionnaire userQuestionnaire)
    {
        Id = userQuestionnaire.Id;
        UserId = userQuestionnaire.UserId;
        Problem = userQuestionnaire.Problem;
        SkillsToLearn = userQuestionnaire.SkillsToLearn;
        StrongQualities = userQuestionnaire.StrongQualities;
        StrongSkills = userQuestionnaire.StrongSkills;
        Sector = userQuestionnaire.Sector;
        Teamwork = userQuestionnaire.Teamwork;
        Mentorship = userQuestionnaire.Mentorship;
        City = userQuestionnaire.City;
        EducationalInstitution = userQuestionnaire.EducationalInstitution;
        Study = userQuestionnaire.Study;
        StudyDirection = userQuestionnaire.StudyDirection;
        StudyNiveau = userQuestionnaire.StudyNiveau;
        AverageGrade = userQuestionnaire.AverageGrade;
        InternshipType = userQuestionnaire.InternshipType;
        DateStart = userQuestionnaire.DateStart;
        Hours = userQuestionnaire.Hours;
        Days = userQuestionnaire.Days;
        CreatedAt = userQuestionnaire.CreatedAt;
        UpdatedAt = userQuestionnaire.UpdatedAt;
    }
}
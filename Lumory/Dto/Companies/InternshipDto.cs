using Lumory.Models;

namespace Lumory.Dto.Companies;

public class InternshipDto
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public string Problem { get; set; }
    public string ProblemDescription { get; set; }
    public string SkillsIntern { get; set; }
    public string SkillsInternDescription { get; set; }
    public string QualitiesIntern { get; set; }
    public string QualitiesInternDescription { get; set; }
    public string Sector { get; set; }
    public string SectorDescription { get; set; }
    public string Teamwork { get; set; }
    public string TeamworkDescription { get; set; }
    public string Mentorship { get; set; }
    public string MentorshipDescription { get; set; }
    public string Money { get; set; }
    public string RemoteWork { get; set; }
    public string Function { get; set; }
    public string Responsability { get; set; }
    public string WorkExperience { get; set; }
    public string Staff { get; set; }
    public string International { get; set; }
    public string DateStart { get; set; }
    public int Hours { get; set; }
    public string ApplyBefore { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public InternshipDto(Internship internship)
    {
        Id = internship.Id;
        CompanyId = internship.CompanyId;
        Problem = internship.Problem;
        ProblemDescription = internship.ProblemDescription;
        SkillsIntern = internship.SkillsIntern;
        SkillsInternDescription = internship.SkillsInternDescription;
        QualitiesIntern = internship.QualitiesIntern;
        QualitiesInternDescription = internship.QualitiesInternDescription;
        Sector = internship.Sector;
        SectorDescription = internship.SectorDescription;
        Teamwork = internship.Teamwork;
        TeamworkDescription = internship.TeamworkDescription;
        Mentorship = internship.Mentorship;
        MentorshipDescription = internship.MentorshipDescription;
        Money = internship.Money;
        RemoteWork = internship.RemoteWork;
        Function = internship.Function;
        Responsability = internship.Responsability;
        WorkExperience = internship.WorkExperience;
        Staff = internship.Staff;
        International = internship.International;
        DateStart = internship.DateStart;
        Hours = internship.Hours;
        ApplyBefore = internship.ApplyBefore;
        CreatedAt = internship.CreatedAt;
        UpdatedAt = internship.UpdatedAt;
    }
}
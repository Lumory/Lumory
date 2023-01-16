using Lumory.Models;
using Lumory.Repositories.Companies;

namespace Lumory.Services.Companies;

public class InternshipService
{
    private InternshipRepository _repository;


    public InternshipService(InternshipRepository repository)
    {
        _repository = repository;
    }
    
    public List<Internship> ListInternships()
    {
        return _repository.GetInternships();
    }
    
    public Internship? FindInternship(int id)
    {
        return _repository.FindInternshipById(id);
    }
    public List<Internship> FindInternshipByCompanyId(int id)
    {
        return _repository.FindInternshipByCompanyId(id);
    }
    
    public Internship CreateInternship(Internship internship, int CompanyId)
    {
        internship.CompanyId = CompanyId;
        return _repository.CreateInternship(internship);
    }
    
    public Internship UpdateInternship(Internship oldInternship, Internship newInternship)
    {
        oldInternship.Problem = newInternship.Problem;
        oldInternship.ProblemDescription = newInternship.ProblemDescription;
        oldInternship.SkillsIntern = newInternship.SkillsIntern;
        oldInternship.SkillsInternDescription = newInternship.SkillsInternDescription;
        oldInternship.QualitiesIntern = newInternship.QualitiesIntern;
        oldInternship.QualitiesInternDescription = newInternship.QualitiesInternDescription;
        oldInternship.Sector = newInternship.Sector;
        oldInternship.SectorDescription = newInternship.SectorDescription;
        oldInternship.Teamwork = newInternship.Teamwork;
        oldInternship.TeamworkDescription = newInternship.TeamworkDescription;
        oldInternship.Mentorship = newInternship.Mentorship;
        oldInternship.MentorshipDescription = newInternship.MentorshipDescription;
        oldInternship.Money = newInternship.Money;
        oldInternship.RemoteWork = newInternship.RemoteWork;
        oldInternship.Function = newInternship.Function;
        oldInternship.Responsability = newInternship.Responsability;
        oldInternship.WorkExperience = newInternship.WorkExperience;
        oldInternship.Staff = newInternship.Staff;
        oldInternship.International = newInternship.International;
        oldInternship.Website = newInternship.Website;
        oldInternship.StreetAddress = newInternship.StreetAddress;
        oldInternship.City = newInternship.City;
        oldInternship.ContactPersonFirstName = newInternship.ContactPersonFirstName;
        oldInternship.ContactPersonLastName = newInternship.ContactPersonLastName;
        oldInternship.ContactPersonEmail = newInternship.ContactPersonEmail;
        oldInternship.DateStart = newInternship.DateStart;
        oldInternship.Hours = newInternship.Hours;
        oldInternship.ApplyBefore = newInternship.ApplyBefore;

        return _repository.UpdateInternship(oldInternship);
    }
    public void DeleteInternship(Internship internship)
    {
        _repository.RemoveInternship(internship);
    }
}
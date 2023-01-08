using Lumory.Data;
using Lumory.Models;

namespace Lumory.Repositories.Companies;

public class InternshipRepository
{
    private ApplicationDbContext _ctx;

    public InternshipRepository(ApplicationDbContext ctx)
    {
        _ctx = ctx;
    }
    
    public List<Internship> GetInternships()
    {
        return _ctx.Internships.ToList();
    }
    
    public Internship? FindInternshipById(int id)
    {
        return _ctx.Internships.Where((Internship ins) => ins.Id == id).SingleOrDefault();
    }
    public List<Internship> FindInternshipByCompanyId(int id)
    {
        return _ctx.Internships.Where((Internship ins) => ins.CompanyId == id).ToList();
    }
    public Internship CreateInternship(Internship internship)
    {
        _ctx.Internships.Add(internship);

        _ctx.SaveChanges();

        return internship;
    }
    
    public Internship UpdateInternship(Internship internship)
    {
        _ctx.Internships.Update(internship);

        _ctx.SaveChanges();

        return FindInternshipById(internship.Id);
    }
    
    public void RemoveInternship(Internship internship)
    {
        _ctx.Internships.Remove(internship);

        _ctx.SaveChanges();
    }

}
using Lumory.Data;
using Lumory.Models;

namespace Lumory.Repositories.Companies;

public class CompanyRepository
{
    private ApplicationDbContext _ctx;
    
    //Just here for user testing
    public CompanyRepository()
    {}


    public CompanyRepository(ApplicationDbContext ctx)
    {
        _ctx = ctx;
    }

    public virtual List<Company> GetCompanies()
    {
        return _ctx.Companies.ToList();
    }

    public virtual Company? FindCompanyById(int id)
    {
        return _ctx.Companies.Where((Company c) => c.Id == id).SingleOrDefault();
    }

    public virtual void RemoveCompany(Company company)
    {
        _ctx.Companies.Remove(company);

        _ctx.SaveChanges();
        
    }

    public virtual Company CreateCompany(Company company)
    {
        _ctx.Companies.Add(company);

        _ctx.SaveChanges();

        return company;
    }
    
    public virtual Company UpdateCompany(Company company)
    {
        _ctx.Companies.Update(company);

        _ctx.SaveChanges();

        return FindCompanyById(company.Id);
    }
}
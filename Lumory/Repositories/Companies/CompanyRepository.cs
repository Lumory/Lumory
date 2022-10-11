using Lumory.Data;
using Lumory.Models;

namespace Lumory.Repositories.Companies;

public class CompanyRepository
{
    private ApplicationDbContext _ctx;

    public CompanyRepository(ApplicationDbContext ctx)
    {
        _ctx = ctx;
    }

    public IEnumerable<Company> GetCompanies()
    {
        return _ctx.Companies.ToList();
    }

    public Company? FindCompanyById(int id)
    {
        return _ctx.Companies.Where((Company c) => c.Id == id).SingleOrDefault();
    }

    public void DeleteCompany(Company company)
    {
        _ctx.Companies.Remove(company);

        _ctx.SaveChanges();
    }

    public Company CreateCompany(Company company)
    {
        _ctx.Companies.Add(company);

        _ctx.SaveChanges();

        return company;
    }
    
    public Company UpdateCompany(Company company)
    {
        _ctx.Companies.Update(company);

        _ctx.SaveChanges();

        return FindCompanyById(company.Id);
    }
}
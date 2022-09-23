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
}
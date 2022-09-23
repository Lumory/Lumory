using Lumory.Models;
using Lumory.Repositories.Companies;

namespace Lumory.Services.Companies;

public class CompanyService
{
    private CompanyRepository _repository;

    public CompanyService(CompanyRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Company> ListCompanies()
    {
        return _repository.GetCompanies();
    }
}
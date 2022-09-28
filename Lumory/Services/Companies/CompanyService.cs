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

    public Company? FindCompany(int id)
    {
        return _repository.FindCompanyById(id);
    }

    public void DeleteCompany(Company company)
    {
        _repository.DeleteCompany(company);
    }

    public Company CreateCompany(Company company)
    {
        return _repository.CreateCompany(company);
    }

    public Company UpdateCompany(Company oldCompany, Company newCompany)
    {
        oldCompany.City = newCompany.City;
        oldCompany.Email = newCompany.Email;
        oldCompany.Name = newCompany.Name;
        oldCompany.Website = newCompany.Website;
        oldCompany.StreetAddress = newCompany.StreetAddress;

        return _repository.UpdateCompany(oldCompany);
    }
}
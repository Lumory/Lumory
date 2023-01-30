using Lumory.Models;
using Lumory.Repositories.Companies;
using BCrypt.Net;

namespace Lumory.Services.Companies;

public class CompanyService
{
    private CompanyRepository _repository;
    
    //Just here for user testing
    public CompanyService()
    {}

    public CompanyService(CompanyRepository repository)
    {
        _repository = repository;
    }

    public virtual List<Company> ListCompanies()
    {
        return _repository.GetCompanies();
    }

    public virtual Company? FindCompany(int id)
    {
        return _repository.FindCompanyById(id);
    }

    public virtual void DeleteCompany(Company company)
    {
        _repository.RemoveCompany(company);
    }

    public virtual Company CreateCompany(Company company)
    {
        company.Password = BCrypt.Net.BCrypt.HashPassword(company.Password);
        
        return _repository.CreateCompany(company);
    }

    public virtual Company UpdateCompany(Company oldCompany, Company newCompany)
    {
        oldCompany.Email = newCompany.Email;
        oldCompany.Name = newCompany.Name;
        oldCompany.Kvk = newCompany.Kvk;


        return _repository.UpdateCompany(oldCompany);
    }
}
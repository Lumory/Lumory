using Lumory.Models;

namespace Lumory.Dto.Companies;

public class CompanyDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Kvk { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public CompanyDto(Company company)
    {
        Id = company.Id;
        Name = company.Name;
        Kvk = company.Kvk;
        CreatedAt = company.CreatedAt;
        UpdatedAt = company.UpdatedAt;
    }
}
using Lumory.Models;

namespace Lumory.Dto.Companies;

public class CompanyDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Website { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public CompanyDto(Company company)
    {
        Id = company.Id;
        Name = company.Name;
        Website = company.Website;
        StreetAddress = company.StreetAddress;
        City = company.City;
        CreatedAt = company.CreatedAt;
        UpdatedAt = company.UpdatedAt;
    }
}
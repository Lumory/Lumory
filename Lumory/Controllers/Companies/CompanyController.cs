using System.Net;
using Lumory.Data;
using Lumory.Dto.Companies;
using Lumory.Models;
using Lumory.Services.Companies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lumory.Controllers.Companies;

//[Authorize]
[ApiController]
[Route("[controller]")]
public class CompanyController : ControllerBase
{
    private CompanyService _service;

    public CompanyController(CompanyService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(
            _service.ListCompanies()
                .Select(c => new CompanyDto(c))
        );
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Find(int id)
    {
        var company = _service.FindCompany(id);

        if (company == null)
        {
            return NotFound();
        }
        
        return Ok(new CompanyDto(company));
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult Delete(int id)
    {
        var company = _service.FindCompany(id);

        if (company == null)
        {
            return NotFound();
        }

        _service.DeleteCompany(company);

        return NoContent();
    }
    
    [HttpPost]
    public IActionResult Create([FromBody] Company company)
    {
        company = _service.CreateCompany(company);        
        
        return Ok(new CompanyDto(company));
    }
    
    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] Company newCompany)
    {
        var oldCompany = _service.FindCompany(id);

        if (oldCompany == null)
        {
            return NotFound();
        }

        newCompany = _service.UpdateCompany(oldCompany, newCompany);
        
        return Ok(new CompanyDto(newCompany));
    }
}
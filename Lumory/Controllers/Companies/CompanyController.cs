using System.Net;
using Lumory.Data;
using Lumory.Models;
using Lumory.Services.Companies;
using Microsoft.AspNetCore.Mvc;

namespace Lumory.Controllers.Companies;

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
        return Ok(_service.ListCompanies());
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
        
        return Ok(company);
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
}
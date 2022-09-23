using Lumory.Data;
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
    
    [HttpGet(Name = "All")]
    public IActionResult Get()
    {
        return Ok(_service.ListCompanies());
    }
}
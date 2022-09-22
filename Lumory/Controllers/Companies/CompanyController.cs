using Lumory.Data;
using Microsoft.AspNetCore.Mvc;

namespace Lumory.Controllers.Companies;

[ApiController]
[Route("[controller]")]
public class CompanyController : ControllerBase
{
    private ApplicationDbContext _db;

    public CompanyController(ApplicationDbContext db)
    {
        _db = db;
    }
    
    [HttpGet(Name = "All")]
    public IActionResult Get()
    {
        return Ok(_db.Companies.ToList());
    }
}
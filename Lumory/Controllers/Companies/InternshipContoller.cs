using Lumory.Models;
using Lumory.Dto.Companies;
using Microsoft.AspNetCore.Mvc;
using Lumory.Services.Companies;

namespace Lumory.Controllers.Companies;


[ApiController]
public class InternshipController : ControllerBase
{
    private InternshipService _service;
    private CompanyService _service2;

    public InternshipController(InternshipService service, CompanyService service2)
    {
        _service = service;
        _service2 = service2;
    }
    
    [HttpGet]
    [Route("Internships")]
    public IActionResult Get()
    {
        return Ok(
            _service.ListInternships()
                .Select(c => new InternshipDto(c))
        );
    }
    
    [HttpGet]
    [Route("Internship/{id}")]
    public IActionResult FindInternship(int id)
    {
        var internship = _service.FindInternship(id);

        if (internship == null)
        {
            return NotFound();
        }
        
        return Ok(new InternshipDto(internship));
    }
    
    [HttpGet]
    [Route("Companies/{CompanyId}/Internship/")]
    public IActionResult FindInternshipByCompanyId(int CompanyId)
    {
        return Ok(
            _service.FindInternshipByCompanyId(CompanyId)
                .Select(c => new InternshipDto(c))
        );
    }
    
    [HttpPost("Companies/{CompanyId}/Internship")]
    public IActionResult Create( int CompanyId, [FromBody] Internship internship)
    {
        var company = _service2.FindCompany(CompanyId);

        if (company == null)
        {
            return NotFound();
        }    
        internship = _service.CreateInternship(internship, CompanyId);
        
        return Ok(new InternshipDto(internship));
    }
    
    [HttpDelete]
    [Route("Internship/{id}")]
    public IActionResult Delete(int id)
    {
        var internship = _service.FindInternship(id);

        if (internship == null)
        {
            return NotFound();
        }

        _service.DeleteInternship(internship);

        return NoContent();
    }
    
    [HttpPut]
    [Route("Internship/{id}")]
    public IActionResult Update(int id, [FromBody] Internship newInternship)
    {
        var oldInternship = _service.FindInternship(id);

        if (oldInternship == null)
        {
            return NotFound();
        }

        newInternship = _service.UpdateInternship(oldInternship, newInternship);
        
        return Ok(new InternshipDto(newInternship));
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Lumory.Models;

[Keyless]
public class InternshipCategory
{
    [ForeignKey("InternshipId")]
    public int InternshipId { get; set; }
    public Internship Internship { get; set; }
    
    [ForeignKey("CategoryId")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
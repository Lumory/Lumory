using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lumory.Models;

public class Internship
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [ForeignKey("CompanyId")]
    public int CompanyId { get; set; }
    public Company Company { get; set; }
    [MaxLength(128)]
    public string Name { get; set; }
    [MaxLength(32768)]
    public string Description { get; set; }
    [MaxLength(6)]
    public string EducationLevel { get; set; }
    public int Crebo { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
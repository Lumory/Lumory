using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lumory.Models;

public class InternshipContactPerson
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [ForeignKey("InternshipId")]
    public int InternshipId { get; set; }
    public Internship Internship { get; set; }
    [MaxLength(128)]
    public string FirstName { get; set; }
    [MaxLength(128)]
    public string LastName { get; set; }
    [MaxLength(128)]
    public string Email { get; set; }
    [MaxLength(32)]
    public string Phone { get; set; }
}
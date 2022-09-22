using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lumory.Models;

public class Company
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [StringLength(128)]
    public string Email { get; set; }
    public string Password { get; set; }
    [StringLength(256)]
    public string Name { get; set; }
    [StringLength(128)]
    public string Website { get; set; }
    [StringLength(256)]
    public string StreetAddress { get; set; }
    [StringLength(128)]
    public string City { get; set; }
    
}
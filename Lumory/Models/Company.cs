using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lumory.Models;

public class Company
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    [StringLength(256)]
    public string Email { get; set; }
    
    [Required]
    [StringLength(256)]
    public string Password { get; set; }
    
    [Required]
    [StringLength(256)]
    public string Name { get; set; }
    
    [Required]
    [StringLength(2048)]
    public string Website { get; set; }
    
    [Required]
    [StringLength(256)]
    public string StreetAddress { get; set; }
    
    [Required]
    [StringLength(128)]
    public string City { get; set; }
    
    [Required]
    [StringLength(2048)]
    public string Description { get; set; }
    
    [Timestamp]
    public DateTime? CreatedAt { get; set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    [Timestamp]
    public DateTime? UpdatedAt { get; set; }
}
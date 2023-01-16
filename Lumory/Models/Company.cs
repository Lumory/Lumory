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
    public int Kvk { get; set; }

    [Timestamp]
    public DateTime? CreatedAt { get; set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    [Timestamp]
    public DateTime? UpdatedAt { get; set; }
}
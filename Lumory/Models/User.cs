using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Lumory.Models;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    [StringLength(128)]
    public string FirstName { get; set; }
    
    [Required]
    [StringLength(128)]
    public string LastName { get; set; }
    
    [StringLength(128)]
    public string? UserType { get; set; }
    
    [Required]
    [StringLength(256)]
    public string Email { get; set; }
    
    [Required]
    public string Password { get; set; }

    [Timestamp]
    public DateTime? CreatedAt { get; set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    [Timestamp]
    public DateTime? UpdatedAt { get; set; }
    
}
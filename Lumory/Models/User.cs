using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Lumory.Models;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [StringLength(128)]
    public string FirstName { get; set; }
    [StringLength(128)]
    public string LastName { get; set; }
    [StringLength(128)]
    public string Email { get; set; }
    
    [IgnoreDataMember]
    public string Password { get; set; }
    
    [Timestamp]
    public DateTime? CreatedAt { get; set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    [Timestamp]
    public DateTime? UpdatedAt { get; set; }
    
}
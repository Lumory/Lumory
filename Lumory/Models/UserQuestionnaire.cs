using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lumory.Models;

public class UserQuestionnaire
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    [ForeignKey("Users")]
    public int UserId { get; set; }

    [Required]
    [StringLength(256)]
    public string Skills { get; set; }
    
    [Timestamp]
    public DateTime? CreatedAt { get; set; }
}
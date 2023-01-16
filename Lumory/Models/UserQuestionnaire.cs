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
    public User? Users { get; set; }

    [Required]
    [StringLength(128)]
    public string Problem { get; set; }

    [Required]
    [StringLength(256)]
    public string SkillsToLearn { get; set; }
    
    [Required]
    [StringLength(256)]
    public string StrongQualities { get; set; }
    
    [Required]
    [StringLength(256)]
    public string StrongSkills { get; set; }
    
    [Required]
    [StringLength(128)]
    public string Sector { get; set; }
    
    [Required]
    [StringLength(256)]
    public string Teamwork { get; set; }
    
    [Required]
    [StringLength(256)]
    public string Mentorship { get; set; }
    
    [Required]
    [StringLength(256)]
    public string City { get; set; }
    
    [Required]
    [StringLength(256)]
    public string EducationalInstitution { get; set; }
    
    [Required]
    [StringLength(256)]
    public string Study { get; set; }
    
    [Required]
    [StringLength(256)]
    public string StudyDirection { get; set; }
    
    [Required]
    [StringLength(128)]
    public string StudyNiveau { get; set; }
    
    [Required]
    public float AverageGrade { get; set; }
    
    [Required]
    [StringLength(256)]
    public string InternshipType { get; set; }
    
    [Required]
    [StringLength(256)]
    public string DateStart { get; set; }
    
    [Required]
    public int Hours { get; set; }
    
    [Required]
    [StringLength(256)]
    public string Days { get; set; }
    
    [Timestamp]
    public DateTime? CreatedAt { get; set; }
    
    [Timestamp]
    public DateTime? UpdatedAt { get; set; }
    
   } 
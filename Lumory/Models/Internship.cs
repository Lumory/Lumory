using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lumory.Models;

public class Internship
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    [ForeignKey("Company")]
    public int CompanyId { get; set; }

    [Required]
    [StringLength(128)]
    public string Problem { get; set; }
    
    [Required]
    [Column(TypeName = "text")]
    public string ProblemDescription { get; set; }
    
    [Required]
    [StringLength(256)]
    public string SkillsIntern { get; set; }
    
    [Required]
    [Column(TypeName = "text")]
    public string SkillsInternDescription { get; set; }
    
    [Required]
    [StringLength(256)]
    public string QualitiesIntern { get; set; }
    
    [Required]
    [Column(TypeName = "text")]
    public string QualitiesInternDescription { get; set; }

    [Required]
    [StringLength(128)]
    public string Sector { get; set; }
    
    [Required]
    [Column(TypeName = "text")]
    public string SectorDescription { get; set; }
    
    [Required]
    [StringLength(256)]
    public string Teamwork { get; set; }
    
    [Required]
    [Column(TypeName = "text")]
    public string TeamworkDescription { get; set; }
    
    [Required]
    [StringLength(256)]
    public string Mentorship { get; set; }
    
    [Required]
    [Column(TypeName = "text")]
    public string MentorshipDescription { get; set; }
    
    [Required]
    [StringLength(128)]
    public string Money { get; set; }
    
    [Required]
    [StringLength(128)]
    public string RemoteWork { get; set; }
    
    [Required]
    [StringLength(256)]
    public string Function { get; set; }
    
    [Required]
    [StringLength(256)]
    public string Responsability { get; set; }
    
    [Required]
    [StringLength(128)]
    public string WorkExperience { get; set; }
    
    [Required]
    [StringLength(128)]
    public string Staff { get; set; }
    
    [Required]
    [Column(TypeName = "text")]
    public string Website { get; set; }
    
    [Required]
    [StringLength(256)]
    public string StreetAddress { get; set; }
    
    [Required]
    [StringLength(128)]
    public string City { get; set; }
    
    [Required]
    [StringLength(128)]
    public string ContactPersonFirstName { get; set; }
    
    [Required]
    [StringLength(128)]
    public string ContactPersonLastName { get; set; }
    
    [Required]
    [StringLength(256)]
    public string ContactPersonEmail { get; set; }
    
    [Required]
    [StringLength(128)]
    public string International { get; set; }
    
    [Required]
    [StringLength(256)]
    public string DateStart { get; set; }
    
    [Required]
    public int Hours { get; set; }
    
    [Required]
    [StringLength(128)]
    public string ApplyBefore { get; set; }
    
    [Timestamp]
    public DateTime? CreatedAt { get; set; }
    
    [Timestamp]
    public DateTime? UpdatedAt { get; set; }
    
} 
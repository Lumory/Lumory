using Microsoft.EntityFrameworkCore;
using Lumory.Models;

namespace Lumory.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Internship> Internships { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<InternshipCategory> InternshipCategories { get; set; }
    public DbSet<InternshipContactPerson> InternshipContactPersons { get; set; }
}
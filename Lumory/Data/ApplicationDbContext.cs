using Microsoft.EntityFrameworkCore;
using Lumory.Models;

namespace Lumory.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<Company> Companies { get; set; }
    public DbSet<User> Users { get; set; }
    
    public DbSet<Internship> Internships { get; set; }
    public DbSet<UserQuestionnaire> UserQuestionnaires { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>()
            .Property(u => u.CreatedAt)
            .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        
        modelBuilder.Entity<User>()
        .Property(u => u.CreatedAt)
        .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        
        modelBuilder.Entity<UserQuestionnaire>()
            .Property(u => u.CreatedAt)
            .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        
        modelBuilder.Entity<Internship>()
            .Property(u => u.CreatedAt)
            .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
    }
}
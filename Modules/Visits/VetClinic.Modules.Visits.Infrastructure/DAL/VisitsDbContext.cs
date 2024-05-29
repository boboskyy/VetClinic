using Microsoft.EntityFrameworkCore;
using VetClinic.Modules.Visits.Core.Entities;

namespace VetClinic.Modules.Visits.Infrastructure.DAL;

public class VisitsDbContext(DbContextOptions<VisitsDbContext> options) : DbContext(options)
{
    public DbSet<Visit> Visits { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("visits");
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}
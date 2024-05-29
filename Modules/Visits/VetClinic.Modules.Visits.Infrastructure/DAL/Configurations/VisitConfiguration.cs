using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetClinic.Modules.Visits.Core.Entities;
using VetClinic.Modules.Visits.Core.Types;

namespace VetClinic.Modules.Visits.Infrastructure.DAL.Configurations;

public class VisitConfiguration : IEntityTypeConfiguration<Visit>
{
    public void Configure(EntityTypeBuilder<Visit> builder)
    {
        builder.Property(u => u.Id)
            .HasConversion(u => u.Value, u => new VisitId(u));
    }
}
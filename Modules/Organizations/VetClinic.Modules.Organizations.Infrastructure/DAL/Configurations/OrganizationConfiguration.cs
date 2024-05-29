using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetClinic.Modules.Organizations.Domain.Entities;
using VetClinic.Modules.Organizations.Domain.ValueObjects;

namespace VetClinic.Modules.Organizations.Infrastructure.DAL.Configurations;

internal class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
{
    public void Configure(EntityTypeBuilder<Organization> builder)
    {
        builder.Property(u => u.Id)
            .HasConversion(u => u.Value, u => new OrganizationId(u));
    }
}
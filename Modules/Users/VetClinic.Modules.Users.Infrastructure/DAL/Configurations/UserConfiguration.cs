using VetClinic.Modules.Users.Domain.Entities;
using VetClinic.Modules.Users.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VetClinic.Modules.Users.Infrastructure.DAL.Configurations;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(u => u.Id)
            .HasConversion(u => u.Value, u => new UserId(u));
    }
}


using Startup.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Startup.DAL.Configuration;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasIndex(x => x.Name);
        builder.HasIndex(x => x.Surname);
        builder.Property(x => x.Name).HasMaxLength(32);
        builder.Property(x => x.Surname).HasMaxLength(64);
    }
}

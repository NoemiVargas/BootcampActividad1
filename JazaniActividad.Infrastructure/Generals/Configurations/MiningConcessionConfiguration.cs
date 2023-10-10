

using JazaniActividad.Domain.Generals.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JazaniActividad.Infrastructure.Generals.Configurations
{
    public class MiningConcessionConfiguration : IEntityTypeConfiguration<MiningConcession>
    {
        public void Configure(EntityTypeBuilder<MiningConcession> builder)
        {
            var toDateTime = new ValueConverter<DateTime, DateTimeOffset>(
                dateTime => DateTimeOffset.UtcNow,
                dateTimeOffset => dateTimeOffset.DateTime
                );

            builder.ToTable("miningconcession", "mc");
            builder.HasKey(miningconcession => miningconcession.Id);
            builder.Property(miningconcession => miningconcession.Name).HasColumnName("name");
            builder.Property(miningconcession => miningconcession.Description).HasColumnName("description");
            builder.Property(miningconcession => miningconcession.RegistrationDate)
                .HasColumnName("registrationdate")
                .HasConversion(toDateTime);
            builder.Property(miningconcession => miningconcession.State).HasColumnName("state");

        }
    }
}

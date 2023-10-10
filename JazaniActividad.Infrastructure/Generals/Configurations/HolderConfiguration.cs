using JazaniActividad.Domain.Generals.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Infrastructure.Generals.Configurations
{
    public class HolderConfiguration : IEntityTypeConfiguration<Holder>
    {
        public void Configure(EntityTypeBuilder<Holder> builder)
        {
            var toDateTime = new ValueConverter<DateTime, DateTimeOffset>(
                dateTime => DateTimeOffset.UtcNow,
                dateTimeOffset => dateTimeOffset.DateTime
                );

            builder.ToTable("holder", "soc");
            builder.HasKey(holder => holder.Id);
            builder.Property(holder => holder.Name).HasColumnName("name");
            builder.Property(holder => holder.RegistrationDate)
                .HasColumnName("registrationdate")
                .HasConversion(toDateTime);
            builder.Property(holder => holder.State).HasColumnName("state");

        }
    }
}

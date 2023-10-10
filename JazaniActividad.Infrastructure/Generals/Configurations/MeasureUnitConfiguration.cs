

using JazaniActividad.Domain.Generals.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;

namespace JazaniActividad.Infrastructure.Generals.Configurations
{
    public class MeasureUnitConfiguration : IEntityTypeConfiguration<MeasureUnit>
    {

        public void Configure(EntityTypeBuilder<MeasureUnit> builder)
        {
            var toDateTime = new ValueConverter<DateTime, DateTimeOffset>(
                dateTime => DateTimeOffset.UtcNow,
                dateTimeOffset => dateTimeOffset.DateTime
                );

            builder.ToTable("measureunit", "ge");
            builder.HasKey(measureunit => measureunit.Id);
            builder.Property(measureunit => measureunit.Name).HasColumnName("name");
            builder.Property(measureunit => measureunit.Description).HasColumnName("description");
            builder.Property(measureunit => measureunit.RegistrationDate)
                .HasColumnName("registrationdate")
                .HasConversion(toDateTime);
            builder.Property(measureunit => measureunit.State).HasColumnName("state");

        }

    }
}

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
    public class PeriodTypeConfiguration : IEntityTypeConfiguration<PeriodType>
    {

        public void Configure(EntityTypeBuilder<PeriodType> builder)
        {
            var toDateTime = new ValueConverter<DateTime, DateTimeOffset>(
                dateTime => DateTimeOffset.UtcNow,
                dateTimeOffset => dateTimeOffset.DateTime
                );

            builder.ToTable("periodtype", "ge");
            builder.HasKey(periodtype => periodtype.Id);
            builder.Property(periodtype => periodtype.Name).HasColumnName("name");
            builder.Property(periodtype => periodtype.Description).HasColumnName("description");
            builder.Property(periodtype => periodtype.RegistrationDate)
                .HasColumnName("registrationdate")
                .HasConversion(toDateTime);
            builder.Property(periodtype => periodtype.State).HasColumnName("state");

        }
    }
}

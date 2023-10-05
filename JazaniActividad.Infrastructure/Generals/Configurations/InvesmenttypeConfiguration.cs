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
    public class InvesmenttypetypeConfiguration : IEntityTypeConfiguration<Invesmenttype>
    {
        public void Configure(EntityTypeBuilder<Invesmenttype> builder)
        {
            var toDateTime = new ValueConverter<DateTime, DateTimeOffset>(
                dateTime => DateTimeOffset.UtcNow,
                dateTimeOffset => dateTimeOffset.DateTime
                );

            builder.ToTable("investmenttypetype", "mc");
            builder.HasKey(invesmenttype => invesmenttype.Id);
            builder.Property(invesmenttype => invesmenttype.Name).HasColumnName("name");
            builder.Property(invesmenttype => invesmenttype.Description).HasColumnName("description");
            builder.Property(invesmenttype => invesmenttype.RegistrationDate)
                .HasColumnName("registrationdate")
                .HasConversion(toDateTime);
            builder.Property(invesmenttype => invesmenttype.State).HasColumnName("state");

        }
    }
}

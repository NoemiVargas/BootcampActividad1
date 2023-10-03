using JazaniActividad.Domain.Admins.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Infrastructure.Admins.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("event", "ge");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Description).HasColumnName("description");
            builder.Property(e => e.ExpirationDate).HasColumnName("fechavencimiento");
            builder.Property(e => e.CreatorEmployeeId).HasColumnName("empleadoregistradorid");
            builder.Property(e => e.OwnerEmployeeId).HasColumnName("empleadoresponsableid");
            builder.Property(e => e.RegistrationDate).HasColumnName("registrationdate");
            builder.Property(e => e.State).HasColumnName("state");
        }
    }
}

using JazaniActividad.Domain.Generals.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
            builder.ToTable("invesmenttypetype", "mc");
            builder.HasKey(invesmenttype => invesmenttype.Id);
            builder.Property(invesmenttype => invesmenttype.Name).HasColumnName("name");
            builder.Property(invesmenttype => invesmenttype.Description).HasColumnName("description");
            builder.Property(invesmenttype => invesmenttype.Registrationdate).HasColumnName("registrationdate");
            builder.Property(invesmenttype => invesmenttype.State).HasColumnName("state");

        }
    }
}

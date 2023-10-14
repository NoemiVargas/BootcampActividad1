

using JazaniActividad.Domain.Admins.Models;
using JazaniActividad.Infrastructure.Cores.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JazaniActividad.Infrastructure.Admins.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users", "adm");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).HasColumnName("name");
            builder.Property(t => t.LastName).HasColumnName("lastname");
            builder.Property(t => t.Email).HasColumnName("email");
            builder.Property(t => t.Password).HasColumnName("password");
            builder.Property(t => t.RoleId).HasColumnName("roleid");
            builder.Property(t => t.RegistrationDate)
                .HasColumnName("registrationdate")
                .HasConversion(new DateTimeToDateTimeOffset());
            builder.Property(t => t.State).HasColumnName("state");
        }
    }
}

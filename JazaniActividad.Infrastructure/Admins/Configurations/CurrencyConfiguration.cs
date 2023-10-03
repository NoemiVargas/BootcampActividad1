using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using JazaniActividad.Domain.Admins.Models;

namespace JazaniActividad.Infrastructure.Admins.Configurations
{
    public class CurrencyConfiguration: IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.ToTable("currency", "ge");
            builder.HasKey(currency => currency.Id);
            builder.Property(currency => currency.Name).HasColumnName("name");
            builder.Property(currency => currency.Description).HasColumnName("description");
            builder.Property(currency => currency.Symbol).HasColumnName("symbol");
            builder.Property(currency => currency.Registration).HasColumnName("registrationdate");
            builder.Property(currency => currency.State).HasColumnName("state");

        }
    }
}

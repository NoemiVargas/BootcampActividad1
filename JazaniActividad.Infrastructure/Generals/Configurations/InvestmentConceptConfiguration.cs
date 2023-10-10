

using JazaniActividad.Domain.Generals.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JazaniActividad.Infrastructure.Generals.Configurations
{
    public class InvestmentConceptConfiguration : IEntityTypeConfiguration<InvestmentConcept>
    {
        public void Configure(EntityTypeBuilder<InvestmentConcept> builder)
        {
            var toDateTime = new ValueConverter<DateTime, DateTimeOffset>(
                dateTime => DateTimeOffset.UtcNow,
                dateTimeOffset => dateTimeOffset.DateTime
                );

            builder.ToTable("investmentconcept", "mc");
            builder.HasKey(investmentconcept => investmentconcept.Id);
            builder.Property(investmentconcept => investmentconcept.Name).HasColumnName("name");
            builder.Property(investmentconcept => investmentconcept.Description).HasColumnName("description");
            builder.Property(investmentconcept => investmentconcept.RegistrationDate)
                .HasColumnName("registrationdate")
                .HasConversion(toDateTime);
            builder.Property(investmentconcept => investmentconcept.State).HasColumnName("state");

        }
    }
}

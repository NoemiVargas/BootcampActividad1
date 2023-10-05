using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace JazaniActividad.Infrastructure.Generals.Configurations
{
    public class InvesmentConfiguration : IEntityTypeConfiguration<Invesment>
    {
        public void Configure(EntityTypeBuilder<Invesment> builder)
        {
            var toDateTime = new ValueConverter<DateTime, DateTimeOffset>(
                dateTime => DateTimeOffset.UtcNow,
                dateTimeOffset => dateTimeOffset.DateTime
                );


            builder.ToTable("investment", "mc");
            builder.HasKey(invesment => invesment.Id);
            builder.Property(invesment => invesment.Amount).HasColumnName("amountinvestd");
            builder.Property(invesment => invesment.Year).HasColumnName("year");
            builder.Property(invesment => invesment.Description).HasColumnName("description");
            builder.Property(invesment => invesment.MiningConcessionId).HasColumnName("miningconcessionid");
            builder.Property(invesment => invesment.Invesmenttypeid).HasColumnName("investmenttypeid");
            builder.Property(invesment => invesment.CurrencyTypeId).HasColumnName("currencytypeid");
            builder.Property(invesment => invesment.PeriodTypeid).HasColumnName("periodtypeid");
            
            builder.Property(invesment => invesment.RegistrationDate)
                .HasColumnName("registrationDate")
                .HasConversion(toDateTime);
            builder.Property(invesment => invesment.State).HasColumnName("state");
            builder.Property(invesment => invesment.MonthName).HasColumnName("monthname");
            builder.Property(invesment => invesment.MonthId).HasColumnName("monthid");
            builder.Property(invesment => invesment.AccreditationCode).HasColumnName("accreditationcode");
            builder.Property(invesment => invesment.AccountantCode).HasColumnName("accountantcode");
            builder.Property(invesment => invesment.HolderId).HasColumnName("holderid");
            builder.Property(invesment => invesment.DeclaredTypeId).HasColumnName("declaredtypeid");
            builder.Property(invesment => invesment.DocumentId).HasColumnName("documentid");
            builder.Property(invesment => invesment.InvesmentConceptId).HasColumnName("investmentconceptid");
            builder.Property(invesment => invesment.Module).HasColumnName("module");
            builder.Property(invesment => invesment.Frecuency).HasColumnName("frecuency");
            builder.Property(invesment => invesment.Isdac).HasColumnName("isdac");
            builder.Property(invesment => invesment.Metrictons).HasColumnName("metrictons");
            builder.Property(invesment => invesment.DeclarationDate)
                .HasColumnName("declarationdate");

        }
    }

}

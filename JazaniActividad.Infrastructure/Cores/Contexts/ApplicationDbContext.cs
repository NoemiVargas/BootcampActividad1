using JazaniActividad.Domain.Admins.Models;
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Infrastructure.Admins.Configurations;
using JazaniActividad.Infrastructure.Generals.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;


namespace JazaniActividad.Infrastructure.Cores.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        { }

        #region "DbSet"
        public DbSet<Invesment> Invesment { get; set; }
        public DbSet<Invesmenttype> Invesmenttype { get; set; }
 
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<MeasureUnit> MeasureUnit { get; set; }
        public DbSet<MiningConcession> MiningConcession { get; set; }
        public DbSet<Holder> Holder { get; set; }
        public DbSet<InvestmentConcept> InvestmentConcept { get; set; }
        public DbSet<PeriodType> PeriodType { get; set; }

        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CurrencyConfiguration());
            modelBuilder.ApplyConfiguration(new EventConfiguration());

            modelBuilder.ApplyConfiguration(new InvesmentConfiguration());
            modelBuilder.ApplyConfiguration(new InvesmenttypetypeConfiguration());
            modelBuilder.ApplyConfiguration(new HolderConfiguration());
            modelBuilder.ApplyConfiguration(new InvestmentConceptConfiguration());
            modelBuilder.ApplyConfiguration(new MeasureUnitConfiguration());
            modelBuilder.ApplyConfiguration(new MiningConcessionConfiguration());
            modelBuilder.ApplyConfiguration(new PeriodTypeConfiguration());

        }

    }
}

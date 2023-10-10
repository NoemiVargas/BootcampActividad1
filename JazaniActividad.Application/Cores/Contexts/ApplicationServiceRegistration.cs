using JazaniActividad.Application.Admins.Services;
using JazaniActividad.Application.Admins.Services.Implementations;
using JazaniActividad.Application.generals.Services;
using JazaniActividad.Application.generals.Services.Implementations;
using JazaniActividad.Application.Generals.Services;
using JazaniActividad.Application.Generals.Services.Implementations;
using JazaniActividad.Domain.Generals.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;



namespace JazaniActividad.Application.Cores.Contexts
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services )
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient<ICurrencyService, CurrencyService>();
            services.AddTransient<IEventService, EventService>();
            services.AddTransient<IInvesmenttypeService, InvesmenttypeService>();
            services.AddTransient<IInvesmentService, InvesmentService>();
            services.AddTransient<IMeasureUnitService, MeasureUnitService>();
            services.AddTransient<IHolderService, HolderService>();
            services.AddTransient<IInvestmentConceptService, InvestmentConceptService>();
            services.AddTransient<IMiningConcessionService, MiningConcessionService>();
            services.AddTransient<IPeriodTypeService, PeriodTypeService>();
            return services;
        }
    }
}

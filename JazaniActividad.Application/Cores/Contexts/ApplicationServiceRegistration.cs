using JazaniActividad.Application.Admins.Services;
using JazaniActividad.Application.Admins.Services.Implementations;
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
            services.AddTransient<IInvesmenttypeRepository, IInvesmenttypeRepository>();
            services.AddTransient<IInvesmentRepository, IInvesmentRepository>();
            return services;
        }
    }
}

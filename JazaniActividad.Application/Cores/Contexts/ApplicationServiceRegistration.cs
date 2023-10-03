using JazaniActividad.Application.Admins.Services;
using JazaniActividad.Application.Admins.Services.Implementations;

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
            return services;
        }
    }
}

using JazaniActividad.Domain.Admins.Repositories;
using JazaniActividad.Domain.Cores.Paginations;
using JazaniActividad.Domain.Generals.Repositories;
using JazaniActividad.Infrastructure.Admins.Persistences;
using JazaniActividad.Infrastructure.Cores.Paginations;
using JazaniActividad.Infrastructure.Generals.Persistences;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;



namespace JazaniActividad.Infrastructure.Cores.Contexts
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection addInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DbConnection"));
            });


            services.AddTransient<ICurrencyRepository, CurrencyRepository>();
            services.AddTransient<IEventRepository, EventRepository>();
            services.AddTransient<IInvesmentRepository,InvesmentRepository>();
            services.AddTransient<IInvesmenttypeRepository, InvesmenttypeRepository>();
            services.AddTransient<IMeasureUnitRepository, MeasureUnitRepository>();

            services.AddTransient(typeof(IPaginator<>), typeof(Paginator<>));

            return services;
        }
    }
}

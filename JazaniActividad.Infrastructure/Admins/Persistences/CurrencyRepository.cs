
using JazaniActividad.Domain.Admins.Models;
using JazaniActividad.Domain.Admins.Repositories;
using JazaniActividad.Infrastructure.Cores.Contexts;
using JazaniActividad.Infrastructure.Cores.Persistences;
using Microsoft.EntityFrameworkCore;


namespace JazaniActividad.Infrastructure.Admins.Persistences
{
    public class CurrencyRepository : CrudRepository<Currency, int>, ICurrencyRepository
    {
        public CurrencyRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

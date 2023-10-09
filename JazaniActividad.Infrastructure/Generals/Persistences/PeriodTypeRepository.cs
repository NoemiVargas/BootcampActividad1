

using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;
using JazaniActividad.Infrastructure.Cores.Contexts;
using JazaniActividad.Infrastructure.Cores.Persistences;

namespace JazaniActividad.Infrastructure.Generals.Persistences
{
    public class PeriodTypeRepository : CrudRepository<PeriodType, int>, IPeriodTypeRepository
    {
        public PeriodTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

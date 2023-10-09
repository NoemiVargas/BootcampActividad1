using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;
using JazaniActividad.Infrastructure.Cores.Contexts;
using JazaniActividad.Infrastructure.Cores.Persistences;


namespace JazaniActividad.Infrastructure.Generals.Persistences
{
    public class MeasureUnitRepository : CrudRepository<MeasureUnit, int>, IMeasureUnitRepository
    {
        public MeasureUnitRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

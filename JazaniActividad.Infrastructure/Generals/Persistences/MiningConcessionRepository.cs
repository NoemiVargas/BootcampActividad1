
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;
using JazaniActividad.Infrastructure.Cores.Contexts;
using JazaniActividad.Infrastructure.Cores.Persistences;

namespace JazaniActividad.Infrastructure.Generals.Persistences
{
    public class MiningConcessionRepository : CrudRepository<MiningConcession, int>, IMiningConcessionRepository
    {
        public MiningConcessionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

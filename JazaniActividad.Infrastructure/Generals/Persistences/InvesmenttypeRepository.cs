using JazaniActividad.Infrastructure.Cores.Contexts;
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;
using Microsoft.EntityFrameworkCore;
using JazaniActividad.Infrastructure.Cores.Persistences;

namespace JazaniActividad.Infrastructure.Generals.Persistences
{
    public class InvesmenttypeRepository : CrudRepository<Invesmenttype, int>, IInvesmenttypeRepository
    {
        public InvesmenttypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

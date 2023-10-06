using JazaniActividad.Infrastructure.Cores.Contexts;
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;
using Microsoft.EntityFrameworkCore;
using JazaniActividad.Infrastructure.Cores.Persistences;

namespace JazaniActividad.Infrastructure.Generals.Persistences
{
    public class InvesmentRepository : CrudRepository<Invesment, int>, IInvesmentRepository
    {
        public InvesmentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

    }
}

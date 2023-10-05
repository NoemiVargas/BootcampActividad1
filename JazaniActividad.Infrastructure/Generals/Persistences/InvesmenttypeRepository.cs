using JazaniActividad.Infrastructure.Cores.Contexts;
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;
using Microsoft.EntityFrameworkCore;

namespace JazaniActividad.Infrastructure.Generals.Persistences
{
    public class InvesmenttypeRepository : IInvesmenttypeRepository
    {
        public readonly ApplicationDbContext _dbContext;

        public InvesmenttypeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyList<Invesmenttype>> FindAllAsync()
        {
            return await _dbContext.Invesmenttype.AsNoTracking().ToListAsync();
        }

        public async Task<Invesmenttype?> FindByIdAsync(int id)
        {
            return await _dbContext.Invesmenttype.FindAsync(id);
        }

        public async Task<Invesmenttype?> SaveAsync(Invesmenttype invesmenttype)
        {
            EntityState state = _dbContext.Entry(invesmenttype).State;
            _ = state switch
            {
                EntityState.Detached => _dbContext.Invesmenttype.Add(invesmenttype),
                EntityState.Modified => _dbContext.Invesmenttype.Update(invesmenttype),

            };
            await _dbContext.SaveChangesAsync();
            return invesmenttype;
        }
    }
}

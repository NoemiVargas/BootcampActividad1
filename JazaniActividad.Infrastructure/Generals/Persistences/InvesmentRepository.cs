using JazaniActividad.Infrastructure.Cores.Contexts;
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;
using Microsoft.EntityFrameworkCore;


namespace JazaniActividad.Infrastructure.Generals.Persistences
{
    public class InvesmentRepository : IInvesmentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public InvesmentRepository(ApplicationDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public async Task<IReadOnlyList<Invesment>> FindAllAsync()
        {
            return await _dbContext.Invesment.AsNoTracking().ToListAsync();
        }

        public async Task<Invesment?> FindByIdAsync(int id)
        {
            return await _dbContext.Invesment.FindAsync(id);
        }

        public async Task<Invesment?> SaveAsync(Invesment invesment)
        {
            EntityState state = _dbContext.Entry(invesment).State;
            _ = state switch
            {
                EntityState.Detached => _dbContext.Invesment.Add(invesment),
                EntityState.Modified => _dbContext.Invesment.Update(invesment),

            };
            await _dbContext.SaveChangesAsync();
            return invesment;
        }
    }
}

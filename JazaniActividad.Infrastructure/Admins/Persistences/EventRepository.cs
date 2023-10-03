
using JazaniActividad.Domain.Admins.Models;
using JazaniActividad.Domain.Admins.Repositories;
using JazaniActividad.Infrastructure.Cores.Contexts;
using Microsoft.EntityFrameworkCore;


namespace JazaniActividad.Infrastructure.Admins.Persistences
{
    public class EventRepository:IEventRepository
    {

        private readonly ApplicationDbContext _dbContext;

        public EventRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public async Task<IReadOnlyList<Event>> FindAllAsync()
        {
            return  await _dbContext.Event.ToListAsync();

        }

        public async Task<Event?> FindByIdAsync(int id)
        {
            return  await _dbContext.Event.FirstOrDefaultAsync(Event => Event.Id == id);
        }

        public async Task<Event?> SaveAsync(Event Event)
        {
            EntityState state = _dbContext.Entry(Event).State;
            _ = state switch
            {
                EntityState.Detached => _dbContext.Event.Add(Event),
                EntityState.Modified => _dbContext.Event.Update(Event)
            };

            await _dbContext.SaveChangesAsync();
            return Event;
        }


    }
}

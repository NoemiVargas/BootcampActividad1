
using JazaniActividad.Domain.Admins.Models;
using JazaniActividad.Domain.Admins.Repositories;
using JazaniActividad.Infrastructure.Cores.Contexts;
using Microsoft.EntityFrameworkCore;


namespace JazaniActividad.Infrastructure.Admins.Persistences
{
    public class CurrencyRepository:ICurrencyRepository
    {

        private readonly ApplicationDbContext _dbContext;

        public CurrencyRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public async Task<IReadOnlyList<Currency>> FindAllAsync()
        {
            return  await _dbContext.Currency.ToListAsync();

        }

        public async Task<Currency?> FindByIdAsync(int id)
        {
            return  await _dbContext.Currency.FirstOrDefaultAsync(currency => currency.Id == id);
        }

        public async Task<Currency?> SaveAsync(Currency currency)
        {
            EntityState state = _dbContext.Entry(currency).State;
            _ = state switch
            {
                EntityState.Detached => _dbContext.Currency.Add(currency),
                EntityState.Modified => _dbContext.Currency.Update(currency)
            };

            await _dbContext.SaveChangesAsync();
            return currency;
        }


    }
}

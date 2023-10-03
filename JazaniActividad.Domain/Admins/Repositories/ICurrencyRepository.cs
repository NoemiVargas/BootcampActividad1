using JazaniActividad.Domain.Admins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Domain.Admins.Repositories
{
    public interface ICurrencyRepository
    {
        Task<IReadOnlyList<Currency>> FindAllAsync();
        Task<Currency?> FindByIdAsync(int id);
        Task<Currency?> SaveAsync(Currency currency);

    }
}

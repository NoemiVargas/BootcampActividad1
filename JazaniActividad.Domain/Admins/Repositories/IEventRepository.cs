using JazaniActividad.Domain.Admins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Domain.Admins.Repositories
{
    public interface IEventRepository
    {
        Task<IReadOnlyList<Event>> FindAllAsync();
        Task<Event?> FindByIdAsync(int id);
        Task<Currency?> SaveAsync(Currency currency);
    }
}

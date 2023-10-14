

using JazaniActividad.Domain.Admins.Models;
using JazaniActividad.Domain.Cores.Repositories;

namespace JazaniActividad.Domain.Admins.Repositories
{
    public interface IUserRepository : ICrudRepository<User, int>
    {
        Task<User?> FindByEmailAsync(string email);
    }
}

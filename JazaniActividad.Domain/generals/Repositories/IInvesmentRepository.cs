using JazaniActividad.Domain.Admins.Models;
using JazaniActividad.Domain.Cores.Repositories;
using JazaniActividad.Domain.Generals.Models;


namespace JazaniActividad.Domain.Generals.Repositories
{
    public interface IInvesmentRepository : ICrudRepository<Invesment, int>, IPaginatedRepository<Invesment>
    {
    }
}

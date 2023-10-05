using JazaniActividad.Domain.Generals.Models;

namespace JazaniActividad.Domain.Generals.Repositories
{
    public interface IInvesmenttypeRepository
    {
        Task<IReadOnlyList<Invesmenttype>> FindAllAsync();
        Task<Invesmenttype?> FindByIdAsync(int id);
        Task<Invesmenttype?> SaveAsync(Invesmenttype invesmenttype);
    }
}

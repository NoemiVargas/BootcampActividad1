using JazaniActividad.Domain.Generals.Models;


namespace JazaniActividad.Domain.Generals.Repositories
{
    public interface IInvesmentRepository
    {
        Task<IReadOnlyList<Invesment>> FindAllAsync();
        Task<Invesment?> FindByIdAsync(int id);
        Task<Invesment?> SaveAsync(Invesment invesment);
    }
}

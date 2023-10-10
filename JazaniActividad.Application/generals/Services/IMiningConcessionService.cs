
using JazaniActividad.Application.Generals.Dtos.MiningConcessions;


namespace JazaniActividad.Application.Generals.Services
{
    public interface IMiningConcessionService
    {
        Task<IReadOnlyList<MiningConcessionDto>> FindAllAsync();
        Task<MiningConcessionDto?> FindByIdAsync(int id);
        Task<MiningConcessionDto> CreateAsync(MiningConcessionSaveDto saveDto);
        Task<MiningConcessionDto> EditAsync(int id, MiningConcessionSaveDto saveDto);
        Task<MiningConcessionDto> DisabledAsync(int id);
    }
}

using JazaniActividad.Application.Generals.Dtos.Invesments;
using JazaniActividad.Application.Generals.Dtos.MeasuredUnit;

namespace JazaniActividad.Application.Generals.Services
{
    public interface IMeasureUnitService
    {
        Task<IReadOnlyList<MeasuredUnitDto>> FindAllAsync();
        Task<MeasuredUnitDto?> FindByIdAsync(int id);
        Task<MeasuredUnitDto> CreateAsync(MeasuredUnitSaveDto saveDto);
        Task<MeasuredUnitDto> EditAsync(int id, MeasuredUnitSaveDto saveDto);
        Task<MeasuredUnitDto> DisabledAsync(int id);
    }
}

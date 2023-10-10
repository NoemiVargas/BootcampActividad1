using JazaniActividad.Application.Generals.Dtos.MiningConcessions;
using JazaniActividad.Application.Generals.Dtos.PeriodTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Application.Generals.Services
{
    public interface IPeriodTypeService
    {
        Task<IReadOnlyList<PeriodTypeDto>> FindAllAsync();
        Task<PeriodTypeDto?> FindByIdAsync(int id);
        Task<PeriodTypeDto> CreateAsync(PeriodTypeSaveDto saveDto);
        Task<PeriodTypeDto> EditAsync(int id, PeriodTypeSaveDto saveDto);
        Task<PeriodTypeDto> DisabledAsync(int id);
    }
}

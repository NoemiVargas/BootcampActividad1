using JazaniActividad.Application.Admins.Dtos.Currencies;
using JazaniActividad.Application.Cores.Services;
using JazaniActividad.Application.generals.Dtos.Invesments;
using JazaniActividad.Application.Generals.Dtos.Invesments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Application.Generals.Services
{
    public interface IInvesmentService : IPaginatedService<InvesmentDto, InvesmentFilterDto>
    {
        Task<IReadOnlyList<InvesmentDto>> FindAllAsync();
        Task<InvesmentDto?> FindByIdAsync(int id);
        Task<InvesmentDto> CreateAsync(InvesmentSaveDto saveDto);
        Task<InvesmentDto> EditAsync(int id, InvesmentSaveDto saveDto);
        Task<InvesmentDto> DisabledAsync(int id);
    }
}

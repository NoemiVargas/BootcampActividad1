using JazaniActividad.Application.Admins.Dtos.Currencies;
using JazaniActividad.Application.Generals.Dtos.Invesments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Application.Generals.Services
{
    public interface IInvesmentService
    {
        Task<IReadOnlyList<InvesmentDto>> FindAllAsync();
        Task<InvesmentDto?> FindByIdAsync(int id);
        Task<InvesmentDto> CreateAsync(InvesmentSaveDto saveDto);
        Task<InvesmentDto> EditAsync(int id, InvesmentSaveDto saveDto);
        Task<InvesmentDto> DisabledAsync(int id);
    }
}

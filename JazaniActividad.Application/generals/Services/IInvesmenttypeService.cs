using JazaniActividad.Application.Generals.Dtos.Invesments;
using JazaniActividad.Application.Generals.Dtos.Invesmenttypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Application.Generals.Services
{
    public interface IInvesmenttypeService
    {
        Task<IReadOnlyList<InvesmenttypeDto>> FindAllAsync();
        Task<InvesmenttypeDto?> FindByIdAsync(int id);
        Task<InvesmenttypeDto> CreateAsync(InvesmenttypeSaveDto saveDto);
        Task<InvesmenttypeDto> EditAsync(int id, InvesmenttypeSaveDto saveDto);
        Task<InvesmenttypeDto> DisabledAsync(int id);
    }
}

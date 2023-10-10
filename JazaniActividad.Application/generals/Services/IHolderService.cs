using JazaniActividad.Application.Generals.Dtos.Holders;
using JazaniActividad.Application.Generals.Dtos.Invesments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Application.Generals.Services
{
    public interface IHolderService
    {
        Task<IReadOnlyList<HolderDto>> FindAllAsync();
        Task<HolderDto?> FindByIdAsync(int id);
        Task<HolderDto> CreateAsync(HolderSaveDto saveDto);
        Task<HolderDto> EditAsync(int id, HolderSaveDto saveDto);
        Task<HolderDto> DisabledAsync(int id);
    }
}

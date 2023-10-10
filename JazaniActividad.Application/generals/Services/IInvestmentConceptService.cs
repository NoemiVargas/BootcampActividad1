using JazaniActividad.Application.Generals.Dtos.InvestmentConcepts;
using JazaniActividad.Application.Generals.Dtos.MiningConcessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Application.generals.Services
{
    public interface IInvestmentConceptService
    {
        Task<IReadOnlyList<InvestmentConceptDto>> FindAllAsync();
        Task<InvestmentConceptDto?> FindByIdAsync(int id);
        Task<InvestmentConceptDto> CreateAsync(InvestmentConceptSaveDto saveDto);
        Task<InvestmentConceptDto> EditAsync(int id, InvestmentConceptSaveDto saveDto);
        Task<InvestmentConceptDto> DisabledAsync(int id);
    }
}

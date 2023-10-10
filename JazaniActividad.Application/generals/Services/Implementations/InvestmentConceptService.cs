using AutoMapper;
using JazaniActividad.Application.generals.Services;
using JazaniActividad.Application.Generals.Dtos.Invesments;
using JazaniActividad.Application.Generals.Dtos.InvestmentConcepts;
using JazaniActividad.Application.Generals.Dtos.MiningConcessions;
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Application.Generals.Services.Implementations
{
    public class InvestmentConceptService : IInvestmentConceptService
    {
        private readonly IInvesmentConceptRepository _invesmentConceptRepository;
        private readonly IMapper _mapper;

        public InvestmentConceptService(IInvesmentConceptRepository invesmentConceptRepository, IMapper mapper)
        {
            _invesmentConceptRepository = invesmentConceptRepository;
            _mapper = mapper;
        }

        public async Task<InvestmentConceptDto> CreateAsync(InvestmentConceptSaveDto saveDto)
        {
            InvestmentConcept investmentconcept = _mapper.Map<InvestmentConcept>(saveDto);
            investmentconcept.RegistrationDate = DateTime.Now;
            investmentconcept.State = true;
            await _invesmentConceptRepository.SaveAsync(investmentconcept);
            return _mapper.Map<InvestmentConceptDto>(investmentconcept);
        }

        public async Task<InvestmentConceptDto> DisabledAsync(int id)
        {
            InvestmentConcept investmentConcept = await _invesmentConceptRepository.FindByIdAsync(id);
            //InvestmentConcept.State = false;

            InvestmentConcept investmentConceptSaved = await _invesmentConceptRepository.SaveAsync(investmentConcept);
            return _mapper.Map<InvestmentConceptDto>(investmentConceptSaved);
        }

        public async Task<InvestmentConceptDto> EditAsync(int id, InvestmentConceptSaveDto saveDto)
        {
            InvestmentConcept investmentConcept = await _invesmentConceptRepository.FindByIdAsync(id);
            _mapper.Map<InvestmentConceptSaveDto, InvestmentConcept>(saveDto, investmentConcept);

            await _invesmentConceptRepository.SaveAsync(investmentConcept);

            return _mapper.Map<InvestmentConceptDto>(investmentConcept);
        }

        public async Task<IReadOnlyList<InvestmentConceptDto>> FindAllAsync()
        {
            IReadOnlyList<InvestmentConcept> investmentConcept = await _invesmentConceptRepository.FindAllAsync();
            return _mapper.Map<IReadOnlyList<InvestmentConceptDto>>(investmentConcept);
        }

        public async Task<InvestmentConceptDto?> FindByIdAsync(int id)
        {
            InvestmentConcept investmentConcept = await _invesmentConceptRepository.FindByIdAsync(id);
            return _mapper.Map<InvestmentConceptDto?>(investmentConcept);
        }
    }
}

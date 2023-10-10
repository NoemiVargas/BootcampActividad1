

using AutoMapper;
using JazaniActividad.Application.Generals.Dtos.Invesments;
using JazaniActividad.Application.Generals.Dtos.PeriodTypes;
using JazaniActividad.Application.Generals.Services;
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;

namespace JazaniActividad.Application.generals.Services.Implementations
{
    public class PeriodTypeService : IPeriodTypeService
    {
        private readonly IPeriodTypeRepository _periodTypeRepository;
        private readonly IMapper _mapper;

        public PeriodTypeService(IPeriodTypeRepository periodTypeRepository, IMapper mapper)
        {
            _periodTypeRepository = periodTypeRepository;
            _mapper = mapper;
        }

        public async Task<PeriodTypeDto> CreateAsync(PeriodTypeSaveDto saveDto)
        {
            PeriodType invesmenttype = _mapper.Map<PeriodType>(saveDto);
            //invesmenttype.RegistrationDate = DateTime.Now;
            invesmenttype.State = true;
            await _periodTypeRepository.SaveAsync(invesmenttype);
            return _mapper.Map<PeriodTypeDto>(invesmenttype);

        }

        public async Task<PeriodTypeDto> DisabledAsync(int id)
        {
            PeriodType periodtype = await _periodTypeRepository.FindByIdAsync(id);
            periodtype.State = false;

            PeriodType periodtypeSaved = await _periodTypeRepository.SaveAsync(periodtype);
            return _mapper.Map<PeriodTypeDto>(periodtypeSaved);

        }

        public async Task<PeriodTypeDto> EditAsync(int id, PeriodTypeSaveDto saveDto)
        {
            PeriodType periodtype = await _periodTypeRepository.FindByIdAsync(id);
            _mapper.Map<PeriodTypeSaveDto, PeriodType>(saveDto, periodtype);

            await _periodTypeRepository.SaveAsync(periodtype);

            return _mapper.Map<PeriodTypeDto>(periodtype);
        }

        public async Task<IReadOnlyList<PeriodTypeDto>> FindAllAsync()
        {
            IReadOnlyList<PeriodType> periodtype = await _periodTypeRepository.FindAllAsync();
            return _mapper.Map<IReadOnlyList<PeriodTypeDto>>(periodtype);

        }

        public async Task<PeriodTypeDto?> FindByIdAsync(int id)
        {
            PeriodType periodtype = await _periodTypeRepository.FindByIdAsync(id);
            return _mapper.Map<PeriodTypeDto?>(periodtype);
        }
    }
}

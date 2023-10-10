using AutoMapper;
using JazaniActividad.Application.Generals.Dtos.Invesments;
using JazaniActividad.Application.Generals.Dtos.MeasuredUnit;
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;


namespace JazaniActividad.Application.Generals.Services.Implementations
{
    public class MeasureUnitService : IMeasureUnitService
    {
        private readonly IMeasureUnitRepository _measureUnitRepository;
        private readonly IMapper _mapper;

        public MeasureUnitService(IMeasureUnitRepository measureUnitRepository, IMapper mapper)
        {
            _measureUnitRepository = measureUnitRepository;
            _mapper = mapper;
        }

        public async Task<MeasuredUnitDto> CreateAsync(MeasuredUnitSaveDto saveDto)
        {
            MeasureUnit measureunit = _mapper.Map<MeasureUnit>(saveDto);
            measureunit.RegistrationDate = DateTime.Now;
            measureunit.State = true;
            await _measureUnitRepository.SaveAsync(measureunit);
            return _mapper.Map<MeasuredUnitDto>(measureunit);

        }

        public async Task<MeasuredUnitDto> DisabledAsync(int id)
        {
            MeasureUnit measureunit = await _measureUnitRepository.FindByIdAsync(id);
            measureunit.State = false;

            MeasureUnit investmentSaved = await _measureUnitRepository.SaveAsync(measureunit);
            return _mapper.Map<MeasuredUnitDto>(investmentSaved);
        }

        public async Task<MeasuredUnitDto> EditAsync(int id, MeasuredUnitSaveDto saveDto)
        {
            MeasureUnit measureunit = await _measureUnitRepository.FindByIdAsync(id);
            _mapper.Map<MeasuredUnitSaveDto, MeasureUnit>(saveDto, measureunit);

            await _measureUnitRepository.SaveAsync(measureunit);

            return _mapper.Map<MeasuredUnitDto>(measureunit);

        }

        public async Task<IReadOnlyList<MeasuredUnitDto>> FindAllAsync()
        {
            IReadOnlyList<MeasureUnit> measureunit = await _measureUnitRepository.FindAllAsync();
            return _mapper.Map<IReadOnlyList<MeasuredUnitDto>>(measureunit);

        }

        public async Task<MeasuredUnitDto?> FindByIdAsync(int id)
        {
            MeasureUnit measureunit = await _measureUnitRepository.FindByIdAsync(id);
            return _mapper.Map<MeasuredUnitDto?>(measureunit);

        }
    }
}

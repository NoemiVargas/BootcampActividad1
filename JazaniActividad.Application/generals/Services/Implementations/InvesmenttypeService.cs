using AutoMapper;
using JazaniActividad.Application.Generals.Dtos.Invesmenttypes;
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;

namespace JazaniActividad.Application.Generals.Services.Implementations
{
    public class InvesmenttypeService : IInvesmenttypeService
    {
        private readonly IInvesmenttypeRepository _invesmenttypeRepository;
        private readonly IMapper _mapper;

        public InvesmenttypeService(IInvesmenttypeRepository invesmenttypeRepository, IMapper mapper)
        {
            _invesmenttypeRepository = invesmenttypeRepository;
            _mapper = mapper;
        }

        public async Task<InvesmenttypeDto> CreateAsync(InvesmenttypeSaveDto saveDto)
        {
            Invesmenttype invesmenttype = _mapper.Map<Invesmenttype>(saveDto);
            invesmenttype.RegistrationDate = DateTime.Now;
            invesmenttype.State = true;

            await _invesmenttypeRepository.SaveAsync(invesmenttype);
            return _mapper.Map<InvesmenttypeDto>(invesmenttype);

        }

        public async Task<InvesmenttypeDto> DisabledAsync(int id)
        {
            Invesmenttype invesmenttype = await _invesmenttypeRepository.FindByIdAsync(id);
            invesmenttype.State = false;

            Invesmenttype invesmenttypeSaved = await _invesmenttypeRepository.SaveAsync(invesmenttype);
            return _mapper.Map<InvesmenttypeDto>(invesmenttypeSaved);

        }

        public async Task<InvesmenttypeDto> EditAsync(int id, InvesmenttypeSaveDto saveDto)
        {
            Invesmenttype invesmenttype = await _invesmenttypeRepository.FindByIdAsync(id);
            _mapper.Map<InvesmenttypeSaveDto, Invesmenttype>(saveDto, invesmenttype);
                    
            await _invesmenttypeRepository.SaveAsync(invesmenttype);

            return _mapper.Map<InvesmenttypeDto>(invesmenttype);
        }

        public async Task<IReadOnlyList<InvesmenttypeDto>> FindAllAsync()
        {
            IReadOnlyList<Invesmenttype> invesmenttypes = await _invesmenttypeRepository.FindAllAsync();      
            return _mapper.Map<IReadOnlyList<InvesmenttypeDto>>(invesmenttypes);
        
        }

        public async Task<InvesmenttypeDto?> FindByIdAsync(int id)
        {
            Invesmenttype invesmenttype = await _invesmenttypeRepository.FindByIdAsync(id);
            return _mapper.Map<InvesmenttypeDto?>(invesmenttype);
        }
    }
}

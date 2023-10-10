using AutoMapper;
using JazaniActividad.Application.generals.Dtos.Invesments;
using JazaniActividad.Application.Generals.Dtos.Invesments;
using JazaniActividad.Application.Generals.Dtos.Invesments;
using JazaniActividad.Core.Paginations;
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;


namespace JazaniActividad.Application.Generals.Services.Implementations
{
    public class InvesmentService : IInvesmentService
    {
        private readonly IInvesmentRepository _invesmentRepository;
        private readonly IMapper _mapper;

        public InvesmentService(IInvesmentRepository invesmenttypeRepository, IMapper mapper)
        {
            _invesmentRepository = invesmenttypeRepository;
            _mapper = mapper;
        }

        public async Task<InvesmentDto> CreateAsync(InvesmentSaveDto saveDto)
        {
            Invesment invesmenttype = _mapper.Map<Invesment>(saveDto);
            invesmenttype.RegistrationDate = DateTime.Now;
            invesmenttype.State = true;
            await _invesmentRepository.SaveAsync(invesmenttype);
            return _mapper.Map<InvesmentDto>(invesmenttype);

        }

        public async Task<InvesmentDto> DisabledAsync(int id)
        {
            Invesment investment = await _invesmentRepository.FindByIdAsync(id);
            investment.State = false;

            Invesment investmentSaved = await _invesmentRepository.SaveAsync(investment);
            return _mapper.Map<InvesmentDto>(investmentSaved);

        }

        public async Task<InvesmentDto> EditAsync(int id, InvesmentSaveDto saveDto)
        {
            Invesment invesmenttype = await _invesmentRepository.FindByIdAsync(id);
            _mapper.Map<InvesmentSaveDto, Invesment>(saveDto, invesmenttype);

            await _invesmentRepository.SaveAsync(invesmenttype);

            return _mapper.Map<InvesmentDto>(invesmenttype);
        }

        public async Task<IReadOnlyList<InvesmentDto>> FindAllAsync()
        {
            IReadOnlyList<Invesment> invesmenttypes = await _invesmentRepository.FindAllAsync();
            return _mapper.Map<IReadOnlyList<InvesmentDto>>(invesmenttypes);

        }

        public async Task<InvesmentDto?> FindByIdAsync(int id)
        {
            Invesment invesmenttype = await _invesmentRepository.FindByIdAsync(id);
            return _mapper.Map<InvesmentDto?>(invesmenttype);
        }

        public async Task<ResponsePagination<InvesmentDto>> PaginatedSearch(RequestPagination<InvesmentFilterDto> request)
        {
            var entity = _mapper.Map<RequestPagination<Invesment>>(request);
            var response = await _invesmentRepository.PaginatedSearch(entity);

            return _mapper.Map<ResponsePagination<InvesmentDto>>(response);
        }
    }
}

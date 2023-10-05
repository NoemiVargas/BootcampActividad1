using AutoMapper;
using JazaniActividad.Application.Generals.Dtos.Invesments;
using JazaniActividad.Application.Generals.Dtos.Invesments;
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            await _invesmentRepository.SaveAsync(invesmenttype);
            return _mapper.Map<InvesmentDto>(invesmenttype);

        }

        public async Task<InvesmentDto> DisabledAsync(int id)
        {
            Invesment invesmenttype = await _invesmentRepository.FindByIdAsync(id);
            invesmenttype.State = false;

            await _invesmentRepository.SaveAsync(invesmenttype);
            return _mapper.Map<InvesmentDto>(invesmenttype);

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
    }
}

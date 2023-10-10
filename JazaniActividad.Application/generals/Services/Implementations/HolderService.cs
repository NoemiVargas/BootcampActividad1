

using AutoMapper;
using JazaniActividad.Application.Generals.Dtos.Holders;
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;

namespace JazaniActividad.Application.Generals.Services.Implementations
{
    public class HolderService : IHolderService
    {
        private readonly IHolderRepository _holderRepository;
        private readonly IMapper _mapper;

        public HolderService(IHolderRepository holderRepository, IMapper mapper)
        {
            _holderRepository = holderRepository;
            _mapper = mapper;
        }

        public async Task<HolderDto> CreateAsync(HolderSaveDto saveDto)
        {
            Holder holder = _mapper.Map<Holder>(saveDto);
            //holder.RegistrationDate = DateTime.Now;
            holder.State = true;
            await _holderRepository.SaveAsync(holder);
            return _mapper.Map<HolderDto>(holder);
        }

        public async Task<HolderDto> DisabledAsync(int id)
        {
            Holder holder = await _holderRepository.FindByIdAsync(id);
            holder.State = false;

            Holder holderSaved = await _holderRepository.SaveAsync(holder);
            return _mapper.Map<HolderDto>(holderSaved);
        }

        public async Task<HolderDto> EditAsync(int id, HolderSaveDto saveDto)
        {
            Holder holder = await _holderRepository.FindByIdAsync(id);
            _mapper.Map<HolderSaveDto, Holder>(saveDto, holder);

            await _holderRepository.SaveAsync(holder);

            return _mapper.Map<HolderDto>(holder);
        }

        public async Task<IReadOnlyList<HolderDto>> FindAllAsync()
        {
            IReadOnlyList<Holder> holder = await _holderRepository.FindAllAsync();
            return _mapper.Map<IReadOnlyList<HolderDto>>(holder);
        }

        public async Task<HolderDto?> FindByIdAsync(int id)
        {
            Holder holder = await _holderRepository.FindByIdAsync(id);
            return _mapper.Map<HolderDto?>(holder);
        }
    }
}

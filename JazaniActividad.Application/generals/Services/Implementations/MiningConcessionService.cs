using AutoMapper;
using JazaniActividad.Application.Generals.Dtos.Invesments;
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
    public class MiningConcessionService : IMiningConcessionService
    {
        private readonly IMiningConcessionRepository _miningConcessionRepository;
        private readonly IMapper _mapper;

        public MiningConcessionService(IMiningConcessionRepository miningConcessionRepository, IMapper mapper)
        {
            _miningConcessionRepository = miningConcessionRepository;
            _mapper = mapper;
        }

        public  async Task<MiningConcessionDto> CreateAsync(MiningConcessionSaveDto saveDto)
        {
            MiningConcession miningconcession = _mapper.Map<MiningConcession>(saveDto);
            //miningconcession.RegistrationDate = DateTime.Now;
            miningconcession.State = true;
            await _miningConcessionRepository.SaveAsync(miningconcession);
            return _mapper.Map<MiningConcessionDto>(miningconcession);
        }

        public async Task<MiningConcessionDto> DisabledAsync(int id)
        {
            MiningConcession miningconcession = await _miningConcessionRepository.FindByIdAsync(id);
            miningconcession.State = false;

            MiningConcession miningconcessionSaved = await _miningConcessionRepository.SaveAsync(miningconcession);
            return _mapper.Map<MiningConcessionDto>(miningconcessionSaved);

        }

        public async Task<MiningConcessionDto> EditAsync(int id, MiningConcessionSaveDto saveDto)
        {
            MiningConcession miningconcession = await _miningConcessionRepository.FindByIdAsync(id);
            _mapper.Map<MiningConcessionSaveDto, MiningConcession>(saveDto, miningconcession);

            await _miningConcessionRepository.SaveAsync(miningconcession);

            return _mapper.Map<MiningConcessionDto>(miningconcession);

        }

        public async Task<IReadOnlyList<MiningConcessionDto>> FindAllAsync()
        {
            IReadOnlyList<MiningConcession> miningconcession = await _miningConcessionRepository.FindAllAsync();
            return _mapper.Map<IReadOnlyList<MiningConcessionDto>>(miningconcession);
        }

        public async Task<MiningConcessionDto?> FindByIdAsync(int id)
        {
            MiningConcession miningconcession = await _miningConcessionRepository.FindByIdAsync(id);
            return _mapper.Map<MiningConcessionDto?>(miningconcession);
        }
    }
}

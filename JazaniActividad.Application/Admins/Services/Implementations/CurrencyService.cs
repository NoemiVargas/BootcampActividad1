using JazaniActividad.Application.Admins.Dtos.Currencies;
using JazaniActividad.Domain.Admins.Repositories;
using JazaniActividad.Domain.Admins.Models;
using AutoMapper;

namespace JazaniActividad.Application.Admins.Services.Implementations
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IMapper _mapper;


        public CurrencyService(ICurrencyRepository currencyRepository, IMapper mapper)
        {
            _currencyRepository = currencyRepository;
            _mapper = mapper;

        }

        public async Task<IReadOnlyList<CurrencyDto>> FindAllAsync()
        {
            IReadOnlyList<Currency> currencies = await _currencyRepository.FindAllAsync();
            return _mapper.Map<IReadOnlyList<CurrencyDto>>(currencies);
        }


        public async Task<CurrencyDto?> FindByIdAsync(int id)
        {
            Currency? currency = await _currencyRepository.FindByIdAsync(id);
            return _mapper.Map<CurrencyDto>(currency);
        }

        public async Task<CurrencyDto> CreateAsync(CurrencySaveDto currencySaveDto)
        {
            Currency currency = _mapper.Map<Currency>(currencySaveDto);
            currency.Registration = DateTime.Now;
            currency.State = true;

            Currency currencySaved = await _currencyRepository.SaveAsync(currency);

            return _mapper.Map<CurrencyDto>(currencySaved);
        }

        public async Task<CurrencyDto> EditAsync (int id, CurrencySaveDto currencySaveDto)
        {
            Currency currency = await _currencyRepository.FindByIdAsync(id);

           _mapper.Map<CurrencySaveDto, Currency>(currencySaveDto, currency);

            Currency currencySaved = await _currencyRepository.SaveAsync(currency);

            return _mapper.Map<CurrencyDto>(currencySaved);
        }


        public async Task<CurrencyDto> DisabledAsync(int id)
        {
            Currency currency = await _currencyRepository.FindByIdAsync(id);
            currency.State = false;

            Currency currencySaved = await _currencyRepository.SaveAsync(currency);
            return _mapper.Map<CurrencyDto>(currencySaved);

        } 
    }
}

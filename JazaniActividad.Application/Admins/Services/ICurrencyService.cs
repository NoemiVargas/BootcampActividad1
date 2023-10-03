using JazaniActividad.Application.Admins.Dtos.Currencies;


namespace JazaniActividad.Application.Admins.Services
{
    public interface ICurrencyService
    {
        Task<IReadOnlyList<CurrencyDto>> FindAllAsync();
        Task<CurrencyDto?> FindByIdAsync(int id);
        Task<CurrencyDto> CreateAsync(CurrencySaveDto currencySaveDto);
        Task<CurrencyDto> EditAsync(int id, CurrencySaveDto currencySaveDto);
        Task<CurrencyDto> DisabledAsync(int id);
        Task<CurrencyDto> DeleteAsync(int id);
    }
}

using JazaniActividad.Application.Admins.Dtos.Currencies;


namespace JazaniActividad.Application.Admins.Services
{
    public interface IEventService
    {
        Task<IReadOnlyList<EventDto>> FindAllAsync();
        Task<EventDto?> FindByIdAsync(int id);
        Task<EventDto> CreateAsync(EventSaveDto EventSaveDto);
        Task<EventDto> EditAsync(int id, EventSaveDto EventSaveDto);
        Task<EventDto> DisabledAsync(int id);
    }
}

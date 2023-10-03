using JazaniActividad.Application.Admins.Dtos.Currencies;
using JazaniActividad.Domain.Admins.Repositories;
using JazaniActividad.Domain.Admins.Models;
using AutoMapper;

namespace JazaniActividad.Application.Admins.Services.Implementations
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;


        public EventService(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;

        }

        public async Task<IReadOnlyList<EventDto>> FindAllAsync()
        {
            IReadOnlyList<Event> currencies = await _eventRepository.FindAllAsync();
            return _mapper.Map<IReadOnlyList<EventDto>>(currencies);
        }


        public async Task<EventDto?> FindByIdAsync(int id)
        {
            Event? objEvent = await _eventRepository.FindByIdAsync(id);
            return _mapper.Map<EventDto>(objEvent);
        }

        public async Task<EventDto> CreateAsync(EventSaveDto eventSaveDto)
        {
            Event objEvent = _mapper.Map<Event>(eventSaveDto);
            objEvent.RegistrationDate = DateTime.Now;
            objEvent.State = true;

            Event currencySaved = await _eventRepository.SaveAsync(objEvent);

            return _mapper.Map<EventDto>(currencySaved);
        }

        public async Task<EventDto> EditAsync (int id, EventSaveDto eventSaveDto)
        {
            Event objEvent = await _eventRepository.FindByIdAsync(id);

           _mapper.Map<EventSaveDto, Event>(eventSaveDto, objEvent);

            Event currencySaved = await _eventRepository.SaveAsync(objEvent);

            return _mapper.Map<EventDto>(currencySaved);
        }


        public async Task<EventDto> DisabledAsync(int id)
        {
            Event objEvent = await _eventRepository.FindByIdAsync(id);
            objEvent.State = false;

            Event currencySaved = await _eventRepository.SaveAsync(objEvent);
            return _mapper.Map<EventDto>(currencySaved);

        } 
    }
}

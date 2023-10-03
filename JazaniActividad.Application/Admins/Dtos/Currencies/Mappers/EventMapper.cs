using AutoMapper;
using JazaniActividad.Domain.Admins.Models;


namespace JazaniActividad.Application.Admins.Dtos.Currencies.Mappers
{
    public class EventMapper : Profile
    {
        public EventMapper()
        {
            CreateMap<Event, EventDto>();
        }
    }
}

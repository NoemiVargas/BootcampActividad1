using AutoMapper;
using JazaniActividad.Domain.Admins.Models;

namespace JazaniActividad.Application.Admins.Dtos.Currencies.Mappers
{
    public class EventSaveMapper : Profile
    {
        public EventSaveMapper() 
        {
            CreateMap<Event, EventSaveDto>().ReverseMap();
        }
    }
}

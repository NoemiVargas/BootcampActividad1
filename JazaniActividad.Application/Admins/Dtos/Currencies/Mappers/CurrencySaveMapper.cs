using AutoMapper;
using JazaniActividad.Domain.Admins.Models;

namespace JazaniActividad.Application.Admins.Dtos.Currencies.Mappers
{
    public class CurrencySaveMapper : Profile
    {
        public CurrencySaveMapper() 
        {
            CreateMap<Currency, CurrencySaveDto>().ReverseMap();
        }
    }
}

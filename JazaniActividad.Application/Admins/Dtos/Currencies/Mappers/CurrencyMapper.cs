using AutoMapper;
using JazaniActividad.Domain.Admins.Models;


namespace JazaniActividad.Application.Admins.Dtos.Currencies.Mappers
{
    public class CurrencyMapper : Profile
    {
        public CurrencyMapper()
        {
            CreateMap<Currency, CurrencyDto>();
        }
    }
}

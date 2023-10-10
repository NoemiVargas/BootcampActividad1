

using AutoMapper;
using JazaniActividad.Application.Generals.Dtos.Holders;
using JazaniActividad.Application.Generals.Dtos.Invesmenttypes;
using JazaniActividad.Application.Generals.Dtos.InvestmentConcepts;
using JazaniActividad.Domain.Generals.Models;

namespace JazaniActividad.Application.Generals.Dtos.PeriodTypes.Profiles
{
    public class PeriodTypeProfile : Profile
    {
        public PeriodTypeProfile() 
        {
            CreateMap<PeriodType, PeriodTypeDto>();
            CreateMap<PeriodType, PeriodTypeSaveDto>().ReverseMap();
        }
    }
}

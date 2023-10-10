using AutoMapper;
using JazaniActividad.Application.Generals.Dtos.Invesmenttypes;
using JazaniActividad.Domain.Generals.Models;


namespace JazaniActividad.Application.Generals.Dtos.InvestmentConcepts.Profiles
{
    public class InvestmentConceptProfile : Profile
    {
        public InvestmentConceptProfile() 
        {
            CreateMap<InvestmentConcept, InvestmentConceptDto>();
            CreateMap<InvestmentConcept, InvesmenttypeSaveDto>().ReverseMap();

        }
    }
}

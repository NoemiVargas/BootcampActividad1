using AutoMapper;
using JazaniActividad.Domain.Generals.Models;

namespace JazaniActividad.Application.Generals.Dtos.Invesments.Profiles
{
    public class InvesmentProfile : Profile
    {
        public InvesmentProfile() {

            CreateMap<Invesment, InvesmentDto>();
            CreateMap<Invesment, InvesmentDto>().ReverseMap();
        }
    }
}

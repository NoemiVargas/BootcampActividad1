using AutoMapper;
using JazaniActividad.Application.Generals.Dtos.Invesments;
using JazaniActividad.Domain.Generals.Models;
namespace JazaniActividad.Application.Generals.Dtos.Invesmenttypes.Profiles
{
    public class InvesmenttypeProfile : Profile
    {
       public InvesmenttypeProfile() {
            CreateMap<Invesmenttype, InvesmenttypeDto>();
            CreateMap<Invesmenttype, InvesmenttypeSaveDto>().ReverseMap();
        }
    }
}

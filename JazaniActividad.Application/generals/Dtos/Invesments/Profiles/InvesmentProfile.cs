using AutoMapper;
using JazaniActividad.Application.generals.Dtos.Invesments;
using JazaniActividad.Core.Paginations;
using JazaniActividad.Domain.Generals.Models;

namespace JazaniActividad.Application.Generals.Dtos.Invesments.Profiles
{
    public class InvesmentProfile : Profile
    {
        public InvesmentProfile() {

            CreateMap<Invesment, InvesmentDto>();
            CreateMap<Invesment, InvesmentSaveDto>().ReverseMap();
            CreateMap<Invesment, InvesmentFilterDto>().ReverseMap();

            CreateMap<ResponsePagination<Invesment>, ResponsePagination<InvesmentDto>>();
            CreateMap<RequestPagination<Invesment>, RequestPagination<InvesmentFilterDto>>()
                .ReverseMap();
        }
    }
}

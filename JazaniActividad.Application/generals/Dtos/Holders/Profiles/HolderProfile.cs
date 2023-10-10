
using AutoMapper;
using JazaniActividad.Application.Generals.Dtos.Invesments;
using JazaniActividad.Domain.Generals.Models;


namespace JazaniActividad.Application.Generals.Dtos.Holders.Profiles
{
    public class HolderProfile : Profile
    {
        public HolderProfile() {

            CreateMap<Holder, HolderDto >();
            CreateMap<Holder, HolderSaveDto>().ReverseMap();

        }
    }
}

using AutoMapper;
using JazaniActividad.Application.Generals.Dtos.Invesments;
using JazaniActividad.Domain.Generals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Application.Generals.Dtos.MeasuredUnit.Profiles
{
    public class MeasuredUnitProfile : Profile
    {
        public MeasuredUnitProfile() 
        {

            CreateMap< MeasureUnit, MeasuredUnitDto>();
            CreateMap<MeasureUnit, MeasuredUnitSaveDto>().ReverseMap();
        }
    }
}

using AutoMapper;
using N_Tier.Application.Models.Students;
using N_Tier.Application.Models.TodoList;
using N_Tier.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.MappingProfiles
{
    public class StudentsProfile : Profile
    {
        public StudentsProfile()
        {
            CreateMap<CreateStudentsModel, Students>();

            CreateMap<Students, StudentsResponseModel>();
        }
    }
}

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMvcProject.Data.Models;
using UniversityMvcProject.ViewModels;

namespace UniversityMvcProject.Models.AutomapperProfiles
{
    public class StudentProfile : Profile
    {

        public StudentProfile()
        {
            CreateMap<Student, StudentDetailViewModel>()
                .ForMember(to => to.StudentId, option => option.MapFrom(from => from.Id))
                .ReverseMap();
        }

    }
}

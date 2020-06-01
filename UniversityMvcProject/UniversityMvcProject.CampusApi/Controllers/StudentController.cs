using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityMvcProject.CampusApi.Contexts;
using UniversityMvcProject.Data.Models;

namespace UniversityMvcProject.CampusApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly UniversityCampusContext context;

        public StudentController(UniversityCampusContext context)
        {
            this.context = context;
        }

        [Route("getAllStudents")]
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return context.Students.ToList();
        }


    }
}

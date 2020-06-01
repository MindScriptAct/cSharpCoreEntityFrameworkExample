using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityMvcProject.Data.Models;

namespace UniversityMvcProject.CampusApi.Contexts
{
    public class UniversityCampusContext : DbContext
    {

        public UniversityCampusContext(DbContextOptions<UniversityCampusContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}

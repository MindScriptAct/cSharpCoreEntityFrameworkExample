using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityMvcProject.Models;

namespace UniversityMvcProject.Data
{
    public class UniversityMvcProjectContext : DbContext
    {
        public UniversityMvcProjectContext (DbContextOptions<UniversityMvcProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Subject> Subjects { get; set; }
        
        public DbSet<Student> Students { get; set; }
    }
}

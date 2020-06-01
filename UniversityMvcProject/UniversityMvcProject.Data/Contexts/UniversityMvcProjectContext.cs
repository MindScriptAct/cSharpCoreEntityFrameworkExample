using Microsoft.EntityFrameworkCore;
using UniversityMvcProject.Data.Models;

namespace UniversityMvcProject.Data.Contexts
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
        
        public DbSet<StudentSubject> StudentSubjects { get; set; }
    }
}

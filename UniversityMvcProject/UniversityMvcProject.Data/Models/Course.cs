using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityMvcProject.Data.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Subject> Subjects { get; set; }
    }
}

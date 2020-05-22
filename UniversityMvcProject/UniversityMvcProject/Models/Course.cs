using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMvcProject.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Subject> Subjects { get; set; }
    }
}

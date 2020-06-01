using System.ComponentModel.DataAnnotations;

namespace UniversityMvcProject.Data.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        public int CourseId { get; set; }
        public Course Course { get; set; } 
    }
}

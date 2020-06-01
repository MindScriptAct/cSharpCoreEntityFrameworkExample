using System.ComponentModel.DataAnnotations;

namespace UniversityMvcProject.Data.Models
{
    public class StudentSubject
    {
        [Key]
        public int Id { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        [Range(0.0, 10.0)]
        public int Score { get; set; }
    }
}

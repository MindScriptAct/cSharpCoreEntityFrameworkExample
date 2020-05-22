using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMvcProject.Models
{
    public class StudentSubject
    {
        [Key]
        public int Id { get; set; }

        public Student Student { get; set; }
        
        public Subject Subject { get; set; }

        [Range(0.0, 10.0)]
        public int Score { get; set; }
    }
}

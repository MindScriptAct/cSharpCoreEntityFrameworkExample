using System;
using System.ComponentModel.DataAnnotations;

namespace UniversityMvcProject.Data.Models
{
    public class Dormitory
    {
        public  int Id { get; set; }
        
        [Required]
        [StringLength(550)]
        public  string Street { get; set; }
        
        [Required]
        [Range(0, int.MaxValue)]
        public  int House { get; set; }

    }
}

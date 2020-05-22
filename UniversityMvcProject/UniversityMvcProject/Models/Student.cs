using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMvcProject.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0.0, 10.0)]
        public double Score { get; set; }

        [Range(0, 255)]
        public int FriendCount { get; set; } = 0;

        public bool IsGettingTuition { get; set; } = false;

        public StudentStatus Status { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }

    }
}

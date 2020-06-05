using System;
using System.ComponentModel.DataAnnotations;

namespace UniversityMvcProject.Data.Models
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

        public int? DormitoryId { get; set; }
        public Dormitory Dormitory { get; set; }
        

    }
}

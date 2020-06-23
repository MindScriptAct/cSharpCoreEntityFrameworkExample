using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UniversityMvcProject.Data.Models;

namespace UniversityMvcProject.ViewModels
{
    public class StudentDetailViewModel
    {
        // student data
        public int StudentId { get; set; }

        public string Name { get; set; }

        public double Score { get; set; }

        public int FriendCount { get; set; } = 0;

        public bool IsGettingTuition { get; set; } = false;

        public StudentStatus Status { get; set; }

        public DateTime BirthDay { get; set; }

        public int? DormitoryId { get; set; }

        //[DisplayFormat(NullDisplayText = "homeless")]
        //public Dormitory Dormitory { get; set; }

        public string DormitoryStreet { get; set; }

        // all student subjects.
        public IEnumerable<Subject> Subjects { get; set; }
    }
}

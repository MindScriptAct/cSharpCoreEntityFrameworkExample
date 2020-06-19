using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMvcProject.Data.Models;

namespace UniversityMvcProject.ViewModels
{
    public class StudentDetailViewModel
    {
        // student data
        public Student Student { get; set; }

        // all student subjects.
        public IEnumerable<Subject> Subjects { get; set; }
    }
}

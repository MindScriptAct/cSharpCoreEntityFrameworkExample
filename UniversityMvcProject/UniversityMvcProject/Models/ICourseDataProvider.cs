using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMvcProject.Data.Models;

namespace UniversityMvcProject.Models
{
    public interface ICourseDataProvider
    {

        List<Course> GetAll();
        Course Get(int id);

        void Add(Course course);

        void Update(Course course);

        void Delete(int id);
    }
}

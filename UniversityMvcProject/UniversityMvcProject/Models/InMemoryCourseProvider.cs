using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMvcProject.Data.Models;

namespace UniversityMvcProject.Models
{
    public class InMemoryCourseProvider : ICourseDataProvider
    {

        static private List<Course> courses = new List<Course>();

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course Get(int id)
        {
            return courses.FirstOrDefault(course => course.Id == id);
        }

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Update(Course course)
        {
            Delete(course.Id);
            Add(course);
        }

        public void Delete(int id)
        {
            courses.RemoveAll(course => course.Id == id);
        }
    }
}

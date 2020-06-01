using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityMvcProject.Data.Models;
using UniversityMvcProject.Models;

namespace UniversityMvcProject.Controllers
{
    public class CourseTestController : Controller
    {

        private ICourseDataProvider courseDataProvider;


        public CourseTestController(ICourseDataProvider courseDataProvider)
        {
            this.courseDataProvider = courseDataProvider;
        }



        // GET: CourseTest
        public ActionResult Index()
        {
            return View(courseDataProvider.GetAll());
        }

        // GET: CourseTest/Details/5
        public ActionResult Details(int id)
        {
            return View(courseDataProvider.Get(id));
        }

        // GET: CourseTest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseTest/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course course)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    courseDataProvider.Add(course);
                    // TODO: Add insert logic here
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {

            }
            return View(course);
        }

        // GET: CourseTest/Edit/5
        public ActionResult Edit(int id)
        {
            return View(courseDataProvider.Get(id));
        }

        // POST: CourseTest/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Course course)
        {
            try
            {
                // TODO: Add update logic here
                courseDataProvider.Update(course);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseTest/Delete/5
        public ActionResult Delete(int id)
        {
            return View(courseDataProvider.Get(id));
        }

        // POST: CourseTest/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                courseDataProvider.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
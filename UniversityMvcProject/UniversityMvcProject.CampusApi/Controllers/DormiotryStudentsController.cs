using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using UniversityMvcProject.CampusApi.Contexts;
using UniversityMvcProject.Data.Models;

namespace UniversityMvcProject.CampusApi.Controllers
{

    [Route("api/Dormitories/{dormitoryId:int}/Students")]
    public class DormiotryStudentsController : ControllerBase
    {
        private readonly UniversityCampusContext context;

        public DormiotryStudentsController(UniversityCampusContext context)
        {
            this.context = context;
        }

        // GET: api/Dormitories/1/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetDormitoryStudents(int dormitoryId, bool includeDormitoryInfo = false)
        {
            if (includeDormitoryInfo)
            {
                return await context.Students.Where(s => s.DormitoryId == dormitoryId).Include(s => s.Dormitory).ToListAsync();
            }
            else
            {
                return await context.Students.Where(s => s.DormitoryId == dormitoryId).ToListAsync();
            }
        }

        // GET: api/Dormitories/1/Students/filterByStatus/1
        [HttpGet("filterByStatus/{status:int}")]
        public async Task<ActionResult<IEnumerable<Student>>> GetDormitoryStudentsFilteredByStatus(int dormitoryId, StudentStatus status)
        {
            if (status == StudentStatus.UNDEFINED)
            {
                return BadRequest("status does not exist.");
            }

            return await context.Students.Where(s => s.DormitoryId == dormitoryId && s.Status == status).ToListAsync();
        }

        [HttpDelete("{studentId:int}")]
        public async Task<ActionResult<IEnumerable<Student>>> DeletDormitoryFromStudent(int dormitoryId, int studentId)
        {
            Dormitory dormitory = await context.Dormitories.FindAsync(dormitoryId);
            if (dormitory == null){
                return BadRequest("Dormitory does not exist");
            }
            Student student = await context.Students.FindAsync(studentId);
            if (student == null){
                return BadRequest("Dormitory does not exist");
            }
            if (student.DormitoryId != dormitoryId)
            {
                return BadRequest("This student does not live here.");
            }

            student.DormitoryId = null;
            context.Entry(student).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return Ok();
        }
    }
}

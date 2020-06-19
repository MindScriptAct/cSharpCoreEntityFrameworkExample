using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UniversityMvcProject.Services;

namespace UniversityMvcProject.Controllers
{
    public class DormitoryTestController : Controller
    {
        private readonly ICampusApiClient apiClient;

        public DormitoryTestController(ICampusApiClient apiClient)
        {
            this.apiClient = apiClient;
        }


        public IActionResult Index()
        {
            return View(apiClient.GetAllDormitories());
        }
    }
}

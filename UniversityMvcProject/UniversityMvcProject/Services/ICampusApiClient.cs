using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMvcProject.Data.Models;

namespace UniversityMvcProject.Services
{
    public interface ICampusApiClient
    {

        IEnumerable<Dormitory> GetAllDormitories();


    }
}

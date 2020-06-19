using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UniversityMvcProject.Data.Models;

namespace UniversityMvcProject.Services
{
    public class CampusApiClient : ICampusApiClient
    {
        public IEnumerable<Dormitory> GetAllDormitories()
        {
            using HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44389/api/");

            var getRequestTask = client.GetAsync("Dormitories");
            getRequestTask.Wait();

            var result = getRequestTask.Result;

            IEnumerable<Dormitory> dormitories;

            if (result.IsSuccessStatusCode)
            {
                var data = result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<IEnumerable<Dormitory>>(data);
            }
            return Enumerable.Empty<Dormitory>();
        }
    }
}

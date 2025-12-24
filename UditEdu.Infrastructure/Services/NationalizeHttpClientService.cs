using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using UditEdu.Core.Models;

namespace UditEdu.Infrastructure.Services
{
    public class NationalizeHttpClientService(HttpClient httpClient)
    {
        public async Task<NationalizeData> GetData()
        {
            return await httpClient.GetFromJsonAsync<NationalizeData>("?name=nathaniel");
        }
    }
}

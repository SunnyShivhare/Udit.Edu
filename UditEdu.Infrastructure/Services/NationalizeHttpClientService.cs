using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace UditEdu.Infrastructure.Services
{
    public class NationalizeHttpClientService(HttpClient httpClient)
    {
        public async Task<dynamic> GetData()
        {
            return httpClient.GetFromJsonAsync<dynamic>("https://api.nationalize.io/?name=nathaniel");
        }
    }
}

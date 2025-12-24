using System.Net.Http.Json;
using UditEdu.Core.Models;

namespace UditEdu.Infrastructure.Services
{
    public class JokeHttpClientService(HttpClient httpClient)
    {
        public async Task<JokeData> GetJokeData()
        {
            return await httpClient.GetFromJsonAsync<JokeData>("random_joke");
        }
    }
}

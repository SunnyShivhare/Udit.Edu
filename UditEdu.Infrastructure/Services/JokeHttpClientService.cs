using System.Net.Http.Json;

namespace UditEdu.Infrastructure.Services
{
    public class JokeHttpClientService(HttpClient httpClient)
    {
        public async Task<dynamic> GetJokeData()
        {
            return httpClient.GetFromJsonAsync<dynamic>("https://official-joke-api.appspot.com/random_joke");
        }
    }
}

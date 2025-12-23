using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UditEdu.Core.Interfaces;
using UditEdu.Infrastructure.Services;

namespace UditEdu.Infrastructure.Repositories
{
    public class ExternalVendorRepository(NationalizeHttpClientService nationalizeHttpClientService,JokeHttpClientService jokeHttpClientService) : IExternalVendorRepository
    {
        public async Task<dynamic> GetNationalizeData()
        {
            return await nationalizeHttpClientService.GetData();
        }

        public async Task<dynamic> GetJokeData() 
        {
            return await jokeHttpClientService.GetJokeData();
        }
    }
}

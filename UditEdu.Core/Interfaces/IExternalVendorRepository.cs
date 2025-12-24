using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UditEdu.Core.Models;

namespace UditEdu.Core.Interfaces
{
    public interface IExternalVendorRepository
    {
        Task<NationalizeData> GetNationalizeData();
        Task<JokeData> GetJokeData();
    }
}

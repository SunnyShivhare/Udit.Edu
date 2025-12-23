using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UditEdu.Core.Interfaces
{
    public interface IExternalVendorRepository
    {
        Task<dynamic> GetNationalizeData();
        Task<dynamic> GetJokeData();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UditEdu.Core.Entities;

namespace UditEdu.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeEntity>> GetAllEmployeesAsync();
        Task<EmployeeEntity> GetEmployeeByIdAsync(Guid employeeId);
        Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity employeeEntity);
        Task<EmployeeEntity> UpdateEmployeeAsync(Guid employeeId, EmployeeEntity employeeEntity);

        Task<bool> DeleteEmployee(Guid employeeId);
    }
}

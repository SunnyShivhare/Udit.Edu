using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UditEdu.Core.Entities;
using UditEdu.Core.Interfaces;
using UditEdu.Infrastructure.Data;

namespace UditEdu.Infrastructure.Repositories
{
    public class EmployeeRepository(AppDBContext dbContext) : IEmployeeRepository
    {
        public async Task<IEnumerable<EmployeeEntity>> GetAllEmployeesAsync()
        {
            return await dbContext.Employees.ToListAsync();
        }

        public async Task<EmployeeEntity> GetEmployeeByIdAsync(Guid employeeId)
        {
            var result = await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);
            return result;
        }

        public async Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity employeeEntity)
        {
            employeeEntity.Id = Guid.NewGuid();
            dbContext.Employees.Add(employeeEntity);
            await dbContext.SaveChangesAsync();
            return employeeEntity;
        }

        public async Task<EmployeeEntity> UpdateEmployeeAsync(Guid employeeId, EmployeeEntity employeeEntity)
        {
            var employee = await dbContext.Employees.FirstOrDefaultAsync(x=>x.Id == employeeId);
            if (employee != null) 
            { 
                employee.Name = employeeEntity.Name;
                employee.Email = employeeEntity.Email;
                employee.Phone = employeeEntity.Phone;

               // dbContext.Employees.Add(employee);
                await dbContext.SaveChangesAsync();
                return employee;
            }
            return employeeEntity;

        }

        public async Task<bool> DeleteEmployee(Guid employeeId)
        {
            var employee = await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);
            if (employee != null)
            { 
             dbContext.Employees.Remove(employee);
             return await dbContext.SaveChangesAsync()>0;
            }
            return false;
        }
    }
}

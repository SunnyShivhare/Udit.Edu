using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UditEdu.Core.Entities;
using UditEdu.Core.Interfaces;

namespace UditEdu.Application.Queries
{
    public record GetAllEmployeeQuery():IRequest<IEnumerable<EmployeeEntity>>;

    public class GetAllEmployeeQueryHandler(IEmployeeRepository employeeRepository) :
        IRequestHandler<GetAllEmployeeQuery, IEnumerable<EmployeeEntity>>
    {
        public async Task<IEnumerable<EmployeeEntity>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepository.GetAllEmployeesAsync();
        }
    }


}

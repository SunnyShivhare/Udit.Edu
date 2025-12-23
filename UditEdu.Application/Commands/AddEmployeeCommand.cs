using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UditEdu.Core.Entities;
using UditEdu.Core.Interfaces;

namespace UditEdu.Application.Commands
{
    public record AddEmployeeCommand(EmployeeEntity employeeEntity) : IRequest<EmployeeEntity>;

    public class AddEmployeeCommandHandler(IEmployeeRepository employeeRepository) :
        IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.AddEmployeeAsync(request.employeeEntity);
        }
    }

}

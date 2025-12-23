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
    public record UpdateEmployeeCommand(Guid employeeId,EmployeeEntity EmployeeEntity):IRequest<EmployeeEntity>;

    public class UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository) :
        IRequestHandler<UpdateEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.UpdateEmployeeAsync(request.employeeId, request.EmployeeEntity);
        }
    }


}

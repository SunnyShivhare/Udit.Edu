using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UditEdu.Core.Interfaces;

namespace UditEdu.Application.Commands
{
    public record DeleteEmployeeCommand(Guid EmployeeId) : IRequest<bool>;

    public class DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository) :
        IRequestHandler<DeleteEmployeeCommand, bool>
    {
        public Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            return employeeRepository.DeleteEmployee(request.EmployeeId);
        }
    }
}

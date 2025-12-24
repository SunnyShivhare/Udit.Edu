using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UditEdu.Application.Events;
using UditEdu.Core.Entities;
using UditEdu.Core.Interfaces;

namespace UditEdu.Application.Commands
{
    public record AddEmployeeCommand(EmployeeEntity employeeEntity) : IRequest<EmployeeEntity>;

    public class AddEmployeeCommandHandler(IEmployeeRepository employeeRepository,IPublisher mediatR) :
        IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var user = await employeeRepository.AddEmployeeAsync(request.employeeEntity);
            await mediatR.Publish(new UserCreatedEvent(user.Id));
            return user;
        }
    }

}

using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UditEdu.Application.Events
{
    public class StartMembershipEventHandler(ILogger<StartMembershipEventHandler> logger) : INotificationHandler<UserCreatedEvent>
    {
        public async Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
        {
            logger.LogInformation("User Created : Start Membership for {userId }", notification.userId);
            await Task.Delay(1000);
            logger.LogInformation("User Created : done Membership for  {userId }", notification.userId);

        }
    }
}

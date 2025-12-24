using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UditEdu.Application.Events
{
    public class SendEmailEventHandler(ILogger<SendEmailEventHandler> logger) : INotificationHandler<UserCreatedEvent>
    {
        public async Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
        {
            logger.LogInformation("User Created : start sending mail for {userId}", notification.userId);
            await Task.Delay(2000);
            logger.LogInformation("User Created : mail send done for {userId}", notification.userId);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NullObjectPattern.NotificationService;

namespace NullObjectPattern.Controllers
{
    [Route("api/v1/send-notification")]
    [ApiController]
    public class SendNotificationController : ControllerBase
    {

        private readonly ILogger<SendNotificationController> _logger;
        private readonly INotification _notification;
        

        public SendNotificationController(ILogger<SendNotificationController> logger,
            INotification notification)
        {
            _logger = logger;
            _notification = notification;
        }

        [HttpPost]
        public async Task<IActionResult> Send(string message)
        {
            await _notification.SendMessage(message);

            return NoContent();
        }
    }
}

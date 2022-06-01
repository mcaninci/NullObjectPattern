using System;
using System.Threading.Tasks;

namespace NullObjectPattern.NotificationService
{
    public class NotificationSmsService : NotificationAbstract
    {

        public override async Task<bool> SendMessage(string message)
        {
            _provider.SendMessage(message);
            return true;
        }

    }
}

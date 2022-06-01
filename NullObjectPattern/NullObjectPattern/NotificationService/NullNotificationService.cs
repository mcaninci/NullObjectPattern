using System;
using System.Threading.Tasks;

namespace NullObjectPattern.NotificationService
{
    public class NullNotificationService:NotificationAbstract
    {

        public override async Task<bool> SendMessage(string message)
        {
            Console.WriteLine("SendSms failed from NullNotificationSmsService");
            return true;
        }
    }
}

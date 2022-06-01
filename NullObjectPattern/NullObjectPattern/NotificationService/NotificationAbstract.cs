using System;
using System.Threading.Tasks;

namespace NullObjectPattern.NotificationService
{
    public abstract class NotificationAbstract: INotification
    {
        public NotificationAbstract _provider;
        public virtual async Task<bool> SendMessage(string message)
        {
           await _provider.SendMessage(message);

            return true;
        }
    }
}

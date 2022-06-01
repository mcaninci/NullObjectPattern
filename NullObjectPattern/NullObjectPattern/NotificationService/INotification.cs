using System;
using System.Threading.Tasks;

namespace NullObjectPattern.NotificationService
{
    public interface INotification
    {

        public  Task<bool> SendMessage(string message);
      
    }
}

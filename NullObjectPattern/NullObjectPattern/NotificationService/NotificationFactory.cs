using System;
namespace NullObjectPattern.NotificationService
{
    public class NotificationFactory:NotificationAbstract
    {
        public NotificationFactory()
        {
            try
            {
                //Create sms notificaiton
                throw new Exception("NotificationSmsService provider does not create");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _provider = new NullNotificationService();
            }
        }
    }
}

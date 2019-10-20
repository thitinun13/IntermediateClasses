using System;

namespace InterfacePolymor
{
    public class SmsNotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}

using System;

namespace InterfacePolymor
{
    public class MailNotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail...");
        }
    }
}

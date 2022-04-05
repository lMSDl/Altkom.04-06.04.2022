using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public static class Client
    {
        public static void Execute()
        {
            var text = Console.ReadLine();
            var notification = (INotification)new InternalNotification();
            if (text.Length <= 10)
                notification = new SmsNotification(notification);
            notification = new EmailNotification(notification);

            notification.Send(text);
        }
    }
}

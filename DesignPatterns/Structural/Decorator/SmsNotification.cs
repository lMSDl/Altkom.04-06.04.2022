using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class SmsNotification : NotificationDecorator
    {
        public SmsNotification(INotification notification) : base(notification)
        {
        }

        protected override void ExtraSend(string message)
        {
            Console.WriteLine($"Wysłanie SMS: {message}");
        }
    }
}

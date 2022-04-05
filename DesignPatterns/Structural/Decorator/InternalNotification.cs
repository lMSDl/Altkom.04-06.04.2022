using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class InternalNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Internal notification has been send: " + message);
        }
    }
}

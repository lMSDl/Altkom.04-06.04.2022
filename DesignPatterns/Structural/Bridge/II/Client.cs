using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.II
{
    public class Client
    {
        public static void Execute()
        {
            var message = new ShortMessageAbstraction();
            message.SenderImplementation = new EmailSender();
            message.SendMessage(Console.ReadLine());

            message.SenderImplementation = new SmsSender();
            message.SendMessage(Console.ReadLine());
        }
    }
}

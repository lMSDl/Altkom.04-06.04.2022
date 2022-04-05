using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.II
{
    public class EmailSender : ISenderImplementation
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Wiadomość została wysłana przez Email: {message}");
        }
    }
}
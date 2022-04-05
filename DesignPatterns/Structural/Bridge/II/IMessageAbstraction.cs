using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.II
{
    public class MessageAbstraction
    {
        public ISenderImplementation SenderImplementation { get; set; }

        public virtual void SendMessage(string message)
        {
            SenderImplementation?.SendMessage(message);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.II
{
    public class ShortMessageAbstraction : MessageAbstraction
    {
        public override void SendMessage(string message)
        {
            base.SendMessage(message.Substring(0, 15));
        }
    }
}
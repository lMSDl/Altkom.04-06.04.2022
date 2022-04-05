using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Frame : Container
    {
        protected override void Click(bool handled)
        {
            if(!handled)
                Console.WriteLine("Frame click");
            Console.WriteLine("Frame Flashing");
            base.Click(true);
        }
    }
}


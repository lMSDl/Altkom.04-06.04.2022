using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public abstract class Component : IClickHandler
    {
        public Component Parent { get; set; }

        public void Click()
        {
            Click(false);
        }

        public int ClickCounter {get; private set;}
        protected virtual void Click(bool handled)
        {
            ClickCounter++;
            Parent?.Click(handled);
        }
    }
}
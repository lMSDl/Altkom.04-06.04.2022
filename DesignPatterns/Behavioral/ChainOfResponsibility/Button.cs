using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Button : Component
    {
        public Func<bool> Func { get; set; }

        protected override void Click(bool handled)
        {
            if(!handled)
            {
                if (!Func())
                {
                    base.Click(false);
                    return;
                }
            }
            base.Click(true);
        }
    }
}

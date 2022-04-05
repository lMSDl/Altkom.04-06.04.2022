using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Hall : Container
    {
        public override string Name { get; }

        public Hall(string name)
        {
            Name = name;
        }
    }
}

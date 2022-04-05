using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Shelf : Container
    {
        public override string Name { get; }

        public Shelf(string name)
        {
            Name = name;
        }
    }
}

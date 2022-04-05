using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public abstract class Leaf : IProduct
    {
        public abstract string Name { get; }

        public abstract float GetValue();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Cookie : Leaf
    {
        public override string Name => "Ciastka";

        public override float GetValue()
        {
            return 16.10f;
        }
    }
}

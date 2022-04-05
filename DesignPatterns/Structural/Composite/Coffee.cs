using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Coffee : Leaf
    {
        public override string Name => "Kawa";
        public override float GetValue()
        {
            return 32.12f;
        }
    }
}

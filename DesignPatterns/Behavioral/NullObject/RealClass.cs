using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.NullObject
{
    public class RealClass : AbstractClass
    {
        public override void MethodC()
        {
            Console.WriteLine("C");
        }
    }
}

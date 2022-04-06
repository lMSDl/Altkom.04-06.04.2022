using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.NullObject
{
    public class NullClass : AbstractClass
    {
        public new void MethodA()
        {
        }
        public override void MethodB()
        {
        }
        public override void MethodC()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.PrivateClassData
{
    public class SomeClass
    {
        private SomeClassData data;

        public SomeClass(string @string, int @int)
        {
            //this.@string = @string;
            //this.@int = @int;
            data = new SomeClassData(@string, @int);
        }

        public void SomeMethid()
        {
            data.GetInt();
            data.GetString();
        }
    }
}

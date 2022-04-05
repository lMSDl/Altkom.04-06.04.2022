using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.PrivateClassData
{
    public class SomeClassData
    {
        private string @string;
        private int @int;

        public SomeClassData(string @string, int @int)
        {
            this.@string = @string;
            this.@int = @int;
        }

        public string GetString()
        {
            return @string;
        }
        public int GetInt()
        {
            return @int;
        }
    }
}

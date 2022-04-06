using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class Client
    {
        public static void Execute()
        {
            var list = new List<string> { "a", "b", "c", "d", "e" };

            var buffer = new Buffer<string>(list);
            var bufferIterator = buffer.GetEnumerator();
            while(bufferIterator.MoveNext())
            {
                var item = bufferIterator.Current;
                Console.WriteLine($"{item[0]}{item[1]}");
            }

            foreach (var item in buffer)
            {
                Console.WriteLine($"{item[0]}{item[1]}");
            }
        }
    }
}

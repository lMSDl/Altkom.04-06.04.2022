using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.NullObject
{
    public class Client
    {
        public static void Execute()
        {

            var classes = new AbstractClass[] { new NullClass(), new RealClass(), null };

            while (true)
            {
                Console.ReadLine();
                var random = new Random().Next(0, 3);
                classes[random].MethodA();
                classes[random].MethodB();
                classes[random].MethodC();
            }
        }
    }
}

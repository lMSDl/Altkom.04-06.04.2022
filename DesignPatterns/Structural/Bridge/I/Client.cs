using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.I
{
    public class Client
    {
        public static void Execute()
        {
            var shape = new Circle();
            Console.WriteLine(shape);

            shape.Color = new BlueColor();
            Console.WriteLine(shape);

        }
    }
}

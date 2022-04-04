using SOLID.L;
using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcRectangleArea(new Square(), 2, 5);
        }

        static void CalcRectangleArea(Rectangle rectangle, int sizeA, int sizeB)
        {
            rectangle.A = sizeA;
            rectangle.B = sizeB;
            Console.WriteLine($"{sizeA} * {sizeB} = {rectangle.Area}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class ElevatorOpenDoor : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Winda otworzy drzwi na piętrze {floor}");
        }
    }
}

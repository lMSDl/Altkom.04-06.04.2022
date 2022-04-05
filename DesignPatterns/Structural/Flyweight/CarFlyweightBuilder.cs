using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class CarFlyweighBuilder
    {
        public CarFlyweighBuilder(CarFlyweight carFlyweight)
        {
            CarFlyweight = (CarFlyweight)carFlyweight.MakeClone();
        }

        public CarFlyweighBuilder()
        {
        }

        private CarFlyweight CarFlyweight { get; } = new CarFlyweight();

        public string Manufacturer { set => CarFlyweight.Manufacturer = value; }
        public string Model { set => CarFlyweight.Model = value; }
        public string Color { set => CarFlyweight.Color = value; }

        public CarFlyweight Build(FlyweightFactory factory)
        {
            return factory.GetFlyweight(CarFlyweight);
        }
        public CarFlyweight Build(HashSetFlyweightFactory factory)
        {
            return factory.GetFlyweight(CarFlyweight);
        }
    }
}

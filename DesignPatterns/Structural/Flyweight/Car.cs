using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class Car
    {
        public string Owner { get; set; }
        public string Number { get; set; }
        public string Manufacturer { get => CarFlyweight.Manufacturer; /*set => CarFlyweight.Manufacturer = value;*/ }
        public string Model { get => CarFlyweight.Model; /*set => CarFlyweight.Model = value;*/ }
        public string Color { get => CarFlyweight.Color; /*set => CarFlyweight.Color = value;*/ }

        public CarFlyweight CarFlyweight { get; set; }
    }
}


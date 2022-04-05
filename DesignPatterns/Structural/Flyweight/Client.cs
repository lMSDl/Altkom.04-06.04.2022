using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class Client
    {
        public static void Execute()
        {
            var factory = new HashSetFlyweightFactory(
                new CarFlyweight { Manufacturer = "Chevrolet", Model = "Camaro2018", Color = "Pink" },
                new CarFlyweight { Manufacturer = "Mercedes Benz", Model = "C300", Color = "Black" },
                new CarFlyweight { Manufacturer = "Mercedes Benz", Model = "C500", Color = "Red" },
                new CarFlyweight { Manufacturer = "BMW", Model = "M5", Color = "Red" },
                new CarFlyweight { Manufacturer = "BMW", Model = "X6", Color = "White" }
            );
            //factory.ListFlyweights();
            var car = new Car
            {
                Number = "CL234IR",
                Owner = "James Doe"
            };

            var builder = new CarFlyweighBuilder();
            builder.Manufacturer = "BMW";
            builder.Model = "M5";
            builder.Color = "Red";

            car.CarFlyweight = builder.Build(factory);
            //factory.ListFlyweights();

            var car2 = new Car();
            var car3 = new Car();

            builder.Color = "Blue";
            car2.CarFlyweight = builder.Build(factory);
            //factory.ListFlyweights();
            car3.CarFlyweight = builder.Build(factory);

            builder = new CarFlyweighBuilder(car2.CarFlyweight);
            builder.Color = "Pink";
            car2.CarFlyweight = builder.Build(factory);
        }
    }
}

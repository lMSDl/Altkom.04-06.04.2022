using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Client
    {
        public static void Execute()
        {
            var vehicle = new Vehicle(4, 5, 4, 500, 100);
            //var vehicle = new Vehicle.VehicleBuilder().Build(); - można stosować jako klasa wewnętrzna klasy Vehicle, w celu zablokowania konstruktorów
            Console.WriteLine(vehicle);

            //var builder = new VehicleBuilder();
            //builder.SetWheels(4);
            //builder.SetDoors(5);
            //builder.SetSeats(4);
            //builder.SetTrunkCapacity(500);
            //builder.SetEnginePower(100);
            //vehicle = builder.Build();

            //fluent api
            var builder = new VehicleBuilder()
            .SetWheels(4)
            .SetDoors(5)
            .SetSeats(4)
            .SetTrunkCapacity(500)
            .SetEnginePower(100);

            vehicle = builder.Build();
            //vehicle = new Vehicle() { Wheels = 4, Doors = 5, Seats = 4, TrunkCapacity = 500, EnginePower = 100 };
            Console.WriteLine(vehicle);
            vehicle.EnginePower = 150;
            Console.WriteLine(vehicle);

            vehicle = builder.Build();
            Console.WriteLine(vehicle);
        }
    }
}

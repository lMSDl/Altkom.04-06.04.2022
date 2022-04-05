using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class HashSetFlyweightFactory
    {
        private readonly HashSet<CarFlyweight> _flyweights;

        public HashSetFlyweightFactory(params CarFlyweight[] values)
        {
            _flyweights = new HashSet<CarFlyweight>(values);
        }

        public CarFlyweight GetFlyweight(CarFlyweight carFlyweight)
        {
            if (_flyweights.TryGetValue(carFlyweight, out var result))
            {
                Console.WriteLine("Płatek istnieje, zwracamy cache");
                return result;
            }

            Console.WriteLine("Płatek nie istnieje, zapisujemy w cache");
            _flyweights.Add(carFlyweight);
            return carFlyweight;
        }
    }
}

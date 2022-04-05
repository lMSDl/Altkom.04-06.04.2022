using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class FlyweightFactory
    {
        private readonly Dictionary<string, CarFlyweight> _flyweights;

        public FlyweightFactory(params CarFlyweight[] values)
        {
            _flyweights = values.ToDictionary(x => GetKey(x));
        }

        private string GetKey(CarFlyweight flyweight)
        {
            var values = flyweight.GetType().GetProperties()
                .Where(x => x.CanWrite)
                .Where(x => x.CanRead)
                .OrderBy(x => x.Name)
                .Select(x => x.GetValue(flyweight).ToString());
            return string.Join("_", values);
        }

        public CarFlyweight GetFlyweight(CarFlyweight carFlyweight)
        {
            var key = GetKey(carFlyweight);
            if (_flyweights.TryGetValue(key, out var result))
            {
                Console.WriteLine("Płatek istnieje, zwracamy cache");
                return result;
            }

            Console.WriteLine("Płatek nie istnieje, zapisujemy w cache");
            _flyweights[key] = carFlyweight;
            return carFlyweight;
        }
        public void ListFlyweights()
        {
            var count = _flyweights.Count;
            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in _flyweights)
            {
                Console.WriteLine(flyweight.Key);
            }
        }
    }
}

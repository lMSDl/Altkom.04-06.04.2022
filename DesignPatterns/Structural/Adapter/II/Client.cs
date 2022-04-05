using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.II
{
    public class Client
    {
        public static void Execute()
        {
            IPeopleService service = new DbPersonServiceAdapter(new DbPersonService());
            foreach (var item in service.GetPeople())
            {
                ToString(item);
            }
        }

        public static void ToString(Person person)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}

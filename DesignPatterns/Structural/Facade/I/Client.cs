using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.I
{
    public class Client
    {
        public static void Execute()
        {
            var item = new Person { Name = "Ewa Ewowska", BirthDate = DateTime.Now.AddDays(-32) };


            Console.WriteLine(SerializerFacade.Serialize(item));
        }
    }
}

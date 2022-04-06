using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class DatabaseLogger : Logger<LogEntity, DatabaseService>
    {
        protected override void StoreData(LogEntity data, DatabaseService service)
        {
            service.Insert(data);
        }

        protected override DatabaseService GetService()
        {
            Console.WriteLine("Connecting to Database.");
            return new DatabaseService();
        }

        protected override LogEntity PrepareData(string message)
        {
            Console.WriteLine("Serializing message");
            return new LogEntity { DateTime = DateTime.Now, Message = message };
        }
    }
}


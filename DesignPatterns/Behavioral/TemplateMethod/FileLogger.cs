using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class FileLogger : Logger<string, FileService>
    {
        protected override void StoreData(string data, FileService service)
        {
            service.Write(data);
        }

        protected override FileService GetService()
        {
            Console.WriteLine("Opening File.");
            return new FileService();
        }

        protected override string PrepareData(string message)
        {
            Console.WriteLine("Serializing message");
            return $"{DateTime.Now}: {message}";
        }
    }
}

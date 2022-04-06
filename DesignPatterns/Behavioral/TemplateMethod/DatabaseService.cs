using Newtonsoft.Json;
using System;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class DatabaseService : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Closing DB connection.");
        }

        public void Insert(LogEntity entity)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + JsonConvert.SerializeObject(entity));
        }
    }
}
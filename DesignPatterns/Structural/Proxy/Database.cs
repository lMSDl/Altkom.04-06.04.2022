using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class Database : IDatabase
    {
        private int _connectionCounter = 0;

        public Database()
        {
            Console.WriteLine("Otwarcie połączenia z bazą");
        }

        public void Dispose()
        {
            Console.WriteLine("Zamknięcie połączenia z bazą");
        }

        public async Task<int?> RequestAsync(int parameter)
        {
            if (_connectionCounter >= 5)
            {
                Console.WriteLine($"Request {parameter} dropped!");
                return null;
            }

            Interlocked.Increment(ref _connectionCounter);
            Console.WriteLine($"Opening connectino {_connectionCounter}");
            await Task.Delay(new Random(_connectionCounter).Next(1000, 3000));

            Console.WriteLine($"Request {parameter} completed ({_connectionCounter})");
            Interlocked.Decrement(ref _connectionCounter);
            return parameter;
        }
    }
}


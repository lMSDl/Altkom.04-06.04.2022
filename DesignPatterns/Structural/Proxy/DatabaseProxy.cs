using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class DatabaseProxy : IDatabase
    {
        private const int InitialCount = 3;
        private IDatabase _database;
        private readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(InitialCount);

        public DatabaseProxy(IDatabase database)
        {
            _database = database;
        }

        public async Task<int?> RequestAsync(int parameter)
        {
            if (_database == null)
                _database = new Database();

            await semaphoreSlim.WaitAsync();
            var result = await _database.RequestAsync(parameter);
            semaphoreSlim.Release();

            if(InitialCount == semaphoreSlim.CurrentCount)
            {
                _database.Dispose();
                _database = null;
            }

            return result;
        }

        public void Dispose()
        {
            _database?.Dispose();
        }
    }
}

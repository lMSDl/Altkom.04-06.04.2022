using System;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public interface IDatabase : IDisposable
    {
        Task<int?> RequestAsync(int parameter);
    }
}
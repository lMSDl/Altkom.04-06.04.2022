using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class Logger<T, TService> where TService : IDisposable
    {
        public void Log(string message)
        {
            T data = PrepareData(message);
            TService service = GetService();
            AfterGetService(service);
            BeforeStoreData(data);
            StoreData(data, service);
            DisposeService(service);
        }

        protected virtual void BeforeStoreData(T data)
        {

        }
        protected virtual void AfterGetService(TService service)
        {

        }

        protected virtual void DisposeService(IDisposable service)
        {

            service.Dispose();
        }

        protected abstract void StoreData(T data, TService service);

        protected abstract TService GetService();

        protected abstract  T PrepareData(string message);
    }
}

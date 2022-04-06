using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public abstract class Observer<T> : IObserver<T>
    {
        private IDisposable subscription;
        public void Subscribe(IObservable<T> stream)
        {
            subscription?.Dispose();
            subscription = stream?.Subscribe(this);
        }

        public virtual void OnCompleted()
        {
            subscription.Dispose();
            subscription = null;
        }

        public abstract void OnError(Exception error);

        public abstract void OnNext(T value);
    }
}

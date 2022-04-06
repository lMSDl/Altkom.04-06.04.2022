using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class Publisher : IObservable<int>, IDisposable
    {
        private List<IObserver<int>> _observers = new List<IObserver<int>>();
        private int index;

        public IDisposable Subscribe(IObserver<int> observer)
        {
            _observers.Add(observer);
            return new Unsubscribe(() => _observers.Remove(observer));
        }

        public int Index
        {
            get => index;
            set
            {
                index = value;
                Notify();
            }
        }

        private void Notify()
        {
            if (Index == -1)
                _observers.ToList().ForEach(x => x.OnError(new IndexOutOfRangeException()));
            else
                _observers.ToList().ForEach(x => x.OnNext(Index));
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nPublisher: I'm doing something important.");
            Thread.Sleep(1000);
            Index = new Random().Next(-1, 10);
            Console.WriteLine("Publisher: My state has just changed to: " + Index);
        }

        public void Dispose()
        {
            _observers.ToList().ForEach(x => x.OnCompleted());
        }
    }
}

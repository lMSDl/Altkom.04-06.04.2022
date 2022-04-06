using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    class ObserverA : Observer<int>
    {
        public override void OnCompleted()
        {
            base.OnCompleted();
            Console.WriteLine($"ObserverA OnCompleted");
        }

        public override void OnError(Exception error)
        {
            Console.WriteLine($"ObserverA: {error.Message}");
        }

        public override void OnNext(int value)
        {
            if (value % 2 == 0)
            {
                Thread.Sleep(value * 1000);
                Console.WriteLine($"ObserverA: {value}");
            }
        }
    }
}

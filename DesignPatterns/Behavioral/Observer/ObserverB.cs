using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    class ObserverB : Observer<int>
    {
        public override void OnCompleted()
        {
            base.OnCompleted();
            Console.WriteLine($"ObserverB OnCompleted");
        }

        public override void OnError(Exception error)
        {
            Console.WriteLine($"ObserverB: {error.Message}");
        }

        public override void OnNext(int value)
        {
            if(value < 3 || value > 7)
                Console.WriteLine($"ObserverB: {value}");
        }
    }
}

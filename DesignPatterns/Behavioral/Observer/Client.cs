using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class Client
    {
        public static void Execute()
        {
            using (var publisher = new Publisher())
            {
                var observerA = new ObserverA();
                observerA.Subscribe(publisher);
                var observerB = new ObserverB();
                observerB.Subscribe(publisher);

                publisher.SomeBusinessLogic();
                publisher.SomeBusinessLogic();
                publisher.SomeBusinessLogic();

                observerB.Subscribe(null);

                publisher.SomeBusinessLogic();
                publisher.SomeBusinessLogic();
                publisher.SomeBusinessLogic();

                observerB.Subscribe(publisher);
                publisher.SomeBusinessLogic();
                publisher.SomeBusinessLogic();
            }
        }
    }
}

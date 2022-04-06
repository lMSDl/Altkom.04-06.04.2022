using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class Client
    {
        public static void Execute()
        {
            var coffeeMachine = new CoffeeMachine();
            Task.Delay(TimeSpan.FromSeconds(3)).ContinueWith(x => coffeeMachine.LargeCoffee());

            Task.Delay(TimeSpan.FromSeconds(7)).ContinueWith(x => coffeeMachine.LargeCoffee());

            Task.Delay(TimeSpan.FromSeconds(10)).ContinueWith(x => coffeeMachine.SmallCoffee());

            Task.Delay(TimeSpan.FromSeconds(11)).ContinueWith(x => coffeeMachine.SmallCoffee());

            Console.ReadKey();
        }
    }
}
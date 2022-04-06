using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class HeatingUpState : State
    {
        public HeatingUpState()
        {
            var task = Task.Delay(TimeSpan.FromSeconds(5));
            task.ContinueWith(x => CoffeeMachine.TransitionTo(new IdleState()));
        }

        public override void SmallCoffee()
        {
            Console.WriteLine("HeatingUpState: i am heating up");
        }

        public override void LargeCoffee()
        {
            Console.WriteLine("HeatingUpState: i am heating up");
        }
    }
}

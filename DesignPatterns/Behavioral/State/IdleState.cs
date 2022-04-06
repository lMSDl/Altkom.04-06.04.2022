using System;

namespace DesignPatterns.Behavioral.State
{
    public class IdleState : State
    {
        public override void SmallCoffee()
        {
            Console.WriteLine("IdleState: make small cofee");
            CoffeeMachine.TransitionTo(new WorkingState(5));
        }

        public override void LargeCoffee()
        {
            Console.WriteLine("IdleState: make large cofee");
            CoffeeMachine.TransitionTo(new WorkingState(7));
        }
    }
}
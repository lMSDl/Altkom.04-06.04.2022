using System;

namespace DesignPatterns.Behavioral.State
{
    public class CoffeeMachine
    {
        private State _state = null;

        public CoffeeMachine()
        {
            TransitionTo(new HeatingUpState());
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"CoffeeMachine: Transition to {state.GetType().Name}.");
            _state?.SetContext(null);
            _state = state;
            _state.SetContext(this);
        }

        public void SmallCoffee()
        {
            _state.SmallCoffee();
        }

        public void LargeCoffee()
        {
            _state.LargeCoffee();
        }
    }
}
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    internal class WorkingState : State
    {
        private readonly CancellationTokenSource _cancellationTokenSource;
        public WorkingState(int time)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            var task = Task.Delay(TimeSpan.FromSeconds(time), _cancellationTokenSource.Token);
            task.ContinueWith(x => { CoffeeMachine.TransitionTo(new IdleState()); _cancellationTokenSource.Dispose(); });
        }
        public override void SmallCoffee()
        {
            _cancellationTokenSource.Cancel();
            Console.WriteLine("WorkingState: process cancelled");
        }

        public override void LargeCoffee()
        {
            _cancellationTokenSource.Cancel();
            Console.WriteLine("WorkingState: process cancelled");
        }
    }
}
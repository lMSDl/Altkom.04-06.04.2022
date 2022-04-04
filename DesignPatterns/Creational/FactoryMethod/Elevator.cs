using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Elevator
    {
        private readonly Dictionary<string, IElevatorOperation> _cache = new();

        public void Execute(IElevatorOperation operation, int floor)
        {
            operation?.Operate(floor);
        }

        public IElevatorOperation CreateOperation(string action)
        {
            if(_cache.TryGetValue(action, out var elevatorOperation)) {
                return elevatorOperation;
            }

            //switch (nameof(Elevator) + action)
            //{
            //    case nameof(ElevatorDown):
            //        elevatorOperation = new ElevatorDown();
            //        break;
            //    case nameof(ElevatorUp):
            //        elevatorOperation = new ElevatorUp();
            //        break;
            //    case nameof(ElevatorGoTo):
            //        elevatorOperation = new ElevatorGoTo();
            //        break;
            //}
            elevatorOperation = (IElevatorOperation).CreateInstance(AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => !x.IsInterface)
                .Where(x => typeof(IElevatorOperation).IsAssignableFrom(x))
                .Single(x => x.Name.Contains(action)));

            _cache[action] = elevatorOperation;

            return elevatorOperation;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();

            var action = "GoTo";
            var elevatorOperation = elevator.CreateOperation(action);
            elevator.Execute(elevatorOperation, 3);

            action = "Down";
            elevatorOperation = elevator.CreateOperation(action);
            elevator.Execute(elevatorOperation, 3);

             action = "GoTo";
            elevatorOperation = elevator.CreateOperation(action);
            elevator.Execute(elevatorOperation, 3);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class Client
    {
        public static void Execute()
        {
            var garden = new Garden(10);
            var command1 = new GardenCommand(garden, GardenAction.Plant, "drzewo");
            var command2 = new GardenCommand(garden, GardenAction.Plant, "słonecznik");
            var command12 = new GardenCommand(garden, GardenAction.Remove, "drzewo");
            var command22 = new GardenCommand(garden, GardenAction.Remove, "słonecznik");


            var plantTreeButton = new CommandInvoker(command1);
            var removeTreeButton = new CommandInvoker(command12);
            var plantSunflowerButton = new CommandInvoker(command2);
            var removeSunflowerButton = new CommandInvoker(command22);


            Console.WriteLine(garden.ToString());

            plantTreeButton.Invoke();
            plantTreeButton.Invoke();
            plantTreeButton.Invoke();
            Console.WriteLine(garden.ToString());

            plantSunflowerButton.Invoke();
            plantSunflowerButton.Invoke();
            Console.WriteLine(garden.ToString());


            removeTreeButton.Invoke();
            removeSunflowerButton.Invoke();
            removeSunflowerButton.Invoke();
            removeSunflowerButton.Invoke();
            Console.WriteLine(garden.ToString());

            CommandInvoker.Undo();
            CommandInvoker.Undo();
            CommandInvoker.Undo();
            Console.WriteLine(garden.ToString());
        }
    }
}

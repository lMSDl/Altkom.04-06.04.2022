using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public static class Client
    {
        public static void Execute()
        {
            var person = new Person();
            person.Name = "Adam Adamski";
            person.BirthDate = new DateTime(1992, 1, 23);

            var caretaker = new Caretaker<Person>(person);
            caretaker.SaveState();
            Console.WriteLine(person);
            Thread.Sleep(1000);

            person.Name = "Ala";
            caretaker.SaveState();
            Console.WriteLine(person);
            Thread.Sleep(1000);

            person.BirthDate = new DateTime(1980, 2, 22);
            caretaker.SaveState();
            Console.WriteLine(person);
            Thread.Sleep(1000);

            person.Name = "Ala Alowska";
            caretaker.SaveState();
            Console.WriteLine(person);
            Thread.Sleep(1000);

            person.Name = "Alowska";
            Console.WriteLine(person);

            caretaker.RestoreState(DateTime.Now.AddSeconds(-2));
            Console.WriteLine(person);

            caretaker.RestoreLastState();
            Console.WriteLine(person);
            caretaker.RestoreLastState();
            Console.WriteLine(person);
            caretaker.RestoreLastState();
            Console.WriteLine(person);
        }
        }
}

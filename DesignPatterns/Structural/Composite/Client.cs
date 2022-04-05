using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Client
    {
        public static void Execute()
        {
            var hall = new Hall("Hala 1");
            var shelf1 = new Shelf("Regał południowy");
            var shelf2 = new Shelf("Regał północzny");
            var box1 = new Box("Pudło z kawami");
            var box2 = new Box("Pudło z ciastkami");
            var box3 = new Box("Pudło z mieszanką");

            hall.Add(shelf1);
            hall.Add(shelf2);
            shelf1.Add(box1);
            shelf1.Add(box2);
            for (int i = 0; i < 10; i++)
            {
                shelf2.Add(new Cookie());
                box1.Add(new Coffee());
                box2.Add(new Cookie());
            }
            for (int i = 0; i < 5; i++)
            {
                box3.Add(new Coffee());
                box3.Add(new Cookie());
            }
            hall.Add(box3);

            hall.GetValue();
            Console.WriteLine();
            box3.GetValue();
        }
    }
}

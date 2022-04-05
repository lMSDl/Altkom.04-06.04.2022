using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Client
    {
        public static void Execute()
        {
            var frame = new Frame();

            var textBox = new TextBox();
            frame.Add(textBox);

            var button = new Button();
            button.Func = () =>
            {
                if (string.IsNullOrEmpty(textBox.InputText))
                {
                    Console.WriteLine("Button unactive");
                    return false;
                }
                Console.WriteLine("Button clears text");
                textBox.InputText = null;
                return true;
            };

            textBox.Add(button);


            button.Click();

            textBox.Click();

            frame.Click();

            textBox.InputText = "sth";
            button.Click();

            Console.WriteLine(button.ClickCounter);
            Console.WriteLine(textBox.ClickCounter);
            Console.WriteLine(frame.ClickCounter);

        }
    }
}

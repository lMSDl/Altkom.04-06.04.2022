using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Client
    {
        public static void Execute()
        {
            var chat = new Chat();
            ChatMember user = new ChatUser("Paweł");
            ChatMember bot1 = new EchoChatBot("Paul");
            ChatMember bot2 = new EchoChatBot("Ringo");


            user.Chat = chat;
            bot1.Chat = chat;
            bot2.Chat = chat;


            while(true)
            {
                var message = Console.ReadLine();
                var split = message.Split(" $ ");
                if(split.Length == 1)
                {
                    user.Send(message);
                }
                else
                {
                    user.Send(split[0], split[1]);
                }
            }
        }
        }
}

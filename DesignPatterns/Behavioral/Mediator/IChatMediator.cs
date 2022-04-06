using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public interface IChatMediator
    {
        void Join(ChatMember member);
        void Quit(ChatMember chat);
        void Send(string from, string to, string message);
        void Send(string from, string message);
    }
}

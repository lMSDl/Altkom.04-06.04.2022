using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    class Unsubscribe : IDisposable
    {
        private Action _action;

        public Unsubscribe(Action action)
        {
            _action = action;
        }

        public void Dispose()
        {
            _action();
            _action = null;
        }
    }
}

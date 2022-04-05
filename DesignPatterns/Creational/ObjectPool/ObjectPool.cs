using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.ObjectPool
{
    public class ObjectPool<T>
    {
        private Stack<T> _stack;

        public ObjectPool(int numberOfItems, Func<T> func)
        {
            _stack = new Stack<T>(Enumerable.Range(1, numberOfItems).Select(x => func()).ToList());
        }

        public T Acquire()
        {
            lock (_stack)
            {
                if (_stack.Count == 0)
                    return default;
                return _stack.Pop();
            }
        }

        public void Release(T item)
        {
            lock (_stack)
            {
                _stack.Push(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.ObjectPool
{
    public class Client
    {
        public static void Execute()
        {
            //var counter = 0;
            //while (true)
            //{
            //    if (counter > 1000)
            //    {
            //        Thread.Sleep(1);
            //        continue;
            //    }
            //    var item = new Item() { IsVisible = true };
            //    Task.Delay(10).ContinueWith(x => { item.IsVisible = false; Interlocked.Decrement(ref counter); });
            //    Interlocked.Increment(ref counter);
            //}

            //var itemPool = new ItemPool(1000);
            //while (true)
            //{
            //    var item = itemPool.Acquire();
            //    if(item == null)
            //    {
            //        Thread.Sleep(1);
            //        continue;
            //    }
            //    Task.Delay(10).ContinueWith(x => { item.IsVisible = false; });
            //}

            var objectPool = new ObjectPool.ObjectPool<Item>(1000, () => new Item());
            while (true)
            {
                var item = objectPool.Acquire();
                if (item == null)
                {
                    Thread.Sleep(10);
                    continue;
                }
                item.IsVisible = true;
                Task.Delay(10).ContinueWith(x => { item.IsVisible = false; objectPool.Release(item); });
            }

        }
    }
}

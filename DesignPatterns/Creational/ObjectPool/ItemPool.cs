using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Creational.ObjectPool
{
    public class ItemPool
    {
        private IReadOnlyCollection<Item> _items;

        public ItemPool(int numberOfItems)
        {
            _items = new ConcurrentQueue<Item>(Enumerable.Range(1, numberOfItems).Select(x => new Item()).ToList());
        }

        public Item Acquire()
        {
            lock(_items)
            {
                var item = _items.FirstOrDefault(x => !x.IsVisible);
                if (item != null)
                    item.IsVisible = true;
                return item;
            }
        }
    }
}

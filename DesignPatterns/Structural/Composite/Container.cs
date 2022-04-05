using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public abstract class Container : IProduct
    {
        private ICollection<IProduct> _products = new List<IProduct>();

        public abstract string Name { get; }

        public void Add(IProduct product)
        {
            _products.Add(product);
        }

        public float GetValue()
        {
            var value = _products.Sum(x => x.GetValue());
            Console.WriteLine($"Wartość {Name} to {value}");
            return value;
        }
    }
}

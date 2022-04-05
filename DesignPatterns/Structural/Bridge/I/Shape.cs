using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.I
{
    public abstract class Shape
    { 
        public Color Color { get; set; }

        public override string ToString()
        {
            return $"{(Color != null ? Color.ToString() : "")}{GetType().Name}";
        }
    }
}
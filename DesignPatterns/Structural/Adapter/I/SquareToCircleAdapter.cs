using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.I
{
    public class SquareToCircleAdapter : ICircle
    {
        private Square _square {get;}

        public double Radius => _square.Width * Math.Sqrt(2) / 2.0;

        public SquareToCircleAdapter(Square square)
        {
            _square = square;
        }

    }
}

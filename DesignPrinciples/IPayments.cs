using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples
{
    public interface IPayments
    {
        bool Charge(float amount);
    }
}

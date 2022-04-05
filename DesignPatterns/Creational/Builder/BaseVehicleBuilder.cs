using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public abstract class BaseVehicleBuilder
    {
        protected Vehicle _vehicle;

        protected BaseVehicleBuilder() : this(new Vehicle())
        {
        }

        protected BaseVehicleBuilder(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public Vehicle Build()
        {
            return (Vehicle)_vehicle.Clone();
        }
    }
}

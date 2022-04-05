using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class VehicleManufacturingInfoBuilder : VehicleBuilderFacade
    {
        public VehicleManufacturingInfoBuilder()
        {
        }

        internal VehicleManufacturingInfoBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleManufacturingInfoBuilder SetManufacturer(string value) {
            _vehicle.Manufacturer = value;
            return this;
        }
        public VehicleManufacturingInfoBuilder SetModel(string value)
        {
            _vehicle.Model = value;
            return this;
        }
        public VehicleManufacturingInfoBuilder SetProductionDate(DateTime value)
        {
            _vehicle.ProductionDate = value;
            return this;
        }

    }
}

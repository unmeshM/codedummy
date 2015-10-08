using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseone
{
    public class VehicleService
    {
        private readonly IVehicleRepository<Vehicle> _vehicleRepository;
        public VehicleService(IVehicleRepository<Vehicle> vehicleRepository)
        {
            this._vehicleRepository = vehicleRepository;
        }
        public void AddNewBicycle(Bicycle bicycle)
        {
            _vehicleRepository.Add(bicycle);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseone
{
    public class MotorCycle : IVehicle
    {
        private readonly IVehicleRepository<IVehicle> _motorcycleRepository;

        public MotorCycle(IVehicleRepository<IVehicle> motorcycleRepository)
        {
            this._motorcycleRepository = motorcycleRepository;
        }

        public MotorCycle(int vehicleID, string vehicleName)
        {
            this._vehicleID = vehicleID;
            this._vehicleName = vehicleName;
        }

        private int _vehicleID;
        private string _vehicleName;
    }
}

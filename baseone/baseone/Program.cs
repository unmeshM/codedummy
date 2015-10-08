using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace baseone
{
    class Program
    {
        static void ContainerRegistrations(UnityContainer container)
        {
            container.RegisterType<IVehicleRepository<Vehicle>, VehicleRepository<Vehicle>>();
        }
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            ContainerRegistrations(container);
            var vehicleRepository = container.Resolve<VehicleRepository<Vehicle>>();
            vehicleRepository.Add(new MotorCycle { vehicleID = 123, NumberOfWheels = 2,Engine="V-Type" });
        }
    }
}

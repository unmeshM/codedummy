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
            container.RegisterType<IVehicleRepository<IVehicle>, VehicleRepository<IVehicle>>();
        }
        static void Main(string[] args)
        {
            ContainerRegistrations(new UnityContainer());
        }
    }
}

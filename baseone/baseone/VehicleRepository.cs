using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseone
{
    public class VehicleRepository<TVehicle> : IVehicleRepository<TVehicle> where TVehicle : Vehicle
    {
        public VehicleRepository() { }

        public void Add(TVehicle vehicle)
        {
            PrintMessage("Vehicle Added");
        }

        public TVehicle GetVehicle(Func<TVehicle> query)
        {
            throw new NotImplementedException();
        }

        public void Delete(TVehicle vehicle)
        {
            PrintMessage(Convert.ToString(typeof(TVehicle)) + " Deleted");
        }

        public IQueryable<TVehicle> GetAllVehicles()
        {
            throw new NotImplementedException();
        }

        private void PrintMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
        }
    }
}

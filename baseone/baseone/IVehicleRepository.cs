using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseone
{
    public interface IVehicleRepository<TVehicle> where TVehicle : Vehicle
    {
        void Add(TVehicle vehicle);
        TVehicle GetVehicle(Func<TVehicle> query);
        void Delete(TVehicle vehicle);
        IQueryable<TVehicle> GetAllVehicles();
    }
}

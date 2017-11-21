using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HireAVehicle.Entity;

namespace HireAVehicle.Repository.Interfaces
{
    public interface IRideRepository : IRepository<Ride>
    {
        bool Start(int id);
        bool Stop(int id);
    }
}

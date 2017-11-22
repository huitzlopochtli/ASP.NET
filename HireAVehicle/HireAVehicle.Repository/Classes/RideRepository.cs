using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HireAVehicle.Entity;
using HireAVehicle.Repository.Interfaces;

namespace HireAVehicle.Repository.Classes
{
    public class RideRepository : Repository<Ride>, IRideRepository
    {
        public RideRepository(DbContext context) : base(context)
        {
        }

        public bool Start(int id)
        {
            throw new NotImplementedException();
        }

        public bool Stop(int id)
        {
            throw new NotImplementedException();
        }
    }
}

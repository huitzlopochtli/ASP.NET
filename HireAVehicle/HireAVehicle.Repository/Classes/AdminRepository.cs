using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HireAVehicle.Data;
using HireAVehicle.Entity;
using HireAVehicle.Repository.Interfaces;

namespace HireAVehicle.Repository.Classes
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        public SystemContext SystemContext => Context as SystemContext;
        public AdminRepository(DbContext context) : base(context)
        {
        }
    }
}

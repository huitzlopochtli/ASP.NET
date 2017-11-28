using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using MBP.Data.Repository.Interfaces;
using MBP.Entity;
using MVP.Data.Repository;

namespace MBP.Data.Repository.Classes
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(DbContext context) : base(context)
        {
        }
    }
}

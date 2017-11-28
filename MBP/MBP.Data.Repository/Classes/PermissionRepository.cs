using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using MBP.Data.Repository.Interfaces;
using MBP.Entity;
using MVP.Data.Repository;

namespace MBP.Data.Repository.Classes
{
    public class PermissionRepository : Repository<Permission>, IPermissionRepository
    {
        public PermissionRepository(DbContext context) : base(context)
        {
        }

        public BlogDbContext BlogDbContext => Context as BlogDbContext;
    }
}

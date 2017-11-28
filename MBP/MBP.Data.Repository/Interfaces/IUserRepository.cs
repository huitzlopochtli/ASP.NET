using System;
using System.Collections.Generic;
using System.Text;
using MBP.Entity;

namespace MBP.Data.Repository.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByUrl(string url);
    }
}

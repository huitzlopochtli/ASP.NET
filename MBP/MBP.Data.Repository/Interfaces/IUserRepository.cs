using System;
using System.Collections.Generic;
using System.Text;
using MBP.Entity;
using MBP.Models;

namespace MBP.Data.Repository.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        BlogUserViewModel GetByUrl(string url);
    }
}

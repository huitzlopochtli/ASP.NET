using System;
using System.Collections.Generic;
using System.Text;
using MBP.Entity;

namespace MBP.Data.Repository.Interfaces
{
    public interface ILoginRepository : IRepository<Login>
    {
        Login GetLoginByUsernameAndPassword(string username, string password);
    }
}

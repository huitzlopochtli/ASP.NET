using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HireAVehicle.Entity;

namespace HireAVehicle.Repository.Interfaces
{
    public interface IAccountRepository : IRepository<Account>
    {
        AccountType Login(string username, string password);
        void Registration(Account account, Customer customer);
        void Registration(Account account, Driver driver);
        void Registration(Account account, Admin admin);
    }
}

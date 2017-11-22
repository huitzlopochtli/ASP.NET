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
    public class AccountRepository : Repository<Account>, IAccountRepository
    {

        public SystemContext SystemContext => Context as SystemContext;

        public AccountRepository(DbContext context) : base(context)
        {
        }

        public AccountType Login(string username, string password)
        {
            Account account = SystemContext.Accounts.SingleOrDefault(a => a.UserName == username);
            if (account != null && account.Password.Equals(password))
            {
                return account.AccountType;
            }

            else
            {
                return 0;
            }
        }

        public void Registration(Account account, Customer customer)
        {
            SystemContext.Accounts.Add(account);
            SystemContext.Customers.Add(customer);
            SystemContext.SaveChanges();
        }

        public void Registration(Account account, Driver driver)
        {
            SystemContext.Accounts.Add(account);
            SystemContext.Drivers.Add(driver);
            SystemContext.SaveChanges();
        }

        public void Registration(Account account, Admin admin)
        {
            SystemContext.Accounts.Add(account);
            SystemContext.Admins.Add(admin);
            SystemContext.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HireAVehicle.Entity;

namespace HireAVehicle.DataAccess
{
    public class SystemContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Moderator> Moderators { get; set; }

        public SystemContext() : base("name=Hire A Vehicle DB")
        {
            
        }
        

        public static void Main(string[] args)
        { }

        
    }
    
}

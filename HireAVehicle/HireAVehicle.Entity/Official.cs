using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireAVehicle.Entity
{
    public abstract class Official
    {
        public int Id { get; set; }
        public ICollection<Account> AccountsCreated { get; set; }
        public ICollection<Driver> DriversValidated { get; set; }

        protected Official()
        {
            AccountsCreated = new HashSet<Account>();
            DriversValidated = new HashSet<Driver>();
        }
    }
}

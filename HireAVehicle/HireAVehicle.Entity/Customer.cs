using System;   
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HireAVehicle.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public String CustomerId { get; set; }
        public float WalletBalance { get; set; }
        public Account Account { get; set; }
    }
}

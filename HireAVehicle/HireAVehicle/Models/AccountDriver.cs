using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HireAVehicle.Entity;

namespace HireAVehicle.Models
{
    public class AccountDriver
    {
        public AccountDriver()
        {
            
        }

        public Account Account { get; set; }
        public Driver Driver { get; set; }
        public Vehicle Vehicle { get; set; }
        public VehicleType VehicleType { get; set; }
    }
}
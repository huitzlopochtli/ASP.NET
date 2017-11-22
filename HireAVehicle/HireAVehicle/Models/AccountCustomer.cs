using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using HireAVehicle.Entity;

namespace HireAVehicle.Models
{
    public class AccountCustomer
    {
        public Account Account { get; set; }
        public Customer Customer { get; set; }
    }
}


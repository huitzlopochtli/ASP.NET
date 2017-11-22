using System;
using System.ComponentModel.DataAnnotations;

namespace HireAVehicle.Entity
{
    public class Customer
    {
        public int Id { get; set; }

        public int? TotalRides { get; set; }

        public float WalletBalance { get; set; }
        public float RewordPoint { get; set; }

        public Account Account { get; set; }


        public bool IsDeleted { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace HireAVehicle.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"cus-20[0-9]{2}-[0-9]+")]
        public String CustomerId { get; set; }

        public int? TotalRides { get; set; }

        public float WalletBalance { get; set; }
        public float RewordPoint { get; set; }

        public Account Account { get; set; }


        public bool IsDeleted { get; set; }
    }
}

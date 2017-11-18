using System;

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

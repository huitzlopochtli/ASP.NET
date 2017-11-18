using System;

namespace HireAVehicle.Entity
{
    public class Account
    {
        public int AccountId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNo { get; set; }
        public bool RideStatus { get; set; }
        public int TotalRides { get; set; }
        public AccountType AccountType { get; set; }
        public bool IsDeleted { get; set; }
        
    }

    public enum AccountType
    {
        Customer = 1,
        Driver = 2,
        Admin = 3,
        Moderator = 4
    } 
}

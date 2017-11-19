using System;
using System.ComponentModel.DataAnnotations;

namespace HireAVehicle.Entity
{
    public class Ride
    {
        [Key]
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Driver Driver { get; set; }
        [Required]
        public DateTime PickUpDateTime { get; set; }
        [Required]
        public string PickUpLocation { get; set; }
        [Required]
        public DateTime DropDateTime { get; set; }
        [Required]
        public string DropLocation { get; set; }

        public float Amount { get; set; }

        public bool IsPayed { get; set; }
    }
}

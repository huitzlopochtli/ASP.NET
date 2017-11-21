using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HireAVehicle.Entity
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"dri-20[0-9]{2}-[0-9]+")]
        public string DriverId { get; set; }

        [Required]
        [RegularExpression(@"[a-zA-Z]{2}[0-9]{7}[a-zA-Z]{2}[0-9]{4}")]
        public string DrivingLicence { get; set; }
        public float TotalEarnings { get; set; }
        public int TotalRidesDrived { get; set; }
        public bool IsValidated { get; set; }

        public string CurrentLocation { get; set; }


        public Admin ValidatedBy { get; set; }

        public Account Account { get; set; }


        public bool IsDeleted { get; set; }

    }
}

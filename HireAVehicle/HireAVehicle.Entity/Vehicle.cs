using System;
using System.ComponentModel.DataAnnotations;

namespace HireAVehicle.Entity
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string VehicleId { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string ModelName { get; set; }


        [Required]
        public string RegistrationNumber { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        [Required]
        public string LicenceNumber { get; set; }

        [Required]
        public float BasePrice { get; set; }

        public bool IsDeleted { get; set; }

        public Driver Driver { get; set; }

        public VehicleType VehicleType { get; set; }
    }

    public class VehicleType
    {
        [Key]
        public int Id { get; set; }
        

        [Required]
        public string VehicleTypeName { get; set; }
    }

    
}

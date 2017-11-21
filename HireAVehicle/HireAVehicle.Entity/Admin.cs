using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HireAVehicle.Entity
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"adm-20[0-9]{2}-[0-9]+")]
        public String AdminId { get; set; }

        public ICollection<Driver> DriverValidated { get; set; }


        public bool IsDeleted { get; set; }

        public Account Account { get; set; }

        public Admin()
        {
            DriverValidated = new HashSet<Driver>();
        }
    }
}

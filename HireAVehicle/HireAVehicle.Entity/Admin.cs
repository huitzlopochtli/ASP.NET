using System;
using System.ComponentModel.DataAnnotations;

namespace HireAVehicle.Entity
{
    public class Admin : Official
    {
        [Required]
        [RegularExpression(@"adm-20[0-9]{2}-[0-9]+")]
        public String AdminId { get; set; }
    }
}

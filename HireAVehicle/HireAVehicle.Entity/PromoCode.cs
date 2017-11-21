using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireAVehicle.Entity
{
    public class PromoCode
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PromoCodeString { get; set; }
        [Required]
        public int MaxNumber { get; set; }
    }
}

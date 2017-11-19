using System;
using System.ComponentModel.DataAnnotations;

namespace HireAVehicle.Entity
{
    public class Moderator : Official
    {
        [Required]
        [RegularExpression(@"mod-20[0-9]{2}-[0-9]+")]
        public String ModeratorId { get; set; }
        public int Salary { get; set; }
        public Account Account { get; set; }
    }
}

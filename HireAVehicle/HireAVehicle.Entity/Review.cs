using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireAVehicle.Entity
{
    public class Review
    {
        public int Id { get; set; }
        public string ReviewComment { get; set; }
        public ReviewRating ReviewRating { get; set; }
    }

    public enum ReviewRating
    {
        Bad = 0,
        Good = 1,
        Excillent = 2
    }
}

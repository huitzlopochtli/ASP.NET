using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HireAVehicle.Entity
{
    public class Moderator : Official
    {
        public String ModeratorId { get; set; }
        public int Salary { get; set; }
        public Account Account { get; set; }
    }
}

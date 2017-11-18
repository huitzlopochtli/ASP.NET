using System;

namespace HireAVehicle.Entity
{
    public class Moderator : Official
    {
        public String ModeratorId { get; set; }
        public int Salary { get; set; }
        public Account Account { get; set; }
    }
}

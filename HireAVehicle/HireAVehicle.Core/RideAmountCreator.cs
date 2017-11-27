using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireAVehicle.Core
{
    public class RideAmountCreator
    {
        public RideAmountCreator(string startLocation, string stopLocation)
        {
            StartLocation = startLocation;
            StopLocation = stopLocation;
        }

        public string StartLocation { get; set; }
        public string StopLocation { get; set; }
        public float Expense { get; set; }
        public float Distance { get; set; }


        public void setAmountAndDistance()
        {
            this.Expense = 100;
            this.Distance = 1;
        }
    }
        
}

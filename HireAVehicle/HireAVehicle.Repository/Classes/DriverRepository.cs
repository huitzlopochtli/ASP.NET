using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HireAVehicle.Entity;
using HireAVehicle.Repository.Interfaces;

namespace HireAVehicle.Repository.Classes
{
    public class DriverRepository : Repository<Driver>, IDriverRepository
    {
        public DriverRepository(DbContext context) : base(context)
        {
        }

        public string TransactionReport(Ride ride)
        {
            throw new NotImplementedException();
        }

        public bool StartRide(Ride ride)
        {
            throw new NotImplementedException();
        }

        public bool StopRide(Ride ride)
        {
            throw new NotImplementedException();
        }

        public bool AcceptRide(Ride ride)
        {
            throw new NotImplementedException();
        }

        public bool CancelRide(Ride ride)
        {
            throw new NotImplementedException();
        }

        public bool ChangeStatus(int id)
        {
            throw new NotImplementedException();
        }

        public Vehicle GetVehicle(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomerDriven(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Payment> GetPaymentDetailsDriven(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ride> GetRidesDetailsDriven(int id)
        {
            throw new NotImplementedException();
        }
    }
}

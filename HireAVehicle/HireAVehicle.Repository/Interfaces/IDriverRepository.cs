using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HireAVehicle.Entity;

namespace HireAVehicle.Repository.Interfaces
{
    public interface IDriverRepository : IRepository<Driver>
    {
        string TransactionReport(Ride ride);
        bool StartRide(Ride ride);
        bool StopRide(Ride ride);
        bool AcceptRide(Ride ride);
        bool CancelRide(Ride ride);
        bool ChangeStatus(int id);
        Vehicle GetVehicle(int id);
        IEnumerable<Customer> GetCustomerDriven(int id);
        IEnumerable<Payment> GetPaymentDetailsDriven(int id);
        IEnumerable<Ride> GetRidesDetailsDriven(int id);
    }
}

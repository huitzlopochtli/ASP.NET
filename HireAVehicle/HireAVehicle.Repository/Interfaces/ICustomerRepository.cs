using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HireAVehicle.Entity;

namespace HireAVehicle.Repository.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Ride RequestRide(string pickUpLocation, string dropLocation);
        bool CancelRide(Ride ride);
        bool TrackRide(Ride ride);
        bool SubmitReview(Review review);
        void PaymentMethod(Payment payment);
        bool TransactionDetails(Payment payment);
        float ViewWallet(Customer customer);
        bool ApplyPromoCode(string promoCode);
        IEnumerable<Driver> GetDriversDriven(int id);
        IEnumerable<Payment> GetPaymentDetailsDriven(int id);
        IEnumerable<Ride> GetRidesDetailsDriven(int id);
    }
}

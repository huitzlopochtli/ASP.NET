using System;
using System.Collections.Generic;
using System.Data.Entity;
using HireAVehicle.Data;
using HireAVehicle.Entity;
using HireAVehicle.Repository.Interfaces;

namespace HireAVehicle.Repository.Classes
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public SystemContext SystemContext => Context as SystemContext;
        public CustomerRepository(DbContext context) : base(context)
        {
        }

        public Ride RequestRide(string pickUpLocation, string dropLocation, int id)
        {
            throw new NotImplementedException();
        }

        public bool CancelRide(Ride ride)
        {
            throw new NotImplementedException();
        }

        public bool TrackRide(Ride ride)
        {
            throw new NotImplementedException();
        }

        public bool SubmitReview(Review review)
        {
            throw new NotImplementedException();
        }

        public void PaymentMethod(Payment payment)
        {
            throw new NotImplementedException();
        }

        public bool TransactionDetails(Payment payment)
        {
            throw new NotImplementedException();
        }

        public float ViewWallet(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool ApplyPromoCode(string promoCode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Driver> GetDriversDriven(int id)
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

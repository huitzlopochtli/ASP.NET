using System;
using System.Collections.Generic;
using System.Data.Entity;
using HireAVehicle.Data;
using HireAVehicle.Core;
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

        public Ride RequestRide(string pickUpLocation, string dropLocation, Customer customer)
        {
            RideAmountCreator rideAmountCreator = new RideAmountCreator(pickUpLocation, dropLocation);
            rideAmountCreator.setAmountAndDistance();

            Ride ride = new Ride()
            {
                PickUpLocation = pickUpLocation,
                DropLocation = dropLocation,
                Customer = customer,
                Distance = rideAmountCreator.Distance,
                Amount = rideAmountCreator.Expense,

            };
            RideRepository r1 = new RideRepository(SystemContext);
            r1.Add(ride);
            return ride;
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

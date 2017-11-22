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
    public class PaymentRepository : Repository<Payment>, IPaymentRepository
    {
        public PaymentRepository(DbContext context) : base(context)
        {
        }

        public bool PaymentMethodSelect(Ride ride)
        {
            throw new NotImplementedException();
        }
    }
}

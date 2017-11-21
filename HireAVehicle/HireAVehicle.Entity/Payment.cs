using System.ComponentModel.DataAnnotations;

namespace HireAVehicle.Entity
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public Ride Ride { get; set; }

        public float Amount
        {
            get => this.Ride.Amount;
            set => value = this.Ride.Amount;
        }

        public PaymentType PaymentType { get; set; }

        public bool IsPayed { get; set; }
    }

    public class PaymentType
    {
        public int Id { get; set; }
        [Required]
        public string PaymentTypeId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

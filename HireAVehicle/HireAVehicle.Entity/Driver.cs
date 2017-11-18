namespace HireAVehicle.Entity
{
    public class Driver
    {
        public int Id { get; set; }
        public string DriverId { get; set; }
        public string DrivingLicence { get; set; }
        public float TotalEarning { get; set; }
        public bool IsValidated { get; set; }


        public Official ValidatedBy { get; set; }

        public Account Account { get; set; }
    }
}

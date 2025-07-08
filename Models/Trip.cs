
namespace Fleet.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public int VehicleId { get; set; }
        public string Destination { get; set; }
        public DateTime TripDate { get; set; }

        public Driver Driver { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}

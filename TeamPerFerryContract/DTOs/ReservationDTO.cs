using System;

namespace TeamPerFerryContract
{
    public class ReservationDTO
    {
        public long ReservationId { get; set; }
        public VehicleDTO VehicleDTO { get; set; }
        public DateTime ReservationDate { get; set; }
        public RouteDTO RouteDTO { get; set; }
        public int PassengerAmount { get; set; }
        public bool CheckedIn { get; set; }
        public UserDTO UserDTO { get; set; }

    }
}
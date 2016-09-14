using System;
using System.Collections.Generic;

namespace TeamPerFerryContract
{
    public class DepartureDTO
    {
        public long DepartureId { get; set; }
        public RouteDTO Route { get; set; }
        public DateTime Date { get; set; }
        public List<VehicleDTO> Vehicles { get; set; }
        public int PassengerAmount { get; set; }
    }
}
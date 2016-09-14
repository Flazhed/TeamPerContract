using TeamPerFerryContract.DTOs;

namespace TeamPerFerryContract
{
    public class VehicleDTO
    {
        public long VehicleId { get; set; }
        public VehicleType VehicleType { get; set; }
        public string LicensePlate { get; set; }
    }
}
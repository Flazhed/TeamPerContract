using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPerFerryContract.DTOs
{
    public class FerryType
    {
        public long FerryTypeId { get; set; }
        public string Name { get; set; }
        public int SmallVehicleCapacity { get; set; }
        public int BigVehicleCapacity { get; set; }
        public double Speed { get; set; }
        public Deck Deck { get; set; }
    }
}

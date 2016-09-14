using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPerFerryContract.DTOs
{
    public class FerryDTO
    {
        public long FerryId { get; set; }
        public string FerryName { get; set; }
        public FerryType FerryType { get; set; }

    }
}

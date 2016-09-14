using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPerFerryContract.ETOs
{
    public class FerryOverbookedEx : InvalidBookingETO
    {
        public FerryOverbookedEx(string message) : base(message)
        {

        }
    }
}

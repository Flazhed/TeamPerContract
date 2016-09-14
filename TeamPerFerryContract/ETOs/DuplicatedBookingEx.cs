using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPerFerryContract.ETOs
{
    public class DuplicatedBookingEx : InvalidBookingETO
    {
        public DuplicatedBookingEx(string message) : base(message)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPerFerryContract.ETOs
{
    public class InvalidBookingETO : SystemException
    {
        private string message;

        public InvalidBookingETO(string message)
        {
            this.message = message;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPerFerryContract.ETOs
{
    public class InvalidFormatETO : SystemException
    {
        
        public InvalidFormatETO(string message) : base(message)
        {

        }
    }
}

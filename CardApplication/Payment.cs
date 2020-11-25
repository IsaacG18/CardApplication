using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApplication
{
    public class Payment
    {
        public String CardNumber { get; set; }

        public DateTime expiryDate { get; set; }

        public int sortCode { get; set; }
    }
}

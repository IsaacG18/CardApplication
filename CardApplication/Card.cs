using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApplication
{
    public abstract class Card
    {
        public Customers Customers { get; set; }

        public Manfactor Manfactor { get; set; }

        public String message  { get; set; }

        public String greeting { get; set; }

        public String Reciver { get; set; }

        public String Address { get; set; }

        public String TextFont { get; set; }

        public String Gender { get; set; }

        public override abstract string ToString();
    }
}

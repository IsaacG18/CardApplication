using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApplication
{
    class Anniversary : Card
    {
        public int years { get; set; }

        public override string ToString() // This overrides the ToString() class in Ticket.
        {
            string message;
            StringBuilder sb = new StringBuilder();

            
            sb.Append(Reciver);
            sb.Append("'s anniversary card from ");
            sb.Append(Customers.FirstName);
            sb.Append(" Years: ");
            sb.Append(years);
            sb.Append(" Manactor: S");
            sb.Append(Manfactor.Name);
            
            message = sb.ToString();

            return message;

        }
    }
}

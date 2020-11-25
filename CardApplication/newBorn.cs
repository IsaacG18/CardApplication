using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApplication
{
    class newBorn : Card
    {
        public DateTime date { get; set; }
        public String ParentName { get; set; }

        public override string ToString() // This overrides the ToString() class in Ticket.
        {
            string message;
            StringBuilder sb = new StringBuilder();

            sb.Append("New Born Card for ");
            sb.Append(Reciver);
            sb.Append(" Email: ");
            sb.Append(Customers.Email);
            sb.Append(" Address: ");
            sb.Append(Address);
            sb.Append(" Manfactor: ");
            sb.Append(Manfactor.Name);
            sb.Append(" Parents: ");
            sb.Append(ParentName);

            message = sb.ToString();

            return message;

        }
    }
}


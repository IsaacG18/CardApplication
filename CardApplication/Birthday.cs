using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApplication
{
    public class Birthday : Card
    {
        public int age { get; set; }
        string message;
        public override string ToString() // This overrides the ToString() class in Ticket.
        {
            string message;
            StringBuilder sb = new StringBuilder();

            sb.Append(Customers.FirstName);
            sb.Append(Customers.LastName);
            sb.Append(Customers.Email);
            sb.Append(Reciver);
            sb.Append(Address);
            sb.Append(age);
            message = sb.ToString();

            return message;

        }
    }
}
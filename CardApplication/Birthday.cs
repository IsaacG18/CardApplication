﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApplication
{
    public class Birthday : Card
    {
        public int age { get; set; }
        
        public override string ToString() // This overrides the ToString() class in Ticket.
        {
            string message;
            StringBuilder sb = new StringBuilder();

            
            sb.Append(Reciver);
            sb.Append("'s birthday card from ");
            sb.Append(Customers.FirstName);
            sb.Append(" Age: ");
            sb.Append(age);           
            sb.Append(" Manufactor: ");
            sb.Append(Address);

        
            message = sb.ToString();

            return message;

        }
    }
}
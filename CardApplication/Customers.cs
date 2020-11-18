using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApplication
{
    public class Customers
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public Customers(int customerId) => ID = customerId;

        public Customers() { }

        public override string ToString() // This overrides the standard String ToString() class.
        {
            return String.Format("First Name: {0} \nLast Name: {1} \n", FirstName, LastName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApplication
{
    class Customers
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public Customers(int customerId) => ID = customerId;

        public Customers() { }
    }
}

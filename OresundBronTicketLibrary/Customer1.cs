using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBronTicketLibrary
{
    public  class Customer1
    {
        public Customer1(int customerID, string customerName)
        {
            CustomerID = customerID;
            CustomerName = customerName;
        }

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

    }
}

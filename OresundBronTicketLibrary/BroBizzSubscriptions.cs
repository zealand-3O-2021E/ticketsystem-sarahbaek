using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBronTicketLibrary
{
    public class BroBizzSubscriptions 
    {
        //public BroBizzSubscriptions(int broBizzSubscriptionID, int customerID, int vehicleID, DateTime subscriptionDate, bool brobizz)
        //{
        //    BroBizzSubscriptionID = broBizzSubscriptionID;
        //    CustomerID = customerID;
        //    VehicleID = vehicleID;
        //    SubscriptionDate = subscriptionDate;
        //    Brobizz = brobizz;
        //}

        public int BroBizzSubscriptionID { get; set; }
        public int CustomerID { get; set; }
        public int VehicleID { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public bool IsActive { get; set; }



        public virtual double Price()
        {
            double price = 240;

            if (IsActive)
            {
                double discount = (price * 0.05);
                price = price - discount;
                return price;
            }
            else
            {
                return price;
            }
        }

    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OresundBronTicketLibrary
//{
//    public class BroBizzSubscriptions 
//    {
//        //public BroBizzSubscriptions(int broBizzSubscriptionID, int customerID, int vehicleID, DateTime subscriptionDate, bool brobizz)
//        //{
//        //    BroBizzSubscriptionID = broBizzSubscriptionID;
//        //    CustomerID = customerID;
//        //    VehicleID = vehicleID;
//        //    SubscriptionDate = subscriptionDate;
//        //    Brobizz = brobizz;
//        //}
//        public BroBizzSubscriptions(int broBizzSubscriptionID)
//        {
//            BroBizzSubscriptionID = broBizzSubscriptionID;
//        }

//        public BroBizzSubscriptions(int broBizzSubscriptionID, int customer1ID, int vehicle1ID, DateTime subscriptionDate, bool isActive)
//        {
//            BroBizzSubscriptionID = broBizzSubscriptionID;
//            Customer1ID = customer1ID;
//            Vehicle1ID = vehicle1ID;
//            SubscriptionDate = subscriptionDate;
//            IsActive = isActive;
//        }

//        public int BroBizzSubscriptionID { get; set; }
//        public int Customer1ID { get; set; }
//        public int Vehicle1ID { get; set; }
//        public DateTime SubscriptionDate { get; set; }
//        public bool IsActive { get; set; }



//        public virtual double Price()
//        {
//            double price = 240;

//            if (IsActive)
//            {
//                double discount = (price * 0.05);
//                price = price - discount;
//                return price;
//            }
//            else
//            {
//                return price;
//            }
//        }

//    }
//}

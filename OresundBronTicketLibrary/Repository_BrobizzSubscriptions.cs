using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OresundBronTicketLibrary
{
    /*
     * To populate the Customer object with data, we need some code to do the work of retrieving that data. This would best be placed in an BroBizzSubscriptionsRepository class. 
     * It will be used to get one or more subcriptions for a Customer. The Repository_BrobizzSubscriptions class has a Retrieve() and a Save() method.
     */
    public class Repository_BrobizzSubscriptions
{
        public BroBizzSubscriptions Retrieve(int broBizzSubscriptionID)
        {
            BroBizzSubscriptions broBizzSubscription = new BroBizzSubscriptions(broBizzSubscriptionID,1,1,DateTime.Now,true);
            if (broBizzSubscriptionID == 1)
            {
                broBizzSubscription.Customer1ID = 1;
                broBizzSubscription.BroBizzSubscriptionID = 1;
                broBizzSubscription.IsActive = true;
                broBizzSubscription.SubscriptionDate = DateTime.Today;
                broBizzSubscription.Vehicle1ID = 1;
                broBizzSubscription.Price();
            }
            return broBizzSubscription;
        }


        public IEnumerable<BroBizzSubscriptions> RetrieveByCustomer1Id(int customerId)
        {
            
            var broBizzSubscriptionsListList = new List<BroBizzSubscriptions>();
            BroBizzSubscriptions bBSubscriber = new BroBizzSubscriptions(1, 1, 1, DateTime.Now, true);
         
            broBizzSubscriptionsListList.Add(bBSubscriber);

            bBSubscriber = new  BroBizzSubscriptions(2, 2, 2, DateTime.Now, true);
            broBizzSubscriptionsListList.Add(bBSubscriber);
       

            return broBizzSubscriptionsListList;
        }

        public bool Save(BroBizzSubscriptions bBSubscriber)
        {
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBronTicketLibrary
{
    /*
     Interestingly, what we can do now is to set up a collaborative relationship between the CustomerRepository and BroBizzSubscriptionsRepository classes. To display the dependency on theBroBizzSubscriptionsRepository in CustomerRepository, we define the relationship at the top of the class and create an instance in the constructor. 
    Additionally, the private property bBizzRepository now holds an BroBizzSubscriptionsRepository object. 
    The Retrieve() method is now updated to use the RetrieveByCustomerId() method that exists in the BroBizzSubscriptionsRepository. That code is highlighted here.
    
     So what is the purpose of this code then? Well now, when any code requests to Retrieve a Customer, it will now retrieve a Customer and its associatedBrobizz Subscription in one swoop.*/
    public class Repository_Customer1
    {
        private Repository_BrobizzSubscriptions broBizzSubRepository { get; set; }
        public Repository_Customer1()
        {
            broBizzSubRepository = new Repository_BrobizzSubscriptions();
        }

      
         public Customer1 Retrieve(int customer1ID)
         {
            Customer1 customer1 = new Customer1(customer1ID);
            customer1.BroBizzSubscriptionsList = broBizzSubRepository.RetrieveByCustomer1Id(customer1ID).ToList();
            if (customer1ID == 1)
            {
                customer1.Customer1Name = "Sarah";
            }
            return customer1;

         }

        public List<Customer1> Retrieve()
        {
            return new List<Customer1>();
        }

        public bool Save(Customer1 customer1)
        {
            return true;
        }
    }
}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using ClassLibraryTicketSystem;

//using OresundBronTicketLibrary;

//using StoreBaeltTicketLibrary;

//namespace OresundBronTicketLibrary
//{
//    public class Customer
//    {
//        /// <summary>
//        /// Incomplete Not tested
//        /// </summary>
   
//        public void  MyTrips()
//        {

//            //Bridge oresundBridge = new Bridge("Oresund", 410, "Car", false);
//            //Bridge storebeltsBridge = new Bridge("Oresund", 410, "Car", true);

//            //List<Car> myTrips = MyTrips();
//            //myTrips.Add("asdf", DateTime.Today, true);

//            Car c1 = new Car("cvdgd", DateTime.Today, true);
//            Car c2 = new Car("cvdgd", DateTime.Today, true);
//            Car c3 = new Car("cvdgd", DateTime.Today, true);
//            MC mc1 = new MC("cvdgd", DateTime.Today, true);
//            MC mc2 = new MC("cvdgd", DateTime.Today, true);
//            MC mc3 = new MC("cvdgd", DateTime.Today, true);
//            List<Vehicle>OresundUsers = new List<Vehicle>();
//            OresundUsers.Add(c1);
//            OresundUsers.Add(c2);
//            OresundUsers.Add(c3);
//            foreach (var vehicle in OresundUsers)
//            {
//                Console.WriteLine(vehicle.Price());
//            }

//            List<Vehicle> storebeltsBridgeUsers = new List<Vehicle>();
//            storebeltsBridgeUsers.Add(mc1);
//            storebeltsBridgeUsers.Add(mc2);
//            storebeltsBridgeUsers.Add(mc3);

//            foreach (var vehicle in storebeltsBridgeUsers)
//            {
//                Console.WriteLine(vehicle.Price());  
//            }






//            Trip trip1 = new Trip(oresundBridge.BridgeName, c1.LicensePlate, 1, true);
//            Trip trip2 = new Trip(storebeltsBridge.BridgeName, c2.LicensePlate, 1, false);
//            Trip trip3 = new Trip(oresundBridge.BridgeName, mc1.LicensePlate, 1, true);
//            Trip trip4 = new Trip(oresundBridge.BridgeName, mc2.LicensePlate, 1, false);

//            List<Trip> myTripsList = new List<Trip>();
//            myTripsList.Add(trip1);
//            myTripsList.Add(trip2);
//            myTripsList.Add(trip3);
//            myTripsList.Add(trip4);

           

            



//        }


//        public static double TotalPrice(Trip trip)
//        {

//            double sum = 0;
//            List<Trip> myTripsList = new List<Trip>();
//            foreach (var t in myTripsList)
//            {
//                if ((t.bridgeName == "Oresund") && (t.BroBizz == false) && t.VehicleUsed == "Car")
//                {
               
//                }
//                sum += t.Price();
//            }
//            return sum;
//        }

//    }
//}

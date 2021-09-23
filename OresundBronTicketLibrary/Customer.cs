using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

using OresundBronTicketLibrary;

using StoreBaeltTicketLibrary;

namespace OresundBronTicketLibrary
{
    public class Customer
    {
        /// <summary>
        /// Incomplete Not tested
        /// </summary>
   
        public void  MyTrips()
        {

            Bridge oresundBridge = new Bridge("Oresund", 410, "Car", false);
            Bridge storebeltsBridge = new Bridge("Oresund", 410, "Car", true);

            //List<Car> myTrips = MyTrips();
            //myTrips.Add("asdf", DateTime.Today, true);

            Car c1 = new Car("cvdgd", DateTime.Today, true);
            Car c2 = new Car("cvdgd", DateTime.Today, true);
            Car c3 = new Car("cvdgd", DateTime.Today, true);
            MC mc1 = new MC("cvdgd", DateTime.Today, true);
            MC mc2 = new MC("cvdgd", DateTime.Today, true);
            MC mc3 = new MC("cvdgd", DateTime.Today, true);
            List<Vehicle>OresundUsers = new List<Vehicle>();
            OresundUsers.Add(c1);
            OresundUsers.Add(c2);
            OresundUsers.Add(c3);
            foreach (var vehicle in OresundUsers)
            {
                Console.WriteLine(vehicle.Price());
            }

            List<Vehicle> storebeltsBridgeUsers = new List<Vehicle>();
            storebeltsBridgeUsers.Add(mc1);
            storebeltsBridgeUsers.Add(mc2);
            storebeltsBridgeUsers.Add(mc3);

            foreach (var vehicle in storebeltsBridgeUsers)
            {
                Console.WriteLine(vehicle.Price());  
            }






            Trip trip1 = new Trip(oresundBridge.BridgeName, c1.LicensePlate, 1, true);
            Trip trip2 = new Trip(storebeltsBridge.BridgeName, c2.LicensePlate, 1, false);
            Trip trip3 = new Trip(oresundBridge.BridgeName, mc1.LicensePlate, 1, true);
            Trip trip4 = new Trip(oresundBridge.BridgeName, mc2.LicensePlate, 1, false);

            List<Trip> myTripsList = new List<Trip>();
            myTripsList.Add(trip1);
            myTripsList.Add(trip2);
            myTripsList.Add(trip3);
            myTripsList.Add(trip4);

           

            



        }


        public static double TotalPrice(Trip trip)
        {

            double sum = 0;
            List<Trip> myTripsList = new List<Trip>();
            foreach (var t in myTripsList)
            {
                if ((t.bridgeName == "Oresund") && (t.BroBizz == false) && t.VehicleUsed == "Car")
                {
               
                }
                sum += t.Price();
            }
            return sum;
        }

    }




    public class Bridge
    {
        public Bridge()
        {

        }
        public Bridge(string bridgeName, double bridgePrice, string bridgeUser, bool broBizz)
        {
            BridgeName = bridgeName;
            BridgePrice = bridgePrice;
            BridgeUser = bridgeUser;
            BroBizz = BroBizz;
        }

        public string BridgeName { get; set; }
        public double  BridgePrice { get; set; }

        public string BridgeUser { get; set; }
        public bool BroBizz { get; set; }
    }



    public class Trip
    {
        public Trip(string bridgeName, string vehicleUsed, int numberTrips, bool broBizz)
        {
            this.bridgeName = bridgeName;
            VehicleUsed = vehicleUsed;
            NumberTrips = numberTrips;
            BroBizz = broBizz;
        }

        public string bridgeName { get; set; }
        public string VehicleUsed { get; set; }
        public int NumberTrips { get; set; }
        public bool BroBizz { get; set; }

        internal int Price()
        {
            throw new NotImplementedException();
        }
    }
}

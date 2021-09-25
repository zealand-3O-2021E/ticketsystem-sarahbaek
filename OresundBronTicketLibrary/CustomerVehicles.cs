
using ClassLibraryTicketSystem;
using System;

namespace OresundBronTicketLibrary
{
    public  class CustomerVehicles : Vehicle
    {
        public CustomerVehicles(int vehicleID, int customerID)
        {
            VehicleID = vehicleID;
            CustomerID = customerID;
        }

        public int VehicleID { get; set; }
        public int CustomerID { get; set; }
    }
}

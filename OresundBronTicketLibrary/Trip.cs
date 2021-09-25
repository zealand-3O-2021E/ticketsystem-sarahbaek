using System;

namespace OresundBronTicketLibrary
{
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBronTicketLibrary
{
    public class VehicleTYpes
    {
        public VehicleTYpes(int vehicleTypesID, string vehicleTypeName)
        {
            VehicleTypesID = vehicleTypesID;
            VehicleTypeName = vehicleTypeName;
        }

        public int VehicleTypesID { get; set; }
        public string VehicleTypeName { get; set; }


    }
}

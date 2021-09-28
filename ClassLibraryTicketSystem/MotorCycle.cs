using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{

    public class MotorCycle : Vehicle
    {
   
        public MotorCycle(string licencePlate, DateTime date, bool broBizz)
        : base(licencePlate, date, broBizz)
        {

        }

        public MotorCycle( int bridgeID, string vehicleName): base( bridgeID, vehicleName)
        {

        }


  

        ///// <summary>
        ///  method 
        ///public double Price() .The price is fixed at 125 kr which must be returned
        /// </summary>
        /// <returns>125.00</returns>
        public override double Price()
        {
            double price = 125;

            if (BroBizz)
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

        /// <summary>
        /// Method
        /// public string Vehicle () .which returns "MC" 
        /// </summary>
        /// <returns>"MC"</returns>
        public override string VehicleType()
        {
            return "MC";
        }


        public override string VehicleType2(int in_bridge, string in_vehicle)
        {
            if (in_bridge == 1 && in_vehicle == "Car")
            {
                return "Car";
            }
            else if (in_bridge == 1 && in_vehicle == "MC")
            {
                return "MC";
            }
            else if (in_bridge == 2 && in_vehicle == "Car")
            {
                return "Oresund Car";
            }
            else if (in_bridge == 2 && in_vehicle == "MC")
                return "Oresund MC";
            else
                return "Another bridge";
        }
    }
}

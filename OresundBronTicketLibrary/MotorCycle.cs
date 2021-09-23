using ClassLibraryTicketSystem;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBronTicketLibrary
{
    public  class MotorCycle : Vehicle
    {
       
        public MotorCycle(string licencePlate, DateTime date, bool broBizz)
       : base(licencePlate, date, broBizz)
        {

        }

        /// <summary>
        ///Method  
        /// public double Price() The price is fixed at 210 which must be returned, but if you have a brobizz the price is 73kr.
        /// </summary>
        /// <returns>210</returns>
        public override double Price()
        {
            double price = 210;

            if (BroBizz)
            {

                double broBizzPrice = 73;
                return broBizzPrice;
            }
            else
            {
                return price;
            }

        }

        /// <summary>
        /// Method
        /// public string VehicleType() which returns the string "Oresund MC" 
        /// </summary>
        /// <returns>"Car"</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }



    }
}

using ClassLibraryTicketSystem;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBronTicketLibrary
{
   public class Car : Vehicle
   {
        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Car()
        {

        }
        /// <summary>
        /// Overloaded Constructor that takes in a licence plate and date as parameters
        /// </summary>
        /// <param name="licencePlate"></param>
        /// <param name="date"></param>
        public Car(string licencePlate, DateTime date)
        : base(licencePlate, date)
        {

        }
        /// <summary>
        /// Anonther overloaded constructor that takes in a licence plate, date and brobizz as parameters
        /// </summary>
        /// <param name="licencePlate"></param>
        /// <param name="date"></param>
        /// <param name="broBizz"></param>
        public Car(string licencePlate, DateTime date, bool broBizz)
        : base(licencePlate, date, broBizz)
        {

        }

        /// <summary>
        ///Method  
        /// public double Price() The price is fixed at 410 which must be returned, but if you have a brobizz the price is 161kr.
        /// </summary>
        /// <returns>410</returns>
        public override double Price()
        {
            double price = 410;

            if (BroBizz)
            {
              
              double broBizzPrice = 161;
                return broBizzPrice;
            }
            else
            {
                return price;
            }


        }

        /// <summary>
        /// Method
        /// public string VehicleType() which returns the string "Oresund Car" 
        /// </summary>
        /// <returns>"Car"</returns>
        public override string VehicleType()
        {
            return "Oresund Car";
        }


    }
}

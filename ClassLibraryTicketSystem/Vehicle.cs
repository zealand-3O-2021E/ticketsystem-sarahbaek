using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Vehicle
    {
        /// <summary>
        /// Properties
        /// </summary>
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        ///Method  
        /// public double Price() The price is fixed at 240 which must be returned
        /// </summary>
        /// <returns>240.00</returns>
        public virtual double Price()
        {
            return 240.00;
        }

        /// <summary>
        /// Method
        /// public string VehicleType() which returns the string "Car" 
        /// </summary>
        /// <returns>"Car"</returns>
        public virtual string VehicleType()
        {
            return "Car";
        }

    }
}

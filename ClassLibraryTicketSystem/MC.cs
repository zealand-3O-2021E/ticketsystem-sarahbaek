using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC
    {
        public string LicencePlate { get; set; }
        public DateTime Date { get; set; }
        /// <summary>
        ///  method 
        ///public double Price() .The price is fixed at 125 kr which must be returned
        /// </summary>
        /// <returns>125.00</returns>
        public double Price()
        {
            return 125.00;
        }

        /// <summary>
        /// Method
        /// public string Vehicle () .which returns "MC" 
        /// </summary>
        /// <returns>"MC"</returns>
        public string Vehicle()
        {
            return "MC";
        }
    }
}

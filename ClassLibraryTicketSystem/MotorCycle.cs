using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// The motor cycle class inherits from the vehicle class
    /// </summary>
    public class MotorCycle : Vehicle
    {
        #region Constructors inherited from hte base class Vehicle
        /// <summary>
        /// A constructor that takes 3 parameters
        /// </summary>
        /// <param name="licencePlate"></param>
        /// <param name="date"></param>
        /// <param name="broBizz"></param>
        public MotorCycle(string licencePlate, DateTime date, bool broBizz)
        : base(licencePlate, date, broBizz)
        {

        }
        /// <summary>
        /// A constructor that takes 2 parameters
        /// </summary>
        /// <param name="bridgeID"></param>
        /// <param name="vehicleName"></param>
        public MotorCycle(int bridgeID, string vehicleName) : base(bridgeID, vehicleName)
        {

        }
        #endregion

        #region Method: Price()
        ///// <summary>
        ///  method 
        /// public double Price() .The price is fixed at 125 kr which must be returned
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
        #endregion

        #region Method: VehicleType()
        /// <summary>
        /// Method
        /// public string Vehicle () .which returns "MC" 
        /// </summary>
        /// <returns>"MC"</returns>
        public override string VehicleType()
        {
            return "MC";
        }
        #endregion

        #region Method: VehicleType2()
        /// <summary>
        /// A method that checks the the bdige and vehicle and then returns the bridge and car type
        /// </summary>
        /// <param name="in_bridge"></param>
        /// <param name="in_vehicle"></param>
        /// <returns></returns>
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
        #endregion
    }
}

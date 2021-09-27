using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// A Vehicle abstract class that has methods that can be inherited and overriden by child classes
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Instance Field
        /// </summary>
        private bool _broBizz = false;
        /// <summary>
        /// Constructor with no parameters
        /// </summary>
        public Vehicle()
        {

        }

        /// <summary>
        /// Constructor with 3 parameters
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        /// <param name="broBizz"></param>
        public Vehicle(string licensePlate, DateTime date, bool broBizz)
        {
            LicensePlate = licensePlate;
            if (licensePlate.Length > 7)
            {
                //throw new ArgumentOutOfRangeException("The licenceplate should not be more than 7 characters.");
                throw new System.Reflection.TargetParameterCountException("Are there 7 characters?");
            }
            Date = date;
            BroBizz = broBizz;
        }
        /// <summary>
        /// Constructor with 2 parameters
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        public Vehicle(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            if (licensePlate.Length > 7)
            {
                //throw new ArgumentOutOfRangeException("The licenceplate should not be more than 7 characters.");
                throw new System.Reflection.TargetParameterCountException("Are there 7 characters?");
            }

            Date = date;
        }
        /// <summary>
        /// Constructor that throws an exception when the licence plate is longer than 7 characters
        /// </summary>
        /// <param name="licensePlate"></param>
        public Vehicle(string licensePlate)
        {
            LicensePlate = licensePlate;
            if (licensePlate.Length > 7)
            {
                //throw new ArgumentOutOfRangeException("The licenceplate should not be more than 7 characters.");
                throw new System.Reflection.TargetParameterCountException("Are there 7 characters?");
            }
        }
        /// <summary>
        /// Constructor that takes 4 parameters
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        /// <param name="broBizz"></param>
        /// <param name="bridgeName"></param>
        public Vehicle(string licensePlate, DateTime date, bool broBizz, string bridgeName) : this(licensePlate, date, broBizz)
        {
            LicensePlate = licensePlate;
            if (licensePlate.Length > 7)
            {
                //throw new ArgumentOutOfRangeException("The licenceplate should not be more than 7 characters.");
                throw new System.Reflection.TargetParameterCountException("Are there 7 characters?");
            }

            Date = date;
            BridgeName = bridgeName;
        }

     

        /// <summary>
        /// Properties
        /// </summary>
        public int VehicleID { get; set; }
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
        public bool BroBizz { get => _broBizz; set => _broBizz = value; }
        public string BridgeName { get; set; }


        /// <summary>
        ///Method  
        /// public double Price() The price is fixed at 240 which must be returned
        /// </summary>
        /// <returns>240.00</returns>
        public virtual double Price()
        {
            double price = 240;

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
        /// public string VehicleType() which returns the string "Car" 
        /// </summary>
        /// <returns>"Car"</returns>
        public virtual string VehicleType()
        {
            return "Car";
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Vehicle
    {
      private bool _broBizz = false ;
        public Vehicle()
        {

        }

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
        public Vehicle(string licensePlate)
        {
            LicensePlate = licensePlate;
            if (licensePlate.Length > 7)
            {
                //throw new ArgumentOutOfRangeException("The licenceplate should not be more than 7 characters.");
                throw new System.Reflection.TargetParameterCountException("Are there 7 characters?");
            }
        }

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

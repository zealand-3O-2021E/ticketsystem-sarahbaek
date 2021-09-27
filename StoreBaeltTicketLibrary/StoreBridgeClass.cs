using ClassLibraryTicketSystem;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{

    public   class StoreBridgeClass :IBridge

    {

        public int BridgeID { get; set; }

        public string BridgeName { get; set; }

        public StoreBridgeClass(int bridgeID, string bridgeName)

        {
            BridgeID = bridgeID;
            BridgeName = bridgeName;
        }

        private bool BroBizz;
        /// <summary>
        /// Method calculates the car price of the brige when a brobizz discount is deduted
        /// </summary>
        /// <param name="broBizz"></param>
        /// <returns>price</returns>
        public double BrobizzCustomersDiscount_Car(bool broBizz)
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
        /// // Method calculates the MC price of the brige when a brobizz discount is deduted
        /// </summary>
        /// <param name="broBizz"></param>
        /// <returns>price</returns>
        public double BrobizzCustomersDiscount_MC(bool broBizz)
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
        /// Method calculated the brige price for a car that does not have a brobizz
        /// </summary>
        /// <returns></returns>
        public double EverydayPrice_Car()
        {
            double price = 240;
            double discount = (price * 0.05);
            price = price - discount;
            return price;
        }



        /// <summary>
        /// Method calculated the brige price for a MC that does not have a brobizz
        /// </summary>
        /// <returns></returns>
        public double EverydayPrice_MC()
        {
            double price = 125;
            double discount = (price * 0.05);
            price = price - discount;
            return price;
        }

        public string VehicleType_Car(string car)
        {

            return "Car";
        }

        public string VehicleType_MC(string mc)
        {

            return "MC";
        }

        public double WeekendBroBizzCustomersPrice_Car( int dayOfTheWeek,   string vehicleType, bool brobizz)

        {
            //Deduct the weekend discount, then deduct the normal discount
            double price = 240;
            double weekendPriceMinus20PctDiscount = price - (price * 0.20);//192
            int currentDayOfWeek = 0;
            currentDayOfWeek = (int)System.DayOfWeek.Monday;

            object dayToday = null;

            if ((currentDayOfWeek == 6 || currentDayOfWeek == 7) && (vehicleType == "Car") && (brobizz == true))
                //if ((currentDayOfWeek == 6 || currentDayOfWeek == 7) && (Vehicle().()"Car") && (brobizz == true))
                {
                //Calculating the weekend discount thats 20% of 240.
                double weekendPrice20Discount = price * 0.20;
                //Deducting the discount from the original price  240- (0.20 * 240)= 192
                double weekendPriceMinus20Discount = price - weekendPrice20Discount;
                //Calculating the brobizz that is 5% discount of the weekend discount i.e (192 * 0.05 )= 9.6
                double weekendDisccountBroBizzWeekend = 0.05 * weekendPriceMinus20Discount;
                //Calculating the final price which is the weekendPrice  - brobiss discount i.e (192-9.6)= 182.4
                double FinalWeekendPrice = weekendPriceMinus20Discount - weekendDisccountBroBizzWeekend;

                return FinalWeekendPrice;
            } else

               return weekendPriceMinus20PctDiscount;
        }


        public double Weekend_No_BroBizzPrice_Car(int dayOfTheWeek, string vehicleType, bool brobizz)
        {
            double price = 240;
            double weekendPrice20Discount = price * 0.20 ;//48
            double weekendPriceMinus20Discount = price - weekendPrice20Discount;//192
            double weekendDisccountBroBizzWeekend = 0.05 * weekendPriceMinus20Discount;//9.6
            double FinalWeekendPrice = weekendPriceMinus20Discount - weekendDisccountBroBizzWeekend;//192-9.6 = 182.4
            int currentDayOfWeek = 0;
            currentDayOfWeek = (int)System.DayOfWeek.Monday;
            object dayToday = null;

            if ((currentDayOfWeek == 6 || currentDayOfWeek == 7) && (vehicleType == "Car") && (brobizz == false))
            {
                return weekendPriceMinus20Discount; //192
            }
            else if ((currentDayOfWeek != 6 || currentDayOfWeek != 7) && (vehicleType == "Car") && (brobizz == false))
            {
                price = 240;

                return price;
            }
            else if ((currentDayOfWeek != 6 || currentDayOfWeek != 7) && (vehicleType == "Car") && (brobizz == true))
            {

                double discount = (price * 0.05);
                price = price - discount;
                return price;  //228

            }
            else /*((currentDayOfWeek == 6 || currentDayOfWeek == 7) && (vehicleType != "Car") && (brobizz == false || brobizz == true))*/

                return 125; //MotorBike 

        }

    }
}



    

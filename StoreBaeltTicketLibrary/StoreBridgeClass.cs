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
        #region Properties
        /// <summary>
        /// Properties
        /// </summary>
        public int BridgeID { get; set; }

        public string BridgeName { get; set; }
        #endregion

        #region Constructor
        public StoreBridgeClass(int bridgeID, string bridgeName)

        {
            BridgeID = bridgeID;
            BridgeName = bridgeName;
        }
        #endregion

        #region Method: BrobizzCustomersDiscount_Car
        /// <summary>
        /// Method calculates the car price of the brige when a brobizz discount is deduted
        /// </summary>
        /// <param name="broBizz"></param>
        /// <returns>price</returns>
        public double BrobizzCustomersDiscount_Car(bool in_broBizz)
        {
            double price = 240;

            if (in_broBizz)
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

        #region Method: BrobizzCustomersDiscount_MC
        /// <summary>
        /// // Method calculates the MC price of the brige when a brobizz discount is deduted
        /// </summary>
        /// <param name="broBizz"></param>
        /// <returns>price</returns>
        public double BrobizzCustomersDiscount_MC(bool in_broBizz)
        {
            double price = 125;

            if (in_broBizz)
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

        #region Method: EverydayPrice_Car
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
        #endregion

        #region Method: EverydayPrice_MC
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
        #endregion

        #region Method: WeekendBroBizzCustomersPrice_Car
        /// <summary>
        /// This method Calculates the weekend price discount on cars 
        /// </summary>
        /// <param name="in_dayOfTheWeek"></param>
        /// <param name="in_vehicleType"></param>
        /// <param name="in_broBizz"></param>
        /// <returns></returns>
        public double WeekendBroBizzCustomersPrice_Car(int in_dayOfTheWeek, string in_vehicleType, bool in_broBizz)
        {
            //Deduct the weekend discount, then deduct the normal discount
            double price = 240;
            double weekendPriceMinus20PctDiscount = price - (price * 0.20);//192
            int currentDayOfWeek = 0;
            currentDayOfWeek = (int)System.DayOfWeek.Monday;

            if ((in_broBizz) && (in_vehicleType == "Car") && (in_dayOfTheWeek == 6 || in_dayOfTheWeek == 7))
            {
                //Calculating the weekend discount thats 20% of 240.
                double weekendPrice20Discount = price * 0.20;
                //Deducting the discount from the original price  240- (0.20 * 240)= 192
                double weekendPriceMinus20Discount = price - weekendPrice20Discount;
                //Calculating the brobizz that is 5% discount of the weekend discount i.e (192 * 0.05 )= 9.6
                double weekendDisccountBroBizzWeekend = 0.05 * weekendPriceMinus20Discount;
                //Calculating the final price which is the weekendPrice  - brobiss discount i.e (192-9.6)= 182.4
                double FinalWeekendPrice = weekendPriceMinus20Discount - weekendDisccountBroBizzWeekend;

                return FinalWeekendPrice;      //Car with brobIzz

            }
            else if ((!in_broBizz) && (in_vehicleType == "Car") && (in_dayOfTheWeek == 6 || in_dayOfTheWeek == 7))
            {
                return weekendPriceMinus20PctDiscount; //192
            }
            else if ((in_broBizz) && (in_vehicleType == "MC") && (in_dayOfTheWeek == 6 || in_dayOfTheWeek == 7))
            {
                double mCPrice = 125;
                double brobizzMc = (125 * 0.05); //6.25
                double broBizzMcPrice = (mCPrice - brobizzMc); //118.75

                return broBizzMcPrice;//MC with Brobizz
            }
            else

                return 210; //MC with no Brobizz

        }
        #endregion

        #region Method:  Weekend_No_BroBizzPrice_Car
        /// <summary>
        /// This method claculates the weekend price for a vehicle without a brobizz passing through the StoreBridge
        /// </summary>
        /// <param name="dayOfTheWeek"></param>
        /// <param name="vehicleType"></param>
        /// <param name="brobizz"></param>
        /// <returns></returns>
        public double Weekend_No_BroBizzPrice_Car(int dayOfTheWeek, string vehicleType, bool brobizz)
        {
            double price = 240;
            double weekendPrice20Discount = price * 0.20;//48
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

        #endregion

    }
}



    

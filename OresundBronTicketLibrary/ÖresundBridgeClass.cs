using ClassLibraryTicketSystem;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBronTicketLibrary
{
    public class OresundBridgeClass : IBridge
    {
        #region Constructor 
        /// <summary>
        /// Constructor taking 2 parameters
        /// </summary>
        /// <param name="bridgeID"></param>
        /// <param name="bridgeName"></param>
        public OresundBridgeClass(int bridgeID, string bridgeName)
        {
            BridgeID = bridgeID;
            BridgeName = bridgeName;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Properties needed to intialize a bridge
        /// </summary>
        public int BridgeID { get; set; }
        public string BridgeName { get; set; }
        #endregion

        #region Method: BrobizzCustomersDiscount_Car
        /// <summary>
        /// We check that a car that has a brobizz gets a discount and only pays 161kr
        /// </summary>
        /// <param name="broBizz"></param>
        /// <returns></returns>
        public double BrobizzCustomersDiscount_Car(bool broBizz)
        {
            double price = 410;

            if (broBizz)
            {
                double discountedPrice = (price - 249);

                return discountedPrice;//161
            }
            else
            {
                return price; //410
            }

        }
        #endregion

        #region Method:BrobizzCustomersDiscount_MC
        /// <summary>
        /// ´This method fives a discount to a MC that has a brobizz
        /// </summary>
        /// <param name="broBizz"></param>
        /// <returns></returns>
        public double BrobizzCustomersDiscount_MC(bool broBizz)
        {
            double price = 210;

            double priceAfterDiscount = 73;

            if (broBizz)
            {
                return priceAfterDiscount;
            }
            else
                return price; //210
        }
        #endregion

        #region Method: EverydayPrice_Car()
        /// <summary>
        /// This method shows the price of a car crossing the bridge without a brobizz
        /// </summary>
        /// <returns></returns>
        public double EverydayPrice_Car()
        {
            double price = 410;
            return price;
        }
        #endregion

        #region Method: EverydayPrice_MC()
        /// <summary>
        /// This method shows the price of a MC without a brobizz, crossing the Oresund Bridge
        /// </summary>
        /// <returns></returns>
        public double EverydayPrice_MC()
        {
            double price = 210;
            return price;
        }
        #endregion

        #region Method:  WeekendBroBizzCustomersPrice_Car
        /// <summary>
        /// Method that calculates the weekend discount for cars crossing the bridge, with and without a brobizz
        /// </summary>
        /// <param name="in_dayOfTheWeek"></param>
        /// <param name="in_vehicleType"></param>
        /// <param name="in_broBizz"></param>
        /// <returns></returns>
        public double WeekendBroBizzCustomersPrice_Car(int in_dayOfTheWeek, string in_vehicleType, bool in_broBizz)
        {
            if ((in_broBizz) && (in_vehicleType == "Car") && (in_dayOfTheWeek == 6 || in_dayOfTheWeek == 7))
            {
                return 161; //Car with brobIzz 
            }
            else if ((!in_broBizz) && (in_vehicleType == "Car") && (in_dayOfTheWeek == 6 || in_dayOfTheWeek == 7))
            {
                return 410; //Car with no Brobizz
            }
            else if ((in_broBizz) && (in_vehicleType == "MC") && (in_dayOfTheWeek == 6 || in_dayOfTheWeek == 7))
            {
                return 73;//MC with Brobizz
            }
            else

                return 210; //MC with no Brobizz

        }
        #endregion

        #region Method:Weekend_No_BroBizzPrice_Car
        /// <summary>
        /// This method calculates the price of a car without a brobizz crossing the bridge on a weekend
        /// </summary>
        /// <param name="in_dayOfTheWeek"></param>
        /// <param name="in_vehicleType"></param>
        /// <param name="in_broBizz"></param>
        /// <returns></returns>
        public double Weekend_No_BroBizzPrice_Car(int in_dayOfTheWeek, string in_vehicleType, bool in_broBizz)
        {
            if ((in_broBizz) && (in_vehicleType == "Car") && (in_dayOfTheWeek == 6 || in_dayOfTheWeek == 7))
            {
                return 161; //Car with brobIzz 
            }
            else if ((!in_broBizz) && (in_vehicleType == "Car") && (in_dayOfTheWeek == 6 || in_dayOfTheWeek == 7))
            {
                return 410; //Car with no Brobizz
            }
            else if ((in_broBizz) && (in_vehicleType != "Car") && (in_dayOfTheWeek != 6 || in_dayOfTheWeek != 7))
            {
                return 73;//MC with Brobizz
            }
            else if ((!in_broBizz) && (in_vehicleType != "Car") && (in_dayOfTheWeek != 6 || in_dayOfTheWeek != 7))

                return 210; //MC with no Brobizz
            else
            {
                return 410;
            }
        }
        #endregion

    }

}


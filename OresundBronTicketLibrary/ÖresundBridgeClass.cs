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
        public OresundBridgeClass(int bridgeID, string bridgeName)
        {
            BridgeID = bridgeID;
            BridgeName = bridgeName;
        }

        public int BridgeID { get; set; }
        public string BridgeName { get; set; }

        private bool broBizz;

        public double BrobizzCustomersDiscount_Car(bool broBizz)
        {
            //double price = 410;
            //double priceAfterDiscount = 161;

            //if (BroBizz)
            //{
            //    return 161;
            //}
            //else
            //{
            //    return 410;
            //}

            double price = 410;

            if (broBizz)
            {
                double discountedPrice = (price - 249);
              
                return discountedPrice;
            }
            else
            {
                return price;
            }

        }

        public double BrobizzCustomersDiscount_MC(bool broBizz)
        {
            double price = 210;

            double priceAfterDiscount = 73;

            if (broBizz)
            {
                return priceAfterDiscount;
            }
            else
                return price;
        }

        public double EverydayPrice_Car()
        {
            double price = 410;
            return price;

        }

        public double EverydayPrice_MC()
        {
            double price = 210;
            return price;
        }


        public string VehicleType_Car(string car)
        {
            return "Oresund Car";
        }

        public string VehicleType_MC(string mc)
        {
            return "Oresund MC";
        }

 
            public double WeekendBroBizzCustomersPrice_Car(int dayOfTheWeek, string vehicleType, bool brobizz)
            {
            if ((broBizz) && (vehicleType == "Car"))
            {
                return 161; //Car with brobIzz 
            }
            else if ((!broBizz) && (vehicleType == "Car"))
            {
                return 410; //Car with no Brobizz
            }
            else if ((broBizz) && (vehicleType == "MC"))
            {
                return 73;//MC with Brobizz
            }
            else  
            
                return 210; //MC with no Brobizz
            
            }

        public double Weekend_No_BroBizzPrice_Car(int dayOfWeek, string vehicleType, bool brobizz) 
        {
            if ((broBizz) && (vehicleType == "Car"))
            {
                return 161; //Car with brobIzz 
            }
            else if ((!broBizz) && (vehicleType == "Car"))
            {
                return 410; //Car with no Brobizz
            }
            else if ((broBizz) && (vehicleType == "MC"))
            {
                return 73;//MC with Brobizz
            }
            else

                return 210; //MC with no Brobizz
        }
    }
















}


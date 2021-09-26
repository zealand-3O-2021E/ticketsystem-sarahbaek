//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ClassLibraryTicketSystem
//{
//    public record Oresund_Bridge_Record(int BridgeID, string BridgeName) : IBridge
//    {
//        public bool BroBizz { get; private set; }

//        public double BrobizzCustomersDiscount_Car(bool broBizz)
//        {
//            double price = 410;
//            double priceAfterDiscount = 161;

//            if (BroBizz)
//            {
//                return priceAfterDiscount;
//            }
//            else
//                return price;
//        }

//        public double BrobizzCustomersDiscount_MC(bool broBizz)
//        {
//            double price = 210;
//            double priceAfterDiscount = 73;

//            if (BroBizz)
//            {
//                return priceAfterDiscount;
//            }
//            else
//                return price;
//        }

//        public double EverydayPrice_Car()
//        {
//            double price = 410;
//            return price;
        
//        }

//        public double EverydayPrice_MC()
//        {
//            double price = 210;
//            return price;
//        }

    
//        public double WeekendBroBizzCustomersPrice_Car(Vehicle vehicle, Car car)
//        {
//            double price = 410;
//            double priceAfterDiscount = 161;

//            if (BroBizz)
//            {
//                return priceAfterDiscount;
//            }
//            else
//                return price;
//        }

//        public double Weekend_NoBroBizz_Price_Car(Vehicle vehicle, Car car)
//        {
//            double price = 410;
//            double priceAfterDiscount = 161;

//            if (BroBizz)
//            {
//                return priceAfterDiscount;
//            }
//            else
//                return price;
//        }

//        public string VehicleType_Car(string car)
//        {
//             return "Oresund Car";
//        }

//        public string VehicleType_MC(string mc)
//        {
//            return "Oresund MC";
//        }

//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ClassLibraryTicketSystem
//{
//    public record StoreBælt_Bridge_Record(int BridgeID, string BridgeName) : IBridge
//    {
//        private bool BroBizz;
//        private DayOfWeek dayToday;



//        /// <summary>
//        /// Methoc calculates the car price of the brige when a brobizz discount is deduted
//        /// </summary>
//        /// <param name="broBizz"></param>
//        /// <returns>price</returns>
//        public double BrobizzCustomersDiscount_Car(bool broBizz)
//{
//            double price = 240;

//            if (BroBizz)
//            {
//                double discount = (price * 0.05);
//                price = price - discount;
//                return price;
//            }
//            else
//            {
//                return price;
//            }
//        }




//        /// <summary>
//        /// // Method calculates the MC price of the brige when a brobizz discount is deduted
//        /// </summary>
//        /// <param name="broBizz"></param>
//        /// <returns>price</returns>
//        public double BrobizzCustomersDiscount_MC(bool broBizz)
//        {
//            double price = 125;

//            if (BroBizz)
//            {
//                double discount = (price * 0.05);
//                price = price - discount;
//                return price;
//            }
//            else
//            {
//                return price;
//            }
//        }




//        /// <summary>
//        /// Method calculated the brige price for a car that does not have a brobizz
//        /// </summary>
//        /// <returns></returns>
//        public double EverydayPrice_Car()
//        {
//            double price = 240;
//            double discount = (price * 0.05);
//            price = price - discount;
//             return price;
//        }



//        /// <summary>
//        /// Method calculated the brige price for a MC that does not have a brobizz
//        /// </summary>
//        /// <returns></returns>
//        public double EverydayPrice_MC()
//        {
//            double price = 125;
//            double discount = (price * 0.05);
//            price = price - discount;
//             return price;
//        }

 




//        /// <summary>
//        /// The method calculates the price for the weekend for a car that has a brobizz
//        /// </summary>
//        /// <param name="vehicle"></param>
//        /// <param name="car"></param>
//        /// <returns></returns>
//        public double WeekendBroBizzCustomersPrice_Car(Vehicle vehicle, Car car)
//        {
//            //Deduct the weekend discount, then deduct the normal discount
//            double price = 240;
//            double broBizzNormalDiscount = price * 0.05;

//            //if ((dayToday == DayOfWeek.Saturday) || (dayToday == DayOfWeek.Sunday) && (EqualTo(vehicle, car) == true))
//                if ((dayToday == DayOfWeek.Saturday) || (dayToday == DayOfWeek.Sunday) &&  (vehicle == car))
//                {
//                //Calculating the weekend discount thats 20% of 240.
//                double weekendPrice20Discount = price * 0.20;
//                //Deducting the discount from the original price  240- (0.20 * 240)= 192
//                double weekendPriceMinus20Discount = price - weekendPrice20Discount;
//                //Calculating the brobizz that is 5% discount of the weekend discount i.e (192 * 0.05 )= 9.6
//                double weekendDisccountBroBizzWeekend = 0.05 * weekendPriceMinus20Discount;
//                //Calculating the final price which is the weekendPrice  - brobiss discount i.e (192-9.6)= 182.4
//                double FinalWeekendPrice = weekendPriceMinus20Discount - weekendDisccountBroBizzWeekend;

//                return (FinalWeekendPrice);
//            }
//            return broBizzNormalDiscount;
//        }



//        /// <summary>
//        /// The method calculates the price for the weekend for a car that does NOT have a brobizz
//        /// </summary>
//        /// <param name="vehicle"></param>
//        /// <param name="car"></param>
//        /// <returns>weekendPrice</returns>
//        public double Weekend_NoBroBizz_Price_Car(Vehicle vehicle, Car car)
//        {
//            //Deduct the weekend discount, then deduct the normal discount
//            double price = 240;
//            double broBizzNormalDiscount = price * 0.05;

//            //if ((dayToday == DayOfWeek.Saturday) || (dayToday == DayOfWeek.Sunday) && (EqualTo(vehicle, car) == true))
//            if ((dayToday == DayOfWeek.Saturday) || (dayToday == DayOfWeek.Sunday) && (vehicle == car) && (BroBizz== false))
//            {
//                broBizzNormalDiscount = price * 0.05;
//                double weekendPrice = price - broBizzNormalDiscount;
//                return (weekendPrice);
//            }
//            return broBizzNormalDiscount;
//        }


//        public string VehicleType_Car(string car)
//        {
        
//            return "Car";
//        }


//        public string VehicleType_MC(string mc)
//        {

//            return "MC";
//        }
//    }

    
//}

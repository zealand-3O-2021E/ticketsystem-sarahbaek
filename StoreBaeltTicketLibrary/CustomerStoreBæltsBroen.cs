//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;
//using System.Xml.Serialization;

//using ClassLibraryTicketSystem;



//using ClassLibraryTicketSystem;

//using static System.Net.Mime.MediaTypeNames;

//namespace StoreBaeltTicketLibrary
//{
//    /// <summary>
//    /// Task 9 – Storebæltsbroen weekend discount 
//    ///  A weekend discount is now to be introduced which means that if you drive across the bridge, 
//    ///Saturday or Sunday you get a 20% discount.This discount applies only to cars.The Brobizz
//    ///discount must be deducted afterwards the weekend discount.
//    ///Check how much you've tested your code through Code Coverage. Write Test so you have 
//    ///covered your code reasonably. NOTE: Remember to give the test methods a descriptive
//    ///name
//    ///Remember to commit and push
//    /// </summary>
//    public static class CustomerStoreBæltsBroen 
//    {
//        private static DayOfWeek dayToday;

    

//        //Car c1 = new Car("ASJH",DateTime.Today, true);

//        public static double WeekendDiscountOnCarsOnly(this Vehicle vehicle, Car car)
//        {
//            //Deduct the weekend discount, then deduct the normal discount
//            double price = 240;
//            double broBizzNormalDiscount = price * 0.05;
            
//            if ((dayToday == DayOfWeek.Saturday) || (dayToday == DayOfWeek.Sunday) && (EqualTo(vehicle, car) == true))
//            {
//                //Calculating the weekend discount thats 20% of 240.
//               double weekendPrice20Discount = price * 0.20;
//                //Deducting the discount from the original price  240- (0.20 * 240)= 192
//               double weekendPriceMinus20Discount = price - weekendPrice20Discount;
//                //Calculating the brobizz that is 5% discount of the weekend discount i.e (192 * 0.05 )= 9.6
//               double   weekendDisccountBroBizzWeekend = 0.05 * weekendPriceMinus20Discount;
//                //Calculating the final price which is the weekendPrice  - brobiss discount i.e (192-9.6)= 182.4
//              double  FinalWeekendPrice = weekendPriceMinus20Discount - weekendDisccountBroBizzWeekend;
               
//                return (FinalWeekendPrice);
//            }
//                return broBizzNormalDiscount;
//        }



//        public static string SerializeObject<T>(this T toSerialize)
//        {
//            XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());

//            using (StringWriter textWriter = new StringWriter())
//            {
//                xmlSerializer.Serialize(textWriter, toSerialize);
//                return textWriter.ToString();
//            }
//        }

//        public static bool EqualTo(this Vehicle vehicle, Car toCompare)
//        {
//            if (vehicle.SerializeObject() == toCompare.SerializeObject())
//                return true;
//            else
//                return false;
//        }

//        //public static void WeekendDiscountOnCarsOnly(object v1, object c1)
//        //{
//        //    throw new NotImplementedException();
//        //}


//        //double EverydayPrice_Car();
//        //double EverydayPrice_MC();
//        //double BrobizzCustomersDiscount_Car(bool broBizz);
//        //double BrobizzCustomersDiscount_MC(bool broBizz);
//        //double WeekendBroBizzCustomersPrice_Car(string car);
//        //double WeekendPrice_NoBroBizz_Car(string car);
//    }

    
//}
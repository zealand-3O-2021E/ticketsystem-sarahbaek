//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Serialization;

//namespace ClassLibraryTicketSystem
//{
//    public  class Bridge_StoreBælt : IBridge
//    {
//        private DayOfWeek dayToday;

//        public int Bridge1ID { get; set; }
//        public string BridgeName { get; set; }
//        public bool BroBizz { get; set; }

//        /// <summary>
//        /// This method gives a discount of 5% to every customer who has a brobizz subscription
//        /// </summary>
//        /// <param name="vehicle"></param>
//        /// <returns></returns>
//        public double BrobizzCustomersDiscount(bool BroBizz)
//        {
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
//        /// Thie method is used by every vehicle without a brobizz
//        /// </summary>
//        /// <param name="vehicle"></param>
//        /// <returns></returns>

//        public double EverydayPrice()
//        {
//            double storebæltsBridgePrice = 240;
//            return storebæltsBridgePrice;
//        }

//        /// <summary>
//        /// This method is only used for Cars crossing the bridge on a weekend without a brobizz
//        /// </summary>
//        /// <returns></returns>
//        public double WeekendBroBizzCustomersCarsOnlyPrice(string car)
//        {
//            //Deduct the weekend discount, then deduct the normal discount
//            double price = 240;
//            double broBizzNormalDiscount = price * 0.05;

//            if ((dayToday == DayOfWeek.Saturday) || (dayToday == DayOfWeek.Sunday) && (EqualTo(vehicle, car) == true))
//            {
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



//        //public double WeekendBroBizzCustomersCarsOnlyPrice(string car)
//        //{
//        //    throw new NotImplementedException();
//        //}

//        public double EverydayPrice_Car()
//        {
//            throw new NotImplementedException();
//        }

//        public double EverydayPrice_MC()
//        {
//            throw new NotImplementedException();
//        }

//        public double BrobizzCustomersDiscount_Car(bool broBizz)
//        {
//            throw new NotImplementedException();
//        }

//        public double BrobizzCustomersDiscount_MC(bool broBizz)
//        {
//            throw new NotImplementedException();
//        }

//        public double WeekendBroBizzCustomersPrice_Car(string car)
//        {
//            throw new NotImplementedException();
//        }

//        public double WeekendPrice_NoBroBizz_Car(string car)
//        {
//            throw new NotImplementedException();
//        }
//    }
 

        
    
//}

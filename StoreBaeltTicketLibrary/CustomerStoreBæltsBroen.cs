using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;



using ClassLibraryTicketSystem;

using static System.Net.Mime.MediaTypeNames;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Task 9 – Storebæltsbroen weekend discount 
    ///  A weekend discount is now to be introduced which means that if you drive across the bridge, 
    ///Saturday or Sunday you get a 20% discount.This discount applies only to cars.The Brobizz
    ///discount must be deducted afterwards the weekend discount.
    ///Check how much you've tested your code through Code Coverage. Write Test so you have 
    ///covered your code reasonably. NOTE: Remember to give the test methods a descriptive
    ///name
    ///Remember to commit and push
    /// </summary>
    public static class CustomerStoreBæltsBroen
    {
        private static DayOfWeek dayToday;

    

        //Car c1 = new Car("ASJH",DateTime.Today, true);

        public static double WeekendDiscountOnCarsOnly(this Vehicle vehicle, Car car)
        {
            double price = 240;
            double weekendPrice = 0;
            double broBizzNormalDiscount = price * 0.05;
            double weekendPriceDeductBroBizzNormalDicsount = price - broBizzNormalDiscount;


            if ((dayToday == DayOfWeek.Saturday) || (dayToday == DayOfWeek.Sunday) && (EqualTo(vehicle, car) == true))
            {
                broBizzNormalDiscount = price * 0.05;

                weekendPriceDeductBroBizzNormalDicsount = price - broBizzNormalDiscount;

                double weekend20PercentDiscount = (20 * weekendPriceDeductBroBizzNormalDicsount) / 100;

                weekendPrice = weekendPriceDeductBroBizzNormalDicsount - weekend20PercentDiscount;
                return (weekendPrice);
            }
                return broBizzNormalDiscount;
            
           
        }



        public static string SerializeObject<T>(this T toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }

        public static bool EqualTo(this Vehicle vehicle, Car toCompare)
        {
            if (vehicle.SerializeObject() == toCompare.SerializeObject())
                return true;
            else
                return false;
        }


    }
}
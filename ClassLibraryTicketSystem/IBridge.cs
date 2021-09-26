using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
   public interface IBridge
    {
 

        double EverydayPrice_Car();
        double EverydayPrice_MC();
        double BrobizzCustomersDiscount_Car(bool broBizz);
        double BrobizzCustomersDiscount_MC(bool broBizz);
        double WeekendBroBizzCustomersPrice_Car(Vehicle vehicle, Car car);
        double Weekend_NoBroBizz_Price_Car(Vehicle vehicle, Car car);
        public string VehicleType_Car(string car);
        public string VehicleType_MC(string mc);


    }
}


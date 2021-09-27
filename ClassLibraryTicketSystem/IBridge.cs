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

        double WeekendBroBizzCustomersPrice_Car(int dayOfTheWeek, string vehicleType, bool brobizz);
        public double Weekend_No_BroBizzPrice_Car(int dayOfTheWeek, string vehicleType, bool brobizz); 

        public string VehicleType_Car(string car);
        public string VehicleType_MC(string mc);
    }
}


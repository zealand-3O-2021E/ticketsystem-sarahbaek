using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    #region
    #endregion
    public interface IBridge
    {
        #region Interface Methods
        /// <summary>
        /// Interface methods that must be implemented by the 2 bridges
        /// </summary>
        /// <returns></returns>
        double EverydayPrice_Car();
        double EverydayPrice_MC();

        double BrobizzCustomersDiscount_Car(bool broBizz);
        double BrobizzCustomersDiscount_MC(bool broBizz);

        double WeekendBroBizzCustomersPrice_Car(int dayOfTheWeek, string vehicleType, bool brobizz);
        public double Weekend_No_BroBizzPrice_Car(int dayOfTheWeek, string vehicleType, bool brobizz);
        #endregion
    }
}


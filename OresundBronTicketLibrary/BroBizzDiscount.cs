using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBronTicketLibrary 
{
  public  class BroBizzDiscount 
    {
        public BroBizzDiscount(int broBizzDiscountID, int vehicleTypeID, double discountPricePercentage, double discountPrice, int bridgeID)
        {
            BroBizzDiscountID = broBizzDiscountID;
            VehicleTypeID = vehicleTypeID;
            DiscountPricePercentage = discountPricePercentage;
            DiscountPrice = discountPrice;
            BridgeID = bridgeID;
        }

        public int BroBizzDiscountID { get; set; }
        public int VehicleTypeID { get; set; }
        public double DiscountPricePercentage { get; set; }
        public double DiscountPrice { get; set; }
        public int BridgeID { get; set; }




        ///// <summary>
        /////Method  
        ///// public double Price() The price is fixed at 210 which must be returned, but if you have a brobizz the price is 73kr.
        ///// </summary>
        ///// <returns>210</returns>
        //public override double Price()
        //{
        //    double price = 210;

        //    if (BroBizz)
        //    {

        //        double broBizzPrice = 73;
        //        return broBizzPrice;
        //    }
        //    else
        //    {
        //        return price;
        //    }

        //}

        ///// <summary>
        ///// Method
        ///// public string VehicleType() which returns the string "Oresund MC" 
        ///// </summary>
        ///// <returns>"Car"</returns>
        //public override string VehicleType()
        //{
        //    return "Oresund MC";
        //}


    }
}

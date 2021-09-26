using System;




namespace OresundBronTicketLibrary
{
    public class OresundBroen : Bridge
    {
        public OresundBroen(string bridgeName, double bridgePrice, string bridgeUser, bool broBizz, int broBizzDiscountID, int vehicleTypeID, double discountPricePercentage, double discountPrice)

            : base(bridgeName, bridgePrice, bridgeUser, broBizz, broBizzDiscountID, vehicleTypeID, discountPricePercentage, discountPrice)
        {

        }


    }
}

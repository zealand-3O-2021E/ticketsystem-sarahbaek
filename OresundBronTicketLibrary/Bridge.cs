using OresundBronTicketLibrary;

namespace OresundBronTicketLibrary
{
    public class  Bridge 
    {
        public Bridge(string bridgeName, double bridgePrice, string bridgeUser, bool broBizz, int broBizzDiscountID, int vehicleTypeID, double discountPricePercentage, double discountPrice)
            
        {
            BridgeName = bridgeName;
            BridgePrice = bridgePrice;
            BridgeUser = bridgeUser;
            BroBizz = BroBizz;
        }
        public int BridgeID { get; set; }
        public string BridgeName { get; set; }
        public double  BridgePrice { get; set; }

        public string BridgeUser { get; set; }
        public bool BroBizz { get; set; }
    }
}


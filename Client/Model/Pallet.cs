using System;

namespace Client.Controller
{
    public class Pallet
    {
        public string PalletID { get; set; }
        public double PalletHeight { get; set; }
        public double PalletArea { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int daysStored { get; set; }
    }
}
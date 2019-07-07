using System;

namespace Client.Controller
{
    public class Pallet
    {
        public string palletID { get; set; }
        public double palletHeight { get; set; }
        public double palletArea { get; set; }
        public DateTime arrivalDate { get; set; }
        public int daysStored { get; set; }
    }
}
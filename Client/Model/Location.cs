using System;

namespace Client.Controller
{
    public class Location
    {
        public string locationID { get; set; }
        public DateTime rentalStart { get; set; }
        public DateTime rentalEnd { get; set; }
        public PalletList palletList { get; set; }
    }
}
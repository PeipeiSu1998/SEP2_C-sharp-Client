using Client.Controller;

namespace Client.Model
{
    public class Company
    {
        public string Name { get; set; }
        public string CompanyID { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public LocationList locationList { get; set; }
    }
}
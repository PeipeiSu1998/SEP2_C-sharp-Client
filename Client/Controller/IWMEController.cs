using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controller
{
    interface IWMEController
    {
        CompanyList getCompanyList();
        LocationList getAvailableLocationList();
        PalletList getAvailablePalletList();
        void registerCompany(Company company);
        void assignLocationToCompany(String locationID, String companyID);
        void storePallet(Pallet pallet, String locationID);
        Company getCompanyByID(String companyID);
        Location getLocationByID(String locationID);
        Pallet getPalletByID(String palletID, String companyID);
        void removeLocationFromCurrentCompany(String companyID);
        void removePallet(String palletID, String companyID);
        void editCompany(RegisterCompany company);
    }
}

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
        void registerCompany(Model.Company company);
        void assignLocationToCompany(string locationID, string companyID);
        void storePallet(Pallet pallet, string locationID);
        Model.Company getCompanyByID(string companyID);
        Location getLocationByID(string locationID);
        Pallet getPalletByID(string palletID, string companyID);
        void removeLocationFromCurrentCompany(string locationID);
        void removePallet(string palletID, string companyID);
        void editCompany(Model.Company company);
    }
}

using Client.Controller;
using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class ListAdapter
    {
        private ICompanyController wMEController = new CompanyController();

        public List<string[]> GetAdaptedAllCompanyList(CompanyList companyList)
        {
            List<string[]> allCompanyList = new List<string[]>();


            foreach (Model.Company company in companyList.companies)
            {
                string[] row = { company.companyID, company.name, company.phone.ToString(), company.email };
                allCompanyList.Add(row);
            }
            return allCompanyList;
        }

        public List<string[]> GetAdaptedAvailableLocationsList(LocationList locationList)
        {
            List<string[]> allLocationList = new List<string[]>();

            if (locationList.locations != null)
                foreach (Location location in locationList.locations)
                {
                    string[] row = { location.locationID };
                    allLocationList.Add(row);
                }
            return allLocationList;
        }

        public List<string[]> GetAdaptedRentedLocationsList(LocationList locationList)
        {
            List<string[]> allLocationList = new List<string[]>();

            if (locationList.locations != null)
                foreach (Location location in locationList.locations)
                {
                    string[] row = { location.locationID, transformIntoDateTime(location.rentalStart.ToString()) };
                    allLocationList.Add(row);
                }
            return allLocationList;
        }

        public List<string[]> GetAdaptedAllPalletsList(PalletList palletList)
        {
            List<string[]> allPalletList = new List<string[]>();

            if (palletList.pallets != null)
                foreach (Pallet pallet in palletList.pallets)
                {
                    string[] row = { pallet.palletID, pallet.companyID, pallet.locationID, pallet.palletHeight.ToString(), pallet.palletArea.ToString(), transformIntoDateTime(pallet.arrivalDate.ToString()), pallet.daysStored.ToString() };
                    allPalletList.Add(row);
                }
            return allPalletList;
        }

        public string transformIntoDateTime(string DateAsMs)
        {
            double ticks = double.Parse(DateAsMs);
            TimeSpan time = TimeSpan.FromMilliseconds(ticks);
            DateTime startdate = new DateTime(1970, 1, 1) + time;

            return startdate.ToString("dd-MM-yyyy");
        }
    }
}

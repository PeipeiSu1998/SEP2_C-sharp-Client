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
        private IWMEController wMEController = new WMEController();

        public List<string[]> GetAdaptedAllAvailableLocationsList(LocationList locationList)
        {
            List<string[]> allAvailableLocationsList = new List<string[]>();
            

            foreach (Location location in locationList.Locations)
            {
                string[] row = { location.locationID, location.rentalStart.ToString(), location.rentalEnd.ToString() };
                allAvailableLocationsList.Add(row);
            }
            return allAvailableLocationsList;
        }

        public List<string[]> GetAdaptedAllCompanyList(CompanyList companyList)
        {
            List<string[]> allCompanyList = new List<string[]>();
            

            foreach (Model.Company company in companyList.companies)
            {
                string[] row = { company.CompanyID, company.Name, company.Phone.ToString(), company.Email };
                allCompanyList.Add(row);
            }
            return allCompanyList;
        }
    }
}

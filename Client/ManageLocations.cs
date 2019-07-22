using Client.Controller;
using Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ManageLocations : Form
    {
        private WMEController WMEController = new WMEController();
        private CompanyList CompanyList = new CompanyList();
        private LocationList RentedLocationList = new LocationList();
        private LocationList AvailableLocationList = new LocationList();
        private ListAdapter ListAdapter = new ListAdapter();

        public ManageLocations()
        {
            InitializeComponent();
        }

        private void ButtonFindCompanyLocations_Click(object sender, EventArgs e)
        {
            AvailableLocationList = WMEController.getRentedLocationList();
            updateRentedLocationsListView();
        }

        private void ButtonRentLocation_Click(object sender, EventArgs e)
        {
            WMEController.assignLocationToCompany(textBoxLocationID.Text, textBoxCompanyID.Text);
        }

        private void ButtonUnRentLocation_Click(object sender, EventArgs e)
        {
            WMEController.removeLocationFromCurrentCompany(textBoxLocationID.Text);
        }

        private void ButtonViewAvailableLocations_Click(object sender, EventArgs e)
        {
            AvailableLocationList = WMEController.getAvailableLocationList();
            updateAvailableLocationsListView();
        }

        /// <summary>
        /// update rented location list view
        /// </summary>
        private void updateRentedLocationsListView()
        {
            listBoxRentedLocations.Items.Clear();
            List<string[]> adaptedRentedLocationsList = ListAdapter.GetAdaptedLocationsList(RentedLocationList);

            foreach (string[] location in adaptedRentedLocationsList)
            {
                listBoxRentedLocations.Items.Add(new ListViewItem(location));
            }

            paintLocationListRows();
        }

        /// <summary>
        /// update available location list view
        /// </summary>
        private void updateAvailableLocationsListView()
        {
            listBoxRentedLocations.Items.Clear();
            List<string[]> adaptedAvailableLocationsList = ListAdapter.GetAdaptedLocationsList(AvailableLocationList);

            foreach (string[] location in adaptedAvailableLocationsList)
            {
                listBoxAvailableLocations.Items.Add(new ListViewItem(location));
            }

            paintLocationListRows();
        }

        /// <summary>
        /// painting rows in list view for locations
        /// </summary>
        private void paintLocationListRows()
        {
            foreach (ListViewItem item in listBoxRentedLocations.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.LightGray : Color.LightBlue;
            }

            foreach (ListViewItem item in listBoxAvailableLocations.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.LightGray : Color.LightBlue;
            }
        }
    }
}

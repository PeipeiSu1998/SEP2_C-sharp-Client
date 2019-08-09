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
        private CompanyController CompanyController = new CompanyController();
        private LocationController LocationController = new LocationController();
        private LocationList RentedLocationList = new LocationList();
        private LocationList AvailableLocationList = new LocationList();
        private ListAdapter ListAdapter = new ListAdapter();

        public ManageLocations()
        {
            InitializeComponent();
        }

        private void ButtonFindCompanyLocations_Click(object sender, EventArgs e)
        {
            RentedLocationList = new LocationList();
            RentedLocationList = LocationController.getRentedLocationList(textBoxCompanyID.Text);
            updateRentedLocationsListView();
        }

        private void ButtonRentLocation_Click(object sender, EventArgs e)
        {
            if (textBoxLocationID.Text != null && textBoxCompanyID.Text != null)
                CompanyController.assignLocationToCompany(textBoxLocationID.Text, textBoxCompanyID.Text);

            RentedLocationList = new LocationList();
            AvailableLocationList = new LocationList();
            updateAvailableLocationsListView();
            updateRentedLocationsListView();
        }

        private void ButtonUnRentLocation_Click(object sender, EventArgs e)
        {
            CompanyController.removeLocationFromCurrentCompany(textBoxLocationID.Text);
            RentedLocationList = new LocationList();
            AvailableLocationList = new LocationList();
            updateAvailableLocationsListView();
            updateRentedLocationsListView();
        }

        private void ButtonViewAvailableLocations_Click(object sender, EventArgs e)
        {
            RentedLocationList = new LocationList();
            AvailableLocationList = new LocationList();

            AvailableLocationList = LocationController.getAvailableLocationList();
            updateAvailableLocationsListView();
            updateRentedLocationsListView();
        }

        /// <summary>
        /// update rented location list view
        /// </summary>
        private void updateRentedLocationsListView()
        {
            listBoxRentedLocations.Items.Clear();
            List<string[]> adaptedRentedLocationsList = ListAdapter.GetAdaptedRentedLocationsList(RentedLocationList);

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
            listBoxAvailableLocations.Items.Clear();
            List<string[]> adaptedAvailableLocationsList = ListAdapter.GetAdaptedAvailableLocationsList(AvailableLocationList);

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

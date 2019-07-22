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
    public partial class MainForm : Form
    {
        private WMEController WMEController = new WMEController();
        private CompanyList CompanyList = new CompanyList();
        private LocationList LocationList = new LocationList();
        private PalletList PalletList = new PalletList();
        private ListAdapter ListAdapter = new ListAdapter();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ListBoxPallets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBoxCompanyIDs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBoxAvailableLocations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSearchCompany_Click(object sender, EventArgs e)
        {

        }

        private void ButtonViewAllCompanies_Click(object sender, EventArgs e)
        {
            //orderList = administratorService.GetOrdersList();
            CompanyList = WMEController.getCompanyList();
            updateCompanyListView();
        }

        private void ButtonSearchPallet_Click(object sender, EventArgs e)
        {

        }

        private void ButtonViewAll_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Used when the "Register" tool strip item from "Company" is clicked to open a new form for company registration.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheMainForm frm = new TheMainForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
        }

        private void EditDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCompany frm = new EditCompany();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
        }

        private void ManageLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void InsertToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// update company list view
        /// </summary>
        private void updateCompanyListView()
        {
            listBoxCompanyIDs.Items.Clear();
            List<string[]> adaptedCompanyList = ListAdapter.GetAdaptedAllCompanyList(CompanyList);

            foreach (string[] company in adaptedCompanyList)
            {
                listBoxCompanyIDs.Items.Add(new ListViewItem(company));
            }

            paintOrderRows();
        }

        /// <summary>
        /// painting rows in list view for companies
        /// </summary>
        private void paintOrderRows()
        {
            foreach (ListViewItem item in listBoxCompanyIDs.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.LightGray : Color.LightBlue;
            }
        }
    }
}

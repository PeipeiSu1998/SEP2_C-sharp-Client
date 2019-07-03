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
            RegisterCompany frm = new RegisterCompany();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
        }

        private void EditDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}

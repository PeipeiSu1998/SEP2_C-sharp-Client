using Client.Controller;
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
    public partial class ReleasePallet : Form
    {
        private WMEController WMEController = new WMEController();

        /// <summary>
        /// Method that initializing the release pallet's view
        /// </summary>
        public ReleasePallet()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Method that handling the click event of releasing pallet's button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReleasePallet_Click(object sender, EventArgs e)
        {
            WMEController.removePallet(textBoxPalletID.Text, textBoxCompanyID.Text);
        }


        /// <summary>
        /// Method that handling the click event of cancelling inputted pallet information's button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            textBoxPalletID.Text = null;

            Close();
        }
    }
}

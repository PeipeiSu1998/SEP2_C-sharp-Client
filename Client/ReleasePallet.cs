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
        private PalletController PalletController = new PalletController();
        public ReleasePallet()
        {
            InitializeComponent();
        }

        private void ButtonReleasePallet_Click(object sender, EventArgs e)
        {
            bool validInput = false;

            if (textBoxCompanyID.Text == "")
            {
                errorProvider1.SetError(textBoxCompanyID, "Please input company ID");
            }
            if (textBoxPalletID.Text == "")
            {
                errorProvider1.SetError(textBoxPalletID, "Please input pallet ID");
            }
            if (textBoxCompanyID.Text.Length >= 1 && textBoxPalletID.Text.Length >= 1)
            {
                validInput = true;
            }

            if (validInput)
            {
                PalletController.removePallet(textBoxPalletID.Text, textBoxCompanyID.Text);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            textBoxPalletID.Text = null;

            Close();
        }
    }
}

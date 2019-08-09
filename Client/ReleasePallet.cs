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
            PalletController.removePallet(textBoxPalletID.Text, textBoxCompanyID.Text);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            textBoxPalletID.Text = null;

            Close();
        }
    }
}

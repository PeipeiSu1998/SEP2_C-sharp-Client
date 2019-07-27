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
        public ReleasePallet()
        {
            InitializeComponent();
        }

        private void ButtonReleasePallet_Click(object sender, EventArgs e)
        {
            WMEController.removePallet(textBoxPalletID.Text);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            textBoxPalletID.Text = null;

            Close();
        }
    }
}

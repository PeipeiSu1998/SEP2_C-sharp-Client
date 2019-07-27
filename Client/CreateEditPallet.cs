﻿using Client.Controller;
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
    public partial class CreateEditPallet : Form
    {
        private WMEController WMEController = new WMEController();
        private Pallet Pallet = new Pallet();

        public CreateEditPallet()
        {
            InitializeComponent();
        }

        private void ButtonCreatePallet_Click(object sender, EventArgs e)
        {
            Pallet.arrivalDate = dateTimePicker.Value;
            Pallet.palletArea = double.Parse(textBoxPalletArea.Text);
            Pallet.palletHeight = double.Parse(textBoxPalletHeight.Text);
            Pallet.palletID = textBoxPalletID.Text;

            WMEController.storePallet(Pallet, textBoxLocationID.Text);
        }

        private void ButtonUpdatePallet_Click(object sender, EventArgs e)
        {
            Pallet.arrivalDate = dateTimePicker.Value;
            Pallet.palletArea = double.Parse(textBoxPalletArea.Text);
            Pallet.palletHeight = double.Parse(textBoxPalletHeight.Text);
            Pallet.palletID = textBoxPalletID.Text;

            WMEController.updatePallet(Pallet, textBoxLocationID.Text);
        }
    }
}